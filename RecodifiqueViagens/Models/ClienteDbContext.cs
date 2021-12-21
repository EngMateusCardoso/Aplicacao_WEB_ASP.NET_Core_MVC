using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RecodifiqueViagens.Models
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options) : base(options)
        {

        }

        public DbSet<Cadastro_Mensagem_Contato> mensagens { get; set; }

        public DbSet<Agendamento_Destinos> agendamentos { get; set; }

        internal object Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
