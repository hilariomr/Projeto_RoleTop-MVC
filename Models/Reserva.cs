using System;
using RoleTopMVC_.Enums;

namespace RoleTopMVC_.Models
{
    public class Reserva
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}

        public DateTime DataDoPedido {get;set;}
        public double IluminacaoPreco {get; set;}
        public double SomPreco {get; set;}
        public double PrecoTotal {get;set;}
        public DateTime DataReserva { get;set; }
        public uint Status {get;set;}
        public double PrecoLocacao {get; set;}

        public Reserva()
        {
            this.Cliente = new Cliente();
            this.Id = 0;
            this.IluminacaoPreco = 0;
            this.SomPreco = 0;
            this.Status = (uint) StatusReserva.PENDENTE;
            this.PrecoLocacao = 0;
        }

        public void CalculaPrecoTotal()
        {
            this.PrecoTotal = this.SomPreco + this.IluminacaoPreco + this.PrecoLocacao;
        }
    }
}