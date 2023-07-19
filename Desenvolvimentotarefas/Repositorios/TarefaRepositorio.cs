using Desenvolvimentotarefas.Data;
using Desenvolvimentotarefas.Models;
using Desenvolvimentotarefas.Repositorios.Interface;

namespace Desenvolvimentotarefas.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly BancoContext _context;

        public TarefaRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;
        }

        public TarefaModel Adicionar(TarefaModel tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return tarefa;
        }
    }
}
