using ControleVendas.MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControleVendas.VIEW
{
    public partial class FrmPagamentos : Form
    {
        Cliente Cliente = new Cliente();
        DataTable Carrinho = new DataTable();
        DateTime DataAtual;

        public FrmPagamentos(Cliente cliente, DataTable carrinho, DateTime dataAtual)
        {
            Cliente = cliente;
            Carrinho = carrinho;
            DataAtual = dataAtual;

            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
