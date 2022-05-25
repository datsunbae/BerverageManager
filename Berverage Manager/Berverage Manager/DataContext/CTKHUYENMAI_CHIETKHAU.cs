namespace Berverage_Manager.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTKHUYENMAI_CHIETKHAU
    {
        [Key]
        public int MACTKM { get; set; }

        public int? MAKM { get; set; }

        public double? GIATU { get; set; }

        public double? DENGIA { get; set; }

        public double? CK { get; set; }

        [StringLength(5)]
        public string LOAICK { get; set; }

        public virtual CHIETKHAU CHIETKHAU { get; set; }

        public virtual KHUYENMAI KHUYENMAI { get; set; }
    }
}
