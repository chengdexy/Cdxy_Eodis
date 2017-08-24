using Cdxy_Eodis.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cdxy_Eodis.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: LogIn
        public ActionResult LogIn()
        {
            // 检查用户是否登录了
            if (SessionHelper.UserHasLogged(Session))
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        // POST: LogIn
        [HttpPost]
        public ActionResult LogIn(FormCollection fc)
        {
            string uid = fc["inputUid"];
            string pwd = fc["inputPwd"];
            if (DbHelper.CheckUidPwd(uid,pwd))
            {
                Session["Uid"] = uid;
                Session["Pwd"] = pwd;
                Session["UserLoggedIn"] = true;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
    }
}