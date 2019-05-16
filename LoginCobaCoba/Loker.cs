namespace LoginCobaCoba
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loker")]
    public partial class Loker
    {
        [Key]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Auth { get; set; }

        [Column(TypeName = "date")]
        public DateTime Published { get; set; }

        [Required]
        [StringLength(200)]
        public string Desc { get; set; }

        [Column(TypeName = "date")]
        public DateTime Applied { get; set; }

        [Required]
        [StringLength(40)]
        public string Note { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }
    }
}