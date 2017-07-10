namespace Apresentacao
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStripBarra = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.toolTipFormBase = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.statusStripBarra.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 83);
            this.panel1.TabIndex = 5;
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
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(186, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Controles";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStripBarra
            // 
            this.statusStripBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripBarra.Location = new System.Drawing.Point(0, 420);
            this.statusStripBarra.Name = "statusStripBarra";
            this.statusStripBarra.Size = new System.Drawing.Size(802, 22);
            this.statusStripBarra.TabIndex = 12;
            this.statusStripBarra.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::Apresentacao.Properties.Resources.Exit_25px;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(434, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 57);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.Delete_25px;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(372, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(54, 57);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources.Save_25px;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(310, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(54, 57);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Apresentacao.Properties.Resources.Edit_25px;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(248, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 57);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::Apresentacao.Properties.Resources.Plus_25px;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(186, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(54, 57);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(802, 442);
            this.Controls.Add(this.statusStripBarra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.Text = "FormBase";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.panel1.ResumeLayout(false);
            this.statusStripBarra.ResumeLayout(false);
            this.statusStripBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnPrimeiro;
        public System.Windows.Forms.Button btnUltimo;
        public System.Windows.Forms.Button btnanterior;
        public System.Windows.Forms.Button btnProximo;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.Button btnRelatorio;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.StatusStrip statusStripBarra;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolTip toolTipFormBase;
    }
}