using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK_Winform.DTO
{
    class LinhKien
    {
        public int maLinhKien { get; set; }

        public int? maLoaiLinhKien { get; set; }

        public int? maNhaCungCap { get; set; }

        public int? maLoaiMay { get; set; }

        public string tenLinhKien { get; set; }

        public string thongSoKiThuat { get; set; }

        public string moTa { get; set; }

        public double? giaBan { get; set; }

        public string thoiGianBaoHanh { get; set; }

        //public LinhKien(string tenLinhKien, string thongSoKiThuat, string moTa, double? giaBan, string thoiGianBaoHanh)
        //{
        //    //this.maLoaiLinhKien = maLoaiLinhKien;
        //    //this.maNhaCungCap = maNhaCungCap;
        //    //this.maLoaiMay = maLoaiMay;
        //    this.tenLinhKien = tenLinhKien;
        //    this.thongSoKiThuat = thongSoKiThuat;
        //    this.moTa = moTa;
        //    this.giaBan = giaBan;
        //    this.thoiGianBaoHanh = thoiGianBaoHanh;
        //}
    }
}
