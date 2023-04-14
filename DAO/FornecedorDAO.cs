using ControleVendas.CONEXAO;
using ControleVendas.MODEL;
using ControleVendas.VIEW;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.DAO
{
    public class FornecedorDAO
    {

        private MySqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarFornecedor
        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                string sql = @"insert into tb_fornecedores 
                              (nome,cnpj,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado) 
                              values (@nome,@cnpj,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
                executaCmd.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);             
                executaCmd.Parameters.AddWithValue("@email", fornecedor.Email);
                executaCmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                executaCmd.Parameters.AddWithValue("@celular", fornecedor.Celular);
                executaCmd.Parameters.AddWithValue("@cep", fornecedor.Cep);
                executaCmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                executaCmd.Parameters.AddWithValue("@numero", fornecedor.Numero);
                executaCmd.Parameters.AddWithValue("@complemento", fornecedor.Complemento);
                executaCmd.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                executaCmd.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                executaCmd.Parameters.AddWithValue("@estado", fornecedor.Estado);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso");
                conexao.Close();                

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro.Message);
            }

        }
        #endregion

        #region ListarFornecedores

        public DataTable ListarFornecedores()
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();

                string sql = "select * from tb_fornecedores";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                executaCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

                da.Fill(tabelaFornecedor);

                conexao.Close();

                return tabelaFornecedor;               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + ex.Message);
                return null;
            }
        }

        #endregion

        #region AlterarFornecedor

        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                string sql = @"update tb_fornecedores set
                              nome = @nome,cnpj = @cnpj,email= @email,telefone = @telefone,celular = @celular,cep = @cep,
                              endereco = @endereco,numero = @numero,complemento = @complemento,bairro = @bairro,cidade = @cidade,estado = @estado where id = @id";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
                executaCmd.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);                
                executaCmd.Parameters.AddWithValue("@email", fornecedor.Email);
                executaCmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                executaCmd.Parameters.AddWithValue("@celular", fornecedor.Celular);
                executaCmd.Parameters.AddWithValue("@cep", fornecedor.Cep);
                executaCmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                executaCmd.Parameters.AddWithValue("@numero", fornecedor.Numero);
                executaCmd.Parameters.AddWithValue("@complemento", fornecedor.Complemento);
                executaCmd.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                executaCmd.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                executaCmd.Parameters.AddWithValue("@estado", fornecedor.Estado);
                executaCmd.Parameters.AddWithValue("@id", fornecedor.Codigo);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor alterado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro.Message);
            }           
        }

        #endregion

        #region ExcluirFornecedor

        public void ExcluirFornecedor(Fornecedor fornecedor)
        {
            try
            {
                string sql = @"delete from tb_fornecedores where id = @id";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                
                executaCmd.Parameters.AddWithValue("@id", fornecedor.Codigo);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluído com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro.Message);
            }
        }

        #endregion

        #region BuscarFornecedorPorNome

        public DataTable BuscarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();

                string sql = "select * from tb_fornecedores where nome = @nome ";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();

                executaCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

                da.Fill(tabelaFornecedor);

                conexao.Close();

                return tabelaFornecedor;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + ex.Message);
                return null;
            }
        }

        #endregion

        #region ListarFornecedoresPorNome

        public DataTable ListarFornecedoresPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();

                string sql = "select * from tb_fornecedores where nome like @nome ";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();

                executaCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

                da.Fill(tabelaFornecedor);

                conexao.Close();

                return tabelaFornecedor;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + ex.Message);
                return null;
            }
        }

        #endregion

    }
}
