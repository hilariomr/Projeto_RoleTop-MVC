using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;
using RoleTopMVC_.Controllers;
using RoleTopMVC_.Enums;
using RoleTopMVC_.Models;
using RoleTopMVC_.Repositories;
using RoleTopMVC_.ViewsModels;

namespace RoleTopMVC.Controllers
{
    public class DashboardController : AbstractController
    {
        ReservaRepository reservaRepository = new ReservaRepository();

        public IActionResult Index () {
            List<Reserva> list = reservaRepository.ObterTodos();

            DashboardViewModel dashboardViewModel = new DashboardViewModel();

            foreach (var reserva in list)
            {
                switch (reserva.Status)
                {
                    case (uint) StatusReserva.APROVADO:
                        dashboardViewModel.ReservasAprovadas++;
                        break;
                    
                    case (uint) StatusReserva.REPROVADO:
                        dashboardViewModel.ReservasReprovadas++;
                        break;

                    default:
                        dashboardViewModel.Reservas.Add(reserva);
                        dashboardViewModel.ReservasPendentes++;
                        break;
                }
            }
            dashboardViewModel.NomeView = "Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
            return View (dashboardViewModel);
        }
    }
}