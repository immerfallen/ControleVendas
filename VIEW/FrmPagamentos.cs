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

        public FrmPagamentos(Cliente cliente, DataTable carrinho)
        {
            Cliente = cliente;
            Carrinho = carrinho;

            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
