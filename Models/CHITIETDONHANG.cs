namespace ASP.NET_QuanTraSua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONHANG")]
    public partial class CHITIETDONHANG
    {
        [Key]
        [StringLength(5)]
        public string MaHD { get; set; }

        [StringLength(5)]
        public string MaGH { get; set; }

        [StringLength(5)]
        public string MaSP { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }

        public virtual GIOHANG GIOHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
