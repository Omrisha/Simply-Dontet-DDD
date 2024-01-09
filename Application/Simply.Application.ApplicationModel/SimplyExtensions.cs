namespace Simply.Application.ApplicationModel;

using AutoMapper;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Pagination;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Logging;
using Microsoft.OpenApi.Models;
using Simply.Core;
using Simply.DomainModel.Impl;
using Simply.DomainModel.Impl.Mappings;
using Simply.Infrastracture.Text;
using Simply.ServiceAgent.CountriesServiceAgent.CountriesNow.Extensions;
using Simply.Services.Graphql;
using Simply.Services.Graphql.Mappings;
using System.IO.Compression;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text.Json.Serialization;

public static class SimplyExtensions
{
    public static IServiceCollection AddSimply(this IServiceCollection services, IConfiguration configuration)
    {
        services.RegisterProxyForwardingServices();

        services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        });

        services.RegisterSwagger();

        services.AddHttpClient();
        services.AddAutoMapper(
            typeof(DomainModelMappingProfile).Assembly,
            typeof(GraphqlModelMappingProfile).Assembly);
        services.AddHttpContextAccessor();
        services.Configure<WebApiOptions>(configuration.GetSection(nameof(WebApiOptions)));
        services.RegisterGraphqlServices();

        services.AddMediatrServices(typeof(WeatherReader).Assembly);

        services.AddCountriesServiceAgent();

        return services;
    }

    /// <summary>
    /// Configure web application.
    /// </summary>
    /// <param name="app"><see cref="WebApplication"/> instance.</param>
    /// <returns>A given <see cref="WebApplication"/> instance.</returns>
    public static WebApplication ConfigureWebApplication(this WebApplication app)
    {
        app.UseForwardedHeaders();

        app.UseRouting();
        app.UseDefaultFiles();
        app.UseStaticFiles();

        string[] allowedOrigins = app.Services.GetRequiredService<IOptionsMonitor<WebApiOptions>>().CurrentValue.AllowedOrigins;
        app.UseCors(
            options => options
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowCredentials()
                .WithOrigins(allowedOrigins));

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.ConfigObject.AdditionalItems.Add("syntaxHighlight", false);
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Simply API Docs");
            c.RoutePrefix = "docs";
        });

        app.UseCors("AllowedOrigins");

        app.UseResponseCompression();

        app.MapControllers();
        app.MapFallbackToFile("index.html");
        app.MapBananaCakePop("/gql");
        app.MapGraphQL();

        return app;
    }

    /// <summary>
    /// Add MediatR services.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/> instance.</param>
    /// <param name="messagingModelAssembly">Current application messaging model assembly contain flow commands.</param>
    /// <param name="domainModelAssembly">Current application domain assembly contains cqrs commands.</param>
    /// <returns>A given <see cref="IServiceCollection"/> instance.</returns>
    public static IServiceCollection AddMediatrServices(
        this IServiceCollection services,
        Assembly domainModelAssembly)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(domainModelAssembly));

        return services;
    }

    private static IServiceCollection RegisterSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(setup =>
        {
            setup.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Simply Api",
                Description = "Simply API",
                Contact = new OpenApiContact
                {
                    Name = "Simply",
                    Email = "omri.shapira@gmail.com",
                    Url = new("https://www.osphotohub.com/"),
                },
            });

            OpenApiSecurityScheme jwtSecurityScheme = new()
            {
                Scheme = "bearer",
                BearerFormat = "JWT",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
                Description = "Please insert JWT with Bearer into field",

                Reference = new OpenApiReference
                {
                    Id = JwtBearerDefaults.AuthenticationScheme,
                    Type = ReferenceType.SecurityScheme,
                },
            };

            setup.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

            setup.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                { jwtSecurityScheme, Array.Empty<string>() },
            });
        });

        return services;
    }

    private static void RegisterProxyForwardingServices(this IServiceCollection services)
    {
        IdentityModelEventSource.ShowPII = true;

        services.AddResponseCompression(options =>
        {
            options.EnableForHttps = true;
            options.Providers.Add<BrotliCompressionProvider>();
            options.Providers.Add<GzipCompressionProvider>();
        });

        services.Configure<BrotliCompressionProviderOptions>(options =>
        {
            options.Level = CompressionLevel.SmallestSize | CompressionLevel.Fastest;
        });

        services.Configure<GzipCompressionProviderOptions>(options =>
        {
            options.Level = CompressionLevel.SmallestSize | CompressionLevel.Fastest;
        });

        services.Configure<ForwardedHeadersOptions>(options =>
        {
            options.ForwardedHeaders =
                ForwardedHeaders.All;
        });
    }

    private static void RegisterGraphqlServices(this IServiceCollection services)
    {
        services
            .AddGraphQLServer()
            .ModifyRequestOptions(opt => opt.IncludeExceptionDetails = true)
            .AddQueryType(q => q.Name("Query"))
            .AddConvention<INamingConventions>(new PascalCaseGraphqlNamingConvention())
            .AddType<CountriesQueries>()
            .InitializeOnStartup();
    }
}
