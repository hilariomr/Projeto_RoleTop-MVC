using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC_.Models;
using RoleTopMVC_.ViewsModels;

namespace RoleTopMVC_.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            }
            );
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
