﻿using System;

namespace Desenvolvimentotarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }
    }
}
