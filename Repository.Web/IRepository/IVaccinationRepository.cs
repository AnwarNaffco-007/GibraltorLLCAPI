using DTOs.Web;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Web.IRepository
{
    public interface IVaccinationRepository
    {
        Task<IEnumerable<TVaccination>> GetVaccinationInfo();
        Task<TVaccination> GetVaccinationInfoByID(int ID);
        Task<TVaccination> InsertVaccinationInfo(TVaccination oVac);
        Task<TVaccination> UpdateVaccinationInfo(TVaccination oVac);
        bool DeleteVaccinationInfo(int ID);

       
    }
}
