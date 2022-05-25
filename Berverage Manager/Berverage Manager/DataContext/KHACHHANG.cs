namespace Berverage_Manager.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            DONHANGs = new HashSet<DONHANG>();
        }

        [Key]
        public int MAKH { get; set; }

        [StringLength(100)]
        public string TENKH { get; set; }

        [StringLength(50)]
        public string SDTKH { get; set; }

        [StringLength(100)]
        public string EMAILKH { get; set; }

        [StringLength(100)]
        public string DIACHIKH { get; set; }

        public bool? GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTHANGNAMSINH { get; set; }

        public bool? LOAIKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
    }
}
