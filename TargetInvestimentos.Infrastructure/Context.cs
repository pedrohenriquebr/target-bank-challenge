using Microsoft.EntityFrameworkCore;
using TargetInvestimentos.Domain.Entities;

namespace TargetInvestimentos.Infrastructure
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options)
            : base(options) { }


    }


}
