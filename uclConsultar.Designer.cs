namespace CRUD
{
	partial class uclConsultar
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
			this.lblConsultaCli = new System.Windows.Forms.Label();
			this.dgvDados = new System.Windows.Forms.DataGridView();
			this.cbbConsulta = new System.Windows.Forms.ComboBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.pnlBuscaNome = new System.Windows.Forms.Panel();
			this.txtBusca = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
			this.pnlBuscaNome.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblConsultaCli
			// 
			this.lblConsultaCli.AutoSize = true;
			this.lblConsultaCli.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblConsultaCli.Location = new System.Drawing.Point(180, 32);
			this.lblConsultaCli.Name = "lblConsultaCli";
			this.lblConsultaCli.Size = new System.Drawing.Size(282, 32);
			this.lblConsultaCli.TabIndex = 3;
			this.lblConsultaCli.Text = "Consulta de Clientes";
			// 
			// dgvDados
			// 
			this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDados.Location = new System.Drawing.Point(17, 165);
			this.dgvDados.Name = "dgvDados";
			this.dgvDados.RowTemplate.Height = 25;
			this.dgvDados.Size = new System.Drawing.Size(596, 231);
			this.dgvDados.TabIndex = 4;
			// 
			// cbbConsulta
			// 
			this.cbbConsulta.FormattingEnabled = true;
			this.cbbConsulta.Items.AddRange(new object[] {
            "Todos",
            "Nome",
            "Número",
            "CPF"});
			this.cbbConsulta.Location = new System.Drawing.Point(42, 109);
			this.cbbConsulta.Name = "cbbConsulta";
			this.cbbConsulta.Size = new System.Drawing.Size(121, 23);
			this.cbbConsulta.TabIndex = 5;
			this.cbbConsulta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(523, 109);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(90, 23);
			this.btnBuscar.TabIndex = 6;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// pnlBuscaNome
			// 
			this.pnlBuscaNome.Controls.Add(this.txtBusca);
			this.pnlBuscaNome.Location = new System.Drawing.Point(169, 83);
			this.pnlBuscaNome.Name = "pnlBuscaNome";
			this.pnlBuscaNome.Size = new System.Drawing.Size(348, 65);
			this.pnlBuscaNome.TabIndex = 7;
			this.pnlBuscaNome.Visible = false;
			// 
			// txtBusca
			// 
			this.txtBusca.Location = new System.Drawing.Point(16, 27);
			this.txtBusca.Name = "txtBusca";
			this.txtBusca.Size = new System.Drawing.Size(313, 23);
			this.txtBusca.TabIndex = 0;
			// 
			// uclConsultar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlBuscaNome);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.cbbConsulta);
			this.Controls.Add(this.dgvDados);
			this.Controls.Add(this.lblConsultaCli);
			this.Name = "uclConsultar";
			this.Size = new System.Drawing.Size(632, 411);
			this.Load += new System.EventHandler(this.uclConsultar_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
			this.pnlBuscaNome.ResumeLayout(false);
			this.pnlBuscaNome.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblConsultaCli;
		private DataGridView dgvDados;
		private ComboBox cbbConsulta;
		private Button btnBuscar;
		private Panel pnlBuscaNome;
		private TextBox txtBusca;
	}
}
