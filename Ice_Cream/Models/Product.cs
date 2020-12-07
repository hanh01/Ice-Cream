using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Ice_Cream.Models
{
    public class Product
    {
        public long ProductID { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public string Recipe { get; set; }

        [Column(TypeName = "decimal(8,2)")]

        public decimal Price { get; set; }

        public string Category { get; set; }
    }
}
