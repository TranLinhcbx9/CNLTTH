using LK_API.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LK_API.Data.DAO
{
    public class LinhKienDAO
    {
        LKDbContext db = null;

        public LinhKienDAO()
        {
            db = new LKDbContext();
        }


        public List<LinhKien> GetAllLinhKien()
        {
            return db.LinhKiens.ToList();
        }

        public int CreateLinhkien(LinhKien lk)
        {
            var linhkien = new LinhKien()
            {
                maLinhKien = lk.maLinhKien,
                maLoaiLinhKien = lk.maLoaiLinhKien,
                maNhaCungCap = lk.maNhaCungCap,
                maLoaiMay = lk.maLoaiMay,
                tenLinhKien = lk.tenLinhKien,
                thongSoKiThuat = lk.thongSoKiThuat,
                moTa = lk.moTa,
                giaBan = lk.giaBan,
                thoiGianBaoHanh = lk.thoiGianBaoHanh

                //maLinhKien = lk.maLinhKien;

            };
            db.LinhKiens.Add(linhkien);
            db.SaveChanges();
            return linhkien.maLinhKien;
        }

    }
}