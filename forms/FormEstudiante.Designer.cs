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
            this.editHorDeClas = new System.Windows.Forms.TabPage();
            this.imagenesMenu = new System.Windows.Forms.ImageList(this.components);
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.mepChecklistJustification = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.mepAddClass = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.dtpJustClass = new System.Windows.Forms.DateTimePicker();
            this.cbClasses = new MaterialSkin.Controls.MaterialComboBox();
            this.lblSelectClass = new MaterialSkin.Controls.MaterialLabel();
            this.chkFecha = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkClass = new MaterialSkin.Controls.MaterialCheckbox();
            this.lvClassesSelected = new MaterialSkin.Controls.MaterialListView();
            this.mtcMenu.SuspendLayout();
            this.SubirPet.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.mepChecklistJustification.SuspendLayout();
            this.mepAddClass.SuspendLayout();
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
            this.mtcMenu.Size = new System.Drawing.Size(1491, 753);
            this.mtcMenu.TabIndex = 0;
            // 
            // SubirPet
            // 
            this.SubirPet.Controls.Add(this.materialCard1);
            this.SubirPet.ImageKey = "SubirArchivo.png";
            this.SubirPet.Location = new System.Drawing.Point(4, 39);
            this.SubirPet.Name = "SubirPet";
            this.SubirPet.Padding = new System.Windows.Forms.Padding(3);
            this.SubirPet.Size = new System.Drawing.Size(1483, 710);
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
            this.EditDatPer.Size = new System.Drawing.Size(1483, 710);
            this.EditDatPer.TabIndex = 1;
            this.EditDatPer.Text = "Editar Datos Personales";
            this.EditDatPer.ToolTipText = "Editar Datos Personales del Usuario";
            this.EditDatPer.UseVisualStyleBackColor = true;
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
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lvClassesSelected);
            this.materialCard1.Controls.Add(this.dtpJustClass);
            this.materialCard1.Controls.Add(this.mepAddClass);
            this.materialCard1.Controls.Add(this.lblDate);
            this.materialCard1.Controls.Add(this.mepChecklistJustification);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1477, 704);
            this.materialCard1.TabIndex = 0;
            // 
            // mepChecklistJustification
            // 
            this.mepChecklistJustification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepChecklistJustification.CancelButtonText = "CANCELar";
            this.mepChecklistJustification.Controls.Add(this.chkClass);
            this.mepChecklistJustification.Controls.Add(this.chkFecha);
            this.mepChecklistJustification.Depth = 0;
            this.mepChecklistJustification.Description = "Lista de campos a llenar";
            this.mepChecklistJustification.Dock = System.Windows.Forms.DockStyle.Right;
            this.mepChecklistJustification.ExpandHeight = 676;
            this.mepChecklistJustification.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepChecklistJustification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepChecklistJustification.Location = new System.Drawing.Point(1005, 14);
            this.mepChecklistJustification.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.mepChecklistJustification.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepChecklistJustification.Name = "mepChecklistJustification";
            this.mepChecklistJustification.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepChecklistJustification.Size = new System.Drawing.Size(458, 676);
            this.mepChecklistJustification.TabIndex = 0;
            this.mepChecklistJustification.Title = "Campos Llenados";
            this.mepChecklistJustification.ValidationButtonText = "ENVIAR";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate.Location = new System.Drawing.Point(38, 120);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 19);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Ingrese la Fecha:";
            // 
            // mepAddClass
            // 
            this.mepAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepAddClass.CancelButtonText = "CANCELar";
            this.mepAddClass.Controls.Add(this.lblSelectClass);
            this.mepAddClass.Controls.Add(this.cbClasses);
            this.mepAddClass.Depth = 0;
            this.mepAddClass.Description = "Agregar una clase para mandar justificación";
            this.mepAddClass.Dock = System.Windows.Forms.DockStyle.Right;
            this.mepAddClass.ExpandHeight = 676;
            this.mepAddClass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepAddClass.Location = new System.Drawing.Point(565, 14);
            this.mepAddClass.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.mepAddClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepAddClass.Name = "mepAddClass";
            this.mepAddClass.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepAddClass.Size = new System.Drawing.Size(440, 676);
            this.mepAddClass.TabIndex = 3;
            this.mepAddClass.Title = "Agregar Clase";
            this.mepAddClass.ValidationButtonText = "Agregar";
            // 
            // dtpJustClass
            // 
            this.dtpJustClass.Location = new System.Drawing.Point(219, 119);
            this.dtpJustClass.Name = "dtpJustClass";
            this.dtpJustClass.Size = new System.Drawing.Size(200, 20);
            this.dtpJustClass.TabIndex = 4;
            // 
            // cbClasses
            // 
            this.cbClasses.AutoResize = false;
            this.cbClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbClasses.Depth = 0;
            this.cbClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbClasses.DropDownHeight = 174;
            this.cbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasses.DropDownWidth = 121;
            this.cbClasses.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Hint = "Clases";
            this.cbClasses.IntegralHeight = false;
            this.cbClasses.ItemHeight = 43;
            this.cbClasses.Location = new System.Drawing.Point(27, 159);
            this.cbClasses.MaxDropDownItems = 4;
            this.cbClasses.MouseState = MaterialSkin.MouseState.OUT;
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(348, 49);
            this.cbClasses.StartIndex = 0;
            this.cbClasses.TabIndex = 2;
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Depth = 0;
            this.lblSelectClass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelectClass.Location = new System.Drawing.Point(28, 105);
            this.lblSelectClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(153, 19);
            this.lblSelectClass.TabIndex = 3;
            this.lblSelectClass.Text = "Seleccione una clase:";
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Depth = 0;
            this.chkFecha.Location = new System.Drawing.Point(28, 105);
            this.chkFecha.Margin = new System.Windows.Forms.Padding(0);
            this.chkFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.ReadOnly = false;
            this.chkFecha.Ripple = true;
            this.chkFecha.Size = new System.Drawing.Size(164, 37);
            this.chkFecha.TabIndex = 2;
            this.chkFecha.Text = "Seleccionar Fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            // 
            // chkClass
            // 
            this.chkClass.AutoSize = true;
            this.chkClass.Depth = 0;
            this.chkClass.Location = new System.Drawing.Point(28, 171);
            this.chkClass.Margin = new System.Windows.Forms.Padding(0);
            this.chkClass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkClass.Name = "chkClass";
            this.chkClass.ReadOnly = false;
            this.chkClass.Ripple = true;
            this.chkClass.Size = new System.Drawing.Size(165, 37);
            this.chkClass.TabIndex = 3;
            this.chkClass.Text = "Escoger una Clase";
            this.chkClass.UseVisualStyleBackColor = true;
            // 
            // lvClassesSelected
            // 
            this.lvClassesSelected.AutoSizeTable = false;
            this.lvClassesSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvClassesSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvClassesSelected.Depth = 0;
            this.lvClassesSelected.FullRowSelect = true;
            this.lvClassesSelected.HideSelection = false;
            this.lvClassesSelected.Location = new System.Drawing.Point(41, 221);
            this.lvClassesSelected.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvClassesSelected.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvClassesSelected.MouseState = MaterialSkin.MouseState.OUT;
            this.lvClassesSelected.Name = "lvClassesSelected";
            this.lvClassesSelected.OwnerDraw = true;
            this.lvClassesSelected.Size = new System.Drawing.Size(388, 301);
            this.lvClassesSelected.TabIndex = 5;
            this.lvClassesSelected.UseCompatibleStateImageBehavior = false;
            this.lvClassesSelected.View = System.Windows.Forms.View.Details;
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 820);
            this.Controls.Add(this.mtcMenu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mtcMenu;
            this.Name = "FormEstudiante";
            this.Text = "FormEstudiante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEstudiante_Load);
            this.mtcMenu.ResumeLayout(false);
            this.SubirPet.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.mepChecklistJustification.ResumeLayout(false);
            this.mepChecklistJustification.PerformLayout();
            this.mepAddClass.ResumeLayout(false);
            this.mepAddClass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mtcMenu;
        private System.Windows.Forms.TabPage SubirPet;
        private System.Windows.Forms.TabPage EditDatPer;
        private System.Windows.Forms.ImageList imagenesMenu;
        private System.Windows.Forms.TabPage editHorDeClas;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private MaterialSkin.Controls.MaterialExpansionPanel mepChecklistJustification;
        private System.Windows.Forms.DateTimePicker dtpJustClass;
        private MaterialSkin.Controls.MaterialExpansionPanel mepAddClass;
        private MaterialSkin.Controls.MaterialLabel lblSelectClass;
        private MaterialSkin.Controls.MaterialComboBox cbClasses;
        private MaterialSkin.Controls.MaterialCheckbox chkClass;
        private MaterialSkin.Controls.MaterialCheckbox chkFecha;
        private MaterialSkin.Controls.MaterialListView lvClassesSelected;
    }
}