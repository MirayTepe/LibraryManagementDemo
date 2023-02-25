using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class LibraryManagementContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DbLibrary;Trusted_Connection=true");

        }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LoanedBook> LoanedBooks { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<User> Users { get; set; }





    }
}
