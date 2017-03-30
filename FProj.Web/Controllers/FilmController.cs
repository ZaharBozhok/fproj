using FProj.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FProj.Web.Controllers
{
    public class FilmController : Controller
    {
        // GET: Film
        public ActionResult Index() => View(UnitOfWork.Instance.FilmRepository.GetAll());

        [HttpGet]
        public ActionResult GetGenres()
        {
            var list = new string[] { "test", "ne test", "ne test", "ne test", "ne test", "ne test", "ne test" };
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}