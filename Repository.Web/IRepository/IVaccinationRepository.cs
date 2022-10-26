using DTOs.Web;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Web.IRepository
{
    public interface IVaccinationRepository
    {
        Task<IEnumerable<DTOVaccination>> GetVaccinationInfo();
        Task<DTOVaccination> GetVaccinationInfoByID(int ID);
        Task<DTOVaccination> InsertVaccinationInfo(DTOVaccination oVac);
        Task<DTOVaccination> UpdateVaccinationInfo(DTOVaccination oVac);
        bool DeleteVaccinationInfo(int ID);

       
    }
}
