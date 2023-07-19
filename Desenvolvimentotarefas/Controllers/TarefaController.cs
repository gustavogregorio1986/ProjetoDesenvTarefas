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

        public IActionResult Editar(int id)
        {
            TarefaModel tarefa = _tarefaRepositorio.ListaPorId(id);
            return View(tarefa);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            TarefaModel tarefa = _tarefaRepositorio.ListaPorId(id);
            return View(tarefa);
        }

        public IActionResult Alterar(TarefaModel tarefa)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Apagar()
        {
            return View();
        }
    }
}
