using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using BAL;
namespace QuickService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int val=0)
        {
            List<SeatStatuDTO> BookedSeats = new BusBL().BookedSeats(1);

            if (val ==0)
                return View();
            else
                return Content("No data");
        }
    }
}