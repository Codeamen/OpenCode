using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AuthLibrary.Controllers
{
    public class LibraryUser : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
