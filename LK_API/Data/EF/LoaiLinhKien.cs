namespace LK_API.Data.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiLinhKien")]
    public partial class LoaiLinhKien
    {
        [Key]
        public int maLoaiLinhKien { get; set; }

        [StringLength(50)]
        public string tenLoai { get; set; }
    }
}
