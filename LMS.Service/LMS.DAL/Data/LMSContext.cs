using LMS.DOMAIN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.DALL.Data
{

    //Install-Package Microsoft.EntityFrameworkCore.SqlServer
    //Install-Package Microsoft.EntityFrameworkCore.Tools
    //Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design

    //once dbcontext and model created use
    //Add-Migration EFCoreCodeFirstSample.Models.EmployeeContext
    //update-database
    public class LMSContext : DbContext
    {
        public LMSContext(DbContextOptions<LMSContext> options) 
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        //Add-Migration EFCoreCodeFirstSample.Models.EmployeeContextSeed
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().HasData(
                    new User {
                        UserId = 1,
                        FirstName = "Marlon",
                        LastName = "Elpedes",
                        PhoneNumber = "06666666666",
                        Email= "mar@yah.com",
                        DateOfBirth = DateTime.Parse("12/15/1999")
                        
                    },
                    new User
                    {
                        UserId = 2,
                        FirstName = "Jess",
                        LastName = "Allen",
                        PhoneNumber = "02346666666",
                        Email = "Jess@yah.com",
                        DateOfBirth = DateTime.Parse("12/15/1989")

                    }
                );
        }
        //update-database

    }
}
