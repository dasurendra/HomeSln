using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecor.Controllers
{
    public class CatalogueController : Controller
    {
       
        public IActionResult Catalogue()
        {
            return View();
        }
    }
}
