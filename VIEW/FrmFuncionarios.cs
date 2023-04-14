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
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Bairro = txtBairro.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.NivelAcesso = cbNivel.Text;
            funcionario.Cargo = cbUf.Text;
            funcionario.Celular = txtCelular.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Complemento = txtComplemento.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Estado = cbCargo.Text;
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
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

          tabelaFuncionario.DataSource =  dao.ListarFuncionarios();
        }
    }
}
