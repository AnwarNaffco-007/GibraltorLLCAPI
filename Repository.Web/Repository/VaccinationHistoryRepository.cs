using DTOs.Web;
using Microsoft.EntityFrameworkCore;
using Repository.Web.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Web.Repository
{
    public class VaccinationHistoryRepository : IVaccinationHistoryRepository
    {
        private readonly AppDbContext _appDBContext;
        public VaccinationHistoryRepository(AppDbContext context)
        {
            _appDBContext = context ??
                throw new ArgumentNullException(nameof(context));
        }
        public bool DeleteVacInfo(int ID)
        {
            bool result = false;
            var vh = _appDBContext.tbl_VaccinationHistory.Find(ID);
            if (vh != null)
            {
                _appDBContext.Entry(vh).State = EntityState.Deleted;
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

        public async Task<DTOVaccinationHistory> GetVacHistoryByID(int ID)
        {
            return await _appDBContext.tbl_VaccinationHistory.FindAsync(ID);
            
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DTOVaccinationHistory>> GetVacInfo()
        {
            return await _appDBContext.tbl_VaccinationHistory.ToListAsync();
            throw new NotImplementedException();
        }

        public async Task<DTOVaccinationHistory> InsertVacInfo(DTOVaccinationHistory vh)
        {
            _appDBContext.tbl_VaccinationHistory.Add(vh);
            await _appDBContext.SaveChangesAsync();
            return vh;
            throw new NotImplementedException();
        }

        public async Task<DTOVaccinationHistory> UpdateVacInfo(DTOVaccinationHistory vh)
        {
            _appDBContext.Entry(vh).State = EntityState.Modified;
            await _appDBContext.SaveChangesAsync();
            return vh;
            throw new NotImplementedException();
        }
    }
}
