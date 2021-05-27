using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicaretAPI.Models
{
    public class ProductsWithStore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int groupid { get; set; }
        public string groupname { get; set; }
    }
}
