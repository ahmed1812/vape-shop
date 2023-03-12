using eCommerce_app.Data.Static;
using eCommerce_app.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCommerce_app.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
