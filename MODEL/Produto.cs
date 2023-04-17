
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.MODEL
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int QuantidadeEstoque { get; set; }

        public int FornecedorId { get; set; }


    }
}
