using HotCholocate.Models;
using Microsoft.EntityFrameworkCore;

namespace HotCholocate
{
    
    public  class MyQuery
    {

        
        public  IQueryable<Customer> GetCustomersWithOrders(NorthWindContext context, string custId)
        {
            return context.Customers.Where(x => x.CustomerId == custId).Include(c => c.Orders).ThenInclude(d=>d.OrderDetails);
        }

        public IQueryable<Order> GetOrders(NorthWindContext context)
        {
            return context.Orders;
        }
    }

}
