using LK_API.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LK_API.Data.DAO
{
    public class NhaCCDAO
    {
        LKDbContext db = null;

        public NhaCCDAO()
        {
            db = new LKDbContext();
        }


        public List<NhaCC> GetALLNhaCC()
        {
            return db.NhaCCs.ToList();
        }
        public int CreateNCC(NhaCC ncc)
        {
            var nhacc = new NhaCC() 
            {
                maNhaCungCap = ncc.maNhaCungCap,
                tenNhaCungCap = ncc.tenNhaCungCap

                //maLinhKien = lk.maLinhKien;

            };
            db.NhaCCs.Add(nhacc);
            db.SaveChanges();
            return nhacc.maNhaCungCap;
        }

        public bool EditNhaCC(NhaCC lm, int id)
        {
            try
            {
                var x = db.NhaCCs.Find(id);
                if (x != null)
                {
                    //x.maNhaCungCap = lm.maNhaCungCap;
                    x.tenNhaCungCap = lm.tenNhaCungCap;
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

        public bool XoaNhaCC(int id)
        {
            try
            {
                var x = db.NhaCCs.Find(id);
                if (x != null)
                {

                    db.NhaCCs.Remove(x);
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
