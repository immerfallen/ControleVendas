﻿
namespace ControleVendas.VIEW
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabelaCliente = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 136);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabPage1);
            this.tabClientes.Controls.Add(this.tabPage2);
            this.tabClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClientes.Location = new System.Drawing.Point(0, 142);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(902, 358);
            this.tabClientes.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbUf);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtCidade);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtComplemento);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtNumero);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtCep);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtCelular);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtTelefone);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtCpf);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtRg);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbUf
            // 
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cbUf.Location = new System.Drawing.Point(353, 244);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(121, 24);
            this.cbUf.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(318, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(73, 246);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(221, 22);
            this.txtCidade.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(12, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(411, 208);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(221, 22);
            this.txtBairro.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(358, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(109, 208);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(221, 22);
            this.txtComplemento.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(8, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(577, 171);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(503, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Número:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(260, 171);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(221, 22);
            this.txtEndereco.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(184, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Endereço:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(83, 171);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(82, 22);
            this.txtCep.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(9, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "CEP:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(429, 137);
            this.txtCelular.Mask = "(99) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(163, 22);
            this.txtCelular.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(356, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Celular:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(82, 137);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(163, 22);
            this.txtTelefone.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(8, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefone:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(427, 98);
            this.txtCpf.Mask = "###.###.###.##";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(163, 22);
            this.txtCpf.TabIndex = 9;
            this.txtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(356, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(427, 63);
            this.txtRg.Mask = "##.###.###-##";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(163, 22);
            this.txtRg.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(356, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 22);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(82, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabelaCliente);
            this.tabPage2.Controls.Add(this.btnPesquisar);
            this.tabPage2.Controls.Add(this.txtPesquisa);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabelaCliente
            // 
            this.tabelaCliente.AllowUserToAddRows = false;
            this.tabelaCliente.AllowUserToDeleteRows = false;
            this.tabelaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCliente.Location = new System.Drawing.Point(8, 69);
            this.tabelaCliente.Name = "tabelaCliente";
            this.tabelaCliente.ReadOnly = true;
            this.tabelaCliente.Size = new System.Drawing.Size(878, 254);
            this.tabelaCliente.TabIndex = 33;
            this.tabelaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaCliente_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPesquisar.Location = new System.Drawing.Point(339, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 33);
            this.btnPesquisar.TabIndex = 32;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(82, 24);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(221, 22);
            this.txtPesquisa.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(9, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome:";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNovo.Location = new System.Drawing.Point(194, 537);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 47);
            this.btnNovo.TabIndex = 28;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAlterar.Location = new System.Drawing.Point(654, 537);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 47);
            this.btnAlterar.TabIndex = 29;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Location = new System.Drawing.Point(500, 537);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 47);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.Location = new System.Drawing.Point(343, 537);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 47);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 612);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tabClientes);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView tabelaCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label16;
    }
}