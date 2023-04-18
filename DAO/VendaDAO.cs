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
    public class VendaDAO
    {
        private MySqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarVenda

        public void CadastrarVenda(Venda venda)
        {
            try
            {
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes) values(@cliente_id, @data_venda, @total_venda, @observacoes  )";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@id_cliente", venda.ClienteId);
                executaCmd.Parameters.AddWithValue("@data_venda", venda.DataVenda);
                executaCmd.Parameters.AddWithValue("@total_venda", venda.TotalVenda);
                executaCmd.Parameters.AddWithValue("@observacoes", venda.Observacoes);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Venda cadastrada com sucesso");

                conexao.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Aconteceu o erro: " + ex.Message);
            }
        }

        #endregion

    }
}
