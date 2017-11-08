namespace Cadastro_2._0
{
	partial class frmInserirDinheiro
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
			this.label2 = new System.Windows.Forms.Label();
			this.senhaValida = new System.Windows.Forms.TextBox();
			this.dinheiroInserir = new System.Windows.Forms.MaskedTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quanto em dinheiro?";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "SENHA:";
			// 
			// senhaValida
			// 
			this.senhaValida.Location = new System.Drawing.Point(90, 100);
			this.senhaValida.Name = "senhaValida";
			this.senhaValida.Size = new System.Drawing.Size(149, 20);
			this.senhaValida.TabIndex = 3;
			this.senhaValida.UseSystemPasswordChar = true;
			// 
			// dinheiroInserir
			// 
			this.dinheiroInserir.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dinheiroInserir.Location = new System.Drawing.Point(209, 38);
			this.dinheiroInserir.Name = "dinheiroInserir";
			this.dinheiroInserir.Size = new System.Drawing.Size(76, 24);
			this.dinheiroInserir.TabIndex = 4;
			this.dinheiroInserir.ValidatingType = typeof(int);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(313, 150);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Confirmar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmInserirDinheiro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 199);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dinheiroInserir);
			this.Controls.Add(this.senhaValida);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmInserirDinheiro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Inserir Dinheiro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox senhaValida;
		private System.Windows.Forms.MaskedTextBox dinheiroInserir;
		private System.Windows.Forms.Button button1;
	}
}