using DTOs.Web;
using GibraltorLLCAPI.Response;
using Microsoft.EntityFrameworkCore;
using Repository.Web.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<VaccinationHistoryResponse> GetVacHistoryByID(int ID)
        {
            var result = await (from vh in _appDBContext.tbl_VaccinationHistory
                                join pi in _appDBContext.tbl_PatientsInfo on vh.PatientId equals pi.Id
                                join vi in _appDBContext.tbl_VaccinationInfo on vh.VaccinationId equals vi.Id
                                where vh.Id == ID
                                select new VaccinationHistoryResponse
                                {
                                    PatientName = pi.Name,
                                    PatientFather = pi.Fathername,
                                    VaccinationName = vi.Name,
                                    VaccinationTotalDose = vi.DoseQuantity.ToString(),
                                    VaccinationDose = vh.VaccinationDose.ToString(),
                                    VaccinationDate = vh.VaccinationDate,
                                    VaccinationPlace = vh.VaccinationPlace
                                }).FirstOrDefaultAsync();
            return result;
            
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<VaccinationHistoryResponse>> GetVacInfo()
        {
  
            var result = await (from vh in _appDBContext.tbl_VaccinationHistory
                          join pi in _appDBContext.tbl_PatientsInfo on vh.PatientId equals pi.Id
                          join vi in _appDBContext.tbl_VaccinationInfo on vh.VaccinationId equals vi.Id
                          select new VaccinationHistoryResponse
                          { 
                          PatientName = pi.Name,
                          PatientFather = pi.Fathername,
                          VaccinationName = vi.Name,
                          VaccinationTotalDose = vi.DoseQuantity.ToString(),
                          VaccinationDose = vh.VaccinationDose.ToString(),
                          VaccinationDate = vh.VaccinationDate,
                          VaccinationPlace = vh.VaccinationPlace
                          }).ToListAsync();

            return result;
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
