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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.txtExcluirProd = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 56);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(536, 240);
            this.dataGridView3.TabIndex = 0;
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Location = new System.Drawing.Point(78, 368);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProd.TabIndex = 1;
            this.btnDeleteProd.Text = "Delete";
            this.btnDeleteProd.UseVisualStyleBackColor = true;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            // 
            // txtExcluirProd
            // 
            this.txtExcluirProd.Location = new System.Drawing.Point(159, 368);
            this.txtExcluirProd.Name = "txtExcluirProd";
            this.txtExcluirProd.Size = new System.Drawing.Size(100, 20);
            this.txtExcluirProd.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(344, 368);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            
            // 
            // frmExcluirProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 462);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtExcluirProd);
            this.Controls.Add(this.btnDeleteProd);
            this.Controls.Add(this.dataGridView3);
            this.Name = "frmExcluirProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Produtos";
            this.Load += new System.EventHandler(this.frmExcluirProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnDeleteProd;
        private System.Windows.Forms.TextBox txtExcluirProd;
        private System.Windows.Forms.Button btnAtualizar;
    }
}