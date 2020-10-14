using System;
using System.Collections.Generic;
using System.Text;

namespace dll_cafeteria_sistema_interno.Produtos.comida
{
    public class Comida : Produto
    {
        public string horarioSaidaComida { get;set; }
        public Comida(string descricao, double preco,string horarioSaidaComida)
            : base(descricao, preco)
        {
            this.horarioSaidaComida = horarioSaidaComida;
        }
    }
}
