using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_SQLITE.Models
{
    public class DATA
    {
        [Key]
        public int ID { get; set; }
        public string REFNO { get; set; }
        public DateTime DATE { get; set; }
        public string PROJ { get; set; }
        public string ACC { get; set; }
        public string PARTY { get; set; }
        public string TYPE { get; set; }
        public decimal AMT { get; set; }
        public string   REM { get; set; }
    }
}