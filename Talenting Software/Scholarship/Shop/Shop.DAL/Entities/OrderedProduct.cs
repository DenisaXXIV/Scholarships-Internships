using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entities
{
    public class OrderedProduct
    {
        [Required]
        [Key]
        public int OrderedProductId { get; set; }

        [Required(ErrorMessage = "*** Order Err ***")]
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "*** Product Err ***")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
    }
}
