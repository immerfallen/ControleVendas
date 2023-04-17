﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.MODEL
{
    public class Venda
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public DateTime DataVenda { get; set; }

        public decimal TotalVenda { get; set; }

        public string Observacoes { get; set; }


    }
}
