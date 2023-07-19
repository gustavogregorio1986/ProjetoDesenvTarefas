using Desenvolvimentotarefas.Data;
using Desenvolvimentotarefas.Models;
using Desenvolvimentotarefas.Repositorios.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Desenvolvimentotarefas.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly BancoContext _context;

        public TarefaRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;
        }

        public TarefaModel ListaPorId(int id)
        {
            return _context.Tarefas.FirstOrDefault(x => x.Id == id);
        }

        public TarefaModel Adicionar(TarefaModel tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return tarefa;
        }

        public List<TarefaModel> BuscarPorTodos()
        {
            return _context.Tarefas.ToList();
        }

        public TarefaModel Atualizar(TarefaModel tarefa)
        {
            TarefaModel tarefaDB = ListaPorId(tarefa.Id);

            if (tarefaDB == null) throw new System.Exception("Houve um erro na atualização do contato");

            tarefaDB.Titulo = tarefa.Titulo;
            tarefaDB.Descricao = tarefa.Descricao;
            tarefaDB.DataInicio = tarefa.DataInicio;
            tarefaDB.DataFim = tarefa.DataFim;

            _context.Tarefas.Update(tarefaDB);
            _context.SaveChanges();

            return tarefa;
       
        }

        public bool Apagar(int id)
        {
            TarefaModel tarefaDB = ListaPorId(id);
            if (tarefaDB == null) throw new System.Exception("Houve um ero na deleção do contato");

            _context.Tarefas.Remove(tarefaDB);
            _context.SaveChanges();

            return true;


        }
    }
}
