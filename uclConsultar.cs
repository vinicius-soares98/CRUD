using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CRUD
{
	public partial class uclConsultar : UserControl
	{
		SqlDataAdapter da;
		public uclConsultar()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbConsulta.Text == "Nome")
			{
				pnlBuscaNome.Visible = true;
				txtBusca.Text = null;
				for (int i = 0; i < dgvDados.RowCount; i++)
				{
					dgvDados.Rows[i].DataGridView.Columns.Clear();
				}
			}
			if (cbbConsulta.Text == "Número")
			{
				txtBusca.Text = null;
				pnlBuscaNome.Visible = true;
				for (int i = 0; i < dgvDados.RowCount; i++)
				{
					dgvDados.Rows[i].DataGridView.Columns.Clear();
				}
			}
			if (cbbConsulta.Text == "CPF")
			{
				txtBusca.Text = null;
				pnlBuscaNome.Visible = true;
				for (int i = 0; i < dgvDados.RowCount; i++)
				{
					dgvDados.Rows[i].DataGridView.Columns.Clear();
				}
			}
			if(cbbConsulta.Text == "Todos")
			{
				pnlBuscaNome.Visible = false;
				for (int i = 0; i < dgvDados.RowCount; i++)
				{
					dgvDados.Rows[i].DataGridView.Columns.Clear();
				}
			}
		}

		private void uclConsultar_Load(object sender, EventArgs e)
		{
			
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			string strSql, path = @"Server=localhost\\SQLEXPRESS;Database=GestãoDeClientes;Trusted_Connection=True;";
			if (cbbConsulta.Text == "Nome")
			{
				if(string.IsNullOrWhiteSpace(txtBusca.Text))
				{
					for (int i = 0; i < dgvDados.RowCount; i++)
					{
						dgvDados.Rows[i].DataGridView.Columns.Clear();
					}
				}
				else
				{
					strSql = $"SELECT * FROM Clientes WHERE nome LIKE '%{txtBusca.Text}%'";
					LoginBanco loginBanco = new LoginBanco();
					loginBanco.Consultar(strSql, dgvDados);
				}				
			}
			if (cbbConsulta.Text == "Número")
			{
				strSql = $"SELECT * FROM Clientes WHERE numero = '{txtBusca.Text}'";
				LoginBanco loginBanco = new LoginBanco();
				loginBanco.Consultar(strSql, dgvDados);
			}
			if (cbbConsulta.Text == "CPF")
			{
				strSql = $"SELECT * FROM Clientes WHERE cpf = '{txtBusca.Text}'";
				LoginBanco loginBanco = new LoginBanco();
				loginBanco.Consultar(strSql, dgvDados);
			}
			if (cbbConsulta.Text == "Todos")
			{
				strSql = $"SELECT * FROM Clientes";
				LoginBanco loginBanco = new LoginBanco();
				loginBanco.Consultar(strSql, dgvDados);
			}
		}
	}
}
