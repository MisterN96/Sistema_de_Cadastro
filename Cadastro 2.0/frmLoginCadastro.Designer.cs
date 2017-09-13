namespace Cadastro_2._0
{
    partial class frmLoginCadastro
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
            this.btnSalvarCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblValida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvarCad
            // 
            this.btnSalvarCad.Location = new System.Drawing.Point(45, 183);
            this.btnSalvarCad.Name = "btnSalvarCad";
            this.btnSalvarCad.Size = new System.Drawing.Size(89, 44);
            this.btnSalvarCad.TabIndex = 0;
            this.btnSalvarCad.Text = "Salvar";
            this.btnSalvarCad.UseVisualStyleBackColor = true;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(108, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(143, 25);
            this.txtNome.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(117, 121);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(134, 25);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(190, 183);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCpf.Location = new System.Drawing.Point(87, 81);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(164, 25);
            this.txtCpf.TabIndex = 8;
            // 
            // lblValida
            // 
            this.lblValida.AutoSize = true;
            this.lblValida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValida.Location = new System.Drawing.Point(257, 88);
            this.lblValida.Name = "lblValida";
            this.lblValida.Size = new System.Drawing.Size(0, 15);
            this.lblValida.TabIndex = 9;
            // 
            // frmLoginCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 264);
            this.Controls.Add(this.lblValida);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarCad);
            this.MaximizeBox = false;
            this.Name = "frmLoginCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblValida;
    }
}