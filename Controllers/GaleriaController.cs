using Microsoft.AspNetCore.Mvc;
using RoleTopMVC_.ViewsModels;

namespace RoleTopMVC_.Controllers
{
    public class GaleriaController : AbstractController
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel(){
                NomeView = "Galeria",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}