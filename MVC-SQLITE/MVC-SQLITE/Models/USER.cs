using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_SQLITE.Models
{
    public class USER
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter your User ID.")]
        [Display(Name = "Username : ")]
        public string USERN { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter your Password.")]
        [Display(Name = "Password : ")]
        public string PASS { get; set; }

        public string FNAME { get; set; }
        public string LNAME { get; set; }
    }
}