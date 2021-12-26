using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderItem.Models
{
    public class Cart
    {
       

        [Key]
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
