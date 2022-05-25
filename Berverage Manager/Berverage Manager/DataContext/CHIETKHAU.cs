namespace Berverage_Manager.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHIETKHAU")]
    public partial class CHIETKHAU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHIETKHAU()
        {
            CTKHUYENMAI_CHIETKHAU = new HashSet<CTKHUYENMAI_CHIETKHAU>();
        }

        [Key]
        [StringLength(5)]
        public string MACK { get; set; }

        [StringLength(20)]
        public string TENCK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTKHUYENMAI_CHIETKHAU> CTKHUYENMAI_CHIETKHAU { get; set; }
    }
}
