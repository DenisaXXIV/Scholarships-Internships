using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entities
{
    public class ShoppingCart
    {
        [Required]
        [Key]
        public int ShoppingCartId { get; set; }

        [Required(ErrorMessage = "*** TotalAmount Err ***")]
        public float TotalAmount { get; set; }

        [Required(ErrorMessage = "*** HasExpired Err ***")]
        public bool HasExpired { get; set; }

        [Required(ErrorMessage = "*** Client Err ***")]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
    }
}
