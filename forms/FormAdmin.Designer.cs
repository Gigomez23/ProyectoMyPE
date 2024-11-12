namespace ProyectoMarjorie.forms
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.ImagenesDeMenu = new System.Windows.Forms.ImageList(this.components);
            this.mtcMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.ConfirmJust = new System.Windows.Forms.TabPage();
            this.mepJustDetails = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.mlblEmailPreview = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tbDate = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.tbClass = new MaterialSkin.Controls.MaterialTextBox();
            this.lblClass = new MaterialSkin.Controls.MaterialLabel();
            this.tbCif = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCif = new MaterialSkin.Controls.MaterialLabel();
            this.tbName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lvPetitions = new MaterialSkin.Controls.MaterialListView();
            this.CrearPet = new System.Windows.Forms.TabPage();
            this.mepFindStudent = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.mepCreateUser = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.tbStudentName = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbUserCif = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbCifEntry = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblBirthDate = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddClass = new MaterialSkin.Controls.MaterialButton();
            this.lvStudentsList = new MaterialSkin.Controls.MaterialListView();
            this.cbClass = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tbUsername = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.mepAddProfessor = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox23 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.mepSendJustNotice = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.mltbEmailPreview = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.mtcMenu.SuspendLayout();
            this.ConfirmJust.SuspendLayout();
            this.mepJustDetails.SuspendLayout();
            this.CrearPet.SuspendLayout();
            this.mepFindStudent.SuspendLayout();
            this.mepCreateUser.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.mepAddProfessor.SuspendLayout();
            this.mepSendJustNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImagenesDeMenu
            // 
            this.ImagenesDeMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagenesDeMenu.ImageStream")));
            this.ImagenesDeMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagenesDeMenu.Images.SetKeyName(0, "Aprobar.png");
            this.ImagenesDeMenu.Images.SetKeyName(1, "EditarUsuario.png");
            this.ImagenesDeMenu.Images.SetKeyName(2, "SubirArchivo.png");
            this.ImagenesDeMenu.Images.SetKeyName(3, "Documento.png");
            this.ImagenesDeMenu.Images.SetKeyName(4, "Usuario.png");
            // 
            // mtcMenu
            // 
            this.mtcMenu.Controls.Add(this.ConfirmJust);
            this.mtcMenu.Controls.Add(this.CrearPet);
            this.mtcMenu.Depth = 0;
            this.mtcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcMenu.ImageList = this.ImagenesDeMenu;
            this.mtcMenu.Location = new System.Drawing.Point(3, 64);
            this.mtcMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtcMenu.Multiline = true;
            this.mtcMenu.Name = "mtcMenu";
            this.mtcMenu.SelectedIndex = 0;
            this.mtcMenu.ShowToolTips = true;
            this.mtcMenu.Size = new System.Drawing.Size(1445, 943);
            this.mtcMenu.TabIndex = 0;
            // 
            // ConfirmJust
            // 
            this.ConfirmJust.Controls.Add(this.mepJustDetails);
            this.ConfirmJust.Controls.Add(this.lvPetitions);
            this.ConfirmJust.ImageKey = "Aprobar.png";
            this.ConfirmJust.Location = new System.Drawing.Point(4, 39);
            this.ConfirmJust.Name = "ConfirmJust";
            this.ConfirmJust.Padding = new System.Windows.Forms.Padding(3);
            this.ConfirmJust.Size = new System.Drawing.Size(1437, 900);
            this.ConfirmJust.TabIndex = 0;
            this.ConfirmJust.Text = "Confirmar Justificaciónes";
            this.ConfirmJust.ToolTipText = "Confirmar Justificaciónes de estudiantes.";
            this.ConfirmJust.UseVisualStyleBackColor = true;
            // 
            // mepJustDetails
            // 
            this.mepJustDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mepJustDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepJustDetails.CancelButtonText = "CANCELar";
            this.mepJustDetails.Controls.Add(this.mlblEmailPreview);
            this.mepJustDetails.Controls.Add(this.tbDate);
            this.mepJustDetails.Controls.Add(this.lblDate);
            this.mepJustDetails.Controls.Add(this.tbClass);
            this.mepJustDetails.Controls.Add(this.lblClass);
            this.mepJustDetails.Controls.Add(this.tbCif);
            this.mepJustDetails.Controls.Add(this.lblCif);
            this.mepJustDetails.Controls.Add(this.tbName);
            this.mepJustDetails.Controls.Add(this.lblName);
            this.mepJustDetails.Depth = 0;
            this.mepJustDetails.Description = "Detalles de petición de justificación de estudiante.";
            this.mepJustDetails.ExpandHeight = 675;
            this.mepJustDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepJustDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepJustDetails.Location = new System.Drawing.Point(664, 115);
            this.mepJustDetails.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.mepJustDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepJustDetails.Name = "mepJustDetails";
            this.mepJustDetails.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepJustDetails.Size = new System.Drawing.Size(703, 675);
            this.mepJustDetails.TabIndex = 1;
            this.mepJustDetails.Title = "Detalles";
            this.mepJustDetails.ValidationButtonText = "Aprobar";
            // 
            // mlblEmailPreview
            // 
            this.mlblEmailPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlblEmailPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlblEmailPreview.Depth = 0;
            this.mlblEmailPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblEmailPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblEmailPreview.Location = new System.Drawing.Point(70, 389);
            this.mlblEmailPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblEmailPreview.Name = "mlblEmailPreview";
            this.mlblEmailPreview.Size = new System.Drawing.Size(561, 178);
            this.mlblEmailPreview.TabIndex = 10;
            this.mlblEmailPreview.Text = resources.GetString("mlblEmailPreview.Text");
            // 
            // tbDate
            // 
            this.tbDate.AnimateReadOnly = false;
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Depth = 0;
            this.tbDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDate.LeadingIcon = null;
            this.tbDate.Location = new System.Drawing.Point(202, 308);
            this.tbDate.MaxLength = 50;
            this.tbDate.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDate.Multiline = false;
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(333, 50);
            this.tbDate.TabIndex = 9;
            this.tbDate.Text = "";
            this.tbDate.TrailingIcon = null;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate.Location = new System.Drawing.Point(66, 327);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 19);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Fecha:";
            // 
            // tbClass
            // 
            this.tbClass.AnimateReadOnly = false;
            this.tbClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbClass.Depth = 0;
            this.tbClass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbClass.LeadingIcon = null;
            this.tbClass.Location = new System.Drawing.Point(202, 230);
            this.tbClass.MaxLength = 50;
            this.tbClass.MouseState = MaterialSkin.MouseState.OUT;
            this.tbClass.Multiline = false;
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(333, 50);
            this.tbClass.TabIndex = 7;
            this.tbClass.Text = "";
            this.tbClass.TrailingIcon = null;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Depth = 0;
            this.lblClass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblClass.Location = new System.Drawing.Point(66, 249);
            this.lblClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 19);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "Clase: ";
            // 
            // tbCif
            // 
            this.tbCif.AnimateReadOnly = false;
            this.tbCif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCif.Depth = 0;
            this.tbCif.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCif.LeadingIcon = null;
            this.tbCif.Location = new System.Drawing.Point(202, 160);
            this.tbCif.MaxLength = 50;
            this.tbCif.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCif.Multiline = false;
            this.tbCif.Name = "tbCif";
            this.tbCif.Size = new System.Drawing.Size(333, 50);
            this.tbCif.TabIndex = 5;
            this.tbCif.Text = "";
            this.tbCif.TrailingIcon = null;
            // 
            // lblCif
            // 
            this.lblCif.AutoSize = true;
            this.lblCif.Depth = 0;
            this.lblCif.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCif.Location = new System.Drawing.Point(66, 179);
            this.lblCif.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCif.Name = "lblCif";
            this.lblCif.Size = new System.Drawing.Size(28, 19);
            this.lblCif.TabIndex = 4;
            this.lblCif.Text = "CIF:";
            this.lblCif.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbName
            // 
            this.tbName.AnimateReadOnly = false;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Depth = 0;
            this.tbName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbName.LeadingIcon = null;
            this.tbName.Location = new System.Drawing.Point(202, 80);
            this.tbName.MaxLength = 50;
            this.tbName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(333, 50);
            this.tbName.TabIndex = 3;
            this.tbName.Text = "";
            this.tbName.TrailingIcon = null;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(66, 99);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lvPetitions
            // 
            this.lvPetitions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lvPetitions.AutoSizeTable = true;
            this.lvPetitions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvPetitions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPetitions.Depth = 0;
            this.lvPetitions.FullRowSelect = true;
            this.lvPetitions.HideSelection = false;
            this.lvPetitions.Location = new System.Drawing.Point(44, 115);
            this.lvPetitions.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvPetitions.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvPetitions.MouseState = MaterialSkin.MouseState.OUT;
            this.lvPetitions.Name = "lvPetitions";
            this.lvPetitions.OwnerDraw = true;
            this.lvPetitions.Scrollable = false;
            this.lvPetitions.Size = new System.Drawing.Size(200, 100);
            this.lvPetitions.TabIndex = 0;
            this.lvPetitions.UseCompatibleStateImageBehavior = false;
            this.lvPetitions.View = System.Windows.Forms.View.Details;
            // 
            // CrearPet
            // 
            this.CrearPet.Controls.Add(this.materialCard1);
            this.CrearPet.Controls.Add(this.mepCreateUser);
            this.CrearPet.Controls.Add(this.mepFindStudent);
            this.CrearPet.ImageKey = "Documento.png";
            this.CrearPet.Location = new System.Drawing.Point(4, 39);
            this.CrearPet.Name = "CrearPet";
            this.CrearPet.Padding = new System.Windows.Forms.Padding(3);
            this.CrearPet.Size = new System.Drawing.Size(1437, 900);
            this.CrearPet.TabIndex = 1;
            this.CrearPet.Text = "Crear Petición";
            this.CrearPet.ToolTipText = "Crear la petición del estudiante. ";
            this.CrearPet.UseVisualStyleBackColor = true;
            // 
            // mepFindStudent
            // 
            this.mepFindStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepFindStudent.CancelButtonText = "CANCELar";
            this.mepFindStudent.Collapse = true;
            this.mepFindStudent.Controls.Add(this.cbClass);
            this.mepFindStudent.Controls.Add(this.lvStudentsList);
            this.mepFindStudent.Controls.Add(this.tbCifEntry);
            this.mepFindStudent.Depth = 0;
            this.mepFindStudent.Description = "Buscar estudiante mediante Cif en la base de datos.";
            this.mepFindStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.mepFindStudent.ExpandHeight = 621;
            this.mepFindStudent.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepFindStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepFindStudent.Location = new System.Drawing.Point(3, 3);
            this.mepFindStudent.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.mepFindStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepFindStudent.Name = "mepFindStudent";
            this.mepFindStudent.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepFindStudent.Size = new System.Drawing.Size(1431, 48);
            this.mepFindStudent.TabIndex = 0;
            this.mepFindStudent.Title = "Buscar Estudiante";
            this.mepFindStudent.ValidationButtonText = "Importar datos";
            // 
            // mepCreateUser
            // 
            this.mepCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepCreateUser.CancelButtonText = "CANCELar";
            this.mepCreateUser.Collapse = true;
            this.mepCreateUser.Controls.Add(this.btnAddClass);
            this.mepCreateUser.Controls.Add(this.dateTimePicker1);
            this.mepCreateUser.Controls.Add(this.lblBirthDate);
            this.mepCreateUser.Controls.Add(this.tbUserCif);
            this.mepCreateUser.Controls.Add(this.tbStudentName);
            this.mepCreateUser.Depth = 0;
            this.mepCreateUser.Description = "Crear usuario para el estudiante";
            this.mepCreateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.mepCreateUser.ExpandHeight = 493;
            this.mepCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepCreateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepCreateUser.Location = new System.Drawing.Point(3, 51);
            this.mepCreateUser.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.mepCreateUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepCreateUser.Name = "mepCreateUser";
            this.mepCreateUser.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepCreateUser.Size = new System.Drawing.Size(1431, 48);
            this.mepCreateUser.TabIndex = 2;
            this.mepCreateUser.Title = "Crear Usuario";
            this.mepCreateUser.ValidationButtonText = "Crear";
            // 
            // tbStudentName
            // 
            this.tbStudentName.AnimateReadOnly = false;
            this.tbStudentName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbStudentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbStudentName.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbStudentName.Depth = 0;
            this.tbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbStudentName.HideSelection = true;
            this.tbStudentName.Hint = "Nombre:";
            this.tbStudentName.LeadingIcon = null;
            this.tbStudentName.LeaveOnEnterKey = true;
            this.tbStudentName.Location = new System.Drawing.Point(76, 101);
            this.tbStudentName.MaxLength = 32767;
            this.tbStudentName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.PasswordChar = '\0';
            this.tbStudentName.PrefixSuffixText = null;
            this.tbStudentName.ReadOnly = false;
            this.tbStudentName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbStudentName.SelectedText = "";
            this.tbStudentName.SelectionLength = 0;
            this.tbStudentName.SelectionStart = 0;
            this.tbStudentName.ShortcutsEnabled = true;
            this.tbStudentName.Size = new System.Drawing.Size(394, 48);
            this.tbStudentName.TabIndex = 2;
            this.tbStudentName.TabStop = false;
            this.tbStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbStudentName.TrailingIcon = null;
            this.tbStudentName.UseSystemPasswordChar = false;
            // 
            // tbUserCif
            // 
            this.tbUserCif.AnimateReadOnly = false;
            this.tbUserCif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbUserCif.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUserCif.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbUserCif.Depth = 0;
            this.tbUserCif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUserCif.HideSelection = true;
            this.tbUserCif.Hint = "Cif:";
            this.tbUserCif.LeadingIcon = null;
            this.tbUserCif.LeaveOnEnterKey = true;
            this.tbUserCif.Location = new System.Drawing.Point(76, 181);
            this.tbUserCif.MaxLength = 32767;
            this.tbUserCif.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUserCif.Name = "tbUserCif";
            this.tbUserCif.PasswordChar = '\0';
            this.tbUserCif.PrefixSuffixText = null;
            this.tbUserCif.ReadOnly = false;
            this.tbUserCif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbUserCif.SelectedText = "";
            this.tbUserCif.SelectionLength = 0;
            this.tbUserCif.SelectionStart = 0;
            this.tbUserCif.ShortcutsEnabled = true;
            this.tbUserCif.Size = new System.Drawing.Size(394, 48);
            this.tbUserCif.TabIndex = 3;
            this.tbUserCif.TabStop = false;
            this.tbUserCif.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUserCif.TrailingIcon = null;
            this.tbUserCif.UseSystemPasswordChar = false;
            // 
            // tbCifEntry
            // 
            this.tbCifEntry.AnimateReadOnly = false;
            this.tbCifEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCifEntry.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCifEntry.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCifEntry.Depth = 0;
            this.tbCifEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCifEntry.HideSelection = true;
            this.tbCifEntry.Hint = "Cif:";
            this.tbCifEntry.LeadingIcon = null;
            this.tbCifEntry.LeaveOnEnterKey = true;
            this.tbCifEntry.Location = new System.Drawing.Point(73, 101);
            this.tbCifEntry.MaxLength = 32767;
            this.tbCifEntry.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCifEntry.Name = "tbCifEntry";
            this.tbCifEntry.PasswordChar = '\0';
            this.tbCifEntry.PrefixSuffixText = null;
            this.tbCifEntry.ReadOnly = false;
            this.tbCifEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCifEntry.SelectedText = "";
            this.tbCifEntry.SelectionLength = 0;
            this.tbCifEntry.SelectionStart = 0;
            this.tbCifEntry.ShortcutsEnabled = true;
            this.tbCifEntry.Size = new System.Drawing.Size(394, 48);
            this.tbCifEntry.TabIndex = 5;
            this.tbCifEntry.TabStop = false;
            this.tbCifEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCifEntry.TrailingIcon = null;
            this.tbCifEntry.UseSystemPasswordChar = false;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Depth = 0;
            this.lblBirthDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBirthDate.Location = new System.Drawing.Point(76, 268);
            this.lblBirthDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(154, 19);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Fecha de Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 266);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnAddClass
            // 
            this.btnAddClass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddClass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddClass.Depth = 0;
            this.btnAddClass.HighEmphasis = true;
            this.btnAddClass.Icon = null;
            this.btnAddClass.Location = new System.Drawing.Point(79, 354);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddClass.Size = new System.Drawing.Size(136, 36);
            this.btnAddClass.TabIndex = 6;
            this.btnAddClass.Text = "Agregar Clase";
            this.btnAddClass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddClass.UseAccentColor = false;
            this.btnAddClass.UseVisualStyleBackColor = true;
            // 
            // lvStudentsList
            // 
            this.lvStudentsList.AutoSizeTable = false;
            this.lvStudentsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvStudentsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvStudentsList.Depth = 0;
            this.lvStudentsList.FullRowSelect = true;
            this.lvStudentsList.HideSelection = false;
            this.lvStudentsList.Location = new System.Drawing.Point(73, 181);
            this.lvStudentsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvStudentsList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvStudentsList.MouseState = MaterialSkin.MouseState.OUT;
            this.lvStudentsList.Name = "lvStudentsList";
            this.lvStudentsList.OwnerDraw = true;
            this.lvStudentsList.Size = new System.Drawing.Size(394, 260);
            this.lvStudentsList.TabIndex = 6;
            this.lvStudentsList.UseCompatibleStateImageBehavior = false;
            this.lvStudentsList.View = System.Windows.Forms.View.Details;
            // 
            // cbClass
            // 
            this.cbClass.AutoResize = false;
            this.cbClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbClass.Depth = 0;
            this.cbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbClass.DropDownHeight = 174;
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.DropDownWidth = 121;
            this.cbClass.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Hint = "Seleccione una clase";
            this.cbClass.IntegralHeight = false;
            this.cbClass.ItemHeight = 43;
            this.cbClass.Location = new System.Drawing.Point(248, 480);
            this.cbClass.MaxDropDownItems = 4;
            this.cbClass.MouseState = MaterialSkin.MouseState.OUT;
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(219, 49);
            this.cbClass.StartIndex = 0;
            this.cbClass.TabIndex = 7;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.mepSendJustNotice);
            this.materialCard1.Controls.Add(this.mltbEmailPreview);
            this.materialCard1.Controls.Add(this.materialDrawer1);
            this.materialCard1.Controls.Add(this.dateTimePicker2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.mepAddProfessor);
            this.materialCard1.Controls.Add(this.materialTextBox21);
            this.materialCard1.Controls.Add(this.tbUsername);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 99);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1431, 798);
            this.materialCard1.TabIndex = 3;
            // 
            // tbUsername
            // 
            this.tbUsername.AnimateReadOnly = false;
            this.tbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbUsername.Depth = 0;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUsername.HideSelection = true;
            this.tbUsername.Hint = "Usuario:";
            this.tbUsername.LeadingIcon = null;
            this.tbUsername.LeaveOnEnterKey = true;
            this.tbUsername.Location = new System.Drawing.Point(35, 36);
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PrefixSuffixText = null;
            this.tbUsername.ReadOnly = false;
            this.tbUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.ShortcutsEnabled = true;
            this.tbUsername.Size = new System.Drawing.Size(342, 48);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TabStop = false;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsername.TrailingIcon = null;
            this.tbUsername.UseSystemPasswordChar = false;
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.Hint = "Usuario:";
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.LeaveOnEnterKey = true;
            this.materialTextBox21.Location = new System.Drawing.Point(35, 118);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(342, 48);
            this.materialTextBox21.TabIndex = 3;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // mepAddProfessor
            // 
            this.mepAddProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepAddProfessor.CancelButtonText = "CANCELar";
            this.mepAddProfessor.Controls.Add(this.materialTextBox23);
            this.mepAddProfessor.Controls.Add(this.materialTextBox22);
            this.mepAddProfessor.Depth = 0;
            this.mepAddProfessor.Description = "Agregar el nombre y correo del profesor";
            this.mepAddProfessor.ExpandHeight = 306;
            this.mepAddProfessor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepAddProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepAddProfessor.Location = new System.Drawing.Point(476, 36);
            this.mepAddProfessor.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.mepAddProfessor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepAddProfessor.Name = "mepAddProfessor";
            this.mepAddProfessor.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepAddProfessor.Size = new System.Drawing.Size(523, 306);
            this.mepAddProfessor.TabIndex = 4;
            this.mepAddProfessor.Title = "Agregar Profesor";
            this.mepAddProfessor.ValidationButtonText = "Agregar";
            // 
            // materialTextBox22
            // 
            this.materialTextBox22.AnimateReadOnly = false;
            this.materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox22.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTextBox22.Depth = 0;
            this.materialTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox22.HideSelection = true;
            this.materialTextBox22.Hint = "Usuario:";
            this.materialTextBox22.LeadingIcon = null;
            this.materialTextBox22.LeaveOnEnterKey = true;
            this.materialTextBox22.Location = new System.Drawing.Point(27, 82);
            this.materialTextBox22.MaxLength = 32767;
            this.materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox22.Name = "materialTextBox22";
            this.materialTextBox22.PasswordChar = '\0';
            this.materialTextBox22.PrefixSuffixText = null;
            this.materialTextBox22.ReadOnly = false;
            this.materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox22.SelectedText = "";
            this.materialTextBox22.SelectionLength = 0;
            this.materialTextBox22.SelectionStart = 0;
            this.materialTextBox22.ShortcutsEnabled = true;
            this.materialTextBox22.Size = new System.Drawing.Size(342, 48);
            this.materialTextBox22.TabIndex = 5;
            this.materialTextBox22.TabStop = false;
            this.materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox22.TrailingIcon = null;
            this.materialTextBox22.UseSystemPasswordChar = false;
            // 
            // materialTextBox23
            // 
            this.materialTextBox23.AnimateReadOnly = false;
            this.materialTextBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox23.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox23.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTextBox23.Depth = 0;
            this.materialTextBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox23.HideSelection = true;
            this.materialTextBox23.Hint = "Usuario:";
            this.materialTextBox23.LeadingIcon = null;
            this.materialTextBox23.LeaveOnEnterKey = true;
            this.materialTextBox23.Location = new System.Drawing.Point(27, 157);
            this.materialTextBox23.MaxLength = 32767;
            this.materialTextBox23.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox23.Name = "materialTextBox23";
            this.materialTextBox23.PasswordChar = '\0';
            this.materialTextBox23.PrefixSuffixText = null;
            this.materialTextBox23.ReadOnly = false;
            this.materialTextBox23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox23.SelectedText = "";
            this.materialTextBox23.SelectionLength = 0;
            this.materialTextBox23.SelectionStart = 0;
            this.materialTextBox23.ShortcutsEnabled = true;
            this.materialTextBox23.Size = new System.Drawing.Size(342, 48);
            this.materialTextBox23.TabIndex = 6;
            this.materialTextBox23.TabStop = false;
            this.materialTextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox23.TrailingIcon = null;
            this.materialTextBox23.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(219, 290);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(32, 216);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(177, 216);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-343, 36);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(343, 306);
            this.materialDrawer1.TabIndex = 8;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // materialCheckbox6
            // 
            this.materialCheckbox6.AutoSize = true;
            this.materialCheckbox6.Depth = 0;
            this.materialCheckbox6.Location = new System.Drawing.Point(24, 64);
            this.materialCheckbox6.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox6.Name = "materialCheckbox6";
            this.materialCheckbox6.ReadOnly = false;
            this.materialCheckbox6.Ripple = true;
            this.materialCheckbox6.Size = new System.Drawing.Size(171, 37);
            this.materialCheckbox6.TabIndex = 16;
            this.materialCheckbox6.Text = "materialCheckbox6";
            this.materialCheckbox6.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(24, 129);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(171, 37);
            this.materialCheckbox1.TabIndex = 17;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(24, 193);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(171, 37);
            this.materialCheckbox2.TabIndex = 18;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.AutoSize = true;
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(24, 259);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(171, 37);
            this.materialCheckbox3.TabIndex = 19;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.AutoSize = true;
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(24, 324);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.ReadOnly = false;
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(171, 37);
            this.materialCheckbox4.TabIndex = 20;
            this.materialCheckbox4.Text = "materialCheckbox4";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // mepSendJustNotice
            // 
            this.mepSendJustNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepSendJustNotice.CancelButtonText = "";
            this.mepSendJustNotice.Controls.Add(this.materialCheckbox4);
            this.mepSendJustNotice.Controls.Add(this.materialCheckbox3);
            this.mepSendJustNotice.Controls.Add(this.materialCheckbox6);
            this.mepSendJustNotice.Controls.Add(this.materialCheckbox2);
            this.mepSendJustNotice.Controls.Add(this.materialCheckbox1);
            this.mepSendJustNotice.Depth = 0;
            this.mepSendJustNotice.ExpandHeight = 414;
            this.mepSendJustNotice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepSendJustNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepSendJustNotice.Location = new System.Drawing.Point(1053, 36);
            this.mepSendJustNotice.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.mepSendJustNotice.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepSendJustNotice.Name = "mepSendJustNotice";
            this.mepSendJustNotice.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepSendJustNotice.Size = new System.Drawing.Size(361, 414);
            this.mepSendJustNotice.TabIndex = 21;
            this.mepSendJustNotice.ValidationButtonText = "mandar correo";
            // 
            // mltbEmailPreview
            // 
            this.mltbEmailPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mltbEmailPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mltbEmailPreview.Depth = 0;
            this.mltbEmailPreview.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mltbEmailPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mltbEmailPreview.Location = new System.Drawing.Point(35, 351);
            this.mltbEmailPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.mltbEmailPreview.Name = "mltbEmailPreview";
            this.mltbEmailPreview.Size = new System.Drawing.Size(1364, 403);
            this.mltbEmailPreview.TabIndex = 22;
            this.mltbEmailPreview.Text = resources.GetString("mltbEmailPreview.Text");
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 1010);
            this.Controls.Add(this.mtcMenu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mtcMenu;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.mtcMenu.ResumeLayout(false);
            this.ConfirmJust.ResumeLayout(false);
            this.mepJustDetails.ResumeLayout(false);
            this.mepJustDetails.PerformLayout();
            this.CrearPet.ResumeLayout(false);
            this.mepFindStudent.ResumeLayout(false);
            this.mepFindStudent.PerformLayout();
            this.mepCreateUser.ResumeLayout(false);
            this.mepCreateUser.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.mepAddProfessor.ResumeLayout(false);
            this.mepAddProfessor.PerformLayout();
            this.mepSendJustNotice.ResumeLayout(false);
            this.mepSendJustNotice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ImagenesDeMenu;
        private MaterialSkin.Controls.MaterialTabControl mtcMenu;
        private System.Windows.Forms.TabPage ConfirmJust;
        private System.Windows.Forms.TabPage CrearPet;
        private MaterialSkin.Controls.MaterialExpansionPanel mepJustDetails;
        private MaterialSkin.Controls.MaterialListView lvPetitions;
        private MaterialSkin.Controls.MaterialTextBox tbDate;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private MaterialSkin.Controls.MaterialTextBox tbClass;
        private MaterialSkin.Controls.MaterialLabel lblClass;
        private MaterialSkin.Controls.MaterialTextBox tbCif;
        private MaterialSkin.Controls.MaterialLabel lblCif;
        private MaterialSkin.Controls.MaterialTextBox tbName;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mlblEmailPreview;
        private MaterialSkin.Controls.MaterialExpansionPanel mepCreateUser;
        private MaterialSkin.Controls.MaterialExpansionPanel mepFindStudent;
        private MaterialSkin.Controls.MaterialTextBox2 tbUserCif;
        private MaterialSkin.Controls.MaterialTextBox2 tbStudentName;
        private MaterialSkin.Controls.MaterialTextBox2 tbCifEntry;
        private MaterialSkin.Controls.MaterialLabel lblBirthDate;
        private MaterialSkin.Controls.MaterialButton btnAddClass;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialComboBox cbClass;
        private MaterialSkin.Controls.MaterialListView lvStudentsList;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialExpansionPanel mepAddProfessor;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialTextBox2 tbUsername;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox23;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialExpansionPanel mepSendJustNotice;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox6;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mltbEmailPreview;
    }
}