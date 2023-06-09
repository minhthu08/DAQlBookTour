using Webdemo.Models;
namespace Webdemo.Repository
{
    public class LoaiTourRepository : ILoaiTourRepository
    {
        private readonly QlBookTourContext _context;

        public LoaiTourRepository(QlBookTourContext context) 
        { 
            _context = context;
        }
        public TLoaiTour Add(TLoaiTour loaiTour)
        {
            _context.TLoaiTours.Add(loaiTour);
            _context.SaveChanges();
            return loaiTour;
        }

        public TLoaiTour Delete(int maLoai)
        {
            throw new NotImplementedException();
        }

        public TLoaiTour Get(int maLoai)
        {
            return _context.TLoaiTours.Find(maLoai);
        }

        public IEnumerable<TLoaiTour> GetAllLoaiTour()
        {
            return _context.TLoaiTours;
        }

        public TLoaiTour Update(TLoaiTour loaiTour)
        {
            _context.Update(loaiTour);
            _context.SaveChanges();
            return loaiTour;
        }
    }
}
