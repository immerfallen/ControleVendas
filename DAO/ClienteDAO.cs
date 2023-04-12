using ControleVendas.CONEXAO;
using ControleVendas.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.DAO
{
    public class ClienteDAO
    {

        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarCliente
        public void CadastrarCliente(Cliente cliente)
        {
            try
            {
                string sql = @"insert into tb_clientes 
                              (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado) 
                              values (@nome,@rg,@cpf,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", cliente.Nome);
                executaCmd.Parameters.AddWithValue("@rg", cliente.Rg);
                executaCmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                executaCmd.Parameters.AddWithValue("@email", cliente.Email);
                executaCmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                executaCmd.Parameters.AddWithValue("@celular", cliente.Celular);
                executaCmd.Parameters.AddWithValue("@cep", cliente.Cep);
                executaCmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                executaCmd.Parameters.AddWithValue("@numero", cliente.Numero);
                executaCmd.Parameters.AddWithValue("@complemento", cliente.Complemento);
                executaCmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                executaCmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                executaCmd.Parameters.AddWithValue("@estado", cliente.Estado);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso");

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro.Message);
            }

        }
        #endregion


    }
}
