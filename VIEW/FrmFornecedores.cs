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
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Bairro = txtBairro.Text;
            fornecedor.Celular = txtCelular.Text;
            fornecedor.Cep = txtCep.Text;
            fornecedor.Cidade = txtCidade.Text;
            fornecedor.Complemento = txtComplemento.Text;           
            fornecedor.Email = txtEmail.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Estado = cbUf.Text;
            fornecedor.Nome = txtNome.Text;
            fornecedor.Numero = int.Parse(txtNumero.Text);
            fornecedor.CNPJ = txtCNPJ.Text;
            fornecedor.Telefone = txtTelefone.Text;

            FornecedorDAO dao = new FornecedorDAO();
            dao.CadastrarFornecedor(fornecedor);

            tabelaFornecedor.DataSource = dao.ListarFornecedores();
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            tabelaFornecedor.DefaultCellStyle.ForeColor = Color.Black;

            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedor.DataSource = dao.ListarFornecedores();
        }

        private void tabelaFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtCNPJ.Text = tabelaFornecedor.CurrentRow.Cells[2].Value.ToString();           
            txtEmail.Text = tabelaFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = tabelaFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = tabelaFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtCep.Text = tabelaFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = tabelaFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = tabelaFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtComplemento.Text = tabelaFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = tabelaFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = tabelaFornecedor.CurrentRow.Cells[11].Value.ToString();
            cbUf.Text = tabelaFornecedor.CurrentRow.Cells[12].Value.ToString();

            tabForncedores.SelectedTab = tabPage1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Codigo = int.Parse(txtCodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.ExcluirFornecedor(fornecedor);

            tabelaFornecedor.DataSource = dao.ListarFornecedores();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Bairro = txtBairro.Text;
            fornecedor.Celular = txtCelular.Text;
            fornecedor.Cep = txtCep.Text;
            fornecedor.Cidade = txtCidade.Text;
            fornecedor.Complemento = txtComplemento.Text;            
            fornecedor.Email = txtEmail.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Estado = cbUf.Text;
            fornecedor.Nome = txtNome.Text;
            fornecedor.Numero = int.Parse(txtNumero.Text);
            fornecedor.CNPJ = txtCNPJ.Text;
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Codigo = int.Parse(txtCodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.AlterarFornecedor(fornecedor);

            tabelaFornecedor.DataSource = dao.ListarFornecedores();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;

            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedor.DataSource = dao.BuscarFornecedorPorNome(nome);

            if (tabelaFornecedor.Rows.Count == 0)
            {
                tabelaFornecedor.DataSource = dao.ListarFornecedores();
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedor.DataSource = dao.ListarFornecedoresPorNome(nome);
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();



            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado por favor digite manualmente.");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
    }
}
