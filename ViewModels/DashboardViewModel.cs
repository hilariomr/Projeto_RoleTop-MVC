using System.Collections.Generic;
using RoleTopMVC_.Models;
using RoleTopMVC_.ViewsModels;

namespace RoleTopMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Reserva> Reservas {get;set;}
        public uint ReservasAprovadas {get;set;}
        public uint ReservasReprovadas {get;set;}
        public uint ReservasPendentes {get;set;}

        public DashboardViewModel()
        {
            this.NomeView = "Dashboard";
            this.Reservas = new List<Reserva>();
        }
    }
}