namespace CRUD
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pnlEsquerda = new System.Windows.Forms.Panel();
			this.btnInicio = new System.Windows.Forms.Button();
			this.pnlLado = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnInserir = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pnlCima = new System.Windows.Forms.Panel();
			this.uclInserir1 = new CRUD.uclInserir();
			this.uclInicio1 = new CRUD.uclInicio();
			this.uclConsultar1 = new CRUD.uclConsultar();
			this.uclExcluir1 = new CRUD.uclExcluirCli();
			this.uclEditar1 = new CRUD.uclEditar();
			this.uclInicio2 = new CRUD.uclInicio();
			this.pnlEsquerda.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlEsquerda
			// 
			this.pnlEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pnlEsquerda.Controls.Add(this.btnInicio);
			this.pnlEsquerda.Controls.Add(this.pnlLado);
			this.pnlEsquerda.Controls.Add(this.panel1);
			this.pnlEsquerda.Controls.Add(this.btnExcluir);
			this.pnlEsquerda.Controls.Add(this.btnConsultar);
			this.pnlEsquerda.Controls.Add(this.btnEditar);
			this.pnlEsquerda.Controls.Add(this.btnFechar);
			this.pnlEsquerda.Controls.Add(this.btnInserir);
			this.pnlEsquerda.Controls.Add(this.panel2);
			this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlEsquerda.Location = new System.Drawing.Point(0, 0);
			this.pnlEsquerda.Name = "pnlEsquerda";
			this.pnlEsquerda.Size = new System.Drawing.Size(150, 450);
			this.pnlEsquerda.TabIndex = 0;
			// 
			// btnInicio
			// 
			this.btnInicio.FlatAppearance.BorderSize = 0;
			this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnInicio.ForeColor = System.Drawing.Color.White;
			this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInicio.Location = new System.Drawing.Point(0, 166);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(150, 40);
			this.btnInicio.TabIndex = 8;
			this.btnInicio.Text = "Inicio";
			this.btnInicio.UseVisualStyleBackColor = true;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// pnlLado
			// 
			this.pnlLado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.pnlLado.Location = new System.Drawing.Point(0, 212);
			this.pnlLado.Name = "pnlLado";
			this.pnlLado.Size = new System.Drawing.Size(7, 40);
			this.pnlLado.TabIndex = 5;
			this.pnlLado.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(150, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(650, 426);
			this.panel1.TabIndex = 2;
			// 
			// btnExcluir
			// 
			this.btnExcluir.FlatAppearance.BorderSize = 0;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnExcluir.ForeColor = System.Drawing.Color.White;
			this.btnExcluir.Image = global::CRUD.Properties.Resources.Design_sem_nome__11_;
			this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcluir.Location = new System.Drawing.Point(0, 350);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(150, 40);
			this.btnExcluir.TabIndex = 7;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnConsultar
			// 
			this.btnConsultar.FlatAppearance.BorderSize = 0;
			this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnConsultar.ForeColor = System.Drawing.Color.White;
			this.btnConsultar.Image = global::CRUD.Properties.Resources.Design_sem_nome__10_;
			this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConsultar.Location = new System.Drawing.Point(0, 304);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(150, 40);
			this.btnConsultar.TabIndex = 6;
			this.btnConsultar.Text = "       Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnEditar.ForeColor = System.Drawing.Color.White;
			this.btnEditar.Image = global::CRUD.Properties.Resources.Design_sem_nome__14_;
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(0, 258);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(150, 40);
			this.btnEditar.TabIndex = 5;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.FlatAppearance.BorderSize = 0;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnFechar.ForeColor = System.Drawing.Color.White;
			this.btnFechar.Image = global::CRUD.Properties.Resources.Design_sem_nome__15_;
			this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFechar.Location = new System.Drawing.Point(0, 410);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(150, 40);
			this.btnFechar.TabIndex = 4;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnInserir
			// 
			this.btnInserir.FlatAppearance.BorderSize = 0;
			this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInserir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnInserir.ForeColor = System.Drawing.Color.White;
			this.btnInserir.Image = global::CRUD.Properties.Resources.Design_sem_nome__7_;
			this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInserir.Location = new System.Drawing.Point(0, 212);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(150, 40);
			this.btnInserir.TabIndex = 3;
			this.btnInserir.Text = "Inserir";
			this.btnInserir.UseVisualStyleBackColor = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(3, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(144, 143);
			this.panel2.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pictureBox1.Image = global::CRUD.Properties.Resources.VSsystem;
			this.pictureBox1.Location = new System.Drawing.Point(23, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 92);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pnlCima
			// 
			this.pnlCima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pnlCima.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCima.Location = new System.Drawing.Point(150, 0);
			this.pnlCima.Name = "pnlCima";
			this.pnlCima.Size = new System.Drawing.Size(650, 18);
			this.pnlCima.TabIndex = 1;
			this.pnlCima.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCima_Paint);
			// 
			// uclInserir1
			// 
			this.uclInserir1.Location = new System.Drawing.Point(156, 27);
			this.uclInserir1.Name = "uclInserir1";
			this.uclInserir1.Size = new System.Drawing.Size(632, 411);
			this.uclInserir1.TabIndex = 3;
			// 
			// uclInicio1
			// 
			this.uclInicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.uclInicio1.Location = new System.Drawing.Point(156, 27);
			this.uclInicio1.Name = "uclInicio1";
			this.uclInicio1.Size = new System.Drawing.Size(632, 411);
			this.uclInicio1.TabIndex = 4;
			// 
			// uclConsultar1
			// 
			this.uclConsultar1.Location = new System.Drawing.Point(156, 24);
			this.uclConsultar1.Name = "uclConsultar1";
			this.uclConsultar1.Size = new System.Drawing.Size(632, 411);
			this.uclConsultar1.TabIndex = 5;
			// 
			// uclExcluir1
			// 
			this.uclExcluir1.Location = new System.Drawing.Point(156, 27);
			this.uclExcluir1.Name = "uclExcluir1";
			this.uclExcluir1.Size = new System.Drawing.Size(632, 411);
			this.uclExcluir1.TabIndex = 6;
			this.uclExcluir1.Load += new System.EventHandler(this.uclExcluir1_Load);
			// 
			// uclEditar1
			// 
			this.uclEditar1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.uclEditar1.Location = new System.Drawing.Point(156, 24);
			this.uclEditar1.Name = "uclEditar1";
			this.uclEditar1.Size = new System.Drawing.Size(632, 411);
			this.uclEditar1.TabIndex = 7;
			// 
			// uclInicio2
			// 
			this.uclInicio2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.uclInicio2.Location = new System.Drawing.Point(150, 15);
			this.uclInicio2.Name = "uclInicio2";
			this.uclInicio2.Size = new System.Drawing.Size(650, 435);
			this.uclInicio2.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.uclInicio2);
			this.Controls.Add(this.uclEditar1);
			this.Controls.Add(this.uclExcluir1);
			this.Controls.Add(this.uclConsultar1);
			this.Controls.Add(this.uclInicio1);
			this.Controls.Add(this.uclInserir1);
			this.Controls.Add(this.pnlCima);
			this.Controls.Add(this.pnlEsquerda);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlEsquerda.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel pnlEsquerda;
		private Panel pnlCima;
		private Panel panel2;
		private PictureBox pictureBox1;
		private Button btnInserir;
		private Button btnFechar;
		private Button btnExcluir;
		private Button btnConsultar;
		private Button btnEditar;
		private ImageList imageList1;
		private Panel panel1;
		private uclInserir uclInserir1;
		private uclInicio uclInicio1;
		private Panel pnlLado;
		private uclConsultar uclConsultar1;
		private uclExcluirCli uclExcluir1;
		private uclEditar uclEditar1;
		private uclInicio uclInicio2;
		private Button btnInicio;
	}
}