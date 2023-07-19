using Desenvolvimentotarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace Desenvolvimentotarefas.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<TarefaModel> Tarefas { get; set; }
    }
}
