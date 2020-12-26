using LK_API.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LK_API.Data.DAO
{
    public class LoaiMayDAO
    {
        LKDbContext db = null;

        public LoaiMayDAO()
        {
            db = new LKDbContext();
        }


        public List<LoaiMay> GetALLLoaiMay()
        {
            return db.LoaiMays.ToList();
        }

        public int CreateLM(LoaiMay lm)
        {
            var loaimay = new LoaiMay()
            {
                maLoaiMay = lm.maLoaiMay,
                tenLoaiMay = lm.tenLoaiMay

                //maLinhKien = lk.maLinhKien;

            };
            db.LoaiMays.Add(loaimay);
            db.SaveChanges();
            return loaimay.maLoaiMay;
        }
    }
}