using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinheirinhoDream
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txt_senha_TextChanged(object sender, EventArgs e)
		{
		}

		private void txt_usuario_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_Entrar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txt_usuario.Text.Equals("rapunzel") && txt_senha.Text.Equals("123"))
				{
					var Home = new home();
					Home.Show();
				}
				else
				{
					MessageBox.Show("Desculpe",
									"Usuario ou senha inválidos",
									MessageBoxButtons.OK,
									MessageBoxIcon.Error);
					txt_usuario.Focus();
					txt_senha.Text = "";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Desculpe",
								ex.Message,
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}
		}

		private void btn_Cancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
