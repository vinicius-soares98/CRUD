using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
	public partial class uclEditar : UserControl
	{
		public uclEditar()
		{
			InitializeComponent();
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtCpf.Text))
			{
				MessageBox.Show("Digite o CPF do Cliente que deseja editar os dados!");
			}
			string strSql;

			strSql = $"SELECT * FROM Clientes WHERE cpf ='{txtCpf.Text}'";
			LoginBanco loginBanco = new LoginBanco();
			loginBanco.Consultar(strSql, dgvDados);
			if (dgvDados.DataSource == null)
			{
				MessageBox.Show("Cliente não encontrado!");
			}
			txtIdCli.Text = (loginBanco.RetornaID(strSql).ToString());
		}

		private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void btnEditarDados_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtCpf.Text) || String.IsNullOrWhiteSpace(txtNome.Text) || String.IsNullOrWhiteSpace(txtCpf.Text))
			{
				MessageBox.Show("Digite as informações do cliente que deseja editar os dados!");
			}
			string strSql;

			strSql = $"UPDATE Clientes SET nome = '{txtNome.Text}', numero = '{txtNumero.Text}' WHERE cpf = '{txtCpf.Text}' AND id = '{txtIdCli.Text}'";
			LoginBanco loginBanco = new LoginBanco();
			loginBanco.Editar(strSql);
			txtCpf.Text = null;
			txtNome.Text = null;
			txtNumero.Text = null;
			txtIdCli.Text = null;
			for (int i = 0; i < dgvDados.RowCount; i++)
			{
				dgvDados.Rows[i].DataGridView.Columns.Clear();
			}
		}
	}
}
