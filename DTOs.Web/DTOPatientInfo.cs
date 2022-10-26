using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DTOs.Web
{
    [Table("tbl_PatientInfo")]
    public class DTOPatientInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fathername { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string NIC { get; set; }
        public string Phone { get; set; }
        public string VaccinationStatus { get; set; }
        public string Address { get; set; }
    }
}
