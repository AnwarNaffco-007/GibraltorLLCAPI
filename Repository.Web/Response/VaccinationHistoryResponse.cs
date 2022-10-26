using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GibraltorLLCAPI.Response
{
    public class VaccinationHistoryResponse
    {
        
       public string PatientName            { get; set; }
       public string PatientFather          { get; set; }
       public string VaccinationName        { get; set; }
       public string VaccinationTotalDose   { get; set; }
       public string VaccinationDose        { get; set; }
       public string VaccinationDate        { get; set; }
       public string VaccinationPlace       { get; set; }
     
    }
}
