using ControleVendas.DAO;
using ControleVendas.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.VIEW
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO fornecedorDao = new FornecedorDAO();

            cbForne.DataSource = fornecedorDao.ListarFornecedores();
            cbForne.DisplayMember = "nome";
            cbForne.ValueMember = "id";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto() {
            Descricao = txtDescricao.Text,
            Preco = decimal.Parse(txtPreco.Text),
            QuantidadeEstoque = int.Parse(txtEstoque.Text),
            FornecedorId = (int)cbForne.SelectedValue
            };

            ProdutoDAO dao = new ProdutoDAO();

            dao.CadastrarProduto(produto);

            new Helpers().LimparTela(this);

            
        }
    }
}
