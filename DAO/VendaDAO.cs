using ControleVendas.CONEXAO;
using ControleVendas.MODEL;
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
                executaCmd.Parameters.AddWithValue("@cliente_id", venda.ClienteId);
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

        #region RetornaIdUltimaVenda

        public int RetornaIdUltimaVenda()
        {
            try
            {
                int idVenda = 0;

                string sql = @"select max(id) id from tb_vendas";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader dr = executaCmd.ExecuteReader();

                if (dr.Read())
                {                    
                    idVenda = dr.GetInt32("id");
                }
                conexao.Close();

                return idVenda;              
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Aconteceu o erro " + ex.Message);
                conexao.Close();
                return 0;
            }
        }
        #endregion

        #region HistoricoDeVenda

        private DataTable  HistoricoDeVenda(DateTime dataInicio, DateTime dataFim )
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();

                string sql = @"select v.id as 'Código',
                            v.data_venda as 'Data da venda', 
                            c.nome as 'Cliente', 
                            v.total_venda as 'Total da venda', 
                            v.observacoes as 'Obs' 
                            from tb_vendas as v 
                            join tb_clientes as c 
                            on (v.cliente_id = c.id)
                            where v.data_venda between @dataInicio and @dataFim";

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("dataInicio", dataInicio);
                executaCmd.Parameters.AddWithValue("dataFim", dataFim);

                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);
                da.Fill(tabelaHistorico);

                return tabelaHistorico;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu o erro " + ex.Message);
                return null;
            }
        }

        #endregion

    }
}
