namespace MVC_SQLCE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        public int ID { get; set; }

        [Column("USER")]
        [Required]
        [StringLength(255)]
        public string USER1 { get; set; }

        [Required]
        [StringLength(255)]
        public string PASS { get; set; }

        [Required]
        [StringLength(255)]
        public string FNAME { get; set; }

        [Required]
        [StringLength(255)]
        public string LNAME { get; set; }
    }
}
