using Webdemo.Models;
using Microsoft.AspNetCore.Mvc;
using Webdemo.Repository;

namespace Webdemo.ViewComponents
{
    public class LoaiTourMenuViewComponent : ViewComponent
    {
        private readonly ILoaiTourRepository _loaiTour;

        public LoaiTourMenuViewComponent(ILoaiTourRepository loaiTourRepository)
        {
            _loaiTour = loaiTourRepository;
        }

        public IViewComponentResult Invoke()
        {
            var loaitour = _loaiTour.GetAllLoaiTour().OrderBy(options=>options.LoaiTour);
            return View(loaitour);

           
        }
    }
}
