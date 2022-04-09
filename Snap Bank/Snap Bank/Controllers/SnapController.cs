using Snap_Bank.Models;
using Snap_Bank.Services;
using Snap_Bank.ViewModel;
using Snap_Bank.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Snap_Bank.Controllers
{
    public class SnapController : Controller
    {
        IAccountNumberService accountNumberService;

        public SnapController(IAccountNumberService _accountNumberService)
        {
            accountNumberService = _accountNumberService;
        }
        // GET: Snap
        public ActionResult Index()
        {
            SnapDbContext db = new SnapDbContext();
            db.securityQuestions.Add(new Models.SecurityQuestions { BirthPlace="hyasdd", PetName="ca", FavouriteFood="ck" });
            //db.accountNumbers.Add(new Models.AccountNumber{ Date = "9819", number = 20 });
            db.SaveChanges();
            return View();
        }

        public ActionResult Register()
        {
            Random rnd = new Random();
            int myRandomNo = rnd.Next(100000000, 999999999);
            ViewBag.RandomNumber = myRandomNo;
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel objreg)
        {
            if (ModelState.IsValid)
            {

            }
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