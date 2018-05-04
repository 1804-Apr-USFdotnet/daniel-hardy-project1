using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace ClientWebApp.Controllers
{
    public class HomeController : Controller
    {
        BusinessLibrary bl = new BusinessLibrary();
        NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Models.Resturant resturant)
        {
            try
            {
                bl.addResturant(resturant);
                //RedirectToAction("GetAll", "Home"); <-- doesn't work!
                Response.Redirect("~/Home/GetAll");
            }
            catch (Exception ex)
            {
                //NLog goes here
                logger.LogException(NLog.LogLevel.Error, "Controller: Function: Update: " + ex.Message, ex);
                return View();
            }
            return View();
        }
        
        public ActionResult Details(int id)
        {

            return View(bl.GetResturantByID(id));
        }

        public ActionResult Update(int id)
        {  
            return View(bl.GetResturantByID(id));
        }

        [HttpPost]
        public ActionResult Update(Models.Resturant resturant)
        {
            try
            {
                bl.updateResturant(resturant);
                Response.Redirect("~/Home/GetAll");
            }
            catch (Exception ex)
            {
                logger.LogException(NLog.LogLevel.Error, "Controller: Function: Update: "+ex.Message, ex);
                return View();
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            return View(bl.GetResturantByID(id));
        }

        [HttpPost]
        public ActionResult Delete(Models.Resturant resturant)
        {
            try
            {
                bl.deleteResturant(resturant);
                Response.Redirect("~/Home/GetAll");
            }
            catch (Exception ex)
            {
                //NLog goes here
                logger.LogException(NLog.LogLevel.Error,"Controller: Function: Delete: "+ex.Message,ex);
                return View();
            }
            return View();
           
        }

        public ActionResult GetAll()
        {
            return View(bl.getAllResturants());
        }

    }
}