namespace Cadastro_2._0
{
	partial class frmSenha
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
			this.btnProximo = new System.Windows.Forms.Button();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxSenha = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenha)).BeginInit();
			this.SuspendLayout();
			// 
			// btnProximo
			// 
			this.btnProximo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnProximo.Location = new System.Drawing.Point(170, 208);
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.Size = new System.Drawing.Size(267, 34);
			this.btnProximo.TabIndex = 5;
			this.btnProximo.Text = "Entrar";
			this.btnProximo.UseVisualStyleBackColor = false;
			this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(170, 173);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(267, 29);
			this.txtSenha.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Open Sans", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(73, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 33);
			this.label1.TabIndex = 3;
			this.label1.Text = "SENHA";
			// 
			// pictureBoxSenha
			// 
			this.pictureBoxSenha.Image = global::Cadastro_2._0.Properties.Resources.user_icon_2098873_960_720;
			this.pictureBoxSenha.Location = new System.Drawing.Point(243, 24);
			this.pictureBoxSenha.Name = "pictureBoxSenha";
			this.pictureBoxSenha.Size = new System.Drawing.Size(121, 133);
			this.pictureBoxSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxSenha.TabIndex = 6;
			this.pictureBoxSenha.TabStop = false;
			// 
			// frmSenha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Cadastro_2._0.Properties.Resources.alpes_suicos_paisagens_lindas_da_natureza;
			this.ClientSize = new System.Drawing.Size(586, 314);
			this.Controls.Add(this.pictureBoxSenha);
			this.Controls.Add(this.btnProximo);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmSenha";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Senha do Usuario";
			this.Load += new System.EventHandler(this.frmSenha_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenha)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnProximo;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBoxSenha;
	}
}