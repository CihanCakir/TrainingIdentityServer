using DortadimIdentityServer.API2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DortadimIdentityServer.API2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PictureController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetPictures()
        {

            var pictures = new List<Picture>()
            {
                new Picture {Id=1,Name="Doğa Resmi",Url="doga.jpg"},
                new Picture {Id=2,Name="ekşi Resmi",Url="doga.jpg"},
                new Picture {Id=3,Name="kavun Resmi",Url="doga.jpg"},
                new Picture {Id=4,Name="karpuz Resmi",Url="doga.jpg"},
                new Picture {Id=5,Name="elma Resmi",Url="doga.jpg"},
                new Picture {Id=6,Name="sebze Resmi",Url="doga.jpg"},
                new Picture {Id=7,Name="meyve Resmi",Url="doga.jpg"},

            };

            return Ok(pictures);

        }
    }
}
