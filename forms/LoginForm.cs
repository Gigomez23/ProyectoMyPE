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
            string nombreUsuario = tbUsername.Text;
            string contrasena = tbPassword.Text;

            // Si el usuario es "Admin" y la contraseña es "Admin", ir al formulario de administración
            if (nombreUsuario == "Admin" && contrasena == "Admin")
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.ShowDialog();
                return;
            }

            // Autenticar al usuario en la base de datos
            Usuario usuario = DatabaseHelper.AutenticarUsuario(nombreUsuario, contrasena);

            if (usuario != null)
            {
                // Si la autenticación es exitosa, abrir el formulario de estudiante con los datos del estudiante asociado
                FormEstudiante formEstudiante = new FormEstudiante(usuario.Estudiante);
                formEstudiante.ShowDialog();
            }
            else
            {
                // Mostrar un mensaje de error si la autenticación falla
                MessageBox.Show("El Nombre de Usuario o Contraseña no es correcto");
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
