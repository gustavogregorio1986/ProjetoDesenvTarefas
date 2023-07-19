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
            try
            {
                if (ModelState.IsValid)
                {
                    _tarefaRepositorio.Adicionar(tarefa);
                    TempData["MensagemSucesso"] = "Tarefa Cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(tarefa);
            }
            catch (System.Exception)
            {
                TempData["MensagemErro"] = "Tarefa Cadastrado com sucesso";
                return RedirectToAction("Index");
            }
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
            try
            {
                if (ModelState.IsValid)
                {
                    _tarefaRepositorio.Atualizar(tarefa);
                    return RedirectToAction("Index");
                }
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu tarefa, tente novamente, detalhe do erro: {erro.Message}";
            }

            return View("Editar", tarefa);
        }

        public IActionResult Apagar(int id)
        {
            bool apagado = _tarefaRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}
