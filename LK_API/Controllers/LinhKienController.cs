﻿using LK_API.Data.DAO;
using LK_API.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LK_API.Controllers
{
    public class LinhKienController : ApiController
    {
        // GET: api/LinhKien
        [HttpGet]
        [Route("listlinhkien")]
        public List<LinhKien> GetAllLinhKien()
        {
            LinhKienDAO dao = new LinhKienDAO();
            return dao.GetAllLinhKien();

        }

        [HttpPost]
        [Route("themlinhkien")]

        public IHttpActionResult ThemLinhKien(LinhKien lk)
        {
            var l = new LinhKienDAO().CreateLinhkien(lk);
            return Ok();
        }
    }

}