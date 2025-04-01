using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MakeupShopAPI.Models
{

    // User Model

    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        // Relationships
        [JsonIgnore]
        public ICollection<Orders> Orders { get; set; }

        [JsonIgnore]
        public ICollection<Cart> Carts { get; set; }
    }

}