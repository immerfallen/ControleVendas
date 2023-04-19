using ControleVendas.CONEXAO;
using ControleVendas.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ControleVendas.DAO
{
    public class ItemVendaDAO
    {
        #region Conexão com o banco de dados
        private MySqlConnection conexao;

        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #endregion

        #region CadastrarItemVenda

        public void CadastrarItemVenda(ItemVenda itemVenda)
        {
            try
            {
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal) values(@venda_id, @produto_id, @qtd, @subtotal  )";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@venda_id", itemVenda.VendaId);
                executaCmd.Parameters.AddWithValue("@produto_id", itemVenda.ProdutoId);
                executaCmd.Parameters.AddWithValue("@qtd", itemVenda.Quantidade);
                executaCmd.Parameters.AddWithValue("@subtotal", itemVenda.SubTotal);

                conexao.Open();
                executaCmd.ExecuteNonQuery();               

                conexao.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu o erro " + ex.Message);
            }
        }

        #endregion
    }
}
