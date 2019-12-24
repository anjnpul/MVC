using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TEST.Models
{
    public class user
    {
        public int CID { get; set; }
        [Required(ErrorMessage = "Please Provide Username", AllowEmptyStrings = false)]
        [DisplayName("User Name")]
        public string uid { get; set; }
        [Required(ErrorMessage = "Please Provide Password", AllowEmptyStrings = false)]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string pass { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
    }
}