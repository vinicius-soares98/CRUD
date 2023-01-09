namespace CRUD
{
	partial class uclInserir
	{
		/// <summary> 
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Designer de Componentes

		/// <summary> 
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNome = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblCadastroCli = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblNumero = new System.Windows.Forms.Label();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.lblCpf = new System.Windows.Forms.Label();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.lblStatusCpf = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNome.Location = new System.Drawing.Point(94, 146);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(56, 21);
			this.lblNome.TabIndex = 0;
			this.lblNome.Text = "Nome:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(171, 148);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(329, 23);
			this.txtNome.TabIndex = 1;
			this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
			// 
			// lblCadastroCli
			// 
			this.lblCadastroCli.AutoSize = true;
			this.lblCadastroCli.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCadastroCli.Location = new System.Drawing.Point(180, 32);
			this.lblCadastroCli.Name = "lblCadastroCli";
			this.lblCadastroCli.Size = new System.Drawing.Size(289, 32);
			this.lblCadastroCli.TabIndex = 2;
			this.lblCadastroCli.Text = "Cadastro de Clientes";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(171, 206);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(329, 23);
			this.txtNumero.TabIndex = 4;
			this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
			this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNumero.Location = new System.Drawing.Point(94, 208);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(71, 21);
			this.lblNumero.TabIndex = 3;
			this.lblNumero.Text = "Numero:";
			// 
			// txtCpf
			// 
			this.txtCpf.Location = new System.Drawing.Point(171, 264);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(329, 23);
			this.txtCpf.TabIndex = 6;
			this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
			// 
			// lblCpf
			// 
			this.lblCpf.AutoSize = true;
			this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCpf.Location = new System.Drawing.Point(94, 262);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(40, 21);
			this.lblCpf.TabIndex = 5;
			this.lblCpf.Text = "CPF:";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnCadastrar.FlatAppearance.BorderSize = 0;
			this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCadastrar.Location = new System.Drawing.Point(0, 367);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(632, 44);
			this.btnCadastrar.TabIndex = 7;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// lblStatusCpf
			// 
			this.lblStatusCpf.AutoSize = true;
			this.lblStatusCpf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblStatusCpf.ForeColor = System.Drawing.Color.Red;
			this.lblStatusCpf.Location = new System.Drawing.Point(180, 290);
			this.lblStatusCpf.Name = "lblStatusCpf";
			this.lblStatusCpf.Size = new System.Drawing.Size(0, 17);
			this.lblStatusCpf.TabIndex = 8;
			this.lblStatusCpf.Visible = false;
			// 
			// uclInserir
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblStatusCpf);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.lblCadastroCli);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblNome);
			this.Name = "uclInserir";
			this.Size = new System.Drawing.Size(632, 411);
			this.Load += new System.EventHandler(this.uclInserir_Load_1);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblNome;
		private TextBox txtNome;
		private Label lblCadastroCli;
		private TextBox txtNumero;
		private Label lblNumero;
		private TextBox txtCpf;
		private Label lblCpf;
		private Button btnCadastrar;
		private Label lblStatusCpf;
	}
}
