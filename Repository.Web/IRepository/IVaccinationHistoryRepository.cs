using DTOs.Web;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Web.IRepository
{
    public interface IVaccinationHistoryRepository
    {
        Task<IEnumerable<TVaccinationHistory>> GetVacInfo();
        Task<TVaccinationHistory> GetVacHistoryByID(int ID);
        Task<TVaccinationHistory> InsertVacInfo(TVaccinationHistory vh);
        Task<TVaccinationHistory> UpdateVacInfo(TVaccinationHistory vh);
        bool DeleteVacInfo(int ID);
    }
}
