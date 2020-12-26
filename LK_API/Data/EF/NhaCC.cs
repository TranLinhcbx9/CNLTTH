namespace LK_API.Data.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCC")]
    public partial class NhaCC
    {
        [Key]
        public int maNhaCungCap { get; set; }

        [StringLength(50)]
        public string tenNhaCungCap { get; set; }
    }
}
