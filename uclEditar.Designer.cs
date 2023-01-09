namespace CRUD
{
	partial class uclEditar
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
			this.btnEditarDados = new System.Windows.Forms.Button();
			this.txtIdCli = new System.Windows.Forms.TextBox();
			this.lblIdCli = new System.Windows.Forms.Label();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.dgvDados = new System.Windows.Forms.DataGridView();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.lblEdicaoDados = new System.Windows.Forms.Label();
			this.lblCpf = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblNumero = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEditarDados
			// 
			this.btnEditarDados.BackColor = System.Drawing.Color.Yellow;
			this.btnEditarDados.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnEditarDados.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnEditarDados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnEditarDados.Location = new System.Drawing.Point(0, 367);
			this.btnEditarDados.Name = "btnEditarDados";
			this.btnEditarDados.Size = new System.Drawing.Size(632, 44);
			this.btnEditarDados.TabIndex = 21;
			this.btnEditarDados.Text = "Atualizar";
			this.btnEditarDados.UseVisualStyleBackColor = false;
			this.btnEditarDados.Click += new System.EventHandler(this.btnEditarDados_Click);
			// 
			// txtIdCli
			// 
			this.txtIdCli.BackColor = System.Drawing.Color.White;
			this.txtIdCli.Enabled = false;
			this.txtIdCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.txtIdCli.Location = new System.Drawing.Point(342, 237);
			this.txtIdCli.Name = "txtIdCli";
			this.txtIdCli.ReadOnly = true;
			this.txtIdCli.Size = new System.Drawing.Size(63, 29);
			this.txtIdCli.TabIndex = 20;
			this.txtIdCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblIdCli
			// 
			this.lblIdCli.AutoSize = true;
			this.lblIdCli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblIdCli.Location = new System.Drawing.Point(234, 240);
			this.lblIdCli.Name = "lblIdCli";
			this.lblIdCli.Size = new System.Drawing.Size(102, 21);
			this.lblIdCli.TabIndex = 19;
			this.lblIdCli.Text = "ID do Cliente:";
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(298, 116);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 18;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// dgvDados
			// 
			this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDados.Location = new System.Drawing.Point(18, 160);
			this.dgvDados.Name = "dgvDados";
			this.dgvDados.RowTemplate.Height = 25;
			this.dgvDados.Size = new System.Drawing.Size(596, 56);
			this.dgvDados.TabIndex = 17;
			// 
			// txtCpf
			// 
			this.txtCpf.Location = new System.Drawing.Point(171, 87);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(329, 23);
			this.txtCpf.TabIndex = 15;
			this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
			// 
			// lblEdicaoDados
			// 
			this.lblEdicaoDados.AutoSize = true;
			this.lblEdicaoDados.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblEdicaoDados.Location = new System.Drawing.Point(211, 32);
			this.lblEdicaoDados.Name = "lblEdicaoDados";
			this.lblEdicaoDados.Size = new System.Drawing.Size(239, 32);
			this.lblEdicaoDados.TabIndex = 14;
			this.lblEdicaoDados.Text = "Edição de Dados";
			// 
			// lblCpf
			// 
			this.lblCpf.AutoSize = true;
			this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCpf.Location = new System.Drawing.Point(94, 89);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(40, 21);
			this.lblCpf.TabIndex = 22;
			this.lblCpf.Text = "CPF:";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(171, 324);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(329, 23);
			this.txtNumero.TabIndex = 26;
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNumero.Location = new System.Drawing.Point(94, 326);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(71, 21);
			this.lblNumero.TabIndex = 25;
			this.lblNumero.Text = "Numero:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(171, 286);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(329, 23);
			this.txtNome.TabIndex = 24;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNome.Location = new System.Drawing.Point(94, 288);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(56, 21);
			this.lblNome.TabIndex = 23;
			this.lblNome.Text = "Nome:";
			// 
			// uclEditar
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.btnEditarDados);
			this.Controls.Add(this.txtIdCli);
			this.Controls.Add(this.lblIdCli);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.dgvDados);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.lblEdicaoDados);
			this.Name = "uclEditar";
			this.Size = new System.Drawing.Size(632, 411);
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnEditarDados;
		private TextBox txtIdCli;
		private Label lblIdCli;
		private Button btnPesquisar;
		private DataGridView dgvDados;
		private TextBox txtCpf;
		private Label lblEdicaoDados;
		private Label lblCpf;
		private TextBox txtNumero;
		private Label lblNumero;
		private TextBox txtNome;
		private Label lblNome;
	}
}
