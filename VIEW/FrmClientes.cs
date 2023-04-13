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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Bairro = txtBairro.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Cep = txtCep.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Estado = cbUf.Text;
            cliente.Nome = txtNome.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Rg = txtRg.Text;
            cliente.Telefone = txtTelefone.Text;

            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(cliente);

            tabelaCliente.DataSource = dao.ListarClientes();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            tabelaCliente.DefaultCellStyle.ForeColor = Color.Black;

            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.ListarClientes();

        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            cbUf.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();

            tabClientes.SelectedTab = tabPage1;


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Codigo = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.ExcluirCliente(cliente);

            tabelaCliente.DataSource = dao.ListarClientes();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Bairro = txtBairro.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Cep = txtCep.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Estado = cbUf.Text;
            cliente.Nome = txtNome.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Rg = txtRg.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Codigo = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.AlterarCliente(cliente);

            tabelaCliente.DataSource = dao.ListarClientes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.BuscarClientePorNome(nome);

            if (tabelaCliente.Rows.Count == 0)
            {
                tabelaCliente.DataSource = dao.ListarClientes();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.ListarClientesPorNome(nome);           

        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";

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
