using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class FormEstudiante : MaterialForm
    {
        public FormEstudiante()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void FormEstudiante_Load(object sender, EventArgs e)
        {

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
            MessageBox.Show("Los cambios han sido guardado con éxito.");
            //agregar función para actualizar datos
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
            MessageBox.Show("Se ha agregado la clase al horario correctamente!");
            //agregar función para agregar clase a horario
        }
    }
}
