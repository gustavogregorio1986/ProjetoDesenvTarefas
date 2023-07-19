using Desenvolvimentotarefas.Models;
using Desenvolvimentotarefas.Repositorios.Interface;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(TarefaModel tarefa)
        {
           if(tarefa.DataInicio < tarefa.DataFim)
           {
                _tarefaRepositorio.Adicionar(tarefa);
                return RedirectToAction("Index");
           }
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
