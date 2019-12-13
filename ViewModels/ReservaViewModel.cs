using System.Collections.Generic;
using RoleTopMVC_.Models;

namespace RoleTopMVC_.ViewsModels
{
    public class ReservaViewModel : BaseViewModel
    {
        public Cliente Cliente {get; set;}
        public string NomeCliente {get;set;}

        public ReservaViewModel()
        {
            this.Cliente = new Cliente();
            this.NomeCliente = "Jóvi";
        }
    }
}