using eTicketMovieSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketMovieSystem.Data.Services
{
    public interface IOrdersService
    {
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
    }
}
