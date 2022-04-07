using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Snap_Bank.Controllers
{
    public class SnapController : Controller
    {
        // GET: Snap
        public ActionResult Index()
        {
            SnapDbContext db = new SnapDbContext();
            db.securityQuestions.Add(new Models.SecurityQuestions { BirthPlace="hyd", PetName="ca", FavouriteFood="ck" });
            db.SaveChanges();
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Questions()
        {
            return View();
        }
        public ActionResult ForgetPassword()
        {
            return View();
        }
        public ActionResult Support()
        {
            return View();
        }
        public ActionResult Settings()
        {
            return View();
        }
        public ActionResult AccountActivity()
        {
            return View();
        }
        public ActionResult PaymentSuccess()
        {
            return View();
        }
        public ActionResult FundTransfer()
        {
            return View();
        }
    }
}