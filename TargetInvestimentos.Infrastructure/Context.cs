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
                .HasMany(c => c.persons)
                .WithOne(c => c.address)
                .HasForeignKey(c => c.ID_Address);
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressLog> AddressLog { get; set; }
        public DbSet<PersonLog> PersonLog{ get; set; }
    }


}
