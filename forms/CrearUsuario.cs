using MaterialSkin;
using MaterialSkin.Controls;
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

namespace ProyectoMarjorie.forms
{
    public partial class CrearUsuario : MaterialForm
    {
        public CrearUsuario()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string nombre = tbName.Text;  
            string cif = tbCif.Text;        
            DateTime fechaNacimiento = dtpBirthDate.Value;  
            string contrasena = tbPassword.Text;

            // Verificar si ya existe un estudiante con ese CIF
            if (DatabaseHelper.ObtenerEstudiantePorCif(cif) != null)
            {
                MessageBox.Show("Ya existe un estudiante con ese CIF.");
                return;
            }

            // Agregar el estudiante a la base de datos
            bool resultadoEstudiante = DatabaseHelper.AgregarEstudiante(nombre, cif, fechaNacimiento);

            if (resultadoEstudiante)
            {
                // Crear el usuario de sistema
                bool resultadoUsuario = DatabaseHelper.AgregarUsuario(cif, contrasena, cif);

                if (resultadoUsuario)
                {
                    MessageBox.Show("Estudiante y usuario agregado correctamente.");
                    this.Close();  // Cerrar el formulario si el estudiante y usuario fueron agregados
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el usuario.");
                }
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el estudiante.");
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            checkText();
        }

        private void tbCif_TextChanged(object sender, EventArgs e)
        {
            checkText();
        }

        private void checkText()
        {
            if (tbName.Text != "" && tbCif.Text != "")
            {
                btnAddUser.Enabled = true;
            }
            else
            {
                btnAddUser.Enabled = false;
            }
        }
    }
}
