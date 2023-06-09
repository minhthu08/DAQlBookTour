using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Webdemo.Models;
using X.PagedList;

namespace Webdemo.Controllers
{
    public class HomeController : Controller
    {
        QlBookTourContext db = new QlBookTourContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? page)
        {
            int pageSize = 8;
            int pageNumber=page==null||page<0?1:page.Value;
                var lstour = db.TTours.AsNoTracking().OrderBy(x=>x.TenTour);
            PagedList<TTour> ls = new PagedList<TTour>(lstour, pageNumber, pageSize);
            return View(ls);
        }

        public IActionResult TourTheoLoai(int maloai, int? page) 
        { 
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lsTour = db.TTours.AsNoTracking().Where(x => x.MaLoai == maloai).OrderBy(x => x.TenTour);
            PagedList<TTour> ls = new PagedList<TTour>(lsTour, pageNumber, pageSize);
            ViewBag.maloai = maloai;
            return View(lsTour);
        }

        public IActionResult Detail(int maTour)
        { 
            var tour=db.TTours.SingleOrDefault(x=>x.MaTour==maTour);
            var anhTour = db.TAnhTours.Where(x=>x.MaTour==maTour).ToList();
            ViewBag.anhTour = anhTour;
            return View(tour);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}