using MyE.Entity;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace MyE.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<FinalReport> FinalReports {get;set;}
        public DbSet<MachineReview> MachineReviews {get;set;}
        public DbSet<MedicalEquipment> MedicalEquipments {get;set;}
        public DbSet<Membership> Memberships {get;set;}
        public DbSet<Order> Orders {get;set;}
        public DbSet<Role> Roles {get;set;}
        public DbSet<Schedule> Schedules {get;set;}
        public DbSet<User> Users {get;set;}

        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
  

    }
}