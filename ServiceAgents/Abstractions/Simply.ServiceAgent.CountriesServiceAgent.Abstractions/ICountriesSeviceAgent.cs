namespace Simply.ServiceAgent.CountriesServiceAgent.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICountriesSeviceAgent
    {
        Task<GetCountriesWithStatesOutput> GetCountriesWithStatesByFilter(GetCountriesWithStatesInput input);

        Task<GetCountriesWithCitiesOutput> GetCountriesWithCitiesByFilter(GetCountriesWithCitiesInput input);
    }
}
