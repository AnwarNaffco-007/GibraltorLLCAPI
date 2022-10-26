using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTOs.Web
{
   public class DTOVaccinationHistory
    {
        [Key]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int VaccinationId { get; set; }
        public string VaccinationPlace { get; set; }
        public string VaccinationDate { get; set; }
        public int VaccinationDose { get; set; }
    }
}
