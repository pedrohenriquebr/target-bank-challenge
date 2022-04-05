using TargetInvestimentos.Infrastructure;

namespace TargetInvestimentos.Api.Services
{
    public class ClientService
    {

        private readonly Context _context;
        public ClientService(Context context)
        {
            _context = context;
        }

        
    }
}
