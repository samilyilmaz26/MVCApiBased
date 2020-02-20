using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCApiBased.Controllers
{
    public class PersonelController : Controller
    {
        string[] Isimler = { "Ahmet", "Mehmet", "Süreyya" };
        public ActionResult Index()
        {

            return Json(Isimler);
        }
    }
}