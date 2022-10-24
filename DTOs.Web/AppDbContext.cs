using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs.Web
{
   public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TPatientInfo> tbl_PatientsInfo
        {
            get;
            set;
        }
        public DbSet<TVaccination> tbl_VaccinationInfo
        {
            get;
            set;
        }

        public DbSet<TVaccinationHistory> tbl_VaccinationHistory 
        {
            get; 
            set; 
        }
    }
}
