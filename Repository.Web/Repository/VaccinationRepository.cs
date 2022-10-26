using DTOs.Web;
using Microsoft.EntityFrameworkCore;
using Repository.Web.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Web.Repository
{
    public class VaccinationRepository : IVaccinationRepository
    {
        //AppDbContext db = new AppDbContext();

        private readonly AppDbContext _appDBContext;
        public VaccinationRepository(AppDbContext context)
        {
            _appDBContext = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public bool DeleteVaccinationInfo(int ID)
        {
            bool result = false;
            var vac = _appDBContext.tbl_VaccinationInfo.Find(ID);
            if (vac != null)
            {
                _appDBContext.Entry(vac).State = EntityState.Deleted;
                _appDBContext.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DTOVaccination>> GetVaccinationInfo()
        {
            return await _appDBContext.tbl_VaccinationInfo.ToListAsync();
            throw new NotImplementedException();
        }

        public async Task<DTOVaccination> GetVaccinationInfoByID(int ID)
        {
            return await _appDBContext.tbl_VaccinationInfo.FindAsync(ID);
            throw new NotImplementedException();
        }

        public async Task<DTOVaccination> InsertVaccinationInfo(DTOVaccination objVac)
        {
            _appDBContext.tbl_VaccinationInfo.Add(objVac);
            await _appDBContext.SaveChangesAsync();
            return objVac;
            throw new NotImplementedException();
        }

        public async Task<DTOVaccination> UpdateVaccinationInfo(DTOVaccination objVac)
        {
            _appDBContext.Entry(objVac).State = EntityState.Modified;
            await _appDBContext.SaveChangesAsync();
            return objVac;
            throw new NotImplementedException();
        }
    }
}
