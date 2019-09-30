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
        public ActionResult Index(int id)
        {
            List<SeatStatuDTO> BookedSeats = new BusBL().BookedSeats(id);
            return View();
        }
    }
}