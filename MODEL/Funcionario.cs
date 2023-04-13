using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.MODEL
{
    public class Funcionario : Cliente
    {
        public string Senha { get; set; }

        public string Cargo { get; set; }

        public string NivelAcesso { get; set; }
    }
}
