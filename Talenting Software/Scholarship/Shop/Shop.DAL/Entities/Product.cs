using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entities
{
    public class Product
    {
        [Required]
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "*** Name Err ***")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*** Price Err ***")]
        public string Price { get; set; }

        [Required(ErrorMessage = "*** ExpirationDate Err ***")]
        public string ExpirationDate { get; set; }
    }
}
