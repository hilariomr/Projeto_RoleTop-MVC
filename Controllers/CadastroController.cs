using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC_.Enums;
using RoleTopMVC_.Models;
using RoleTopMVC_.Repositories;
using RoleTopMVC_.ViewsModels;

namespace RoleTopMVC_.Controllers {
    public class CadastroController : AbstractController {
        ClienteRepository clienteRepository = new ClienteRepository ();
        public IActionResult Index () {
            return View (new BaseViewModel () {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente (IFormCollection form) {
            Cliente cliente = new Cliente ();
            ViewData["Action"] = "Cadastro";
            try {
                cliente = new Cliente (form["nome"], form["cpf"], form["telefone"], form["senha"], form["email"], DateTime.Parse (form["data-nascimento"]));

                cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;

                clienteRepository.Inserir (cliente);

                return View ("Sucesso", new RespostaViewModel () {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });

            } catch (Exception e) {
                System.Console.Write (e.StackTrace);
                return View ("Erro", new RespostaViewModel () {
                    NomeView = "Cadastro",
                        Mensagem = $"{cliente.Nome} seu cadastro nao foi concluído!"
                });
            }
        }
    }
}