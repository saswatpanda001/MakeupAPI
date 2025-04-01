using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace MakeupShopAPI.Models
{

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }

        // Relationships
        [JsonIgnore]
        public ICollection<Cart> Carts { get; set; }
        
        [JsonIgnore]
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }


}
