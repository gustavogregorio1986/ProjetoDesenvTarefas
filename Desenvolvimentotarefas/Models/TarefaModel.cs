using System;
using System.ComponentModel.DataAnnotations;

namespace Desenvolvimentotarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Titulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Por favor, informe a descrição é fundamental")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Data de Inicio")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Data de Fim")]
        public DateTime DataFim { get; set; }
    }
}
