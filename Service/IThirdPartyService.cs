using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiGresol.DTO;


namespace WebApiGresol.Service
{
    public interface IThirdPartyService
    {
        Task<DtoThirdParty> GetThirdPartyById(int Id);
        IQueryable<DtoThirdParty> GetDtoThirdParties();
        Task<int> SaveThirdParty(DtoThirdParty dtoThirdParty);
        bool UpdateThirdParty(int Id, DtoThirdParty dtoThirdParty);

        Task DeleteThirdParty(int Id);
    }
}
