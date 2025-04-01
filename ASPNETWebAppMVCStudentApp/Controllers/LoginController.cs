using ASPNETWebAppMVCStudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ASPNETWebAppMVCStudentApp.Models;

namespace ASPNETWebAppMVCStudentApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly MyDbContext db = new MyDbContext();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                string hashedPassword = HashPassword(model.Password);
                var user = db.tblUser.FirstOrDefault(u => u.Name == model.Username && u.PasswordHash == hashedPassword);

                if (user != null)
                {
                    Session["Username"] = user.Name;
                    //return RedirectToAction("Index", "Home"); // Redirect to Home
                    return RedirectToRoute(new { controller = "Home", action = "Index" });

                }
                else
                {
                    ViewBag.Message = "Invalid username or password!";
                    return View();
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}