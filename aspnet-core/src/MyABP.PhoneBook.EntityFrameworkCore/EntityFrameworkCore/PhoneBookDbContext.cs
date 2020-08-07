using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyABP.PhoneBook.Authorization.Roles;
using MyABP.PhoneBook.Authorization.Users;
using MyABP.PhoneBook.MultiTenancy;

namespace MyABP.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }
    }
}
