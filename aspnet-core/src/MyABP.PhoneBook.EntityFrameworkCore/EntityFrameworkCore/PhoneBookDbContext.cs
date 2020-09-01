using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyABP.PhoneBook.Authorization.Roles;
using MyABP.PhoneBook.Authorization.Users;
using MyABP.PhoneBook.MultiTenancy;
using MyABP.PhoneBook.PhoneBooks.Persons;
using MyABP.PhoneBook.PhoneBooks.PhoneNumbers;

namespace MyABP.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person", "PB");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }


    }
}
