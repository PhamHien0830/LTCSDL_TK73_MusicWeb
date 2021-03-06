﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace music.Controllers
{
    using Music.BLL;
    using music.DAL.Models;
    using Common.Req;
    using Common.Rsp;
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        public PlaylistController()
        {
            _svc = new PlaylistSvc();
        }
        [HttpPost("get-by-MaPlayList")]
        public IActionResult getPlayList([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Keyword);
            return Ok(res);
        }
        [HttpPost("Delete-MaPlayList")]
        public IActionResult DeletePlayList(DeleteReq req)
        {
            var res = _svc.DeletePlayList(req.MaPlayList);
            return Ok(res);
        }

        private readonly PlaylistSvc _svc;
    }
}