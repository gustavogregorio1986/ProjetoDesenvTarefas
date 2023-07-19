using Desenvolvimentotarefas.Models;
using System.Collections.Generic;

namespace Desenvolvimentotarefas.Repositorios.Interface
{
    public interface ITarefaRepositorio
    {
        TarefaModel ListaPorId(int id);

        TarefaModel Adicionar(TarefaModel tarefa);

        List<TarefaModel> BuscarPorTodos();
    }
}
