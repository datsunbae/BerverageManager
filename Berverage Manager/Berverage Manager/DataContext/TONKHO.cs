namespace Berverage_Manager.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TONKHO")]
    public partial class TONKHO
    {
        public int ID { get; set; }

        public int? IDSP { get; set; }

        public int? SLTON { get; set; }

        [StringLength(100)]
        public string SLTONQUIDOI { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
