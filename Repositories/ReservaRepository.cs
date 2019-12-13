

using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC_.Models;

namespace RoleTopMVC_.Repositories
{
    public class ReservaRepository : RepositoryBase
    {
        private const string PATH = "Database/Reserva.csv";

        public ReservaRepository () {
            if (!File.Exists (PATH)) {

                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Reserva reserva) {
            var quantidadeReservas = File.ReadAllLines(PATH).Length;
            reserva.Id = (ulong) ++quantidadeReservas;
            var linha = new string[] { PrepararReservaCSV (reserva) };
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public List<Reserva> ObterTodosPorCliente(string emailCliente)
        {
        List<Reserva> reservasCliente = new List<Reserva>();
            var reservas = ObterTodos();
            foreach (var reserva in reservas)
            {
                if(reserva.Cliente.Email.Equals(emailCliente))
                {
                    reservasCliente.Add(reserva);
                }
            }
            return reservasCliente;
        }

        public List<Reserva> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Reserva> reservas = new List<Reserva>();
            
            foreach (var linha in linhas)
            {
                Reserva reserva = new Reserva();
                
                reserva.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                reserva.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                reserva.Cliente.Cpf = ExtrairValorDoCampo("cliente_cpf", linha);
                reserva.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                reserva.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                reserva.IluminacaoPreco = double.Parse(ExtrairValorDoCampo("iluminacao_preco", linha));
                reserva.SomPreco = double.Parse(ExtrairValorDoCampo("som_preco", linha));
                reserva.PrecoLocacao = double.Parse(ExtrairValorDoCampo("preco_locacao", linha));
                reserva.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                reserva.DataReserva = DateTime.Parse(ExtrairValorDoCampo("data_reserva", linha));
                reserva.Status = uint.Parse(ExtrairValorDoCampo("status", linha));

                reservas.Add(reserva);
            }
            return reservas;
        }
        public Reserva ObterPor(ulong id)
        {
            var reservasTotais = ObterTodos();
            foreach (var reserva in reservasTotais)
            {
                if(id.Equals(reserva.Id))
                {
                    return reserva;
                }
            }
            return null;
        }

        public bool Atualizar(Reserva reserva)
        {
            var reservasTotais = File.ReadAllLines(PATH);
            var reservaCSV = PrepararReservaCSV(reserva);
            var linhaReserva = -1;
            var resultado = false;
            for (int i = 0; i < reservasTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", reservasTotais[i]));
                if(reserva.Id.Equals(idConvertido))
                {
                    linhaReserva = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                reservasTotais[linhaReserva] = reservaCSV;
                File.WriteAllLines(PATH, reservasTotais);
            }
            return resultado;
        }

        private string PrepararReservaCSV (Reserva reserva) {

            Cliente c = reserva.Cliente;
            
            return $"id={reserva.Id};cliente_nome={c.Nome};cliente_cpf={c.Cpf};cliente_telefone={c.Telefone};cliente_email={c.Email};iluminacao_preco={reserva.IluminacaoPreco};som_preco={reserva.SomPreco};preco_locacao={reserva.PrecoLocacao};data_reserva={reserva.DataReserva};preco_total={reserva.PrecoTotal};status={reserva.Status}";
        }
    }
}