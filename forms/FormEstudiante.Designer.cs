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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dtpJustClass = new System.Windows.Forms.DateTimePicker();
            this.mclbClassesList = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.lblSelectClass = new MaterialSkin.Controls.MaterialLabel();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.mepChecklistJustification = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.cbClass = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbFecha = new MaterialSkin.Controls.MaterialCheckbox();
            this.EditDatPer = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.lblPersonalData = new MaterialSkin.Controls.MaterialLabel();
            this.btnSaveChanges = new MaterialSkin.Controls.MaterialButton();
            this.tbName = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCif = new MaterialSkin.Controls.MaterialTextBox();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblBirthDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblCif = new MaterialSkin.Controls.MaterialLabel();
            this.editHorDeClas = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.mepAddClassSchedule = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.tbAddProfessorEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbAddProfessorName = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbAddClassName = new MaterialSkin.Controls.MaterialTextBox2();
            this.imagenesMenu = new System.Windows.Forms.ImageList(this.components);
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox7 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox8 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox9 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox10 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox11 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox12 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox13 = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnDeleteClass = new MaterialSkin.Controls.MaterialButton();
            this.mtcMenu.SuspendLayout();
            this.SubirPet.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.mepChecklistJustification.SuspendLayout();
            this.EditDatPer.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.editHorDeClas.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.mepAddClassSchedule.SuspendLayout();
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
            this.mtcMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dtpJustClass);
            this.materialCard1.Controls.Add(this.mclbClassesList);
            this.materialCard1.Controls.Add(this.lblSelectClass);
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
            // dtpJustClass
            // 
            this.dtpJustClass.Location = new System.Drawing.Point(219, 119);
            this.dtpJustClass.Name = "dtpJustClass";
            this.dtpJustClass.Size = new System.Drawing.Size(200, 20);
            this.dtpJustClass.TabIndex = 4;
            this.dtpJustClass.ValueChanged += new System.EventHandler(this.dtpJustClass_ValueChanged);
            // 
            // mclbClassesList
            // 
            this.mclbClassesList.AutoScroll = true;
            this.mclbClassesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mclbClassesList.Depth = 0;
            this.mclbClassesList.Location = new System.Drawing.Point(41, 237);
            this.mclbClassesList.MouseState = MaterialSkin.MouseState.HOVER;
            this.mclbClassesList.Name = "mclbClassesList";
            this.mclbClassesList.Size = new System.Drawing.Size(382, 450);
            this.mclbClassesList.Striped = false;
            this.mclbClassesList.StripeDarkColor = System.Drawing.Color.Empty;
            this.mclbClassesList.TabIndex = 4;
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Depth = 0;
            this.lblSelectClass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelectClass.Location = new System.Drawing.Point(38, 185);
            this.lblSelectClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(153, 19);
            this.lblSelectClass.TabIndex = 3;
            this.lblSelectClass.Text = "Seleccione una clase:";
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
            // mepChecklistJustification
            // 
            this.mepChecklistJustification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepChecklistJustification.CancelButtonText = "CANCELar";
            this.mepChecklistJustification.Controls.Add(this.cbClass);
            this.mepChecklistJustification.Controls.Add(this.cbFecha);
            this.mepChecklistJustification.Depth = 0;
            this.mepChecklistJustification.Description = "Lista de campos a llenar";
            this.mepChecklistJustification.Dock = System.Windows.Forms.DockStyle.Right;
            this.mepChecklistJustification.ExpandHeight = 676;
            this.mepChecklistJustification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // cbClass
            // 
            this.cbClass.AutoSize = true;
            this.cbClass.Depth = 0;
            this.cbClass.Location = new System.Drawing.Point(28, 171);
            this.cbClass.Margin = new System.Windows.Forms.Padding(0);
            this.cbClass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbClass.Name = "cbClass";
            this.cbClass.ReadOnly = true;
            this.cbClass.Ripple = true;
            this.cbClass.Size = new System.Drawing.Size(165, 37);
            this.cbClass.TabIndex = 3;
            this.cbClass.Text = "Escoger una Clase";
            this.cbClass.UseVisualStyleBackColor = true;
            // 
            // cbFecha
            // 
            this.cbFecha.AutoSize = true;
            this.cbFecha.Depth = 0;
            this.cbFecha.Location = new System.Drawing.Point(28, 105);
            this.cbFecha.Margin = new System.Windows.Forms.Padding(0);
            this.cbFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.ReadOnly = true;
            this.cbFecha.Ripple = true;
            this.cbFecha.Size = new System.Drawing.Size(164, 37);
            this.cbFecha.TabIndex = 2;
            this.cbFecha.Text = "Seleccionar Fecha";
            this.cbFecha.UseVisualStyleBackColor = true;
            // 
            // EditDatPer
            // 
            this.EditDatPer.Controls.Add(this.materialCard2);
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
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialCard4);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(3, 3);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1477, 704);
            this.materialCard2.TabIndex = 0;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard4.Controls.Add(this.lblPersonalData);
            this.materialCard4.Controls.Add(this.btnSaveChanges);
            this.materialCard4.Controls.Add(this.tbName);
            this.materialCard4.Controls.Add(this.tbCif);
            this.materialCard4.Controls.Add(this.lblName);
            this.materialCard4.Controls.Add(this.lblBirthDate);
            this.materialCard4.Controls.Add(this.dtpBirthDate);
            this.materialCard4.Controls.Add(this.lblCif);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(461, 118);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(557, 485);
            this.materialCard4.TabIndex = 8;
            // 
            // lblPersonalData
            // 
            this.lblPersonalData.AutoSize = true;
            this.lblPersonalData.Depth = 0;
            this.lblPersonalData.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPersonalData.Location = new System.Drawing.Point(216, 27);
            this.lblPersonalData.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPersonalData.Name = "lblPersonalData";
            this.lblPersonalData.Size = new System.Drawing.Size(129, 19);
            this.lblPersonalData.TabIndex = 7;
            this.lblPersonalData.Text = "Datos Personales:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveChanges.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveChanges.Depth = 0;
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.HighEmphasis = true;
            this.btnSaveChanges.Icon = null;
            this.btnSaveChanges.Location = new System.Drawing.Point(366, 369);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveChanges.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveChanges.Size = new System.Drawing.Size(157, 36);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Guardar Cambios";
            this.btnSaveChanges.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveChanges.UseAccentColor = false;
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // tbName
            // 
            this.tbName.AnimateReadOnly = false;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Depth = 0;
            this.tbName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbName.LeadingIcon = null;
            this.tbName.Location = new System.Drawing.Point(194, 100);
            this.tbName.MaxLength = 50;
            this.tbName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(330, 50);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "";
            this.tbName.TrailingIcon = null;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbCif
            // 
            this.tbCif.AnimateReadOnly = false;
            this.tbCif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCif.Depth = 0;
            this.tbCif.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCif.LeadingIcon = null;
            this.tbCif.Location = new System.Drawing.Point(194, 181);
            this.tbCif.MaxLength = 50;
            this.tbCif.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCif.Multiline = false;
            this.tbCif.Name = "tbCif";
            this.tbCif.Size = new System.Drawing.Size(330, 50);
            this.tbCif.TabIndex = 5;
            this.tbCif.Text = "";
            this.tbCif.TrailingIcon = null;
            this.tbCif.TextChanged += new System.EventHandler(this.tbCif_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(72, 131);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Depth = 0;
            this.lblBirthDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBirthDate.Location = new System.Drawing.Point(17, 294);
            this.lblBirthDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(150, 19);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Fecha de Nacimiento";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(194, 294);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(329, 20);
            this.dtpBirthDate.TabIndex = 2;
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // lblCif
            // 
            this.lblCif.AutoSize = true;
            this.lblCif.Depth = 0;
            this.lblCif.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCif.Location = new System.Drawing.Point(72, 212);
            this.lblCif.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCif.Name = "lblCif";
            this.lblCif.Size = new System.Drawing.Size(25, 19);
            this.lblCif.TabIndex = 3;
            this.lblCif.Text = "Cif:";
            // 
            // editHorDeClas
            // 
            this.editHorDeClas.Controls.Add(this.materialCard3);
            this.editHorDeClas.ImageKey = "Documento.png";
            this.editHorDeClas.Location = new System.Drawing.Point(4, 39);
            this.editHorDeClas.Name = "editHorDeClas";
            this.editHorDeClas.Size = new System.Drawing.Size(1483, 710);
            this.editHorDeClas.TabIndex = 2;
            this.editHorDeClas.Text = "Editar Horario de Clases";
            this.editHorDeClas.ToolTipText = "Editar el horario de clase. ";
            this.editHorDeClas.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnDeleteClass);
            this.materialCard3.Controls.Add(this.dgvClasses);
            this.materialCard3.Controls.Add(this.mepAddClassSchedule);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(0, 0);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(1483, 710);
            this.materialCard3.TabIndex = 0;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(18, 53);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.Size = new System.Drawing.Size(781, 525);
            this.dgvClasses.TabIndex = 2;
            // 
            // mepAddClassSchedule
            // 
            this.mepAddClassSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepAddClassSchedule.CancelButtonText = "";
            this.mepAddClassSchedule.Controls.Add(this.tbAddProfessorEmail);
            this.mepAddClassSchedule.Controls.Add(this.tbAddProfessorName);
            this.mepAddClassSchedule.Controls.Add(this.tbAddClassName);
            this.mepAddClassSchedule.Depth = 0;
            this.mepAddClassSchedule.Description = "Agregue una clase a su horario";
            this.mepAddClassSchedule.ExpandHeight = 593;
            this.mepAddClassSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepAddClassSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepAddClassSchedule.Location = new System.Drawing.Point(873, 53);
            this.mepAddClassSchedule.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.mepAddClassSchedule.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepAddClassSchedule.Name = "mepAddClassSchedule";
            this.mepAddClassSchedule.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepAddClassSchedule.Size = new System.Drawing.Size(493, 593);
            this.mepAddClassSchedule.TabIndex = 1;
            this.mepAddClassSchedule.Title = "Agregar Clase";
            this.mepAddClassSchedule.ValidationButtonText = "Agregar";
            this.mepAddClassSchedule.SaveClick += new System.EventHandler(this.mepAddClassSchedule_SaveClick);
            // 
            // tbAddProfessorEmail
            // 
            this.tbAddProfessorEmail.AnimateReadOnly = false;
            this.tbAddProfessorEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAddProfessorEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAddProfessorEmail.Depth = 0;
            this.tbAddProfessorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAddProfessorEmail.HideSelection = true;
            this.tbAddProfessorEmail.Hint = "Correo del profesor/a:";
            this.tbAddProfessorEmail.LeadingIcon = null;
            this.tbAddProfessorEmail.Location = new System.Drawing.Point(27, 237);
            this.tbAddProfessorEmail.MaxLength = 32767;
            this.tbAddProfessorEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAddProfessorEmail.Name = "tbAddProfessorEmail";
            this.tbAddProfessorEmail.PasswordChar = '\0';
            this.tbAddProfessorEmail.PrefixSuffixText = null;
            this.tbAddProfessorEmail.ReadOnly = false;
            this.tbAddProfessorEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAddProfessorEmail.SelectedText = "";
            this.tbAddProfessorEmail.SelectionLength = 0;
            this.tbAddProfessorEmail.SelectionStart = 0;
            this.tbAddProfessorEmail.ShortcutsEnabled = true;
            this.tbAddProfessorEmail.Size = new System.Drawing.Size(303, 48);
            this.tbAddProfessorEmail.TabIndex = 4;
            this.tbAddProfessorEmail.TabStop = false;
            this.tbAddProfessorEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAddProfessorEmail.TrailingIcon = null;
            this.tbAddProfessorEmail.UseSystemPasswordChar = false;
            this.tbAddProfessorEmail.TextChanged += new System.EventHandler(this.tbAddProfessorEmail_TextChanged);
            // 
            // tbAddProfessorName
            // 
            this.tbAddProfessorName.AnimateReadOnly = false;
            this.tbAddProfessorName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAddProfessorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAddProfessorName.Depth = 0;
            this.tbAddProfessorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAddProfessorName.HideSelection = true;
            this.tbAddProfessorName.Hint = "Nombre del profesor/a:";
            this.tbAddProfessorName.LeadingIcon = null;
            this.tbAddProfessorName.Location = new System.Drawing.Point(27, 161);
            this.tbAddProfessorName.MaxLength = 32767;
            this.tbAddProfessorName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAddProfessorName.Name = "tbAddProfessorName";
            this.tbAddProfessorName.PasswordChar = '\0';
            this.tbAddProfessorName.PrefixSuffixText = null;
            this.tbAddProfessorName.ReadOnly = false;
            this.tbAddProfessorName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAddProfessorName.SelectedText = "";
            this.tbAddProfessorName.SelectionLength = 0;
            this.tbAddProfessorName.SelectionStart = 0;
            this.tbAddProfessorName.ShortcutsEnabled = true;
            this.tbAddProfessorName.Size = new System.Drawing.Size(303, 48);
            this.tbAddProfessorName.TabIndex = 3;
            this.tbAddProfessorName.TabStop = false;
            this.tbAddProfessorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAddProfessorName.TrailingIcon = null;
            this.tbAddProfessorName.UseSystemPasswordChar = false;
            this.tbAddProfessorName.TextChanged += new System.EventHandler(this.tbAddProfessorName_TextChanged);
            // 
            // tbAddClassName
            // 
            this.tbAddClassName.AnimateReadOnly = false;
            this.tbAddClassName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAddClassName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAddClassName.Depth = 0;
            this.tbAddClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAddClassName.HideSelection = true;
            this.tbAddClassName.Hint = "Nombre de la clase:";
            this.tbAddClassName.LeadingIcon = null;
            this.tbAddClassName.Location = new System.Drawing.Point(27, 80);
            this.tbAddClassName.MaxLength = 32767;
            this.tbAddClassName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAddClassName.Name = "tbAddClassName";
            this.tbAddClassName.PasswordChar = '\0';
            this.tbAddClassName.PrefixSuffixText = null;
            this.tbAddClassName.ReadOnly = false;
            this.tbAddClassName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAddClassName.SelectedText = "";
            this.tbAddClassName.SelectionLength = 0;
            this.tbAddClassName.SelectionStart = 0;
            this.tbAddClassName.ShortcutsEnabled = true;
            this.tbAddClassName.Size = new System.Drawing.Size(303, 48);
            this.tbAddClassName.TabIndex = 2;
            this.tbAddClassName.TabStop = false;
            this.tbAddClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAddClassName.TrailingIcon = null;
            this.tbAddClassName.UseSystemPasswordChar = false;
            this.tbAddClassName.TextChanged += new System.EventHandler(this.tbAddClassName_TextChanged);
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
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "Estadisticas II";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "Calculo II";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.ReadOnly = false;
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox4.TabIndex = 0;
            this.materialCheckbox4.Text = "Comunicación y Lenguaje 2";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox5
            // 
            this.materialCheckbox5.Depth = 0;
            this.materialCheckbox5.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox5.Name = "materialCheckbox5";
            this.materialCheckbox5.ReadOnly = false;
            this.materialCheckbox5.Ripple = true;
            this.materialCheckbox5.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox5.TabIndex = 0;
            this.materialCheckbox5.Text = "Algebra Lineal";
            this.materialCheckbox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox6
            // 
            this.materialCheckbox6.Depth = 0;
            this.materialCheckbox6.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox6.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox6.Name = "materialCheckbox6";
            this.materialCheckbox6.ReadOnly = false;
            this.materialCheckbox6.Ripple = true;
            this.materialCheckbox6.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox6.TabIndex = 0;
            this.materialCheckbox6.Text = "Finanzas";
            this.materialCheckbox6.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox7
            // 
            this.materialCheckbox7.Depth = 0;
            this.materialCheckbox7.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox7.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox7.Name = "materialCheckbox7";
            this.materialCheckbox7.ReadOnly = false;
            this.materialCheckbox7.Ripple = true;
            this.materialCheckbox7.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox7.TabIndex = 0;
            this.materialCheckbox7.Text = "Programación Estructurada";
            this.materialCheckbox7.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "Ejemplo de clase";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox8
            // 
            this.materialCheckbox8.Depth = 0;
            this.materialCheckbox8.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox8.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox8.Name = "materialCheckbox8";
            this.materialCheckbox8.ReadOnly = false;
            this.materialCheckbox8.Ripple = true;
            this.materialCheckbox8.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox8.TabIndex = 0;
            this.materialCheckbox8.Text = "materialCheckbox8";
            this.materialCheckbox8.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox9
            // 
            this.materialCheckbox9.Depth = 0;
            this.materialCheckbox9.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox9.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox9.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox9.Name = "materialCheckbox9";
            this.materialCheckbox9.ReadOnly = false;
            this.materialCheckbox9.Ripple = true;
            this.materialCheckbox9.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox9.TabIndex = 0;
            this.materialCheckbox9.Text = "materialCheckbox9";
            this.materialCheckbox9.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox10
            // 
            this.materialCheckbox10.Depth = 0;
            this.materialCheckbox10.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox10.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox10.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox10.Name = "materialCheckbox10";
            this.materialCheckbox10.ReadOnly = false;
            this.materialCheckbox10.Ripple = true;
            this.materialCheckbox10.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox10.TabIndex = 0;
            this.materialCheckbox10.Text = "materialCheckbox10";
            this.materialCheckbox10.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox11
            // 
            this.materialCheckbox11.Depth = 0;
            this.materialCheckbox11.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox11.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox11.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox11.Name = "materialCheckbox11";
            this.materialCheckbox11.ReadOnly = false;
            this.materialCheckbox11.Ripple = true;
            this.materialCheckbox11.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox11.TabIndex = 0;
            this.materialCheckbox11.Text = "materialCheckbox11";
            this.materialCheckbox11.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox12
            // 
            this.materialCheckbox12.Depth = 0;
            this.materialCheckbox12.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox12.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox12.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox12.Name = "materialCheckbox12";
            this.materialCheckbox12.ReadOnly = false;
            this.materialCheckbox12.Ripple = true;
            this.materialCheckbox12.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox12.TabIndex = 0;
            this.materialCheckbox12.Text = "materialCheckbox12";
            this.materialCheckbox12.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox13
            // 
            this.materialCheckbox13.Depth = 0;
            this.materialCheckbox13.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox13.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox13.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox13.Name = "materialCheckbox13";
            this.materialCheckbox13.ReadOnly = false;
            this.materialCheckbox13.Ripple = true;
            this.materialCheckbox13.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox13.TabIndex = 0;
            this.materialCheckbox13.Text = "materialCheckbox13";
            this.materialCheckbox13.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.AutoSize = false;
            this.btnDeleteClass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteClass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteClass.Depth = 0;
            this.btnDeleteClass.HighEmphasis = true;
            this.btnDeleteClass.Icon = null;
            this.btnDeleteClass.Location = new System.Drawing.Point(641, 610);
            this.btnDeleteClass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteClass.Size = new System.Drawing.Size(158, 36);
            this.btnDeleteClass.TabIndex = 3;
            this.btnDeleteClass.Text = "Eliminar Clase";
            this.btnDeleteClass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteClass.UseAccentColor = false;
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
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
            this.Text = "Panel de Estudiante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEstudiante_Load);
            this.mtcMenu.ResumeLayout(false);
            this.SubirPet.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.mepChecklistJustification.ResumeLayout(false);
            this.mepChecklistJustification.PerformLayout();
            this.EditDatPer.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.editHorDeClas.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.mepAddClassSchedule.ResumeLayout(false);
            this.mepAddClassSchedule.PerformLayout();
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
        private MaterialSkin.Controls.MaterialLabel lblSelectClass;
        private MaterialSkin.Controls.MaterialCheckbox cbClass;
        private MaterialSkin.Controls.MaterialCheckbox cbFecha;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialTextBox tbName;
        private MaterialSkin.Controls.MaterialTextBox tbCif;
        private MaterialSkin.Controls.MaterialLabel lblBirthDate;
        private MaterialSkin.Controls.MaterialLabel lblCif;
        private MaterialSkin.Controls.MaterialButton btnSaveChanges;
        private MaterialSkin.Controls.MaterialLabel lblPersonalData;
        private MaterialSkin.Controls.MaterialCheckedListBox mclbClassesList;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox6;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox7;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialExpansionPanel mepAddClassSchedule;
        private MaterialSkin.Controls.MaterialTextBox2 tbAddProfessorEmail;
        private MaterialSkin.Controls.MaterialTextBox2 tbAddProfessorName;
        private MaterialSkin.Controls.MaterialTextBox2 tbAddClassName;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox8;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox9;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox10;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox11;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox12;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox13;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.DataGridView dgvClasses;
        private MaterialSkin.Controls.MaterialButton btnDeleteClass;
    }
}