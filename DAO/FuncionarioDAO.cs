using ControleVendas.CONEXAO;
using ControleVendas.MODEL;
using ControleVendas.VIEW;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
