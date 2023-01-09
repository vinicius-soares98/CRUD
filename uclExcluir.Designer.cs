namespace CRUD
{
	partial class uclExcluirCli
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
			this.lblExclusaoCli = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.lblCpf = new System.Windows.Forms.Label();
			this.dgvDados = new System.Windows.Forms.DataGridView();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.lblIdCli = new System.Windows.Forms.Label();
			this.txtIdCli = new System.Windows.Forms.TextBox();
			this.btnExcluir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
			this.SuspendLayout();
			// 
			// lblExclusaoCli
			// 
			this.lblExclusaoCli.AutoSize = true;
			this.lblExclusaoCli.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblExclusaoCli.Location = new System.Drawing.Point(182, 32);
			this.lblExclusaoCli.Name = "lblExclusaoCli";
			this.lblExclusaoCli.Size = new System.Drawing.Size(283, 32);
			this.lblExclusaoCli.TabIndex = 3;
			this.lblExclusaoCli.Text = "Exclusão de Clientes";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(171, 97);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(329, 23);
			this.txtNome.TabIndex = 5;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNome.Location = new System.Drawing.Point(94, 99);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(56, 21);
			this.lblNome.TabIndex = 4;
			this.lblNome.Text = "Nome:";
			// 
			// txtCpf
			// 
			this.txtCpf.Location = new System.Drawing.Point(171, 144);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(329, 23);
			this.txtCpf.TabIndex = 8;
			// 
			// lblCpf
			// 
			this.lblCpf.AutoSize = true;
			this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCpf.Location = new System.Drawing.Point(94, 146);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(40, 21);
			this.lblCpf.TabIndex = 7;
			this.lblCpf.Text = "CPF:";
			// 
			// dgvDados
			// 
			this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDados.Location = new System.Drawing.Point(17, 223);
			this.dgvDados.Name = "dgvDados";
			this.dgvDados.RowTemplate.Height = 25;
			this.dgvDados.Size = new System.Drawing.Size(596, 56);
			this.dgvDados.TabIndex = 9;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(286, 173);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 10;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// lblIdCli
			// 
			this.lblIdCli.AutoSize = true;
			this.lblIdCli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblIdCli.Location = new System.Drawing.Point(234, 314);
			this.lblIdCli.Name = "lblIdCli";
			this.lblIdCli.Size = new System.Drawing.Size(102, 21);
			this.lblIdCli.TabIndex = 11;
			this.lblIdCli.Text = "ID do Cliente:";
			// 
			// txtIdCli
			// 
			this.txtIdCli.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.txtIdCli.BackColor = System.Drawing.Color.White;
			this.txtIdCli.Enabled = false;
			this.txtIdCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.txtIdCli.Location = new System.Drawing.Point(342, 312);
			this.txtIdCli.Name = "txtIdCli";
			this.txtIdCli.Size = new System.Drawing.Size(63, 29);
			this.txtIdCli.TabIndex = 12;
			this.txtIdCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.Red;
			this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExcluir.Location = new System.Drawing.Point(0, 367);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(632, 44);
			this.btnExcluir.TabIndex = 13;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// uclExcluirCli
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.txtIdCli);
			this.Controls.Add(this.lblIdCli);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.dgvDados);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblExclusaoCli);
			this.Name = "uclExcluirCli";
			this.Size = new System.Drawing.Size(632, 411);
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblExclusaoCli;
		private TextBox txtNome;
		private Label lblNome;
		private TextBox txtCpf;
		private Label lblCpf;
		private DataGridView dgvDados;
		private Button btnPesquisar;
		private Label lblIdCli;
		private TextBox txtIdCli;
		private Button btnExcluir;
	}
}
