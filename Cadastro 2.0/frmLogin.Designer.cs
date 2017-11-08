namespace Cadastro_2._0
{
	partial class frmLogin
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.btnProximo = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Open Sans", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Location = new System.Drawing.Point(150, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "LOGIN";
			// 
			// txtLogin
			// 
			this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogin.Location = new System.Drawing.Point(150, 95);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(267, 29);
			this.txtLogin.TabIndex = 1;
			// 
			// btnProximo
			// 
			this.btnProximo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnProximo.Location = new System.Drawing.Point(150, 144);
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.Size = new System.Drawing.Size(267, 34);
			this.btnProximo.TabIndex = 2;
			this.btnProximo.Text = "Próximo";
			this.btnProximo.UseVisualStyleBackColor = false;
			this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.GrayText;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(25, 263);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(137, 39);
			this.button1.TabIndex = 3;
			this.button1.Text = "Cadastrar-se";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Cadastro_2._0.Properties.Resources._37_lindas_paisagens_da_Islandia_3;
			this.ClientSize = new System.Drawing.Size(586, 314);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnProximo);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login do Usuario";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.Button btnProximo;
		private System.Windows.Forms.Button button1;
	}
}