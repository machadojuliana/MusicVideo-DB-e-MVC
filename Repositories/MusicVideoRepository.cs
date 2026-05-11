using MusicVideo_MVC.Contexts;
using MusicVideo_MVC.Models;

namespace MusicVideo_MVC.Repositories
{
    public class MusicVideoRepository
    {
        private readonly MusicVideoDBContext _context;

        public MusicVideoRepository(MusicVideoDBContext context)
        {
            _context = context;
        }

        public List<Mv> ListMVs()
        {
            return _context.Mv.ToList();
        }
    }
}