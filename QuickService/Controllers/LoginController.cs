using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickService.Models;
using DTO;
using BAL;
namespace QuickService.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public JsonResult getBus(string SourceStation, string DestinationStation, DateTime DateOfJourney)
        {
           // string t1 = Request.Form[]
            List<BusStatuDTO> BusRoute = new List<BusStatuDTO>();
            BusRoute = new CustomerBL().GetBusOfGivenRoute(SourceStation, DestinationStation, DateOfJourney);


            return Json(BusRoute, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Index(BusStopModel busmodel, string Prefix, string pos)
        {
            List<StopDTO> stops = new CustomerBL().getStops();
            //Searching records from list using LINQ query  
            if (pos == "first")
            {
                var CityList = (from N in stops
                                where N.StopName.StartsWith(Prefix)
                                select new { N.StopName });
                return Json(CityList, JsonRequestBehavior.AllowGet);
            }
            else if (pos == "end")
            {
                var CityList = (from N in stops
                                where N.StopName.StartsWith(Prefix)
                                select new { N.StopName });
                return Json(CityList, JsonRequestBehavior.AllowGet);
            }
            return Json("");
        }
        //
        // GET: /Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Login/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
