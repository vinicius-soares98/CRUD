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
	public partial class uclExcluirCli : UserControl
	{
		public uclExcluirCli()
		{
			InitializeComponent();
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtNome.Text)||String.IsNullOrWhiteSpace(txtCpf.Text))
			{
				MessageBox.Show("Digite o Nome e o CPF do Cliente que deseja excluir!");
			}			
			string strSql;

			strSql = $"SELECT * FROM Clientes WHERE nome LIKE '%{txtNome.Text}%' AND cpf = '{txtCpf.Text}'";
			LoginBanco loginBanco = new LoginBanco();
			loginBanco.Consultar(strSql, dgvDados);
			txtIdCli.Text = loginBanco.RetornaID(strSql).ToString();
			if (dgvDados.DataSource == null)
			{
				MessageBox.Show("Cliente não encontrado!");
			}

		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(txtIdCli.Text))
			{
				MessageBox.Show("Digite o ID do Cliente que deseja excluir!");
			}						
			DialogResult resposta;
			resposta = MessageBox.Show("Tem certeza que deseja excluir esse cliente?", "Excluir", MessageBoxButtons.YesNo);
			if (resposta == DialogResult.Yes)
			{
				string strSql;
				strSql = $"DELETE FROM Clientes WHERE id = '{txtIdCli.Text}'";
				LoginBanco loginBanco = new LoginBanco();					
				loginBanco.Deletar(strSql);
				txtNome.Text = null;
				txtCpf.Text = null;
				txtIdCli.Text = null;
				for (int i = 0; i < dgvDados.RowCount; i++)
				{
					dgvDados.Rows[i].DataGridView.Columns.Clear();
				}
			}
			txtNome.Text = null;
			txtCpf.Text = null;
			txtIdCli.Text = null;
			for (int i = 0; i < dgvDados.RowCount; i++)
			{
				dgvDados.Rows[i].DataGridView.Columns.Clear();
			}
		}
	}
}
