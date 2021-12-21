using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecodifiqueViagens.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RecodifiqueViagens.Controllers
{
    public class HomeController : Controller
    {

        private ClienteDbContext _context;

        public HomeController(ClienteDbContext contexto)
        {
            _context = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Destinos()
        {
            return View();
        }

        public IActionResult Promocoes()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        //READ

        public IActionResult Mensagens()
        {
            List<Cadastro_Mensagem_Contato> mensagens = _context.mensagens.ToList();
            return View(mensagens);
        }

        public IActionResult Agendamentos()
        {
            List<Agendamento_Destinos> agendamentos = _context.agendamentos.ToList();
            return View(agendamentos);
        }

        //CREATE

        [HttpPost]
        public IActionResult Destinos(Agendamento_Destinos agendamento)
        {
            _context.Add(agendamento);
            _context.SaveChanges();
            return View();
        }

        [HttpPost]
        public IActionResult Contato(Cadastro_Mensagem_Contato mensagem)
        {
            _context.Add(mensagem);
            _context.SaveChanges();
            return View();
        }

        //UPDATE

        public IActionResult EditarAgendamento(int id)
        {
            var agendamento = _context.agendamentos.Find(id);
            if (agendamento == null)
            {
                return RedirectToAction("Index");
            }
            return View(agendamento);
        }

        [HttpPost]
        public IActionResult EditarAgendamento(Agendamento_Destinos agendamento)
        {
            _context.agendamentos.Update(agendamento);
            _context.SaveChanges();
            return RedirectToAction("Agendamentos");
        }


        public IActionResult EditarMensagens(int id)
        {
            var mensagem = _context.mensagens.Find(id);
            if (mensagem == null)
            {
                return RedirectToAction("Index");
            }
            return View(mensagem);
        }

        [HttpPost]
        public IActionResult EditarMensagens(Cadastro_Mensagem_Contato mensagem)
        {
            _context.mensagens.Update(mensagem);
            _context.SaveChanges();
            return RedirectToAction("Mensagens");
        }

        //DELETE

        public IActionResult DeletarAgendamento(int id)
        {
            var agendamento = _context.agendamentos.Find(id);
            _context.agendamentos.Remove(agendamento);
            _context.SaveChanges();
            return RedirectToAction("Agendamentos");
        }

        public IActionResult DeletarMensagem(int id)
        {
            var mensagem = _context.mensagens.Find(id);
            _context.mensagens.Remove(mensagem);
            _context.SaveChanges();
            return RedirectToAction("Mensagens");
        }

    }
}
