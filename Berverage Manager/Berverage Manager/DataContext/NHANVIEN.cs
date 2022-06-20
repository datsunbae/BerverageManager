namespace Berverage_Manager.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            DONHANGs = new HashSet<DONHANG>();
            NHAPKHOes = new HashSet<NHAPKHO>();
        }

        [Key]
        public int MANV { get; set; }

        [StringLength(100)]
        public string TENNV { get; set; }

        [StringLength(20)]
        public string SDTNV { get; set; }

        [StringLength(150)]
        public string DIACHINV { get; set; }

        [Required]
        [StringLength(50)]
        public string MATK { get; set; }

        [Column(TypeName = "image")]
        public byte[] HINHANHNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAPKHO> NHAPKHOes { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
