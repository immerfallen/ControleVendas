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
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarFuncionario

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            try
            {
                string sql = @"insert into tb_funcionarios 
                              (nome,rg,cpf,email, senha, cargo, nivel_acesso, telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado) 
                              values (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                executaCmd.Parameters.AddWithValue("@rg", funcionario.Rg);
                executaCmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                executaCmd.Parameters.AddWithValue("@email", funcionario.Email);
                executaCmd.Parameters.AddWithValue("@senha", funcionario.Senha);
                executaCmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                executaCmd.Parameters.AddWithValue("@nivel_acesso", funcionario.NivelAcesso);
                executaCmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                executaCmd.Parameters.AddWithValue("@celular", funcionario.Celular);
                executaCmd.Parameters.AddWithValue("@cep", funcionario.Cep);
                executaCmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                executaCmd.Parameters.AddWithValue("@numero", funcionario.Numero);
                executaCmd.Parameters.AddWithValue("@complemento", funcionario.Complemento);
                executaCmd.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                executaCmd.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                executaCmd.Parameters.AddWithValue("@estado", funcionario.Estado);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso");
                conexao.Close();

               

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        #endregion


        #region ListarFuncionarios

        public DataTable ListarFuncionarios()
        {
            try
            {
                DataTable tabelaFuncionario = new DataTable();

                string sql = "select * from tb_funcionarios";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                executaCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

                da.Fill(tabelaFuncionario);

                conexao.Close();

                return tabelaFuncionario;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + ex.Message);
                return null;
            }
        }

        #endregion

        #region AlterarFuncionario

        public void AlterarFuncionario(Funcionario funcionario)
        {
            try
            {
                string sql = @"update tb_funcionarios set
                              nome = @nome,rg = @rg,cpf = @cpf,email= @email, senha = @senha, cargo = @cargo, nivel_acesso = @nivel_acesso, telefone = @telefone,celular = @celular,cep = @cep,
                              endereco = @endereco,numero = @numero,complemento = @complemento,bairro = @bairro,cidade = @cidade,estado = @estado where id = @id";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                executaCmd.Parameters.AddWithValue("@rg", funcionario.Rg);
                executaCmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                executaCmd.Parameters.AddWithValue("@email", funcionario.Email);
                executaCmd.Parameters.AddWithValue("@senha", funcionario.Senha);
                executaCmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                executaCmd.Parameters.AddWithValue("@nivel_acesso", funcionario.NivelAcesso);
                executaCmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                executaCmd.Parameters.AddWithValue("@celular", funcionario.Celular);
                executaCmd.Parameters.AddWithValue("@cep", funcionario.Cep);
                executaCmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                executaCmd.Parameters.AddWithValue("@numero", funcionario.Numero);
                executaCmd.Parameters.AddWithValue("@complemento", funcionario.Complemento);
                executaCmd.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                executaCmd.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                executaCmd.Parameters.AddWithValue("@estado", funcionario.Estado);
                executaCmd.Parameters.AddWithValue("@id", funcionario.Codigo);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário alterado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro.Message);
            }
        }

        #endregion

        #region Excluirfuncionario

        public void ExcluirFuncionario(Funcionario funcionario)
        {
            try
            {
                string sql = @"delete from tb_funcionarios where id = @id";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@id", funcionario.Codigo);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluído com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro.Message);
            }
        }

        #endregion

        #region BuscarFuncionarioPorNome

        public DataTable BuscarFuncionarioPorNome(string nome)
        {
            try
            {
                DataTable tabelaFuncionario = new DataTable();

                string sql = "select * from tb_funcionarios where nome = @nome ";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();

                executaCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

                da.Fill(tabelaFuncionario);

                conexao.Close();

                return tabelaFuncionario;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + ex.Message);
                return null;
            }
        }

        #endregion

        #region ListarFuncionariosPorNome

        public DataTable ListarClientesPorNome(string nome)
        {
            try
            {
                DataTable tabelaFuncionario = new DataTable();

                string sql = "select * from tb_funcionarios where nome like @nome ";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();

                executaCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

                da.Fill(tabelaFuncionario);

                conexao.Close();

                return tabelaFuncionario;

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
