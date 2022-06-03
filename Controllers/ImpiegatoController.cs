using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class ImpiegatoController : Controller
    {
        public IActionResult CreaForm()
        {
            Impiegato tempImpiegato = new Impiegato()
            {
                Id = 0,
                FullName = "",
                Gender = "",
                City = "",
                EmailAddress = "",
                PersonalWebSite = "",
                Photo = "",
                AlternateText = ""
            };
            return View(tempImpiegato);
        }

        public IActionResult CreaScheda(Impiegato impiegato)
        {
            return View(impiegato);
        }

        public IActionResult CreaFormConFoto()
        {
            ImpiegatoConFile tempImpiegato = new ImpiegatoConFile()
            {
                Id = 0,
                FullName = "",
                Gender = "",
                City = "",
                EmailAddress = "",
                PersonalWebSite = "",
                Photo = "",
                AlternateText = ""
            };
            return View(tempImpiegato);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreaSchedaConFoto(ImpiegatoConFile impiegato)
        {
            if (!ModelState.IsValid)
            {
                return View("CreaFormConFoto", impiegato);
            }
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FileInfo newFileInfo = new FileInfo(impiegato.File.FileName);
            string fileName = String.Format("{0}{1}", impiegato.FullName, newFileInfo.Extension);
            string FullPathName = Path.Combine(path, fileName);
            using (FileStream stream = new FileStream(FullPathName, FileMode.Create))
            {
                impiegato.File.CopyTo(stream);

            }
            impiegato.Photo = String.Format("~/files/{0}", fileName);
            return View(impiegato);
        }
    }
}
