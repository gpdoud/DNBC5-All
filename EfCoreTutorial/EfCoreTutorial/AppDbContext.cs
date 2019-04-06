using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreTutorial {

    public class AppDbContext : DbContext {

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr = @"server=localhost\sqlexpress;database=TutorialDb2;trusted_connection=true;";
            builder.UseSqlServer(connStr);
        }
    }
}
