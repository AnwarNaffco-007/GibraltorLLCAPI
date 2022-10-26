using DTOs.Web;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Web.IRepository
{
    public interface IPatientRepository
    {
        
        Task<IEnumerable<DTOPatientInfo>> GetPatientInfo();
        Task<DTOPatientInfo> GetPatientInfoByID(int ID);
        Task<DTOPatientInfo> InsertPatientInfo(DTOPatientInfo pat);
        Task<DTOPatientInfo> UpdatePatientInfo(DTOPatientInfo pat);
        bool DeletePatientInfo(int ID);
        //List<DTOPatientInfo> GetPatientInfo();
        //DTOPatientInfo GetPatientInfoByID(Guid ID);
        //DTOPatientInfo InsertPatientInfo(DTOPatientInfo oPat);
        //DTOPatientInfo UpdatePatientInfo(DTOPatientInfo oPat);
        //bool DeletePatientInfo(Guid ID);
    }
}
