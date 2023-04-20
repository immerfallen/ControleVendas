using ControleVendas.DAO;
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
            try
            {
                decimal valorDinheiro, valorCartao, troco, totalPago, total;

                int quantidadeEstoque, quantidadeComprada, estoqueAtualizado;

                ProdutoDAO produtoDAO = new ProdutoDAO();

                valorDinheiro = decimal.Parse(txtDinheiro.Text);
                valorCartao = decimal.Parse(txtCartao.Text);
                total = decimal.Parse(txtTotal.Text);

                totalPago = valorDinheiro + valorCartao;

                if(totalPago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor da venda");
                }
                else
                {
                    troco = totalPago - total;
                    txtTroco.Text = troco.ToString();
                }

                Venda venda = new Venda();
                venda.ClienteId = Cliente.Codigo;
                venda.DataVenda = DataAtual;
                venda.TotalVenda = total;
                venda.Observacoes = txtObs.Text;

                VendaDAO vendaDAO = new VendaDAO();

                vendaDAO.CadastrarVenda(venda);

                

                foreach (DataRow linha in Carrinho.Rows)
                {
                    ItemVenda item = new ItemVenda();
                    item.VendaId = vendaDAO.RetornaIdUltimaVenda();
                    item.ProdutoId = int.Parse(linha["Código"].ToString());
                    item.Quantidade = int.Parse(linha["Quantidade"].ToString());
                    item.SubTotal = decimal.Parse(linha["Subtotal"].ToString());

                    quantidadeEstoque = produtoDAO.RetornaEstoqueAtual(item.ProdutoId);
                    quantidadeComprada = item.Quantidade;
                    estoqueAtualizado = quantidadeEstoque - quantidadeComprada;

                    produtoDAO.BaixaEstoque(item.ProdutoId, estoqueAtualizado);

                    ItemVendaDAO itemDAO = new ItemVendaDAO();
                    itemDAO.CadastrarItemVenda(item);
                }


                MessageBox.Show("Venda finalizada com sucesso");

                this.Dispose();

                new FrmVendas().ShowDialog();
                
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu o erro " + ex.Message);
            }

        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            txtTroco.Text = "0,00";
            txtDinheiro.Text = "0,00";
            txtCartao.Text = "0,00";
        }
    }
}
