using Webdemo.Models;
namespace Webdemo.Repository
{
    public interface ILoaiTourRepository
    {
        TLoaiTour Add(TLoaiTour loaiTour);
        TLoaiTour Update(TLoaiTour loaiTour);
        TLoaiTour Delete(int maLoai);
        TLoaiTour Get(int maLoai);
        IEnumerable<TLoaiTour> GetAllLoaiTour();
    }
}
