using eCommerce_app.Data.Base;
using eCommerce_app.Models;

namespace eCommerce_app.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducerService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
