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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Bairro = txtBairro.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.NivelAcesso = cbNivel.Text;
            funcionario.Cargo = cbCargo.Text;
            funcionario.Celular = txtCelular.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Complemento = txtComplemento.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Estado = cbUf.Text;
            funcionario.Nome = txtNome.Text;
            funcionario.Numero = int.Parse(txtNumero.Text);
            funcionario.Rg = txtRg.Text;
            funcionario.Telefone = txtTelefone.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionario(funcionario);

            new Helpers().LimparTela(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Codigo = int.Parse(txtCodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.ExcluirFuncionario(funcionario);

            tabelaFuncionario.DataSource = dao.ListarFuncionarios();

            new Helpers().LimparTela(this);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Bairro = txtBairro.Text;
            funcionario.Celular = txtCelular.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Complemento = txtComplemento.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Estado = cbUf.Text;
            funcionario.Nome = txtNome.Text;
            funcionario.Numero = int.Parse(txtNumero.Text);
            funcionario.Rg = txtRg.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Codigo = int.Parse(txtCodigo.Text);
            funcionario.Senha = txtSenha.Text;
            funcionario.Cargo = cbCargo.Text;
            funcionario.NivelAcesso = cbNivel.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AlterarFuncionario(funcionario);

            tabelaFuncionario.DataSource = dao.ListarFuncionarios();

            new Helpers().LimparTela(this);
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

          tabelaFuncionario.DataSource =  dao.ListarFuncionarios();
        }

        private void tabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = tabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = tabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = tabelaFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = tabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbNivel.Text = tabelaFuncionario.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = tabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = tabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtCep.Text = tabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = tabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = tabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = tabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = tabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = tabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbUf.Text = tabelaFuncionario.CurrentRow.Cells[16].Value.ToString();

            tabFuncionarios.SelectedTab = tabPage1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.BuscarFuncionarioPorNome(txtPesquisa.Text);

            if (tabelaFuncionario.Rows.Count == 0)
            {
                tabelaFuncionario.DataSource = dao.ListarFuncionarios();
            }

        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.ListarFuncionarios();
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
    }
}
