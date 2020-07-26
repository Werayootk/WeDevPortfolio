using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeDevPortfolio.Controllers
{
    public class SpaController : Controller
    {
        public IActionResult Index([FromServices]IWebHostEnvironment env)
        {
            return new PhysicalFileResult(env.WebRootPath + "/index.html", "text/html");
        }
    }
}
