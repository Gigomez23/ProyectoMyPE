using MaterialSkin;
using MaterialSkin.Controls;
using ProyectoMarjorie.forms;
using ProyectoMarjorie.models;
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
            launchUserForm();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.ShowDialog();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            checkText();
        }

        private void launchUserForm()
        {
            string cifEstudiante = tbUsername.Text;

            // Buscar el estudiante en la base de datos con el CIF ingresado
            Estudiante estudiante = DatabaseHelper.ObtenerEstudiantePorCif(cifEstudiante);

            if (tbUsername.Text == "Admin" && tbPassword.Text == "Admin")
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.ShowDialog();
            }
            else if (estudiante != null && tbPassword.Text == "Usuario")
            {
                FormEstudiante formEstudiante = new FormEstudiante(estudiante);
                formEstudiante.ShowDialog();
            }
            else
            {
                MessageBox.Show("El Nombre do Usuario o Contraseña no es correcto");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            checkText();
        }

        private void checkText()
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }
    }
}
