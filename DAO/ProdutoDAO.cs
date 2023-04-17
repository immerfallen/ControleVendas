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
    public class ProdutoDAO
    {
        private MySqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarProduto
        public void CadastrarProduto(Produto produto)
        {
            try
            {
                string sql = @"insert into tb_produtos 
                              (descricao,preco,qtd_estoque,for_id) 
                              values (@descricao,@preco,@qtd_estoque,@for_id)";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                executaCmd.Parameters.AddWithValue("@preco", produto.Preco);
                executaCmd.Parameters.AddWithValue("@qtd_estoque", produto.QuantidadeEstoque);
                executaCmd.Parameters.AddWithValue("@for_id", produto.FornecedorId);


                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso");
                conexao.Close();

                new Helpers().LimparTela(FrmProdutos.ActiveForm);

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro.Message);
            }

        }
        #endregion

        #region ListarProdutos

        public DataTable ListarProdutos()
        {
            try
            {
                DataTable tabelaProduto = new DataTable();

                string sql = @"select p.id as 'Código', 
                               p.descricao as 'Descrição', 
                               p.preco as 'Preço', 
                               p.qtd_estoque as 'Qtd Estoque', 
                               f.nome as 'Fornecedor'  
                               from tb_produtos as p join tb_fornecedores as f 
                               on (p.for_id = f.id);";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                executaCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

                da.Fill(tabelaProduto);

                conexao.Close();

                return tabelaProduto;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + ex.Message);
                return null;
            }
        }

        #endregion

        #region AlterarProduto

        public void AlterarProduto(Produto produto)
        {
            try
            {
                string sql = @"update tb_produtos set
                              descricao = @descricao,preco = @preco,qtd_estoque = @qtd_estoque,for_id= @for_id where id = @id";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                executaCmd.Parameters.AddWithValue("@preco", produto.Preco);
                executaCmd.Parameters.AddWithValue("@qtd_estoque", produto.QuantidadeEstoque);
                executaCmd.Parameters.AddWithValue("@for_id", produto.FornecedorId);


                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro.Message);
            }
        }

        #endregion

        #region ExcluirProduto

        public void ExcluirProduto(Produto produto)
        {
            try
            {
                string sql = @"delete from tb_produtos where id = @id";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@id", produto.Id);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluído com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro.Message);
            }
        }

        #endregion

        #region BuscarProdutoPorNome

        public DataTable ListarProdutoPorNome(string descricao)
        {
            try
            {
                DataTable tabelaProduto = new DataTable();

                string sql = @"select p.id as 'Código', 
                               p.descricao as 'Descrição', 
                               p.preco as 'Preço', 
                               p.qtd_estoque as 'Qtd Estoque', 
                               f.nome as 'Fornecedor'  
                               from tb_produtos as p join tb_fornecedores as f 
                               on (p.for_id = f.id) where p.descricao like @descricao;";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@descricao", descricao);

                conexao.Open();

                executaCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

                da.Fill(tabelaProduto);

                conexao.Close();

                return tabelaProduto;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + ex.Message);
                return null;
            }
        }

        #endregion

        #region ListarProdutosPorNome

        public DataTable BuscarProdutosPorNome(string descricao)
        {
            try
            {
                DataTable tabelaProduto = new DataTable();

                string sql = @"select p.id as 'Código', 
                               p.descricao as 'Descrição', 
                               p.preco as 'Preço', 
                               p.qtd_estoque as 'Qtd Estoque', 
                               f.nome as 'Fornecedor'  
                               from tb_produtos as p join tb_fornecedores as f 
                               on (p.for_id = f.id) where descricao = @descricao;";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@descricao", descricao);

                conexao.Open();

                executaCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

                da.Fill(tabelaProduto);

                conexao.Close();

                return tabelaProduto;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + ex.Message);
                return null;
            }
        }

        #endregion

        #region BuscarProdutoPorId

        public Produto BuscarProdutoPorId(int id)
        {
            try
            {
                var sql = "select * from tb_produtos where id = @id";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@id", id);
                conexao.Open();

                MySqlDataReader dr = executaCmd.ExecuteReader();

                if (dr.Read())
                {
                    Produto produto = new Produto();
                    produto.Id = dr.GetInt32("id");
                    produto.Descricao = dr.GetString("descricao");
                    produto.Preco = dr.GetDecimal("preco");
                    return produto;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado com esse id");
                    return null;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Aconteceu o erro " + ex);
                return null;
            }
           

            

        }

        #endregion


    }
}
