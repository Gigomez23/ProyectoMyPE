using MaterialSkin;
using MaterialSkin.Controls;
using ProyectoMarjorie.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMarjorie
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Admin" && tbPassword.Text == "Admin")
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.ShowDialog();
            }
            else if (tbUsername.Text == "Usuario" && tbPassword.Text == "Usuario")
            {
                FormEstudiante formEstudiante = new FormEstudiante();
                formEstudiante.ShowDialog();
            }
            else
            {
                MessageBox.Show("El Nombre do Usuario o Contraseña no es correcto");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.ShowDialog();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbUsername.Text != "")
            {
                btnLogin.Enabled = true;
            }
        }
    }
}
