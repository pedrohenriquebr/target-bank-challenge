using Microsoft.EntityFrameworkCore;
using TargetInvestimentos.Domain.Entities;

namespace TargetInvestimentos.Infrastructure
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options)
            : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasOne(c => c.Person)
                .WithOne(c => c.Address)
                .HasForeignKey<Person>(d => d.ID_Address);
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<AddressLog> AddressLog { get; set; }
        public DbSet<PersonLog> PersonLog{ get; set; }
    }


}
