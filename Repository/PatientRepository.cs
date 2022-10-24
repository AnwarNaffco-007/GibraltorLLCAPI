using DTOs.Web;
using Repository.Web.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Repository.Web.Repository
{
   public class PatientRepository : IPatientRepository
    {
        DTOPatientInfo pInfo = new DTOPatientInfo();
        List<DTOPatientInfo> pInfoList = new List<DTOPatientInfo>();

        public bool DeletePatientInfo(Guid ID)
        {
            bool result = false;
            var patientObj = pInfoList.Where(s=>s.Id == ID).FirstOrDefault();
            if (patientObj != null)
            {
                pInfoList.Remove(patientObj);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;

        }

        public List<DTOPatientInfo> GetPatientInfo()
        {
           return pInfoList;
       
        }

        public DTOPatientInfo GetPatientInfoByID(Guid ID)
        {
            return pInfoList.Where(s => s.Id == ID).FirstOrDefault();            
        }

        public DTOPatientInfo InsertPatientInfo(DTOPatientInfo objPat)
        {
            DTOPatientInfo pInfo = new DTOPatientInfo()
            {
                Name = objPat.Name,
                Fathername = objPat.Fathername,
                Address = objPat.Address,
                Age = objPat.Age,
                Gender = objPat.Gender,
                NIC = objPat.NIC,
                Phone = objPat.Phone,
                VaccinationStatus = objPat.VaccinationStatus,
                Id = new Guid()

            };

            pInfoList.Add(pInfo);
            return pInfo;
        }

        public DTOPatientInfo UpdatePatientInfo(DTOPatientInfo objPat)
        {
            var obj = pInfoList.FirstOrDefault(x => x.Id == objPat.Id);
            if (obj != null)
            {
                obj.Name = objPat.Name;
                obj.Fathername = objPat.Fathername;
                obj.Address = objPat.Address;
                obj.Age = objPat.Age;
                obj.Gender = objPat.Gender;
                obj.NIC = objPat.NIC;
                obj.Phone = objPat.Phone;
                obj.VaccinationStatus = objPat.VaccinationStatus;              

            }
            return obj;
        }


    }
}
