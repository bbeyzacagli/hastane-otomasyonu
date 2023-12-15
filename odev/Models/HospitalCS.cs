using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using odev.Models;
using System.Collections.Generic;

namespace odev.Models
{
    public class HospitalCS : DbContext
    {
        private readonly IConfiguration _configuration;

        public HospitalCS(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<UsersAccount> UsersAccounts { get; set; }
        public DbSet<WorkingHours> WorkingHourss { get; set; }
        public DbSet<Patients> Patientss { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Doctors> Doctorss { get; set; }
        public DbSet<Appointments> Appointmentss { get; set; }
        public DbSet<Polyclinics> Polyclinicss { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            }
        }
    }
}