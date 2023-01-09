using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CRUD
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			uclInicio2.Visible= true;
			uclEditar1.Visible = false;
			uclInicio1.Visible= false;
			uclInserir1.Visible= false;
			uclConsultar1.Visible= false;
			uclExcluir1.Visible= false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void btnInserir_Click(object sender, EventArgs e)
		{
			uclInserir1.Visible = true;
			pnlLado.Height = btnInserir.Height;
			pnlLado.Top = btnInserir.Top;
			uclEditar1.Visible = false;
			pnlLado.Visible= true;
			uclExcluir1.Visible= false;
			uclInicio1.Visible= false;
			uclConsultar1.Visible = false;
			uclInicio2.Visible= false;

			
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{			
			pnlLado.Height = btnConsultar.Height;
			pnlLado.Top = btnConsultar.Top;
			uclEditar1.Visible = false;
			uclExcluir1.Visible = false;
			uclInserir1.Visible = false;
			uclInicio1.Visible = false;
			uclInicio2.Visible = false;
			uclConsultar1.Visible= true;
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			pnlLado.Height = btnConsultar.Height;
			pnlLado.Top = btnEditar.Top;
			uclExcluir1.Visible = false;
			uclInserir1.Visible = false;
			uclConsultar1.Visible= false;
			uclInicio1.Visible = false;
			uclInicio2.Visible = false;
			uclEditar1.Visible= true;
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			pnlLado.Height = btnConsultar.Height;
			pnlLado.Top = btnExcluir.Top;
			uclEditar1.Visible = false;
			uclInserir1.Visible = false;
			uclConsultar1.Visible = false;
			uclInicio1.Visible = false;
			uclInicio2.Visible = false;
			uclExcluir1.Visible = true;
		}

		private void uclExcluir1_Load(object sender, EventArgs e)
		{

		}

		private void pnlCima_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnInicio_Click(object sender, EventArgs e)
		{
			pnlLado.Height = btnInicio.Height;
			pnlLado.Top = btnInicio.Top;
			pnlLado.Visible = true;
			uclInicio2.Visible = true;
			uclEditar1.Visible = false;
			uclInicio1.Visible = false;
			uclInserir1.Visible = false;
			uclConsultar1.Visible = false;
			uclExcluir1.Visible = false;
		}
	}
}