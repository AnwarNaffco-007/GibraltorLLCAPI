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

        public async Task<IEnumerable<TPatientInfo>> GetPatientInfo()
        {
            return await _appDBContext.tbl_PatientsInfo.ToListAsync();
            throw new NotImplementedException();
        }

        public async Task<TPatientInfo> GetPatientInfoByID(int ID)
        {
            return await _appDBContext.tbl_PatientsInfo.FindAsync(ID);
            throw new NotImplementedException();
        }

        public async Task<TPatientInfo> InsertPatientInfo(TPatientInfo oPat)
        {
            _appDBContext.tbl_PatientsInfo.Add(oPat);
            await _appDBContext.SaveChangesAsync();
            return oPat;
            throw new NotImplementedException();
        }

        public async Task<TPatientInfo> UpdatePatientInfo(TPatientInfo oPat)
        {
            _appDBContext.Entry(oPat).State = EntityState.Modified;
            await _appDBContext.SaveChangesAsync();
            return oPat;
            throw new NotImplementedException();
        }
        //DTOPatientInfo pInfo = new DTOPatientInfo();
        //List<DTOPatientInfo> pInfoList = new List<DTOPatientInfo>();

        //public bool DeletePatientInfo(Guid ID)
        //{
        //    bool result = false;
        //    var patientObj = pInfoList.Where(s=>s.Id == ID).FirstOrDefault();
        //    if (patientObj != null)
        //    {
        //        pInfoList.Remove(patientObj);
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;

        //}

        //public List<DTOPatientInfo> GetPatientInfo()
        //{
        //   return pInfoList;

        //}

        //public DTOPatientInfo GetPatientInfoByID(Guid ID)
        //{
        //    return pInfoList.Where(s => s.Id == ID).FirstOrDefault();            
        //}

        //public DTOPatientInfo InsertPatientInfo(DTOPatientInfo objPat)
        //{
        //    DTOPatientInfo pInfo = new DTOPatientInfo()
        //    {
        //        Name = objPat.Name,
        //        Fathername = objPat.Fathername,
        //        Address = objPat.Address,
        //        Age = objPat.Age,
        //        Gender = objPat.Gender,
        //        NIC = objPat.NIC,
        //        Phone = objPat.Phone,
        //        VaccinationStatus = objPat.VaccinationStatus,
        //        Id = new Guid()

        //    };

        //    pInfoList.Add(pInfo);
        //    return pInfo;
        //}

        //public DTOPatientInfo UpdatePatientInfo(DTOPatientInfo objPat)
        //{
        //    var obj = pInfoList.FirstOrDefault(x => x.Id == objPat.Id);
        //    if (obj != null)
        //    {
        //        obj.Name = objPat.Name;
        //        obj.Fathername = objPat.Fathername;
        //        obj.Address = objPat.Address;
        //        obj.Age = objPat.Age;
        //        obj.Gender = objPat.Gender;
        //        obj.NIC = objPat.NIC;
        //        obj.Phone = objPat.Phone;
        //        obj.VaccinationStatus = objPat.VaccinationStatus;              

        //    }
        //    return obj;
        //}


    }
}
