namespace Berverage_Manager.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUYENMAI")]
    public partial class KHUYENMAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUYENMAI()
        {
            CTKHUYENMAI_CHIETKHAU = new HashSet<CTKHUYENMAI_CHIETKHAU>();
            CTKHUYENMAI_TANGSP = new HashSet<CTKHUYENMAI_TANGSP>();
            DONHANGs = new HashSet<DONHANG>();
        }

        [Key]
        public int MAKM { get; set; }

        [StringLength(100)]
        public string TENKM { get; set; }

        public DateTime? TUNGAY { get; set; }

        public DateTime? DENNGAY { get; set; }

        public bool? TRANGTHAI { get; set; }

        public int? MAHTKM { get; set; }

        public int? MADTKM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTKHUYENMAI_CHIETKHAU> CTKHUYENMAI_CHIETKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTKHUYENMAI_TANGSP> CTKHUYENMAI_TANGSP { get; set; }

        public virtual DOITUONGKHUYENMAI DOITUONGKHUYENMAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }

        public virtual HINHTHUCKHUYENMAI HINHTHUCKHUYENMAI { get; set; }
    }
}
