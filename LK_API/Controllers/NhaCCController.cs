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
    public class NhaCCController : ApiController
    {
        [HttpGet]
        [Route("listnhacc")]
        public List<NhaCC> GetAllLoaiLinhKien()
        {
            NhaCCDAO dao = new NhaCCDAO();
            return dao.GetALLNhaCC();

        }

        //[HttpGet]
        //[Route("getnhaccbyid/{id}")]
        //public NhaCC GetNhaCCByID(int id)
        //{
        //    NhaCCDAO dao = new NhaCCDAO();
        //    return dao.GetNhaCCByID(id);

        //}

        [HttpPost]
        [Route("themnhacc")]

        public IHttpActionResult ThemNhaCC(NhaCC ncc)
        {
            var l = new NhaCCDAO().CreateNCC(ncc);
            return Ok();
        }

        [HttpPut]
        [Route("suanhacc/{id}")]
        public bool EditNhaCC(NhaCC ncc, int id)
        {
            NhaCCDAO dao = new NhaCCDAO();
            return dao.EditNhaCC(ncc, id);
        }

        [HttpDelete]
        [Route("xoanhacc/{id}")]
        public bool XoaNhaCC(int id)
        {
            NhaCCDAO dao = new NhaCCDAO();
            return dao.XoaNhaCC(id);
        }

    }
}
