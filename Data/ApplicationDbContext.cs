﻿using Microsoft.EntityFrameworkCore;
using MyFirstApplication.Models;

namespace MyFirstApplication.Data
{
    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<GatePass> GatePasses { get; set; }
        public DbSet<LockerRequest> LockerRequests { get; set; }
        public DbSet<ActivityReservation> ActivityReservations { get; set; }


    }
}
