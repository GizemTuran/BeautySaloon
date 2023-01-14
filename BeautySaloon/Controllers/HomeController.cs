using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using BeautySaloon.Models;

namespace BeautySaloon.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        BeautySalonEntities2 db = new BeautySalonEntities2();
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Oursalon()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Social()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Appointment(AppointmentInfoModel model) //submite basıldığında çalışır.
        {
            //var userID = Session["userID"];
            var operation = db.Operation.FirstOrDefault(m => m.ID == model.selectedItem);

                Appointment app = new Appointment();
                app.Apointee_ID = Int32.Parse(Session["userID"].ToString());
                app.Date = model.date;
                app.Operation_ID = model.selectedItem;

                db.Appointment.Add(app);
                db.SaveChanges();

                
            TempData["msg"] = "<script>alert('You have ordered your appointment successfully..')</script>";
            return RedirectToAction("Appointment");
        }
        public ActionResult Appointment()
        {
            var operationlist = db.Operation.ToList();
            SelectList list = new SelectList(operationlist,"ID","Name"); //HTML dropdown selectlist kullanır.
            ViewBag.operationlist = list;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source=DESKTOP-HLA1UQS; database=BeautySalon; integrated security=SSPI;";
        }
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(User model)
        {
            HttpCookie cookie = new HttpCookie("Users");
            if (ModelState.IsValid == true)
            {
                if (model.Rememberme == true)
                {

                    cookie["Name"] = model.Name;
                    cookie["Password"] = model.Password;
                    cookie.Expires = DateTime.Now.AddDays(4);
                    HttpContext.Response.Cookies.Add(cookie);

                }
                else
                {
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    HttpContext.Response.Cookies.Add(cookie);
                }
            }

            var user1 = db.User.FirstOrDefault(m => m.Name == model.Name && m.Password == model.Password);
            if (user1 != null)
            {
                Session["Name"] = user1.Name;
                Session["userID"] = user1.ID;
                TempData["msg"] = "<script>alert('You are logged in successfully')</script>";

                return RedirectToAction("Home","Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User model)
        {

            var u = db.User.FirstOrDefault(m=>m.Name == model.Name && m.Password ==model.Password && m.Email==model.Email);
            if (u==null) { 
            User user = new User();
            user.Name = model.Name;
            user.Password = model.Password;
            user.Email = model.Email;
            
            db.User.Add(user);
            db.SaveChanges();
            return RedirectToAction("Home", "Home");
            }
            else {
                TempData["alertMessage"] = "This user has been already added..";
                return View();
            }

            return RedirectToAction("Home","Home");
        }
        public ActionResult Signup()
        {

            return View();
        }

    }
    }