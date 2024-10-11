using AddressBook.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Data.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PersonDetail> PersonDetails { get; set; }
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
    }
}
