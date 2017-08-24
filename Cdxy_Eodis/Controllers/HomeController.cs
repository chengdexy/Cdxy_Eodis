using Cdxy_Eodis.Helpers;
using Cdxy_Eodis.Models;
using System;
using System.Web.Mvc;

namespace Cdxy_Eodis.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //检查Session判断是否登录
            if (!SessionHelper.UserHasLogged(Session))
            {
                //未登录,跳转到登录页面
                return RedirectToAction("LogIn", "Account");
            }

            //获取Session中的用户信息
            User ur = new User
            {
                Uid = Session["Uid"].ToString(),
                Pwd = Session["Pwd"].ToString()
            };

            return View(ur);
        }
    }
}