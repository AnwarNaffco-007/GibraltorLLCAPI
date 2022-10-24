using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs.Web
{
    public class DTOPatientInfo
    {
        public Guid Id { get; set; }
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
