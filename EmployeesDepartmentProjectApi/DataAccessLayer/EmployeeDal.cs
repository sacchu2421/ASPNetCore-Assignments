﻿using EmployeesDepartmentProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeesDepartmentProjectApi.DataAccessLayer
{
    public class EmployeeDal: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            modelBuilder.Entity<Project>().ToTable("TblProject");
            modelBuilder.Entity<Department>().ToTable("TblDepartment");
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}