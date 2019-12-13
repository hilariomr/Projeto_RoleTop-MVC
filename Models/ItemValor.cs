using RoleTopMVC_.Models;

namespace RoleTopMVC.Models
{
    public class ItemValor : Produto
    {
        public ItemValor()
        {

        }
        public ItemValor(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}