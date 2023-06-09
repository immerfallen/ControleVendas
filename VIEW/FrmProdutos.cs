﻿using ControleVendas.DAO;
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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO fornecedorDao = new FornecedorDAO();
            ProdutoDAO produtoDAO = new ProdutoDAO();

            cbForne.DataSource = fornecedorDao.ListarFornecedores();
            cbForne.DisplayMember = "nome";
            cbForne.ValueMember = "id";

            tabelaProduto.DataSource = produtoDAO.ListarProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto()
            {
                Descricao = txtDescricao.Text,
                Preco = decimal.Parse(txtPreco.Text),
                QuantidadeEstoque = int.Parse(txtEstoque.Text),
                FornecedorId = (int)cbForne.SelectedValue
            };

            ProdutoDAO dao = new ProdutoDAO();

            dao.CadastrarProduto(produto);

            new Helpers().LimparTela(this);

            tabelaProduto.DataSource = dao.ListarProdutos();



        }

        private void tabelaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaProduto.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = tabelaProduto.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = tabelaProduto.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = tabelaProduto.CurrentRow.Cells[3].Value.ToString();
            cbForne.Text = tabelaProduto.CurrentRow.Cells[4].Value.ToString();

            tabProdutos.SelectedTab = tabPage1;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao = txtDescricao.Text;
            produto.Preco = decimal.Parse(txtPreco.Text);
            produto.QuantidadeEstoque = int.Parse(txtEstoque.Text);
            produto.FornecedorId = int.Parse(cbForne.Text);
            

            ProdutoDAO dao = new ProdutoDAO();
            dao.AlterarProduto(produto);

            new Helpers().LimparTela(this);

            tabelaProduto.DataSource = dao.ListarProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Id = int.Parse(txtCodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.ExcluirProduto(produto);

            new Helpers().LimparTela(this);

            tabelaProduto.DataSource = dao.ListarProdutos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProduto.DataSource = dao.BuscarProdutosPorNome(nome);

            if (tabelaProduto.Rows.Count == 0)
            {
                tabelaProduto.DataSource = dao.ListarProdutos();
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutoDAO dao = new ProdutoDAO();
            tabelaProduto.DataSource = dao.ListarProdutoPorNome(nome);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
    }
}
