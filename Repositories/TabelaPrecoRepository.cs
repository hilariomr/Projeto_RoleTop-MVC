using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;
using RoleTopMVC_.Repositories;

namespace RoleTopMVC.Repositories
{
    public class TabelaPrecoRepository 
    {
        private const string PATH = "Database/TabelaPreco.csv";

        public double ObterPrecoDe(string nome)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nome))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<ItemValor> ObterTodos()
        {
            List<ItemValor> itens = new List<ItemValor>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas)
            {
                ItemValor i = new ItemValor();
                string[] dados = linha.Split("=");
                i.Nome = dados[0];
                i.Preco = double.Parse(dados[1]);
                itens.Add(i);
            }

            return itens;
        }
    }
}