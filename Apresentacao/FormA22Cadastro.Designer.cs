namespace Apresentacao
{
    partial class FormA22Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnIncluirEstado = new System.Windows.Forms.Button();
            this.btnExcluirExtado = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrimeiro
            // 
            this.toolTipFormBase.SetToolTip(this.btnPrimeiro, "Ir para o Primeiro Registro!");
            // 
            // btnUltimo
            // 
            this.toolTipFormBase.SetToolTip(this.btnUltimo, "Pular para o ultimo Registro!");
            // 
            // btnanterior
            // 
            this.toolTipFormBase.SetToolTip(this.btnanterior, "Registro Anterior!");
            // 
            // btnProximo
            // 
            this.toolTipFormBase.SetToolTip(this.btnProximo, "Próximo Registro!");
            // 
            // btnPesquisa
            // 
            this.toolTipFormBase.SetToolTip(this.btnPesquisa, "Pesquisar Registros do Banco de Dados!");
            // 
            // btnRelatorio
            // 
            this.toolTipFormBase.SetToolTip(this.btnRelatorio, "Abrir tela de Relatórios!");
            // 
            // btnNovo
            // 
            this.toolTipFormBase.SetToolTip(this.btnNovo, "Adicionar Registro!");
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.toolTipFormBase.SetToolTip(this.btnEditar, "Editar Registro da Tela!");
            // 
            // btnSalvar
            // 
            this.toolTipFormBase.SetToolTip(this.btnSalvar, "Salvar Registro da Tela!");
            // 
            // btnExcluir
            // 
            this.toolTipFormBase.SetToolTip(this.btnExcluir, "Excluir Registro da Tela");
            // 
            // btnSair
            // 
            this.toolTipFormBase.SetToolTip(this.btnSair, "Sair da Tela");
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 108);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 134);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Código:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(47, 104);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(441, 20);
            this.txtNome.TabIndex = 15;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(47, 130);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(441, 20);
            this.txtCodigo.TabIndex = 16;
            // 
            // btnIncluirEstado
            // 
            this.btnIncluirEstado.Enabled = false;
            this.btnIncluirEstado.Location = new System.Drawing.Point(12, 156);
            this.btnIncluirEstado.Name = "btnIncluirEstado";
            this.btnIncluirEstado.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirEstado.TabIndex = 17;
            this.btnIncluirEstado.Text = "Incluir";
            this.btnIncluirEstado.UseVisualStyleBackColor = true;
            // 
            // btnExcluirExtado
            // 
            this.btnExcluirExtado.Enabled = false;
            this.btnExcluirExtado.Location = new System.Drawing.Point(93, 156);
            this.btnExcluirExtado.Name = "btnExcluirExtado";
            this.btnExcluirExtado.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirExtado.TabIndex = 18;
            this.btnExcluirExtado.Text = "Excluir";
            this.btnExcluirExtado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 240);
            this.dataGridView1.TabIndex = 19;
            // 
            // FormA22Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcluirExtado);
            this.Controls.Add(this.btnIncluirEstado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNome);
            this.Name = "FormA22Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pais";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnNovo, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnIncluirEstado, 0);
            this.Controls.SetChildIndex(this.btnExcluirExtado, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnIncluirEstado;
        private System.Windows.Forms.Button btnExcluirExtado;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
