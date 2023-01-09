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

namespace CRUD
{
	public partial class uclInserir : UserControl
	{
		public uclInserir()
		{
			InitializeComponent();
		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			string strSql;

			if(String.IsNullOrWhiteSpace(txtNome.Text) || String.IsNullOrWhiteSpace(txtNumero.Text) || String.IsNullOrWhiteSpace(txtCpf.Text))
			{
				MessageBox.Show("Preencha os campos em branco!","ERRO");
			}
			else
			{
				ValidacaoCPF validacaoCPF = new ValidacaoCPF();
				if(validacaoCPF.ValidaCpf(txtCpf.Text) == false)
				{
					lblStatusCpf.Text = "CPF Inválido!";
					lblStatusCpf.Visible = true;
				}
				else
				{
					LoginBanco loginBanco = new LoginBanco();

					if (loginBanco.VerificaCPF(txtCpf.Text) == false)
					{
						strSql = $"INSERT INTO Clientes (nome, numero, cpf) Values('{txtNome.Text}', '{txtNumero.Text}','{txtCpf.Text}')";

						loginBanco.Inserir(strSql);
						txtNome.Text = null;
						txtNumero.Text = null;
						txtCpf.Text = null;
					}
					else
					{
						lblStatusCpf.Visible = true;
						lblStatusCpf.Text = "O CPF informado ja possui cadastro em nosso banco";
						txtCpf.Text = null;
						txtCpf.Focus();
					}
				}			
			}			
		}

		private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void txtNumero_TextChanged(object sender, EventArgs e)
		{

		}

		private void uclInserir_Load(object sender, EventArgs e)
		{
			lblStatusCpf.Text = null;
		}

		private void uclInserir_Load_1(object sender, EventArgs e)
		{

		}
	}
}
