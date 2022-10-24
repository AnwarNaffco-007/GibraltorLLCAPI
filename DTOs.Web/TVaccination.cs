﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DTOs.Web
{
    [Table("tbl_VaccinationInfo")]
    public class TVaccination
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string DoseQuantity { get; set; }
    }
}
