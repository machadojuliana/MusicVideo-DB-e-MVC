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

         public void Adicionar(Mv m)
        {
            _context.Mv.Add(m);
            _context.SaveChanges();
        }

         public void Remover(int id)
        {
            var mv = _context.Mv.FirstOrDefault(m => m.Id == id);
            if (mv == null)return;
            {
                _context.Mv.Remove(mv);
                _context.SaveChanges();
            }
        }
    }
}