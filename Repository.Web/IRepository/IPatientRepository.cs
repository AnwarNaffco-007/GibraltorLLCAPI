using DTOs.Web;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Web.IRepository
{
    public interface IPatientRepository
    {
        
        Task<IEnumerable<TPatientInfo>> GetPatientInfo();
        Task<TPatientInfo> GetPatientInfoByID(int ID);
        Task<TPatientInfo> InsertPatientInfo(TPatientInfo pat);
        Task<TPatientInfo> UpdatePatientInfo(TPatientInfo pat);
        bool DeletePatientInfo(int ID);
        //List<DTOPatientInfo> GetPatientInfo();
        //DTOPatientInfo GetPatientInfoByID(Guid ID);
        //DTOPatientInfo InsertPatientInfo(DTOPatientInfo oPat);
        //DTOPatientInfo UpdatePatientInfo(DTOPatientInfo oPat);
        //bool DeletePatientInfo(Guid ID);
    }
}
