using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecodifiqueViagens.Models
{
    public class Agendamento_Destinos
    {
        [Key]
        public int Id_Agendamento { get; set; }

        public string nome { get; set; }

        public string destino { get; set; }

        public string telefone { get; set; }

        public string formaPagamento { get; set; }

    }
}