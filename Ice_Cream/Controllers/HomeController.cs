using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ice_Cream.Models;

namespace Ice_Cream.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

    }
}
