using Microsoft.AspNetCore.Mvc;
using HoaDonApp.Models;

namespace HoaDonApp.Controllers
{
    public class HoaDonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(HoaDonModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ThanhTien = model.ThanhTien.ToString("N0") + " VND";
            }
            return View(model);
        }
    }
}
