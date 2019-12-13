using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC_.Enums;
using RoleTopMVC_.Repositories;
using RoleTopMVC_.ViewsModels;

namespace RoleTopMVC_.Controllers {
    public class LoginController : AbstractController 
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private ReservaRepository reservaRepository = new ReservaRepository();
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {   NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("=================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("=================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if (cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        

                        switch (cliente.TipoUsuario)
                        {
                            case (uint) TiposUsuario.CLIENTE:
                            HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, cliente.Email);
                            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                            HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                            return RedirectToAction("Historico","Login");
                            
                            default:
                            HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, cliente.Email);
                            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                            HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                            return RedirectToAction("Index","Dashboard"); 
                        
                        }
                        
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta"){
                            NomeView = "Login"
                        });
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }
        public IActionResult Historico()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var reservasCliente = reservaRepository.ObterTodosPorCliente(emailCliente);

            return  View(new HistoricoViewModel()
            {
                Reservas = reservasCliente,
                NomeView = "Historico",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

    public IActionResult Logoff()
    {
        HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
        HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }
    }
}