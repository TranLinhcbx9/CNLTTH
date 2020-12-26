namespace LK_API.Data.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiMay")]
    public partial class LoaiMay
    {
        [Key]
        public int maLoaiMay { get; set; }

        [StringLength(50)]
        public string tenLoaiMay { get; set; }
    }
}
