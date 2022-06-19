using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entities
{
    public class Gender
    {
        [Required]
        [Key]
        public int GenderId { get; set; }

        [Required(ErrorMessage = "*** Gender Err ***")]
        public char ThisGender { get; set; }
    }
}
