using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFlight.Models;
using System.Data.Entity;
using MyFlight.DAL;



namespace MyFlight.Controllers

{
    public class AdminUserController : Controller
    {
        // GET: AdminUser
        
        public ActionResult FlightListEdit()
        {
            return View();
        }
    }
}