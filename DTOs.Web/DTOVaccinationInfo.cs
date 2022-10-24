using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs.Web
{
    public class DTOVaccinationInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string DoseQuantity { get; set; }
    
    }
}
