using HotCholocate.Models;
using Microsoft.EntityFrameworkCore;

namespace HotCholocate
{
    
    public  class MyQuery
    {

        
        public  IQueryable<Customer> GetCustomers(NorthWindContext context)
        {
            return context.Customers;
        }
    }
}
