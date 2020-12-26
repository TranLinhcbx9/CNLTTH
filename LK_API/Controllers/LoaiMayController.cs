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
    public class LoaiMayController : ApiController
    {
        [HttpGet]
        [Route("listloaimay")]
        public List<LoaiMay> GetAllLoaiLinhKien()
        {
            LoaiMayDAO dao = new LoaiMayDAO();
            return dao.GetALLLoaiMay();

        }

        [HttpPost]
        [Route("themloaimay")]

        public IHttpActionResult ThemLoaiMay(LoaiMay lm)
        {
            var l = new LoaiMayDAO().CreateLM(lm);
            return Ok();
        }

        [HttpPut]
        [Route("sualoaimay/{id}")]
        public bool EditLoaiMay(LoaiMay lm, int id)
        {
            LoaiMayDAO dao = new LoaiMayDAO();
            return dao.EditLoaiMay(lm, id);
        }

        [HttpDelete]
        [Route("xoaloaimay/{id}")]
        public bool XoaLoaiMay(int id)
        {
            LoaiMayDAO dao = new LoaiMayDAO();
            return dao.XoaLoaiMay(id);
        }
    }
}
