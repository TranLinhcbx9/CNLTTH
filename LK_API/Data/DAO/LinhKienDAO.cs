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
        
        public bool EditLinhKien(LinhKien lk, int id)
        {
            try
            {
                var x = db.LinhKiens.Find(id);
                if (x != null)
                {
                    x.maLoaiLinhKien = lk.maLoaiLinhKien;
                    x.maLoaiMay = lk.maLoaiMay;
                    x.maNhaCungCap = lk.maNhaCungCap;
                    x.tenLinhKien = lk.tenLinhKien;
                    x.thongSoKiThuat = lk.thongSoKiThuat;
                    x.moTa = lk.moTa;
                    x.giaBan = lk.giaBan;
                    x.thoiGianBaoHanh = lk.thoiGianBaoHanh;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool XoaLinhKien(int id)
        {
            try
            {
                var x = db.LinhKiens.Find(id);
                if (x != null)
                {
                   
                    db.LinhKiens.Remove(x);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}