using System.Linq;
using DB.Models.Model;
using HotChocolate;
using HotChocolate.Types;

namespace Api.GraphQL
{
    public class Query
    {
        

            [UseSelection]
            public IQueryable<Customers> GetCustomers([Service]chinookContext context)
            {
                return context.Customers;
            }
        
    }
}