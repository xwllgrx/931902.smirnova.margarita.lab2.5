﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab5.Models;

namespace lab5.Data
{
    public class HospitalContext : DbContext
    {
        public DbSet<HospitalModel> Hospitals { get; set; }
        public DbSet<LabModel> Labs { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<PatientModel> Patients { get; set; }

        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
            Database.EnsureCreated(); 
        }

        public HospitalContext()
        {

        }
    }
}
