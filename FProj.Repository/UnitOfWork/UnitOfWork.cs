using FProj.Data;

namespace FProj.Repository
{
    public class UnitOfWork
    {
        private readonly FProjContext _context = null;

        private static UnitOfWork _instance = null;
        public static UnitOfWork Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UnitOfWork();
                return _instance;
            }
        }
        private UnitOfWork()
        {
            _context = new FProjContext();
        }

        private FilmRepository _filmRepository = null;
        public FilmRepository FilmRepository
        {
            get
            {
                if (_filmRepository == null)
                    _filmRepository = new FilmRepository(_context);
                return _filmRepository;
            }
        }

        private ImageRepository _imageRepository = null;
        public ImageRepository ImageRepository { get {
                if (_imageRepository == null)
                    _imageRepository = new ImageRepository(_context);
                return _imageRepository;
            } }
    }
}
