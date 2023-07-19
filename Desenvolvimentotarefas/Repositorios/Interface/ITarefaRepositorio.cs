using Desenvolvimentotarefas.Models;

namespace Desenvolvimentotarefas.Repositorios.Interface
{
    public interface ITarefaRepositorio
    {
        TarefaModel Adicionar(TarefaModel tarefa);
    }
}
