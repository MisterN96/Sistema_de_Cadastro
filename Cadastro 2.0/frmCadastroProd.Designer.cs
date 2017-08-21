namespace Cadastro_2._0
{
    partial class frmCadastroProd
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoNaoPerecivel = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValidade = new System.Windows.Forms.MaskedTextBox();
            this.txtFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoPerecivel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(144, 162);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 50);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Prod:";
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(100, 43);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(158, 20);
            this.txtNomeProd.TabIndex = 2;
            this.txtNomeProd.TextChanged += new System.EventHandler(this.txtNomeProd_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(337, 162);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 50);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Produto:";
            // 
            // rdoNaoPerecivel
            // 
            this.rdoNaoPerecivel.AutoSize = true;
            this.rdoNaoPerecivel.Location = new System.Drawing.Point(457, 46);
            this.rdoNaoPerecivel.Name = "rdoNaoPerecivel";
            this.rdoNaoPerecivel.Size = new System.Drawing.Size(94, 17);
            this.rdoNaoPerecivel.TabIndex = 6;
            this.rdoNaoPerecivel.TabStop = true;
            this.rdoNaoPerecivel.Text = "Não Perecível";
            this.rdoNaoPerecivel.UseVisualStyleBackColor = true;
            this.rdoNaoPerecivel.CheckedChanged += new System.EventHandler(this.rdoNaoPerecivel_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de Validade:";
            // 
            // txtValidade
            // 
            this.txtValidade.Location = new System.Drawing.Point(380, 81);
            this.txtValidade.Mask = "00/00/0000";
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(100, 20);
            this.txtValidade.TabIndex = 8;
            this.txtValidade.ValidatingType = typeof(System.DateTime);
            // 
            // txtFabricacao
            // 
            this.txtFabricacao.Location = new System.Drawing.Point(141, 85);
            this.txtFabricacao.Mask = "00/00/0000";
            this.txtFabricacao.Name = "txtFabricacao";
            this.txtFabricacao.Size = new System.Drawing.Size(100, 20);
            this.txtFabricacao.TabIndex = 10;
            this.txtFabricacao.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data de Fabricação:";
            // 
            // rdoPerecivel
            // 
            this.rdoPerecivel.AutoSize = true;
            this.rdoPerecivel.Location = new System.Drawing.Point(380, 46);
            this.rdoPerecivel.Name = "rdoPerecivel";
            this.rdoPerecivel.Size = new System.Drawing.Size(71, 17);
            this.rdoPerecivel.TabIndex = 11;
            this.rdoPerecivel.TabStop = true;
            this.rdoPerecivel.Text = "Perecível";
            this.rdoPerecivel.UseVisualStyleBackColor = true;
            this.rdoPerecivel.CheckedChanged += new System.EventHandler(this.rdoPerecivel_CheckedChanged);
            // 
            // frmCadastroProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 260);
            this.Controls.Add(this.rdoPerecivel);
            this.Controls.Add(this.txtFabricacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdoNaoPerecivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmCadastroProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Produto";
            this.Load += new System.EventHandler(this.frmCadastroProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.RadioButton perecivel;
        private System.Windows.Forms.RadioButton rdoNaoPerecivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtValidade;
        private System.Windows.Forms.MaskedTextBox txtFabricacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoPerecivel;
    }
}