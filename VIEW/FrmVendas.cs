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
    public partial class FrmVendas : Form
    {

        Cliente cliente = new Cliente();
        ClienteDAO daoCliente = new ClienteDAO();
        Produto produto = new Produto();
        ProdutoDAO daoProduto = new ProdutoDAO();

        int quantidade;
        decimal preco;
        decimal subtotal, total;         

        DataTable carrinho = new DataTable();

        public FrmVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                this.cliente = this.daoCliente.BuscarClientePorCpf(txtCpf.Text);

                txtNome.Text = cliente.Nome;
            }
        }       

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                quantidade = int.Parse(string.IsNullOrWhiteSpace(txtQuantidade.Text) ? "0" : txtQuantidade.Text);
                preco = decimal.Parse(string.IsNullOrWhiteSpace(txtPreco.Text) ? "0" : txtPreco.Text);
                subtotal = quantidade * preco;
                total += subtotal;

                carrinho.Rows.Add(int.Parse(txtCodigo.Text), txtDescricao.Text, quantidade, preco, subtotal);

                txtCodigo.Clear();
                txtDescricao.Clear();
                txtQuantidade.Clear();
                txtPreco.Clear();

                txtCodigo.Focus();

                txtTotal.Text = total.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Digite o código do produto!");
            }
        }        

        private void btnRemover_Click(object sender, EventArgs e)
        {
            decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());

            int indice = tabelaProdutos.CurrentRow.Index;

            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);

            carrinho.AcceptChanges();

            total -= subproduto;

            txtTotal.Text = total.ToString();

            MessageBox.Show("Item removido com sucesso do carrinho");
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Parse(txtData.Text);

            FrmPagamentos telaPagamento = new FrmPagamentos(cliente, carrinho, dataAtual);

            telaPagamento.txtTotal.Text = total.ToString();

            telaPagamento.ShowDialog();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.produto = this.daoProduto.BuscarProdutoPorId(int.Parse(txtCodigo.Text));

                if(produto != null)
                {
                    txtDescricao.Text = produto.Descricao;
                    txtPreco.Text = produto.Preco.ToString();
                }

                
            }
        }
    }
}
