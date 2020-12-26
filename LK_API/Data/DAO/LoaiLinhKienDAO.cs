using LK_API.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LK_API.Data.DAO
{
    public class LoaiLinhKienDAO
    {
        LKDbContext db = null;

        public LoaiLinhKienDAO()
        {
            db = new LKDbContext();
        }


        public List<LoaiLinhKien> GetAllLoaiLinhKien()
        {
            return db.LoaiLinhKiens.ToList();
        }

        public int CreateLLK(LoaiLinhKien llk)
        {
            var loailinhkien = new LoaiLinhKien()
            {
                maLoaiLinhKien = llk.maLoaiLinhKien,
                tenLoai = llk.tenLoai

                //maLinhKien = lk.maLinhKien;

            };
            db.LoaiLinhKiens.Add(loailinhkien);
            db.SaveChanges();
            return loailinhkien.maLoaiLinhKien;
        }

        public bool EditLoaiLinhKien(LoaiLinhKien llk, int id)
        {
            try
            {
                var x = db.LoaiLinhKiens.Find(id);
                if (x != null)
                {
                    //x.maLoaiLinhKien = llk.maLoaiLinhKien;
                    x.tenLoai = llk.tenLoai;
                  
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

        public bool XoaLoaiLinhKien(int id)
        {
            try
            {
                var x = db.LoaiLinhKiens.Find(id);
                if (x != null)
                {

                    db.LoaiLinhKiens.Remove(x);
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