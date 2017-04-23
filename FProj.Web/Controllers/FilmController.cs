using FProj.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace FProj.Web.Controllers
{
    public class FilmController : Controller
    {
        // GET: Film
        public ActionResult Index() => View(UnitOfWork.Instance.FilmRepository.GetAll());

        public ActionResult Details(int Id) => View(UnitOfWork.Instance.FilmRepository.GetById(Id));

        [HttpPost]
        public ActionResult UploadPoster(int Id, HttpPostedFileBase file) {
            string uniqueName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string localPath = Path.Combine(Server.MapPath($"~{WebConfigurationManager.AppSettings["ImageFolder"]}"), uniqueName);
            
            file.SaveAs(localPath);
            var path = UnitOfWork.Instance.ImageRepository.AddPoster(new Api.ImageApi() { Path = uniqueName }, Id);
            return Json(new { Ok = true, Path = WebConfigurationManager.AppSettings["ImageFolder"] + path });
        }
    }
}