using DTOs.Web;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Web.IRepository
{
    public interface IVaccinationHistoryRepository
    {
        Task<IEnumerable<DTOVaccinationHistory>> GetVacInfo();
        Task<DTOVaccinationHistory> GetVacHistoryByID(int ID);
        Task<DTOVaccinationHistory> InsertVacInfo(DTOVaccinationHistory vh);
        Task<DTOVaccinationHistory> UpdateVacInfo(DTOVaccinationHistory vh);
        bool DeleteVacInfo(int ID);
    }
}
