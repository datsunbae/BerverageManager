namespace Berverage_Manager.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CT_DONHANG = new HashSet<CT_DONHANG>();
            CT_PNHAPKHO = new HashSet<CT_PNHAPKHO>();
            CTKHUYENMAI_TANGSP = new HashSet<CTKHUYENMAI_TANGSP>();
            TONKHOes = new HashSet<TONKHO>();
        }

        [Key]
        public int MASP { get; set; }

        [StringLength(100)]
        public string TENSP { get; set; }

        [StringLength(50)]
        public string DVTCHINH { get; set; }

        public double? GIANHAP_DVTC { get; set; }

        public double? GIABANSI_DVTC { get; set; }

        public double? GIABANLE_DVTC { get; set; }

        [StringLength(50)]
        public string DVTPHU { get; set; }

        public double? GIABANSI_DVTP { get; set; }

        public double? GIABANLE_DVTP { get; set; }

        public int? QUIDOI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DONHANG> CT_DONHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PNHAPKHO> CT_PNHAPKHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTKHUYENMAI_TANGSP> CTKHUYENMAI_TANGSP { get; set; }

        public virtual DONVI DONVI { get; set; }

        public virtual DONVI DONVI1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TONKHO> TONKHOes { get; set; }
    }
}
