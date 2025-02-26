using Microsoft.AspNetCore.Mvc;
using HocPhanApp.Models;

namespace HocPhanApp.Controllers
{
    public class HocPhanController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/DiemHocPhan/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Index(HocPhanModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DiemHocPhan = model.DiemHocPhan.ToString("0.00");
            }
            return View("/Views/DiemHocPhan/Index.cshtml");
        }
    }
}
