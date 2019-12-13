using System.Collections.Generic;
using RoleTopMVC_.Models;

namespace RoleTopMVC_.ViewsModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Reserva> Reservas {get;set;}
    }
}