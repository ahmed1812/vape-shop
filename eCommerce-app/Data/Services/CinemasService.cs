using eCommerce_app.Data.Base;
using eCommerce_app.Models;

namespace eCommerce_app.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
