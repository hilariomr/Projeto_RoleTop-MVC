

using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Repositories;
using RoleTopMVC_.Enums;
using RoleTopMVC_.Models;
using RoleTopMVC_.Repositories;
using RoleTopMVC_.ViewsModels;

namespace RoleTopMVC_.Controllers
{
    public class ReservaController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        ReservaRepository reservaRepository = new ReservaRepository();
        TabelaPrecoRepository tabelaPrecoRepository = new TabelaPrecoRepository();
        public IActionResult Index()
        {
            ReservaViewModel pvm = new ReservaViewModel();


            var emailCliente = ObterUsuarioSession();
            if(!string.IsNullOrEmpty(emailCliente))
            {
                pvm.Cliente = clienteRepository.ObterPor(emailCliente);
            }

            var nomeUsuario = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                pvm.NomeCliente = nomeUsuario;
            }

                pvm.NomeView = "Reserva";
                pvm.UsuarioEmail = emailCliente;
                pvm.UsuarioNome = nomeUsuario;

                return View(pvm);

        }

        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"]= "Reserva";
            Reserva reserva = new Reserva();
            
            var usuarioEmail = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            Cliente cliente = clienteRepository.ObterPor(usuarioEmail);
            reserva.Cliente = cliente;

            var som = form["som"];
            if (som.Equals("sim"))
            {
                reserva.SomPreco = tabelaPrecoRepository.ObterPrecoDe("som");
            }
            var iluminacao = form["iluminacao"];
            if (iluminacao.Equals("sim"))
            {
                reserva.IluminacaoPreco = tabelaPrecoRepository.ObterPrecoDe("iluminacao");
            }

            reserva.DataReserva = DateTime.Now;
            reserva.PrecoLocacao = tabelaPrecoRepository.ObterPrecoDe("valor_evento");

            reserva.CalculaPrecoTotal();

            if(reservaRepository.Inserir(reserva))
            {
                return RedirectToAction("Historico","Login");
                
            } else {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Reserva",
                    Mensagem = $"{cliente.Nome} reserva não realizada!"
                });
            }


        }
    
        public IActionResult Aprovar(ulong id) 
        {
            Reserva reserva = reservaRepository.ObterPor(id);
            reserva.Status = (uint) StatusReserva.APROVADO;
            //reservaRepository.Atualizar(reserva);
            //System.Console.WriteLine("Status    " + reserva.Status);
            //return RedirectToAction("Index", "Dashboard");
            if(reservaRepository.Atualizar(reserva))
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar esta reserva")
                {
                    NomeView = "Index",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()                   
                });
            }
        }

        public IActionResult Recusar(ulong id) 
        {
            Reserva reserva = reservaRepository.ObterPor(id);
            reserva.Status = (uint) StatusReserva.REPROVADO;
            //reservaRepository.Atualizar(reserva);
            if(reservaRepository.Atualizar(reserva))
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este pedido")
                {
                    NomeView = "Index",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()                   
                });
                
            }

           // return RedirectToAction("Index", "Dashboard");
        }
    }
}
