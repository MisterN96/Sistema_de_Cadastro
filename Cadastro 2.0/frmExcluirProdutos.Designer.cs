namespace Cadastro_2._0
{
    partial class frmExcluirProdutos
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
			this.btnDeleteProd = new System.Windows.Forms.Button();
			this.txtExcluirProd = new System.Windows.Forms.TextBox();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.chkSelecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.btnDecrescente = new System.Windows.Forms.Button();
			this.btnCrescente = new System.Windows.Forms.Button();
			this.btnFiltar = new System.Windows.Forms.Button();
			this.txtPalavra = new System.Windows.Forms.TextBox();
			this.cbxFiltros = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDeleteProd
			// 
			this.btnDeleteProd.Location = new System.Drawing.Point(27, 322);
			this.btnDeleteProd.Name = "btnDeleteProd";
			this.btnDeleteProd.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteProd.TabIndex = 1;
			this.btnDeleteProd.Text = "Delete";
			this.btnDeleteProd.UseVisualStyleBackColor = true;
			this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
			// 
			// txtExcluirProd
			// 
			this.txtExcluirProd.Location = new System.Drawing.Point(108, 324);
			this.txtExcluirProd.Name = "txtExcluirProd";
			this.txtExcluirProd.Size = new System.Drawing.Size(100, 20);
			this.txtExcluirProd.TabIndex = 2;
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.Location = new System.Drawing.Point(267, 321);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
			this.btnAtualizar.TabIndex = 3;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(396, 321);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 4;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.AllowUserToDeleteRows = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelecionar});
			this.dataGridView3.Location = new System.Drawing.Point(12, 68);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.RowHeadersVisible = false;
			this.dataGridView3.Size = new System.Drawing.Size(522, 221);
			this.dataGridView3.TabIndex = 5;
			// 
			// chkSelecionar
			// 
			this.chkSelecionar.HeaderText = "Selecionar";
			this.chkSelecionar.Name = "chkSelecionar";
			// 
			// btnDecrescente
			// 
			this.btnDecrescente.Location = new System.Drawing.Point(459, 39);
			this.btnDecrescente.Name = "btnDecrescente";
			this.btnDecrescente.Size = new System.Drawing.Size(75, 23);
			this.btnDecrescente.TabIndex = 6;
			this.btnDecrescente.Text = "Z - A";
			this.btnDecrescente.UseVisualStyleBackColor = true;
			this.btnDecrescente.Click += new System.EventHandler(this.btnDecrescente_Click);
			// 
			// btnCrescente
			// 
			this.btnCrescente.Location = new System.Drawing.Point(378, 38);
			this.btnCrescente.Name = "btnCrescente";
			this.btnCrescente.Size = new System.Drawing.Size(75, 23);
			this.btnCrescente.TabIndex = 7;
			this.btnCrescente.Text = "A -Z";
			this.btnCrescente.UseVisualStyleBackColor = true;
			this.btnCrescente.Click += new System.EventHandler(this.btnCrescente_Click);
			// 
			// btnFiltar
			// 
			this.btnFiltar.Location = new System.Drawing.Point(245, 41);
			this.btnFiltar.Name = "btnFiltar";
			this.btnFiltar.Size = new System.Drawing.Size(75, 23);
			this.btnFiltar.TabIndex = 8;
			this.btnFiltar.Text = "Filtar";
			this.btnFiltar.UseVisualStyleBackColor = true;
			this.btnFiltar.Click += new System.EventHandler(this.btnFiltar_Click);
			// 
			// txtPalavra
			// 
			this.txtPalavra.Location = new System.Drawing.Point(12, 41);
			this.txtPalavra.Name = "txtPalavra";
			this.txtPalavra.Size = new System.Drawing.Size(100, 20);
			this.txtPalavra.TabIndex = 9;
			// 
			// cbxFiltros
			// 
			this.cbxFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxFiltros.FormattingEnabled = true;
			this.cbxFiltros.Items.AddRange(new object[] {
            "Nome",
            "Validade",
            "Fabricacao",
            "Tipo",
            "Status"});
			this.cbxFiltros.Location = new System.Drawing.Point(118, 41);
			this.cbxFiltros.Name = "cbxFiltros";
			this.cbxFiltros.Size = new System.Drawing.Size(121, 21);
			this.cbxFiltros.TabIndex = 10;
			// 
			// frmExcluirProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 462);
			this.Controls.Add(this.cbxFiltros);
			this.Controls.Add(this.txtPalavra);
			this.Controls.Add(this.btnFiltar);
			this.Controls.Add(this.btnCrescente);
			this.Controls.Add(this.btnDecrescente);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.txtExcluirProd);
			this.Controls.Add(this.btnDeleteProd);
			this.Name = "frmExcluirProdutos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Excluir Produtos";
			this.Load += new System.EventHandler(this.frmExcluirProdutos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteProd;
        private System.Windows.Forms.TextBox txtExcluirProd;
        private System.Windows.Forms.Button btnAtualizar;
		private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelecionar;
		private System.Windows.Forms.Button btnDecrescente;
		private System.Windows.Forms.Button btnCrescente;
		private System.Windows.Forms.Button btnFiltar;
		private System.Windows.Forms.TextBox txtPalavra;
		private System.Windows.Forms.ComboBox cbxFiltros;
	}
}