using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecodifiqueViagens.Models
{
    public class Cadastro_Mensagem_Contato
    {
        [Key]
        public int Id_Msg { get; set; }

        public string nomeDeContato { get; set; }

        public string email { get; set; }

        public string msg { get; set; }

        public Boolean aceitaReceberNot { get; set; }

    }
}
