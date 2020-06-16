using System;
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
    public class CaSiController : ControllerBase
    {
        public CaSiController()
        {
            _svc = new CaSiSvc();
        }
        [HttpPost("get-by-MaCaSi")]
        public IActionResult getMusicMaCaSi([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Keyword);
            return Ok(res);
        }
        [HttpPost("Delete-MaCaSi")]
        public IActionResult DeleteCasi(DeleteReq req)
        {
            var res = _svc.DeleteCasi(req.MaCaSi);
            return Ok(res);
        }

        private readonly CaSiSvc _svc;
    }
}