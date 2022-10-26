using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs.Web
{
   public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<DTOPatientInfo> tbl_PatientsInfo
        {
            get;
            set;
        }
        public DbSet<DTOVaccination> tbl_VaccinationInfo
        {
            get;
            set;
        }

        public DbSet<DTOVaccinationHistory> tbl_VaccinationHistory 
        {
            get; 
            set; 
        }
    }
}
