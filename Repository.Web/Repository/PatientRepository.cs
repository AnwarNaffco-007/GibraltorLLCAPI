using DTOs.Web;
using Repository.Web.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository.Web.Repository
{
   public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext _appDBContext;
        public PatientRepository(AppDbContext context)
        {
            _appDBContext = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public bool DeletePatientInfo(int ID)
        {
            bool result = false;
            var vac = _appDBContext.tbl_PatientsInfo.Find(ID);
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

        public async Task<IEnumerable<DTOPatientInfo>> GetPatientInfo()
        {
            return await _appDBContext.tbl_PatientsInfo.ToListAsync();
            throw new NotImplementedException();
        }

        public async Task<DTOPatientInfo> GetPatientInfoByID(int ID)
        {
            return await _appDBContext.tbl_PatientsInfo.FindAsync(ID);
            throw new NotImplementedException();
        }

        public async Task<DTOPatientInfo> InsertPatientInfo(DTOPatientInfo oPat)
        {
            _appDBContext.tbl_PatientsInfo.Add(oPat);
            await _appDBContext.SaveChangesAsync();
            return oPat;
            throw new NotImplementedException();
        }

        public async Task<DTOPatientInfo> UpdatePatientInfo(DTOPatientInfo oPat)
        {
            _appDBContext.Entry(oPat).State = EntityState.Modified;
            await _appDBContext.SaveChangesAsync();
            return oPat;
            throw new NotImplementedException();
        }        

    }
}
