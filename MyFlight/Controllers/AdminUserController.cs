using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFlight.Models;
using System.Data.Entity;
using MyFlight.DAL;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace MyFlight.Controllers

{
    public class AdminUserController : Controller
    {
        // GET: AdminUser
        private AdminUserDAL db = new AdminUserDAL();

        public ActionResult FlightListEdit()
        {
            return View();
        }

        public ActionResult Login()
        {
            AdminUser au = new AdminUser();
            return View("Submit", au);
            
              
        }

        public ActionResult Submit(AdminUser au)
        {
            if (ModelState.IsValid)
            {
                if (au.UserName == "Admin" && au.Password == "Admin123")
                {
                    return View("FlightListEdit");
                }
                else
                {
                    MessageBox.Show("The user name or password is not correct, please try again!", "Wrong values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return View();
                }


            }
            else
            {
                MessageBox.Show("The user name or password is not correct, please try again!", "Wrong values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return View();
            }

        }
        public ActionResult GetPopUp(int id)
        {
            // Communication with the model
            return View("UserControl/PopupView"); // The defined View in the project
        }
    }
}