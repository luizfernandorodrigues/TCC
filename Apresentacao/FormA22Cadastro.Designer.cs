﻿namespace Apresentacao
{
    partial class FormA22Cadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA22Cadastro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtControles = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.toolTipA22Cadastro = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditaEstado = new System.Windows.Forms.Button();
            this.btnVisualizaEstado = new System.Windows.Forms.Button();
            this.btnExcluiEstado = new System.Windows.Forms.Button();
            this.btnNovoEstado = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Controls.Add(this.btnPesquisa);
            this.panel1.Controls.Add(this.btnanterior);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.btnPrimeiro);
            this.panel1.Controls.Add(this.btnUltimo);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 83);
            this.panel1.TabIndex = 13;
            // 
            // txtControles
            // 
            this.txtControles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtControles.Enabled = false;
            this.txtControles.Location = new System.Drawing.Point(178, 67);
            this.txtControles.Name = "txtControles";
            this.txtControles.Size = new System.Drawing.Size(302, 20);
            this.txtControles.TabIndex = 19;
            this.txtControles.Text = "Controles";
            this.txtControles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(4, 100);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(42, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(438, 20);
            this.txtNome.TabIndex = 22;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(-1, 128);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(42, 124);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(438, 20);
            this.txtCodigo.TabIndex = 24;
            // 
            // toolTipA22Cadastro
            // 
            this.toolTipA22Cadastro.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipA22Cadastro.ToolTipTitle = "Dica";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.sigla});
            this.dataGridView1.Location = new System.Drawing.Point(2, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 236);
            this.dataGridView1.TabIndex = 25;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "a23_001_c";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // sigla
            // 
            this.sigla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sigla.DataPropertyName = "siglaEstado";
            this.sigla.HeaderText = "Sigla";
            this.sigla.Name = "sigla";
            // 
            // btnEditaEstado
            // 
            this.btnEditaEstado.Enabled = false;
            this.btnEditaEstado.Image = global::Apresentacao.Properties.Resources.edit_15px;
            this.btnEditaEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditaEstado.Location = new System.Drawing.Point(83, 150);
            this.btnEditaEstado.Name = "btnEditaEstado";
            this.btnEditaEstado.Size = new System.Drawing.Size(75, 23);
            this.btnEditaEstado.TabIndex = 27;
            this.btnEditaEstado.Text = "Editar";
            this.btnEditaEstado.UseVisualStyleBackColor = true;
            // 
            // btnVisualizaEstado
            // 
            this.btnVisualizaEstado.Image = global::Apresentacao.Properties.Resources.search_15px;
            this.btnVisualizaEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizaEstado.Location = new System.Drawing.Point(164, 150);
            this.btnVisualizaEstado.Name = "btnVisualizaEstado";
            this.btnVisualizaEstado.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizaEstado.TabIndex = 28;
            this.btnVisualizaEstado.Text = "Visualizar";
            this.btnVisualizaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizaEstado.UseVisualStyleBackColor = true;
            // 
            // btnExcluiEstado
            // 
            this.btnExcluiEstado.Image = global::Apresentacao.Properties.Resources.trash_15px;
            this.btnExcluiEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluiEstado.Location = new System.Drawing.Point(245, 150);
            this.btnExcluiEstado.Name = "btnExcluiEstado";
            this.btnExcluiEstado.Size = new System.Drawing.Size(75, 23);
            this.btnExcluiEstado.TabIndex = 29;
            this.btnExcluiEstado.Text = "Excluir";
            this.btnExcluiEstado.UseVisualStyleBackColor = true;
            // 
            // btnNovoEstado
            // 
            this.btnNovoEstado.Enabled = false;
            this.btnNovoEstado.Image = global::Apresentacao.Properties.Resources.plus_15px;
            this.btnNovoEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoEstado.Location = new System.Drawing.Point(2, 150);
            this.btnNovoEstado.Name = "btnNovoEstado";
            this.btnNovoEstado.Size = new System.Drawing.Size(75, 23);
            this.btnNovoEstado.TabIndex = 26;
            this.btnNovoEstado.Text = "Novo";
            this.btnNovoEstado.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Image = global::Apresentacao.Properties.Resources.Report_Card_25px;
            this.btnRelatorio.Location = new System.Drawing.Point(3, 43);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(49, 34);
            this.btnRelatorio.TabIndex = 6;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Image = global::Apresentacao.Properties.Resources.Pesquisasearch_25px;
            this.btnPesquisa.Location = new System.Drawing.Point(3, 3);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(49, 34);
            this.btnPesquisa.TabIndex = 0;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Enabled = false;
            this.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanterior.Image = global::Apresentacao.Properties.Resources.left_round_25px;
            this.btnanterior.Location = new System.Drawing.Point(58, 43);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(49, 34);
            this.btnanterior.TabIndex = 3;
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Enabled = false;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Image = global::Apresentacao.Properties.Resources.right_round_25px;
            this.btnProximo.Location = new System.Drawing.Point(113, 43);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(49, 34);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Enabled = false;
            this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeiro.Image = global::Apresentacao.Properties.Resources.skip_to_start_25px;
            this.btnPrimeiro.Location = new System.Drawing.Point(58, 3);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(49, 34);
            this.btnPrimeiro.TabIndex = 1;
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Enabled = false;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Image = global::Apresentacao.Properties.Resources.end_25px;
            this.btnUltimo.Location = new System.Drawing.Point(113, 3);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(49, 34);
            this.btnUltimo.TabIndex = 2;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::Apresentacao.Properties.Resources.Exit_25px;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(426, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 57);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.Delete_25px;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(364, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(54, 57);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources.Save_25px;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(302, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(54, 57);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Apresentacao.Properties.Resources.Edit_25px;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(240, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 57);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::Apresentacao.Properties.Resources.Plus_25px;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(178, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(54, 57);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FormA22Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 424);
            this.Controls.Add(this.btnExcluiEstado);
            this.Controls.Add(this.btnVisualizaEstado);
            this.Controls.Add(this.btnEditaEstado);
            this.Controls.Add(this.btnNovoEstado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtControles);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormA22Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de País";
            this.Load += new System.EventHandler(this.FormA22Cadastro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnRelatorio;
        public System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.Button btnanterior;
        public System.Windows.Forms.Button btnProximo;
        public System.Windows.Forms.Button btnPrimeiro;
        public System.Windows.Forms.Button btnUltimo;
        public System.Windows.Forms.TextBox txtControles;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolTip toolTipA22Cadastro;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigla;
        private System.Windows.Forms.Button btnNovoEstado;
        private System.Windows.Forms.Button btnEditaEstado;
        private System.Windows.Forms.Button btnVisualizaEstado;
        private System.Windows.Forms.Button btnExcluiEstado;
    }
}