namespace ProyectoMarjorie.forms
{
    partial class FormEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudiante));
            this.mtcMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.SubirPet = new System.Windows.Forms.TabPage();
            this.EditDatPer = new System.Windows.Forms.TabPage();
            this.imagenesMenu = new System.Windows.Forms.ImageList(this.components);
            this.editHorDeClas = new System.Windows.Forms.TabPage();
            this.mtcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtcMenu
            // 
            this.mtcMenu.Controls.Add(this.SubirPet);
            this.mtcMenu.Controls.Add(this.EditDatPer);
            this.mtcMenu.Controls.Add(this.editHorDeClas);
            this.mtcMenu.Depth = 0;
            this.mtcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcMenu.ImageList = this.imagenesMenu;
            this.mtcMenu.Location = new System.Drawing.Point(3, 64);
            this.mtcMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtcMenu.Multiline = true;
            this.mtcMenu.Name = "mtcMenu";
            this.mtcMenu.SelectedIndex = 0;
            this.mtcMenu.Size = new System.Drawing.Size(794, 383);
            this.mtcMenu.TabIndex = 0;
            // 
            // SubirPet
            // 
            this.SubirPet.ImageKey = "SubirArchivo.png";
            this.SubirPet.Location = new System.Drawing.Point(4, 39);
            this.SubirPet.Name = "SubirPet";
            this.SubirPet.Padding = new System.Windows.Forms.Padding(3);
            this.SubirPet.Size = new System.Drawing.Size(786, 340);
            this.SubirPet.TabIndex = 0;
            this.SubirPet.Text = "Subir Petición";
            this.SubirPet.ToolTipText = "Subir petición de justificación por razones medicas para faltas de clase.";
            this.SubirPet.UseVisualStyleBackColor = true;
            // 
            // EditDatPer
            // 
            this.EditDatPer.ImageKey = "EditarUsuario.png";
            this.EditDatPer.Location = new System.Drawing.Point(4, 39);
            this.EditDatPer.Name = "EditDatPer";
            this.EditDatPer.Padding = new System.Windows.Forms.Padding(3);
            this.EditDatPer.Size = new System.Drawing.Size(786, 340);
            this.EditDatPer.TabIndex = 1;
            this.EditDatPer.Text = "Editar Datos Personales";
            this.EditDatPer.ToolTipText = "Editar Datos Personales del Usuario";
            this.EditDatPer.UseVisualStyleBackColor = true;
            // 
            // imagenesMenu
            // 
            this.imagenesMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagenesMenu.ImageStream")));
            this.imagenesMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imagenesMenu.Images.SetKeyName(0, "Aprobar.png");
            this.imagenesMenu.Images.SetKeyName(1, "EditarUsuario.png");
            this.imagenesMenu.Images.SetKeyName(2, "SubirArchivo.png");
            this.imagenesMenu.Images.SetKeyName(3, "Documento.png");
            this.imagenesMenu.Images.SetKeyName(4, "Usuario.png");
            // 
            // editHorDeClas
            // 
            this.editHorDeClas.ImageKey = "Documento.png";
            this.editHorDeClas.Location = new System.Drawing.Point(4, 39);
            this.editHorDeClas.Name = "editHorDeClas";
            this.editHorDeClas.Size = new System.Drawing.Size(786, 340);
            this.editHorDeClas.TabIndex = 2;
            this.editHorDeClas.Text = "Editar Horario de Clases";
            this.editHorDeClas.ToolTipText = "Editar el horario de clase. ";
            this.editHorDeClas.UseVisualStyleBackColor = true;
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtcMenu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mtcMenu;
            this.Name = "FormEstudiante";
            this.Text = "FormEstudiante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEstudiante_Load);
            this.mtcMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mtcMenu;
        private System.Windows.Forms.TabPage SubirPet;
        private System.Windows.Forms.TabPage EditDatPer;
        private System.Windows.Forms.ImageList imagenesMenu;
        private System.Windows.Forms.TabPage editHorDeClas;
    }
}