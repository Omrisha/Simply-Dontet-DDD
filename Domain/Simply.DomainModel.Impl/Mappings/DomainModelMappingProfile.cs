namespace Simply.DomainModel.Impl.Mappings;

using AutoMapper;
using Simply.EntityModel;

/// <summary>
/// Domain model mapping profile.
/// </summary>
public class DomainModelMappingProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainModelMappingProfile"/> class.
    /// </summary>
    public DomainModelMappingProfile()
    {
        this.CreateProjection<CountryEntity, CountryDto>();
    }
}