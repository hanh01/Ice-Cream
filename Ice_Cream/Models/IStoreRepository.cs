using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ice_Cream.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Customer> Customers { get; }
    }
}
