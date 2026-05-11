using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MusicVideo_MVC.Models;
using MusicVideo_MVC.Repositories;

namespace MusicVideo_MVC.Controllers
{
    [Route("[controller]")]
    public class MvController : Controller
    {
        private readonly MusicVideoRepository _repository;

        public MvController(MusicVideoRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<Mv> mvs = _repository.ListMVs();
            return View(mvs);
        }
    }
}
