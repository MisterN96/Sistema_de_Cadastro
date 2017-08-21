namespace Cadastro_2._0
{
    partial class frmExcluir_EditarClientes
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
            this.btnCarregarLista = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnFiltar = new System.Windows.Forms.Button();
            this.txtFiltar = new System.Windows.Forms.TextBox();
            this.btncrescente = new System.Windows.Forms.Button();
            this.btndecrescente = new System.Windows.Forms.Button();
            this.cbxFiltos = new System.Windows.Forms.ComboBox();
            this.btnDeletChek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarregarLista
            // 
            this.btnCarregarLista.Location = new System.Drawing.Point(30, 462);
            this.btnCarregarLista.Name = "btnCarregarLista";
            this.btnCarregarLista.Size = new System.Drawing.Size(112, 54);
            this.btnCarregarLista.TabIndex = 1;
            this.btnCarregarLista.Text = "CARREGAR DADOS";
            this.btnCarregarLista.UseVisualStyleBackColor = true;
            this.btnCarregarLista.Click += new System.EventHandler(this.btnCarregarLista_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(645, 489);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(88, 30);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(551, 489);
            this.txtDelete.Multiline = true;
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(88, 30);
            this.txtDelete.TabIndex = 3;
       
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkBox});
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(721, 373);
            this.dataGridView1.TabIndex = 5;
            // 
            // chkBox
            // 
            this.chkBox.HeaderText = "Selecionar";
            this.chkBox.Name = "chkBox";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(175, 463);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 53);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR DADOS";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnFiltar
            // 
            this.btnFiltar.Location = new System.Drawing.Point(282, 46);
            this.btnFiltar.Name = "btnFiltar";
            this.btnFiltar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltar.TabIndex = 7;
            this.btnFiltar.Text = "Filtrar";
            this.btnFiltar.UseVisualStyleBackColor = true;
            this.btnFiltar.Click += new System.EventHandler(this.btnFiltar_Click);
            // 
            // txtFiltar
            // 
            this.txtFiltar.Location = new System.Drawing.Point(12, 48);
            this.txtFiltar.Name = "txtFiltar";
            this.txtFiltar.Size = new System.Drawing.Size(130, 20);
            this.txtFiltar.TabIndex = 8;
            // 
            // btncrescente
            // 
            this.btncrescente.Location = new System.Drawing.Point(518, 46);
            this.btncrescente.Name = "btncrescente";
            this.btncrescente.Size = new System.Drawing.Size(75, 23);
            this.btncrescente.TabIndex = 9;
            this.btncrescente.Text = "De A - Z";
            this.btncrescente.UseVisualStyleBackColor = true;
            this.btncrescente.Click += new System.EventHandler(this.btncrescente_Click);
            // 
            // btndecrescente
            // 
            this.btndecrescente.Location = new System.Drawing.Point(599, 45);
            this.btndecrescente.Name = "btndecrescente";
            this.btndecrescente.Size = new System.Drawing.Size(75, 23);
            this.btndecrescente.TabIndex = 10;
            this.btndecrescente.Text = "De Z - A";
            this.btndecrescente.UseVisualStyleBackColor = true;
            this.btndecrescente.Click += new System.EventHandler(this.btndecrescente_Click);
            // 
            // cbxFiltos
            // 
            this.cbxFiltos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltos.FormattingEnabled = true;
            this.cbxFiltos.Items.AddRange(new object[] {
            "Nome",
            "Telefone",
            "CPF",
            "RG",
            "Sexo",
            "Cidade",
            "Numero",
            "Cep"});
            this.cbxFiltos.Location = new System.Drawing.Point(155, 48);
            this.cbxFiltos.Name = "cbxFiltos";
            this.cbxFiltos.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltos.TabIndex = 11;
            // 
            // btnDeletChek
            // 
            this.btnDeletChek.Location = new System.Drawing.Point(293, 463);
            this.btnDeletChek.Name = "btnDeletChek";
            this.btnDeletChek.Size = new System.Drawing.Size(93, 53);
            this.btnDeletChek.TabIndex = 12;
            this.btnDeletChek.Text = "DELETAR COM CHECK BOX";
            this.btnDeletChek.UseVisualStyleBackColor = true;
            this.btnDeletChek.Click += new System.EventHandler(this.btnDeletChek_Click);
            // 
            // frmExcluir_EditarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 541);
            this.Controls.Add(this.btnDeletChek);
            this.Controls.Add(this.cbxFiltos);
            this.Controls.Add(this.btndecrescente);
            this.Controls.Add(this.btncrescente);
            this.Controls.Add(this.txtFiltar);
            this.Controls.Add(this.btnFiltar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCarregarLista);
            this.Name = "frmExcluir_EditarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exclusão Clientes";
            this.Load += new System.EventHandler(this.frmExclusaoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCarregarLista;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBox;
        private System.Windows.Forms.Button btnFiltar;
        private System.Windows.Forms.TextBox txtFiltar;
        private System.Windows.Forms.Button btncrescente;
        private System.Windows.Forms.Button btndecrescente;
        private System.Windows.Forms.ComboBox cbxFiltos;
        private System.Windows.Forms.Button btnDeletChek;
    }
}