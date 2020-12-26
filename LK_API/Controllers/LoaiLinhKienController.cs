using LK_API.Data.DAO;
using LK_API.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LK_API.Controllers
{
    public class LoaiLinhKienController : ApiController
    {
        // GET: api/LoaiLinhKien
        [HttpGet]
        [Route("listloailinhkien")]
        public List<LoaiLinhKien> GetAllLoaiLinhKien()
        {
            LoaiLinhKienDAO dao = new LoaiLinhKienDAO();
            return dao.GetAllLoaiLinhKien();

        }

        [HttpPost]
        [Route("themloailinhkien")]

        public IHttpActionResult ThemLoaiLinhKien(LoaiLinhKien llk)
        {
            var l = new LoaiLinhKienDAO().CreateLLK(llk);
            return Ok();
        }
    }
}
