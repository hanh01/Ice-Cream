using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ice_Cream.Models
{
    public class Customer
    {
        public long CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
