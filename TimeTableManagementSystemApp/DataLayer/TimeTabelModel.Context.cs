﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TimetableManagementSystemEntities2 : DbContext
    {
        public TimetableManagementSystemEntities2()
            : base("name=TimetableManagementSystemEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Location1> Locations1 { get; set; }
        public virtual DbSet<Programme> Programmes { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<StudentDetail> StudentDetails { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<workingDaysAndHour> workingDaysAndHours { get; set; }
    }
}
