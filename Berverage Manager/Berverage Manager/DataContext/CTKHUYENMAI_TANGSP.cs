namespace Berverage_Manager.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTKHUYENMAI_TANGSP
    {
        [Key]
        public int MACTKM { get; set; }

        public int? MAKM { get; set; }

        public int? MASP { get; set; }

        public int? SLTANG { get; set; }

        public double? GIATU { get; set; }

        public double? DENGIA { get; set; }

        public virtual KHUYENMAI KHUYENMAI { get; set; }
    }
}
