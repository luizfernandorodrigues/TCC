namespace Apresentacao
{
    partial class FormPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisa));
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNomePesquisa = new System.Windows.Forms.ComboBox();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.lblNomePesquisa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AllowUserToDeleteRows = false;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.codigo});
            this.dataGridViewDados.Location = new System.Drawing.Point(12, 96);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.Size = new System.Drawing.Size(603, 362);
            this.dataGridViewDados.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "a22_001_c";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo.DataPropertyName = "a22_002_c";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Carregar Filtrados";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::Apresentacao.Properties.Resources.Search_25px;
            this.btnPesquisa.Location = new System.Drawing.Point(333, 12);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 29);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxNomePesquisa);
            this.groupBox1.Controls.Add(this.txtNomePesquisa);
            this.groupBox1.Controls.Add(this.lblNomePesquisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // comboBoxNomePesquisa
            // 
            this.comboBoxNomePesquisa.FormattingEnabled = true;
            this.comboBoxNomePesquisa.Location = new System.Drawing.Point(44, 12);
            this.comboBoxNomePesquisa.Name = "comboBoxNomePesquisa";
            this.comboBoxNomePesquisa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNomePesquisa.TabIndex = 2;
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomePesquisa.Location = new System.Drawing.Point(173, 12);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(132, 20);
            this.txtNomePesquisa.TabIndex = 1;
            // 
            // lblNomePesquisa
            // 
            this.lblNomePesquisa.AutoSize = true;
            this.lblNomePesquisa.Location = new System.Drawing.Point(6, 16);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(38, 13);
            this.lblNomePesquisa.TabIndex = 0;
            this.lblNomePesquisa.Text = "Nome:";
            // 
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa País";
            this.Load += new System.EventHandler(this.FormPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxNomePesquisa;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
    }
}