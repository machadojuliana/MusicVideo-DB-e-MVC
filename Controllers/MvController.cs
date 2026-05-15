using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MusicVideo_MVC.Models;
using MusicVideo_MVC.Repositories;

namespace MusicVideo_MVC.Controllers
{
    public class MvController : Controller
    {
        private readonly MusicVideoRepository _repository;

        public MvController(MusicVideoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            @ViewData["Title"] = "Lista";
            List<Mv> mvs = _repository.ListMVs();
            return View(mvs);
        }

        [HttpGet("Cadastro")]
        public IActionResult Cadastro()
        {
            ViewData["Title"] = "Cadastro";
            return View();
        }

        [HttpPost("Cadastro")]
        public IActionResult Cadastro(Mv m)
        {

            _repository.Adicionar(m);

            return RedirectToAction("Index");
        }

         [HttpPost]
        public IActionResult Deletar(int id)
        {
            _repository.Remover(id);
            return RedirectToAction("Index");
        }
    }
}
