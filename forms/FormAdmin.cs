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
    public partial class FormAdmin : MaterialForm
    {
        public FormAdmin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void ActivateAddButton()
        {
            if (tbCifSendPet.Text != "" && tbUsername.Text != "" && cbJustDateCompletion.Checked == true)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            cbName.Checked = true;
            ActivateAddButton();
        }

        private void tbCifSendPet_TextChanged(object sender, EventArgs e)
        {
            cbCifCompletion.Checked = true;
            ActivateAddButton();
        }

        private void activateProfessorBotons()
        {
            if (tbProfessorName.Text != "" && tbProfessorEmail.Text != "")
            {
                mepAddProfessor.ValidationButtonEnable = true;
                btnAddOtherProfessor.Enabled = true;
            }
            else
            {
                mepAddProfessor.ValidationButtonEnable = false;
                btnAddOtherProfessor.Enabled = false;
            }
        }
        
        private void tbProfessorName_TextChanged(object sender, EventArgs e)
        {
            cbProfessorName.Checked = true;

            activateProfessorBotons();

            if (tbProfessorName.Text == "")
            {
                cbProfessorName.Checked = false;
            }
        }

        private void tbProfessorEmail_TextChanged(object sender, EventArgs e)
        {
            cbProfessorEmailCompletion.Checked = true;

            activateProfessorBotons();

            if (tbProfessorEmail.Text == "")
            {
                cbProfessorEmailCompletion.Checked = false;
            }
        }

        private void dtpStudenBirthDate_ValueChanged(object sender, EventArgs e)
        {
            cbJustDateCompletion.Checked = true;
            ActivateAddButton();
        }

        //Funcion para activar el botón para mandar la justificación
        private void checkCompletion()
        {
            if (cbJustDateCompletion.Checked == true && cbCifCompletion.Checked == true && cbProfessorName.Checked == true && cbProfessorEmailCompletion.Checked == true && cbName.Checked == true)
            {
                mepSendJustNotice.ValidationButtonEnable = true;
            }
        }

        private void cbName_CheckedChanged(object sender, EventArgs e)
        {
            checkCompletion();
        }

        private void cbCifCompletion_CheckedChanged(object sender, EventArgs e)
        {
            checkCompletion();
        }

        private void cbProfessorName_CheckedChanged(object sender, EventArgs e)
        {
            checkCompletion();
        }

        private void cbProfessorEmailCompletion_CheckedChanged(object sender, EventArgs e)
        {
            checkCompletion();
        }

        private void cbJustDateCompletion_CheckedChanged(object sender, EventArgs e)
        {
            checkCompletion();
        }

        private void mepAddProfessor_CancelClick(object sender, EventArgs e)
        {
            tbProfessorName.Text = "";
            tbProfessorEmail.Text = "";
            
        }

        private void mepAddProfessor_SaveClick(object sender, EventArgs e)
        {
            //Agregar función para agregar profesor al string de correo
        }

        private void btnAddOtherProfessor_Click(object sender, EventArgs e)
        {
            tbProfessorName.Text = "";
            tbProfessorEmail.Text = "";
        }

        private void mepJustDetails_CancelClick(object sender, EventArgs e)
        {
            mepJustDetails.Collapse = true;
            mepRejectedPet.Collapse = false;
        }

        private void mepRejectedPet_CancelClick(object sender, EventArgs e)
        {
            mepJustDetails.Collapse = false;
            mepRejectedPet.Collapse = true;
        }
    }
}
