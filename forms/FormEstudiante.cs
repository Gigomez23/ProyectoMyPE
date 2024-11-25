using MaterialSkin;
using MaterialSkin.Controls;
using ProyectoMarjorie.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoMarjorie.database;

namespace ProyectoMarjorie.forms
{
    public partial class FormEstudiante : MaterialForm
    {
        private Estudiante _estudiante;

        public FormEstudiante(Estudiante estudiante)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // Asignar el estudiante recibido al campo _estudiante
            _estudiante = estudiante;

            // Obtener las clases del estudiante desde la base de datos
            var clases = DatabaseHelper.ObtenerClasesDeEstudiante(_estudiante.Cif);

            // Verificar si las columnas ya están configuradas
            if (dgvClasses.Columns.Count == 0)
            {
                dgvClasses.Columns.Add("NombreClase", "Nombre de la Clase");
                dgvClasses.Columns.Add("NombreProfesor", "Nombre del Profesor");
                dgvClasses.Columns.Add("CorreoProfesor", "Correo del Profesor");
            }

            // Mostrar las clases en un control como DataGridView o ListBox
            foreach (var clase in clases)
            {
                dgvClasses.Rows.Add(clase.Nombre, clase.NombreProfesor, clase.CorreoProfesor);
            }

            //Cargar clases en mclbClassesList
            CargarClasesEnCheckedListBox(); 
        }

        private void FormEstudiante_Load(object sender, EventArgs e)
        {
            tbName.Text = _estudiante.Nombre;
            tbCif.Text = _estudiante.Cif.ToString();
            dtpBirthDate.Value = _estudiante.FechaNacimiento; // Deberia de mostrar fecha de nacimiento de estudiante
        }

        private void ActivateButtonUpdate()
        {
            if (tbName.Text != "" && tbCif.Text != "")
            {
                btnSaveChanges.Enabled = true;
            }
        }

        private void dtpJustClass_ValueChanged(object sender, EventArgs e)
        {
            cbClass.Checked = true;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            ActivateButtonUpdate();
        }

        private void tbCif_TextChanged(object sender, EventArgs e)
        {
            ActivateButtonUpdate();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            ActivateButtonUpdate();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Asegurarse de que el CIF es un número válido
            int cif;
            if (int.TryParse(tbCif.Text, out cif)) // Intenta convertir el texto en tbCif a un número entero
            {
                // Actualizar el objeto estudiante con los nuevos valores
                _estudiante.Nombre = tbName.Text;  // Asumiendo que tbName es el TextBox para el nombre
                _estudiante.Cif = cif;             // Ahora que cif es un número entero
                _estudiante.FechaNacimiento = dtpBirthDate.Value;  // Asumiendo que dtpBirthDate es el DateTimePicker para la fecha de nacimiento

                // Llamar a una función en DatabaseHelper para actualizar los datos en la base de datos
                bool resultado = DatabaseHelper.ActualizarEstudiante(_estudiante);

                if (resultado)
                {
                    MessageBox.Show("Los cambios han sido guardados con éxito.");
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar los cambios.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un CIF válido.");
            }
        }

        private void ActivateAddClassBtn()
        {
            if (tbAddClassName.Text != "" && tbAddProfessorEmail.Text != "" && tbAddProfessorName.Text != "")
            {
                mepAddClassSchedule.ValidationButtonEnable = true;
            }
        }
        private void tbAddClassName_TextChanged(object sender, EventArgs e)
        {
            ActivateAddClassBtn();
        }

        private void tbAddProfessorName_TextChanged(object sender, EventArgs e)
        {
            ActivateAddClassBtn();
        }

        private void tbAddProfessorEmail_TextChanged(object sender, EventArgs e)
        {
            ActivateAddClassBtn();
        }

        private void mepAddClassSchedule_SaveClick(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string nombreClase = tbAddClassName.Text;  // Nombre de la clase
            string nombreProfesor = tbAddProfessorName.Text;  // Nombre del profesor
            string correoProfesor = tbAddProfessorEmail.Text;  // Correo del profesor


            if (string.IsNullOrEmpty(nombreClase) || string.IsNullOrEmpty(nombreProfesor) || string.IsNullOrEmpty(correoProfesor))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar la clase.");
                return;
            }

            // Agregar la clase a la base de datos
            bool claseAgregada = DatabaseHelper.AgregarClaseAEstudiante(nombreClase, nombreProfesor, correoProfesor);

            if (claseAgregada)
            {
                // Agregar la clase al estudiante usando solo el nombre de la clase
                bool claseAsignada = DatabaseHelper.AsignarClaseAEstudiante(_estudiante.Cif, nombreClase);

                if (claseAsignada)
                {
                    MessageBox.Show("La clase ha sido agregada correctamente al estudiante.");
                }
                else
                {
                    MessageBox.Show("Hubo un error al asignar la clase al estudiante.");
                }

                ActualizarClasesEnDataGridView();
                CargarClasesEnCheckedListBox();
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar la clase.");
            }

        }

        //Función para cargar el material list box al igual que actualizar
        private void CargarClasesEnCheckedListBox()
        {
            // Obtener las clases del estudiante desde la base de datos
            var clases = DatabaseHelper.ObtenerClasesDeEstudiante(_estudiante.Cif);

            // Limpiar los elementos existentes en el CheckedListBox
            mclbClassesList.Items.Clear();

            // Añadir los nombres de las clases al MaterialCheckedListBox
            foreach (var clase in clases)
            {
                mclbClassesList.Items.Add(clase.Nombre, false); // 'false' indica que no están seleccionadas por defecto
            }
        }

        //Funcion para actualizar el data grid view (dgvClasses. 
        private void ActualizarClasesEnDataGridView()
        {
            // Obtener las clases actualizadas
            var clases = DatabaseHelper.ObtenerClasesDeEstudiante(_estudiante.Cif);

            // Limpiar el DataGridView
            dgvClasses.Rows.Clear();

            // Agregar las clases al DataGridView
            foreach (var clase in clases)
            {
                dgvClasses.Rows.Add(clase.Nombre, clase.NombreProfesor, clase.CorreoProfesor);
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            // Obtener la clase seleccionada en el DataGridView
            if (dgvClasses.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dgvClasses.SelectedRows[0];
                string nombreClase = filaSeleccionada.Cells["NombreClase"].Value.ToString(); // Suponiendo que la columna "Nombre" existe

                // Llamar a la función para eliminar la clase del estudiante
                DatabaseHelper.EliminarClaseDeEstudiante(_estudiante.Cif, nombreClase);

                // Actualizar la lista de clases en el DataGridView
                ActualizarClasesEnDataGridView();
                CargarClasesEnCheckedListBox();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una clase para eliminar.");
            }
        }
    }
}
