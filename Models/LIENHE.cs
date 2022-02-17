namespace ASP.NET_QuanTraSua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LIENHE")]
    public partial class LIENHE
    {
        [Key]
        [StringLength(5)]
        public string MaLH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLH { get; set; }

        [Required]
        [StringLength(100)]
        public string DiaChiLH { get; set; }

        [Required]
        [StringLength(20)]
        public string SDT { get; set; }
    }
}
