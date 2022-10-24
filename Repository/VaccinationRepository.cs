using DTOs.Web;
using Repository.Web.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Web.Repository
{
    public class VaccinationRepository : IVaccinationRepository
    {
        AppDbContext db = new AppDbContext();



        public bool DeleteVaccinationInfo(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DTOVaccinationInfo>> GetVaccinationInfo()
        {
            throw new NotImplementedException();
        }

        public Task<DTOVaccinationInfo> GetVaccinationInfoByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<DTOVaccinationInfo> InsertVaccinationInfo(DTOVaccinationInfo objDepartment)
        {
            throw new NotImplementedException();
        }

        public Task<DTOVaccinationInfo> UpdateVaccinationInfo(DTOVaccinationInfo objDepartment)
        {
            throw new NotImplementedException();
        }
    }
}
