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


        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            tabelaCliente.DefaultCellStyle.ForeColor = Color.Black;

            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.ListarClientes();
        }
    }
}
