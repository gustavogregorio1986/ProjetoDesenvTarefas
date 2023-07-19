using Desenvolvimentotarefas.Models;
using Desenvolvimentotarefas.Repositorios.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Desenvolvimentotarefas.Controllers
{
    public class TarefaController : Controller
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public TarefaController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }

        public IActionResult Index()
        {
            List<TarefaModel> listaTarefas = _tarefaRepositorio.BuscarPorTodos();
            return View(listaTarefas);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(TarefaModel tarefa)
        {
            if(ModelState.IsValid)
            {
                _tarefaRepositorio.Adicionar(tarefa);
                return RedirectToAction("Index");
            }

            return View(tarefa);
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }
    }
}
