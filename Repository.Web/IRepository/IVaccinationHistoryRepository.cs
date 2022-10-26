using DTOs.Web;
using GibraltorLLCAPI.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Web.IRepository
{
    public interface IVaccinationHistoryRepository
    {
        Task<IEnumerable<VaccinationHistoryResponse>> GetVacInfo();
        Task<VaccinationHistoryResponse> GetVacHistoryByID(int ID);
        Task<DTOVaccinationHistory> InsertVacInfo(DTOVaccinationHistory vh);
        Task<DTOVaccinationHistory> UpdateVacInfo(DTOVaccinationHistory vh);
        bool DeleteVacInfo(int ID);
    }
}
