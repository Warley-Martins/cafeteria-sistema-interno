using System;
using System.Collections.Generic;
using System.Text;

namespace dll_cafeteria_sistema_interno.Produtos
{
    public class Produto
    {
        public string descricao { get; set; }
        public double preco { get; set; }
        public Produto(string descricao, double preco)
        {
            if (String.IsNullOrEmpty(descricao))
            {
                throw new ArgumentException("A descrição do produto não pode ser nula ou vazia");
            }
            if(preco <= 0)
            {
                throw new ArgumentException("O preço do produto não pode ser menor ou igual a zero");
            }
            this.descricao = descricao;
            this.preco = preco;
        }
    }
}
