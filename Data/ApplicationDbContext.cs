using HospitalWebApp.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using HospitalWebApp.Models.Doctors;
using HospitalWebApp.Models;

namespace HospitalWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Bill> Bills { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed roles
            builder.Entity<AppRole>().HasData(
                new AppRole { Id = 1, Name = "Patient", NormalizedName = "PATIENT" },
                new AppRole { Id = 2, Name = "Doctor", NormalizedName = "DOCTOR" },
                new AppRole { Id = 3, Name = "Admin", NormalizedName = "ADMIN" }
            );
        }
    }
}
