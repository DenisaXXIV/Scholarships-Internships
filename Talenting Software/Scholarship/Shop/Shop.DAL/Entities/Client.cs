using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entities
{
    public class Client
    {
        [Required]
        [Key]
        public int ClientID { get; set; }

        [Required(ErrorMessage = "*** Name Err ***")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*** Street Err ***")]
        public string Street { get; set; }

        [Required(ErrorMessage = "*** Number Err ***")]
        public string Number { get; set; }

        [Required(ErrorMessage = "*** City Err ***")]
        public string City { get; set; }

        [Required(ErrorMessage = "*** Country Err ***")]
        public string Country { get; set; }

        [Required(ErrorMessage = "*** PhoneNumber Err ***")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "*** Gender Err ***")]
        [ForeignKey("Gender")]
        public int GenderId { get; set; }
    }
}
