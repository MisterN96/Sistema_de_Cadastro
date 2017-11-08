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
			this.label4 = new System.Windows.Forms.Label();
			this.rdoPerecivel = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.dtFabr = new System.Windows.Forms.DateTimePicker();
			this.dtVali = new System.Windows.Forms.DateTimePicker();
			this.rdNatural = new System.Windows.Forms.RadioButton();
			this.rdIndus = new System.Windows.Forms.RadioButton();
			this.grpTipo = new System.Windows.Forms.GroupBox();
			this.grpStatus = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.grpTipo.SuspendLayout();
			this.grpStatus.SuspendLayout();
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
			this.label2.Location = new System.Drawing.Point(279, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tipo de Produto:";
			// 
			// rdoNaoPerecivel
			// 
			this.rdoNaoPerecivel.AutoSize = true;
			this.rdoNaoPerecivel.Location = new System.Drawing.Point(78, 14);
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
			this.label3.Location = new System.Drawing.Point(279, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Data de Validade:";
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
			this.rdoPerecivel.Location = new System.Drawing.Point(5, 14);
			this.rdoPerecivel.Name = "rdoPerecivel";
			this.rdoPerecivel.Size = new System.Drawing.Size(71, 17);
			this.rdoPerecivel.TabIndex = 11;
			this.rdoPerecivel.TabStop = true;
			this.rdoPerecivel.Text = "Perecível";
			this.rdoPerecivel.UseVisualStyleBackColor = true;
			this.rdoPerecivel.CheckedChanged += new System.EventHandler(this.rdoPerecivel_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(279, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Status de Produto:";
			// 
			// dtFabr
			// 
			this.dtFabr.CustomFormat = "";
			this.dtFabr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtFabr.Location = new System.Drawing.Point(141, 82);
			this.dtFabr.Name = "dtFabr";
			this.dtFabr.Size = new System.Drawing.Size(82, 20);
			this.dtFabr.TabIndex = 16;
			// 
			// dtVali
			// 
			this.dtVali.CustomFormat = "";
			this.dtVali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtVali.Location = new System.Drawing.Point(377, 82);
			this.dtVali.Name = "dtVali";
			this.dtVali.Size = new System.Drawing.Size(82, 20);
			this.dtVali.TabIndex = 17;
			this.dtVali.Value = new System.DateTime(2017, 8, 29, 0, 0, 0, 0);
			// 
			// rdNatural
			// 
			this.rdNatural.AutoSize = true;
			this.rdNatural.Location = new System.Drawing.Point(5, 7);
			this.rdNatural.Name = "rdNatural";
			this.rdNatural.Size = new System.Drawing.Size(59, 17);
			this.rdNatural.TabIndex = 18;
			this.rdNatural.TabStop = true;
			this.rdNatural.Text = "Natural";
			this.rdNatural.UseVisualStyleBackColor = true;
			this.rdNatural.CheckedChanged += new System.EventHandler(this.rdNatural_CheckedChanged);
			// 
			// rdIndus
			// 
			this.rdIndus.AutoSize = true;
			this.rdIndus.Location = new System.Drawing.Point(68, 8);
			this.rdIndus.Name = "rdIndus";
			this.rdIndus.Size = new System.Drawing.Size(92, 17);
			this.rdIndus.TabIndex = 19;
			this.rdIndus.TabStop = true;
			this.rdIndus.Text = "Industrializado";
			this.rdIndus.UseVisualStyleBackColor = true;
			this.rdIndus.CheckedChanged += new System.EventHandler(this.rdIndus_CheckedChanged);
			// 
			// grpTipo
			// 
			this.grpTipo.Controls.Add(this.rdoPerecivel);
			this.grpTipo.Controls.Add(this.rdoNaoPerecivel);
			this.grpTipo.Location = new System.Drawing.Point(371, 29);
			this.grpTipo.Name = "grpTipo";
			this.grpTipo.Size = new System.Drawing.Size(178, 34);
			this.grpTipo.TabIndex = 20;
			this.grpTipo.TabStop = false;
			// 
			// grpStatus
			// 
			this.grpStatus.Controls.Add(this.rdNatural);
			this.grpStatus.Controls.Add(this.rdIndus);
			this.grpStatus.Location = new System.Drawing.Point(371, 114);
			this.grpStatus.Name = "grpStatus";
			this.grpStatus.Size = new System.Drawing.Size(162, 28);
			this.grpStatus.TabIndex = 21;
			this.grpStatus.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(31, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "VALOR:";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(83, 123);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(103, 20);
			this.txtValor.TabIndex = 23;
			// 
			// frmCadastroProd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 260);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.grpStatus);
			this.Controls.Add(this.grpTipo);
			this.Controls.Add(this.dtVali);
			this.Controls.Add(this.dtFabr);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.txtNomeProd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalvar);
			this.Name = "frmCadastroProd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro Produto";
			this.grpTipo.ResumeLayout(false);
			this.grpTipo.PerformLayout();
			this.grpStatus.ResumeLayout(false);
			this.grpStatus.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoPerecivel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtFabr;
		private System.Windows.Forms.DateTimePicker dtVali;
		private System.Windows.Forms.RadioButton rdNatural;
		private System.Windows.Forms.RadioButton rdIndus;
		private System.Windows.Forms.GroupBox grpTipo;
		private System.Windows.Forms.GroupBox grpStatus;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtValor;
	}
}