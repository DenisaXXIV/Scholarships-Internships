using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entities
{
    public class Order
    {
        [Required]
        [Key]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "*** Client Err ***")]
        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "*** CreatedDate Err ***")]
        public string CreatedDate { get; set; }

        [Required(ErrorMessage = "*** TotalAmount Err ***")]
        public float TotalAmount { get; set; }

        [Required(ErrorMessage = "*** Discount Err ***")]
        public int Discount { get; set; }
    }
}
