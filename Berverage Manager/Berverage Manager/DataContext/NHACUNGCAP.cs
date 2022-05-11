namespace Berverage_Manager.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACUNGCAP")]
    public partial class NHACUNGCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACUNGCAP()
        {
            NHAPKHOes = new HashSet<NHAPKHO>();
        }

        [Key]
        public int MANCC { get; set; }

        [StringLength(100)]
        public string TENNCC { get; set; }

        [StringLength(20)]
        public string SDTNCC { get; set; }

        [StringLength(100)]
        public string EMAILNCC { get; set; }

        [StringLength(100)]
        public string DIACHINCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAPKHO> NHAPKHOes { get; set; }
    }
}
