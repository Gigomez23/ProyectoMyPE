﻿namespace ProyectoMarjorie.forms
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
            this.mepImg = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.pbJustImg = new System.Windows.Forms.PictureBox();
            this.lblImage = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lbPetList = new MaterialSkin.Controls.MaterialLabel();
            this.dgvPetList = new System.Windows.Forms.DataGridView();
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
            this.mepRejectedPet = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.mltbReasonForRejection = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tbDateRejected = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbClassRejected = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tbCifRejected = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbNameRejected = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.CrearPet = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lblStudenInfo = new MaterialSkin.Controls.MaterialLabel();
            this.tbUsername = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbCifSendPet = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.dtpPetDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDateSend = new MaterialSkin.Controls.MaterialLabel();
            this.mepSendJustNotice = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.cbJustDateCompletion = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbProfessorEmailCompletion = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbName = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbProfessorName = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbCifCompletion = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.mepAddProfessor = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.btnAddOtherProfessor = new MaterialSkin.Controls.MaterialButton();
            this.tbProfessorEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbProfessorName = new MaterialSkin.Controls.MaterialTextBox2();
            this.mltbEmailPreview = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.mepCreateUser = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.tbPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtpStudentBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new MaterialSkin.Controls.MaterialLabel();
            this.tbUserCif = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbStudentName = new MaterialSkin.Controls.MaterialTextBox2();
            this.mepFindStudent = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.lblStudenList = new MaterialSkin.Controls.MaterialLabel();
            this.cbStudentClasses = new System.Windows.Forms.CheckedListBox();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.lblSelectClass = new MaterialSkin.Controls.MaterialLabel();
            this.materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.pbManualImg = new System.Windows.Forms.PictureBox();
            this.btnSearchImg = new MaterialSkin.Controls.MaterialButton();
            this.cbUploadImg = new MaterialSkin.Controls.MaterialCheckbox();
            this.mtcMenu.SuspendLayout();
            this.ConfirmJust.SuspendLayout();
            this.mepImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJustImg)).BeginInit();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetList)).BeginInit();
            this.mepJustDetails.SuspendLayout();
            this.mepRejectedPet.SuspendLayout();
            this.CrearPet.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.mepSendJustNotice.SuspendLayout();
            this.mepAddProfessor.SuspendLayout();
            this.mepCreateUser.SuspendLayout();
            this.mepFindStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.materialExpansionPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManualImg)).BeginInit();
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
            this.ImagenesDeMenu.Images.SetKeyName(5, "view-stroke-rounded.png");
            // 
            // mtcMenu
            // 
            this.mtcMenu.Controls.Add(this.ConfirmJust);
            this.mtcMenu.Controls.Add(this.CrearPet);
            this.mtcMenu.Depth = 0;
            this.mtcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcMenu.HotTrack = true;
            this.mtcMenu.ImageList = this.ImagenesDeMenu;
            this.mtcMenu.Location = new System.Drawing.Point(3, 64);
            this.mtcMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtcMenu.Multiline = true;
            this.mtcMenu.Name = "mtcMenu";
            this.mtcMenu.SelectedIndex = 0;
            this.mtcMenu.ShowToolTips = true;
            this.mtcMenu.Size = new System.Drawing.Size(1445, 932);
            this.mtcMenu.TabIndex = 0;
            // 
            // ConfirmJust
            // 
            this.ConfirmJust.Controls.Add(this.mepImg);
            this.ConfirmJust.Controls.Add(this.materialCard3);
            this.ConfirmJust.Controls.Add(this.mepJustDetails);
            this.ConfirmJust.Controls.Add(this.mepRejectedPet);
            this.ConfirmJust.ImageKey = "Aprobar.png";
            this.ConfirmJust.Location = new System.Drawing.Point(4, 39);
            this.ConfirmJust.Name = "ConfirmJust";
            this.ConfirmJust.Padding = new System.Windows.Forms.Padding(3);
            this.ConfirmJust.Size = new System.Drawing.Size(1437, 889);
            this.ConfirmJust.TabIndex = 0;
            this.ConfirmJust.Text = "Confirmar Justificaciónes";
            this.ConfirmJust.ToolTipText = "Confirmar Justificaciónes de estudiantes.";
            this.ConfirmJust.UseVisualStyleBackColor = true;
            this.ConfirmJust.Click += new System.EventHandler(this.ConfirmJust_Click);
            // 
            // mepImg
            // 
            this.mepImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mepImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepImg.CancelButtonText = "";
            this.mepImg.Collapse = true;
            this.mepImg.Controls.Add(this.pbJustImg);
            this.mepImg.Controls.Add(this.lblImage);
            this.mepImg.Depth = 0;
            this.mepImg.Description = "Ver imagen de constancia";
            this.mepImg.ExpandHeight = 656;
            this.mepImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepImg.Location = new System.Drawing.Point(653, 30);
            this.mepImg.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.mepImg.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepImg.Name = "mepImg";
            this.mepImg.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepImg.Size = new System.Drawing.Size(703, 48);
            this.mepImg.TabIndex = 11;
            this.mepImg.Title = "Constancia";
            this.mepImg.ValidationButtonEnable = true;
            this.mepImg.ValidationButtonText = "";
            // 
            // pbJustImg
            // 
            this.pbJustImg.Location = new System.Drawing.Point(69, 148);
            this.pbJustImg.Name = "pbJustImg";
            this.pbJustImg.Size = new System.Drawing.Size(561, 407);
            this.pbJustImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbJustImg.TabIndex = 3;
            this.pbJustImg.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Depth = 0;
            this.lblImage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImage.Location = new System.Drawing.Point(66, 99);
            this.lblImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(163, 19);
            this.lblImage.TabIndex = 2;
            this.lblImage.Text = "Imagen de Constancia:";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.lbPetList);
            this.materialCard3.Controls.Add(this.dgvPetList);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(17, 30);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(595, 721);
            this.materialCard3.TabIndex = 4;
            // 
            // lbPetList
            // 
            this.lbPetList.Depth = 0;
            this.lbPetList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPetList.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbPetList.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbPetList.Location = new System.Drawing.Point(14, 14);
            this.lbPetList.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPetList.Name = "lbPetList";
            this.lbPetList.Size = new System.Drawing.Size(567, 31);
            this.lbPetList.TabIndex = 8;
            this.lbPetList.Text = "Peticiones de Estudiantes:";
            // 
            // dgvPetList
            // 
            this.dgvPetList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPetList.Location = new System.Drawing.Point(17, 80);
            this.dgvPetList.Name = "dgvPetList";
            this.dgvPetList.Size = new System.Drawing.Size(561, 591);
            this.dgvPetList.TabIndex = 3;
            this.dgvPetList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPetList_CellClick);
            // 
            // mepJustDetails
            // 
            this.mepJustDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mepJustDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepJustDetails.CancelButtonText = "rechazar";
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
            this.mepJustDetails.ExpandHeight = 653;
            this.mepJustDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepJustDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepJustDetails.Location = new System.Drawing.Point(653, 98);
            this.mepJustDetails.Margin = new System.Windows.Forms.Padding(16);
            this.mepJustDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepJustDetails.Name = "mepJustDetails";
            this.mepJustDetails.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepJustDetails.Size = new System.Drawing.Size(703, 653);
            this.mepJustDetails.TabIndex = 1;
            this.mepJustDetails.Title = "Detalles";
            this.mepJustDetails.ValidationButtonEnable = true;
            this.mepJustDetails.ValidationButtonText = "Aprobar";
            this.mepJustDetails.SaveClick += new System.EventHandler(this.mepJustDetails_SaveClick);
            this.mepJustDetails.CancelClick += new System.EventHandler(this.mepJustDetails_CancelClick);
            // 
            // mlblEmailPreview
            // 
            this.mlblEmailPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlblEmailPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mlblEmailPreview.Depth = 0;
            this.mlblEmailPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblEmailPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblEmailPreview.Location = new System.Drawing.Point(70, 389);
            this.mlblEmailPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblEmailPreview.Name = "mlblEmailPreview";
            this.mlblEmailPreview.Size = new System.Drawing.Size(561, 178);
            this.mlblEmailPreview.TabIndex = 10;
            this.mlblEmailPreview.Text = "";
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
            this.tbName.BackColor = System.Drawing.SystemColors.MenuHighlight;
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
            // mepRejectedPet
            // 
            this.mepRejectedPet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mepRejectedPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepRejectedPet.CancelButtonText = "CANCELAR";
            this.mepRejectedPet.Collapse = true;
            this.mepRejectedPet.Controls.Add(this.mltbReasonForRejection);
            this.mepRejectedPet.Controls.Add(this.tbDateRejected);
            this.mepRejectedPet.Controls.Add(this.materialLabel1);
            this.mepRejectedPet.Controls.Add(this.tbClassRejected);
            this.mepRejectedPet.Controls.Add(this.materialLabel2);
            this.mepRejectedPet.Controls.Add(this.tbCifRejected);
            this.mepRejectedPet.Controls.Add(this.materialLabel3);
            this.mepRejectedPet.Controls.Add(this.tbNameRejected);
            this.mepRejectedPet.Controls.Add(this.materialLabel4);
            this.mepRejectedPet.Depth = 0;
            this.mepRejectedPet.Description = "Especifique por que no es valida la justificación.";
            this.mepRejectedPet.ExpandHeight = 656;
            this.mepRejectedPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepRejectedPet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepRejectedPet.Location = new System.Drawing.Point(653, 163);
            this.mepRejectedPet.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.mepRejectedPet.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepRejectedPet.Name = "mepRejectedPet";
            this.mepRejectedPet.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepRejectedPet.Size = new System.Drawing.Size(703, 48);
            this.mepRejectedPet.TabIndex = 2;
            this.mepRejectedPet.Title = "Detalles";
            this.mepRejectedPet.ValidationButtonEnable = true;
            this.mepRejectedPet.ValidationButtonText = "Enviar";
            this.mepRejectedPet.CancelClick += new System.EventHandler(this.mepRejectedPet_CancelClick);
            // 
            // mltbReasonForRejection
            // 
            this.mltbReasonForRejection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mltbReasonForRejection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mltbReasonForRejection.Depth = 0;
            this.mltbReasonForRejection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mltbReasonForRejection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mltbReasonForRejection.Location = new System.Drawing.Point(69, 390);
            this.mltbReasonForRejection.MouseState = MaterialSkin.MouseState.HOVER;
            this.mltbReasonForRejection.Name = "mltbReasonForRejection";
            this.mltbReasonForRejection.Size = new System.Drawing.Size(561, 178);
            this.mltbReasonForRejection.TabIndex = 10;
            this.mltbReasonForRejection.Text = "La razón por la que su constancia no es aceptable:";
            // 
            // tbDateRejected
            // 
            this.tbDateRejected.AnimateReadOnly = false;
            this.tbDateRejected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDateRejected.Depth = 0;
            this.tbDateRejected.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDateRejected.LeadingIcon = null;
            this.tbDateRejected.Location = new System.Drawing.Point(202, 308);
            this.tbDateRejected.MaxLength = 50;
            this.tbDateRejected.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDateRejected.Multiline = false;
            this.tbDateRejected.Name = "tbDateRejected";
            this.tbDateRejected.Size = new System.Drawing.Size(333, 50);
            this.tbDateRejected.TabIndex = 9;
            this.tbDateRejected.Text = "";
            this.tbDateRejected.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(66, 327);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(48, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Fecha:";
            // 
            // tbClassRejected
            // 
            this.tbClassRejected.AnimateReadOnly = false;
            this.tbClassRejected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbClassRejected.Depth = 0;
            this.tbClassRejected.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbClassRejected.LeadingIcon = null;
            this.tbClassRejected.Location = new System.Drawing.Point(202, 230);
            this.tbClassRejected.MaxLength = 50;
            this.tbClassRejected.MouseState = MaterialSkin.MouseState.OUT;
            this.tbClassRejected.Multiline = false;
            this.tbClassRejected.Name = "tbClassRejected";
            this.tbClassRejected.Size = new System.Drawing.Size(333, 50);
            this.tbClassRejected.TabIndex = 7;
            this.tbClassRejected.Text = "";
            this.tbClassRejected.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(66, 249);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Clase: ";
            // 
            // tbCifRejected
            // 
            this.tbCifRejected.AnimateReadOnly = false;
            this.tbCifRejected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCifRejected.Depth = 0;
            this.tbCifRejected.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCifRejected.LeadingIcon = null;
            this.tbCifRejected.Location = new System.Drawing.Point(202, 160);
            this.tbCifRejected.MaxLength = 50;
            this.tbCifRejected.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCifRejected.Multiline = false;
            this.tbCifRejected.Name = "tbCifRejected";
            this.tbCifRejected.Size = new System.Drawing.Size(333, 50);
            this.tbCifRejected.TabIndex = 5;
            this.tbCifRejected.Text = "";
            this.tbCifRejected.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(66, 179);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(28, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "CIF:";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbNameRejected
            // 
            this.tbNameRejected.AnimateReadOnly = false;
            this.tbNameRejected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNameRejected.Depth = 0;
            this.tbNameRejected.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNameRejected.LeadingIcon = null;
            this.tbNameRejected.Location = new System.Drawing.Point(202, 80);
            this.tbNameRejected.MaxLength = 50;
            this.tbNameRejected.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNameRejected.Multiline = false;
            this.tbNameRejected.Name = "tbNameRejected";
            this.tbNameRejected.Size = new System.Drawing.Size(333, 50);
            this.tbNameRejected.TabIndex = 3;
            this.tbNameRejected.Text = "";
            this.tbNameRejected.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(66, 99);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(61, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Nombre:";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.CrearPet.Size = new System.Drawing.Size(1437, 889);
            this.CrearPet.TabIndex = 1;
            this.CrearPet.Text = "Crear Petición";
            this.CrearPet.ToolTipText = "Crear la petición del estudiante. ";
            this.CrearPet.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.AutoSize = true;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard1.Controls.Add(this.mepAddProfessor);
            this.materialCard1.Controls.Add(this.materialExpansionPanel1);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.mepSendJustNotice);
            this.materialCard1.Controls.Add(this.materialDrawer1);
            this.materialCard1.Controls.Add(this.mltbEmailPreview);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 99);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1431, 787);
            this.materialCard1.TabIndex = 3;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblStudenInfo);
            this.materialCard2.Controls.Add(this.tbUsername);
            this.materialCard2.Controls.Add(this.tbCifSendPet);
            this.materialCard2.Controls.Add(this.btnAdd);
            this.materialCard2.Controls.Add(this.dtpPetDate);
            this.materialCard2.Controls.Add(this.lblBirthDateSend);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 36);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(426, 371);
            this.materialCard2.TabIndex = 23;
            // 
            // lblStudenInfo
            // 
            this.lblStudenInfo.Depth = 0;
            this.lblStudenInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStudenInfo.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblStudenInfo.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblStudenInfo.Location = new System.Drawing.Point(14, 14);
            this.lblStudenInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStudenInfo.Name = "lblStudenInfo";
            this.lblStudenInfo.Size = new System.Drawing.Size(398, 31);
            this.lblStudenInfo.TabIndex = 8;
            this.lblStudenInfo.Text = "Datos de Estudiante:";
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
            this.tbUsername.Hint = "Nombre:";
            this.tbUsername.LeadingIcon = null;
            this.tbUsername.LeaveOnEnterKey = true;
            this.tbUsername.Location = new System.Drawing.Point(40, 82);
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
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // tbCifSendPet
            // 
            this.tbCifSendPet.AnimateReadOnly = false;
            this.tbCifSendPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCifSendPet.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCifSendPet.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCifSendPet.Depth = 0;
            this.tbCifSendPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCifSendPet.HideSelection = true;
            this.tbCifSendPet.Hint = "Cif:";
            this.tbCifSendPet.LeadingIcon = null;
            this.tbCifSendPet.LeaveOnEnterKey = true;
            this.tbCifSendPet.Location = new System.Drawing.Point(40, 164);
            this.tbCifSendPet.MaxLength = 32767;
            this.tbCifSendPet.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCifSendPet.Name = "tbCifSendPet";
            this.tbCifSendPet.PasswordChar = '\0';
            this.tbCifSendPet.PrefixSuffixText = null;
            this.tbCifSendPet.ReadOnly = false;
            this.tbCifSendPet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCifSendPet.SelectedText = "";
            this.tbCifSendPet.SelectionLength = 0;
            this.tbCifSendPet.SelectionStart = 0;
            this.tbCifSendPet.ShortcutsEnabled = true;
            this.tbCifSendPet.Size = new System.Drawing.Size(342, 48);
            this.tbCifSendPet.TabIndex = 3;
            this.tbCifSendPet.TabStop = false;
            this.tbCifSendPet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCifSendPet.TrailingIcon = null;
            this.tbCifSendPet.UseSystemPasswordChar = false;
            this.tbCifSendPet.TextChanged += new System.EventHandler(this.tbCifSendPet_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.Enabled = false;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(224, 303);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(158, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpPetDate
            // 
            this.dtpPetDate.Location = new System.Drawing.Point(182, 245);
            this.dtpPetDate.Name = "dtpPetDate";
            this.dtpPetDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPetDate.TabIndex = 7;
            this.dtpPetDate.ValueChanged += new System.EventHandler(this.dtpStudenBirthDate_ValueChanged);
            // 
            // lblBirthDateSend
            // 
            this.lblBirthDateSend.AutoSize = true;
            this.lblBirthDateSend.Depth = 0;
            this.lblBirthDateSend.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBirthDateSend.Location = new System.Drawing.Point(37, 245);
            this.lblBirthDateSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBirthDateSend.Name = "lblBirthDateSend";
            this.lblBirthDateSend.Size = new System.Drawing.Size(109, 19);
            this.lblBirthDateSend.TabIndex = 6;
            this.lblBirthDateSend.Text = "Fecha de Falta:";
            // 
            // mepSendJustNotice
            // 
            this.mepSendJustNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepSendJustNotice.CancelButtonText = "";
            this.mepSendJustNotice.Controls.Add(this.cbUploadImg);
            this.mepSendJustNotice.Controls.Add(this.cbJustDateCompletion);
            this.mepSendJustNotice.Controls.Add(this.cbProfessorEmailCompletion);
            this.mepSendJustNotice.Controls.Add(this.cbName);
            this.mepSendJustNotice.Controls.Add(this.cbProfessorName);
            this.mepSendJustNotice.Controls.Add(this.cbCifCompletion);
            this.mepSendJustNotice.Depth = 0;
            this.mepSendJustNotice.Description = "";
            this.mepSendJustNotice.ExpandHeight = 371;
            this.mepSendJustNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepSendJustNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepSendJustNotice.Location = new System.Drawing.Point(1029, 36);
            this.mepSendJustNotice.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.mepSendJustNotice.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepSendJustNotice.Name = "mepSendJustNotice";
            this.mepSendJustNotice.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepSendJustNotice.Size = new System.Drawing.Size(368, 371);
            this.mepSendJustNotice.TabIndex = 21;
            this.mepSendJustNotice.Title = "Lista de Campos Completados";
            this.mepSendJustNotice.ValidationButtonText = "mandar correo";
            this.mepSendJustNotice.SaveClick += new System.EventHandler(this.mepSendJustNotice_SaveClick);
            // 
            // cbJustDateCompletion
            // 
            this.cbJustDateCompletion.AutoSize = true;
            this.cbJustDateCompletion.Depth = 0;
            this.cbJustDateCompletion.Location = new System.Drawing.Point(24, 212);
            this.cbJustDateCompletion.Margin = new System.Windows.Forms.Padding(0);
            this.cbJustDateCompletion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbJustDateCompletion.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbJustDateCompletion.Name = "cbJustDateCompletion";
            this.cbJustDateCompletion.ReadOnly = true;
            this.cbJustDateCompletion.Ripple = true;
            this.cbJustDateCompletion.Size = new System.Drawing.Size(136, 37);
            this.cbJustDateCompletion.TabIndex = 20;
            this.cbJustDateCompletion.Text = "Fecha de falta";
            this.cbJustDateCompletion.UseVisualStyleBackColor = true;
            this.cbJustDateCompletion.CheckedChanged += new System.EventHandler(this.cbJustDateCompletion_CheckedChanged);
            // 
            // cbProfessorEmailCompletion
            // 
            this.cbProfessorEmailCompletion.AutoSize = true;
            this.cbProfessorEmailCompletion.Depth = 0;
            this.cbProfessorEmailCompletion.Location = new System.Drawing.Point(24, 175);
            this.cbProfessorEmailCompletion.Margin = new System.Windows.Forms.Padding(0);
            this.cbProfessorEmailCompletion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbProfessorEmailCompletion.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbProfessorEmailCompletion.Name = "cbProfessorEmailCompletion";
            this.cbProfessorEmailCompletion.ReadOnly = true;
            this.cbProfessorEmailCompletion.Ripple = true;
            this.cbProfessorEmailCompletion.Size = new System.Drawing.Size(170, 37);
            this.cbProfessorEmailCompletion.TabIndex = 19;
            this.cbProfessorEmailCompletion.Text = "Correo del Profesor";
            this.cbProfessorEmailCompletion.UseVisualStyleBackColor = true;
            this.cbProfessorEmailCompletion.CheckedChanged += new System.EventHandler(this.cbProfessorEmailCompletion_CheckedChanged);
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Depth = 0;
            this.cbName.Location = new System.Drawing.Point(24, 64);
            this.cbName.Margin = new System.Windows.Forms.Padding(0);
            this.cbName.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbName.Name = "cbName";
            this.cbName.ReadOnly = true;
            this.cbName.Ripple = true;
            this.cbName.Size = new System.Drawing.Size(190, 37);
            this.cbName.TabIndex = 16;
            this.cbName.Text = "Nombre de estudiante";
            this.cbName.UseVisualStyleBackColor = true;
            this.cbName.CheckedChanged += new System.EventHandler(this.cbName_CheckedChanged);
            // 
            // cbProfessorName
            // 
            this.cbProfessorName.AutoSize = true;
            this.cbProfessorName.Depth = 0;
            this.cbProfessorName.Location = new System.Drawing.Point(24, 138);
            this.cbProfessorName.Margin = new System.Windows.Forms.Padding(0);
            this.cbProfessorName.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbProfessorName.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbProfessorName.Name = "cbProfessorName";
            this.cbProfessorName.ReadOnly = true;
            this.cbProfessorName.Ripple = true;
            this.cbProfessorName.Size = new System.Drawing.Size(176, 37);
            this.cbProfessorName.TabIndex = 18;
            this.cbProfessorName.Text = "Nombre de Profesor";
            this.cbProfessorName.UseVisualStyleBackColor = true;
            this.cbProfessorName.CheckedChanged += new System.EventHandler(this.cbProfessorName_CheckedChanged);
            // 
            // cbCifCompletion
            // 
            this.cbCifCompletion.AutoSize = true;
            this.cbCifCompletion.Depth = 0;
            this.cbCifCompletion.Location = new System.Drawing.Point(24, 101);
            this.cbCifCompletion.Margin = new System.Windows.Forms.Padding(0);
            this.cbCifCompletion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbCifCompletion.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbCifCompletion.Name = "cbCifCompletion";
            this.cbCifCompletion.ReadOnly = true;
            this.cbCifCompletion.Ripple = true;
            this.cbCifCompletion.Size = new System.Drawing.Size(158, 37);
            this.cbCifCompletion.TabIndex = 17;
            this.cbCifCompletion.Text = "Cif del estudiante";
            this.cbCifCompletion.UseVisualStyleBackColor = true;
            this.cbCifCompletion.CheckedChanged += new System.EventHandler(this.cbCifCompletion_CheckedChanged);
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
            // mepAddProfessor
            // 
            this.mepAddProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepAddProfessor.CancelButtonText = "CANCELar";
            this.mepAddProfessor.Controls.Add(this.btnAddOtherProfessor);
            this.mepAddProfessor.Controls.Add(this.tbProfessorEmail);
            this.mepAddProfessor.Controls.Add(this.tbProfessorName);
            this.mepAddProfessor.Depth = 0;
            this.mepAddProfessor.Description = "Agregar el nombre y correo del profesor";
            this.mepAddProfessor.ExpandHeight = 371;
            this.mepAddProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepAddProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepAddProfessor.Location = new System.Drawing.Point(476, 36);
            this.mepAddProfessor.Margin = new System.Windows.Forms.Padding(16);
            this.mepAddProfessor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepAddProfessor.Name = "mepAddProfessor";
            this.mepAddProfessor.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepAddProfessor.Size = new System.Drawing.Size(523, 371);
            this.mepAddProfessor.TabIndex = 4;
            this.mepAddProfessor.Title = "Agregar Profesor";
            this.mepAddProfessor.ValidationButtonText = "Agregar";
            this.mepAddProfessor.SaveClick += new System.EventHandler(this.mepAddProfessor_SaveClick);
            this.mepAddProfessor.CancelClick += new System.EventHandler(this.mepAddProfessor_CancelClick);
            // 
            // btnAddOtherProfessor
            // 
            this.btnAddOtherProfessor.AutoSize = false;
            this.btnAddOtherProfessor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddOtherProfessor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddOtherProfessor.Depth = 0;
            this.btnAddOtherProfessor.Enabled = false;
            this.btnAddOtherProfessor.HighEmphasis = true;
            this.btnAddOtherProfessor.Icon = null;
            this.btnAddOtherProfessor.Location = new System.Drawing.Point(211, 244);
            this.btnAddOtherProfessor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddOtherProfessor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddOtherProfessor.Name = "btnAddOtherProfessor";
            this.btnAddOtherProfessor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddOtherProfessor.Size = new System.Drawing.Size(158, 46);
            this.btnAddOtherProfessor.TabIndex = 7;
            this.btnAddOtherProfessor.Text = "Agregar otro profesor";
            this.btnAddOtherProfessor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddOtherProfessor.UseAccentColor = false;
            this.btnAddOtherProfessor.UseVisualStyleBackColor = true;
            this.btnAddOtherProfessor.Click += new System.EventHandler(this.btnAddOtherProfessor_Click);
            // 
            // tbProfessorEmail
            // 
            this.tbProfessorEmail.AnimateReadOnly = false;
            this.tbProfessorEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbProfessorEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbProfessorEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbProfessorEmail.Depth = 0;
            this.tbProfessorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbProfessorEmail.HideSelection = true;
            this.tbProfessorEmail.Hint = "Correo: ";
            this.tbProfessorEmail.LeadingIcon = null;
            this.tbProfessorEmail.LeaveOnEnterKey = true;
            this.tbProfessorEmail.Location = new System.Drawing.Point(27, 157);
            this.tbProfessorEmail.MaxLength = 32767;
            this.tbProfessorEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.tbProfessorEmail.Name = "tbProfessorEmail";
            this.tbProfessorEmail.PasswordChar = '\0';
            this.tbProfessorEmail.PrefixSuffixText = null;
            this.tbProfessorEmail.ReadOnly = false;
            this.tbProfessorEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbProfessorEmail.SelectedText = "";
            this.tbProfessorEmail.SelectionLength = 0;
            this.tbProfessorEmail.SelectionStart = 0;
            this.tbProfessorEmail.ShortcutsEnabled = true;
            this.tbProfessorEmail.Size = new System.Drawing.Size(342, 48);
            this.tbProfessorEmail.TabIndex = 6;
            this.tbProfessorEmail.TabStop = false;
            this.tbProfessorEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbProfessorEmail.TrailingIcon = null;
            this.tbProfessorEmail.UseSystemPasswordChar = false;
            this.tbProfessorEmail.TextChanged += new System.EventHandler(this.tbProfessorEmail_TextChanged);
            // 
            // tbProfessorName
            // 
            this.tbProfessorName.AnimateReadOnly = false;
            this.tbProfessorName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbProfessorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbProfessorName.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbProfessorName.Depth = 0;
            this.tbProfessorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbProfessorName.HideSelection = true;
            this.tbProfessorName.Hint = "Nombre del Profesor/a:";
            this.tbProfessorName.LeadingIcon = null;
            this.tbProfessorName.LeaveOnEnterKey = true;
            this.tbProfessorName.Location = new System.Drawing.Point(27, 82);
            this.tbProfessorName.MaxLength = 32767;
            this.tbProfessorName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbProfessorName.Name = "tbProfessorName";
            this.tbProfessorName.PasswordChar = '\0';
            this.tbProfessorName.PrefixSuffixText = null;
            this.tbProfessorName.ReadOnly = false;
            this.tbProfessorName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbProfessorName.SelectedText = "";
            this.tbProfessorName.SelectionLength = 0;
            this.tbProfessorName.SelectionStart = 0;
            this.tbProfessorName.ShortcutsEnabled = true;
            this.tbProfessorName.Size = new System.Drawing.Size(342, 48);
            this.tbProfessorName.TabIndex = 5;
            this.tbProfessorName.TabStop = false;
            this.tbProfessorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbProfessorName.TrailingIcon = null;
            this.tbProfessorName.UseSystemPasswordChar = false;
            this.tbProfessorName.TextChanged += new System.EventHandler(this.tbProfessorName_TextChanged);
            // 
            // mltbEmailPreview
            // 
            this.mltbEmailPreview.AcceptsTab = true;
            this.mltbEmailPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mltbEmailPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mltbEmailPreview.Depth = 0;
            this.mltbEmailPreview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mltbEmailPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mltbEmailPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mltbEmailPreview.Location = new System.Drawing.Point(14, 441);
            this.mltbEmailPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.mltbEmailPreview.Name = "mltbEmailPreview";
            this.mltbEmailPreview.Size = new System.Drawing.Size(1401, 330);
            this.mltbEmailPreview.TabIndex = 22;
            this.mltbEmailPreview.Text = resources.GetString("mltbEmailPreview.Text");
            // 
            // mepCreateUser
            // 
            this.mepCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepCreateUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mepCreateUser.CancelButtonText = "CANCELar";
            this.mepCreateUser.Collapse = true;
            this.mepCreateUser.Controls.Add(this.tbPassword);
            this.mepCreateUser.Controls.Add(this.dtpStudentBirthDate);
            this.mepCreateUser.Controls.Add(this.lblBirthDate);
            this.mepCreateUser.Controls.Add(this.tbUserCif);
            this.mepCreateUser.Controls.Add(this.tbStudentName);
            this.mepCreateUser.Depth = 0;
            this.mepCreateUser.Description = "Crear usuario para el estudiante";
            this.mepCreateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.mepCreateUser.ExpandHeight = 460;
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
            this.mepCreateUser.UseAccentColor = true;
            this.mepCreateUser.ValidationButtonText = "Crear";
            this.mepCreateUser.SaveClick += new System.EventHandler(this.mepCreateUser_SaveClick);
            // 
            // tbPassword
            // 
            this.tbPassword.AnimateReadOnly = false;
            this.tbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPassword.Depth = 0;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.HelperText = "adsf";
            this.tbPassword.HideSelection = true;
            this.tbPassword.Hint = "Contraseña:";
            this.tbPassword.LeadingIcon = null;
            this.tbPassword.LeaveOnEnterKey = true;
            this.tbPassword.Location = new System.Drawing.Point(76, 258);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.PrefixSuffixText = null;
            this.tbPassword.ReadOnly = false;
            this.tbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(394, 48);
            this.tbPassword.TabIndex = 11;
            this.tbPassword.TabStop = false;
            this.tbPassword.Tag = "";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TrailingIcon = null;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // dtpStudentBirthDate
            // 
            this.dtpStudentBirthDate.Location = new System.Drawing.Point(265, 337);
            this.dtpStudentBirthDate.Name = "dtpStudentBirthDate";
            this.dtpStudentBirthDate.Size = new System.Drawing.Size(200, 23);
            this.dtpStudentBirthDate.TabIndex = 5;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Depth = 0;
            this.lblBirthDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBirthDate.Location = new System.Drawing.Point(73, 339);
            this.lblBirthDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(154, 19);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Fecha de Nacimiento:";
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
            this.tbUserCif.TextChanged += new System.EventHandler(this.tbUserCif_TextChanged);
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
            this.tbStudentName.TextChanged += new System.EventHandler(this.tbStudentName_TextChanged);
            // 
            // mepFindStudent
            // 
            this.mepFindStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mepFindStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mepFindStudent.CancelButtonText = "CANCELar";
            this.mepFindStudent.Collapse = true;
            this.mepFindStudent.Controls.Add(this.lblStudenList);
            this.mepFindStudent.Controls.Add(this.cbStudentClasses);
            this.mepFindStudent.Controls.Add(this.dgvStudentList);
            this.mepFindStudent.Controls.Add(this.lblSelectClass);
            this.mepFindStudent.Depth = 0;
            this.mepFindStudent.Description = "Buscar estudiante en la base de datos.";
            this.mepFindStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.mepFindStudent.ExpandHeight = 656;
            this.mepFindStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepFindStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepFindStudent.Location = new System.Drawing.Point(3, 3);
            this.mepFindStudent.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.mepFindStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepFindStudent.Name = "mepFindStudent";
            this.mepFindStudent.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepFindStudent.Size = new System.Drawing.Size(1431, 48);
            this.mepFindStudent.TabIndex = 0;
            this.mepFindStudent.Title = "Buscar Estudiante";
            this.mepFindStudent.UseAccentColor = true;
            this.mepFindStudent.ValidationButtonText = "Importar datos";
            // 
            // lblStudenList
            // 
            this.lblStudenList.AutoSize = true;
            this.lblStudenList.Depth = 0;
            this.lblStudenList.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStudenList.Location = new System.Drawing.Point(76, 129);
            this.lblStudenList.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStudenList.Name = "lblStudenList";
            this.lblStudenList.Size = new System.Drawing.Size(187, 19);
            this.lblStudenList.TabIndex = 11;
            this.lblStudenList.Text = "Seleccionar un estudiante:";
            // 
            // cbStudentClasses
            // 
            this.cbStudentClasses.FormattingEnabled = true;
            this.cbStudentClasses.Location = new System.Drawing.Point(655, 181);
            this.cbStudentClasses.Name = "cbStudentClasses";
            this.cbStudentClasses.Size = new System.Drawing.Size(422, 328);
            this.cbStudentClasses.TabIndex = 10;
            this.cbStudentClasses.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbStudentClasses_ItemCheck);
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Location = new System.Drawing.Point(79, 181);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.Size = new System.Drawing.Size(434, 326);
            this.dgvStudentList.TabIndex = 9;
            this.dgvStudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentList_CellClick);
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Depth = 0;
            this.lblSelectClass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelectClass.Location = new System.Drawing.Point(652, 129);
            this.lblSelectClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(157, 19);
            this.lblSelectClass.TabIndex = 8;
            this.lblSelectClass.Text = "Seleccione las Clases:";
            // 
            // materialExpansionPanel1
            // 
            this.materialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel1.CancelButtonText = "";
            this.materialExpansionPanel1.Collapse = true;
            this.materialExpansionPanel1.Controls.Add(this.btnSearchImg);
            this.materialExpansionPanel1.Controls.Add(this.pbManualImg);
            this.materialExpansionPanel1.Depth = 0;
            this.materialExpansionPanel1.Description = "Agregar el nombre y correo del profesor";
            this.materialExpansionPanel1.ExpandHeight = 312;
            this.materialExpansionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel1.Location = new System.Drawing.Point(476, 101);
            this.materialExpansionPanel1.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel1.Name = "materialExpansionPanel1";
            this.materialExpansionPanel1.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel1.Size = new System.Drawing.Size(523, 48);
            this.materialExpansionPanel1.TabIndex = 8;
            this.materialExpansionPanel1.Title = "Agregar Profesor";
            this.materialExpansionPanel1.ValidationButtonText = "Subir";
            this.materialExpansionPanel1.SaveClick += new System.EventHandler(this.materialExpansionPanel1_SaveClick);
            // 
            // pbManualImg
            // 
            this.pbManualImg.Location = new System.Drawing.Point(27, 67);
            this.pbManualImg.Name = "pbManualImg";
            this.pbManualImg.Size = new System.Drawing.Size(342, 168);
            this.pbManualImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbManualImg.TabIndex = 2;
            this.pbManualImg.TabStop = false;
            // 
            // btnSearchImg
            // 
            this.btnSearchImg.AutoSize = false;
            this.btnSearchImg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchImg.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearchImg.Depth = 0;
            this.btnSearchImg.Enabled = false;
            this.btnSearchImg.HighEmphasis = true;
            this.btnSearchImg.Icon = null;
            this.btnSearchImg.Location = new System.Drawing.Point(376, 67);
            this.btnSearchImg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearchImg.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchImg.Name = "btnSearchImg";
            this.btnSearchImg.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearchImg.Size = new System.Drawing.Size(135, 36);
            this.btnSearchImg.TabIndex = 9;
            this.btnSearchImg.Text = "Buscar";
            this.btnSearchImg.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearchImg.UseAccentColor = false;
            this.btnSearchImg.UseVisualStyleBackColor = true;
            this.btnSearchImg.Click += new System.EventHandler(this.btnSearchImg_Click);
            // 
            // cbUploadImg
            // 
            this.cbUploadImg.AutoSize = true;
            this.cbUploadImg.Depth = 0;
            this.cbUploadImg.Location = new System.Drawing.Point(24, 244);
            this.cbUploadImg.Margin = new System.Windows.Forms.Padding(0);
            this.cbUploadImg.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbUploadImg.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbUploadImg.Name = "cbUploadImg";
            this.cbUploadImg.ReadOnly = true;
            this.cbUploadImg.Ripple = true;
            this.cbUploadImg.Size = new System.Drawing.Size(232, 37);
            this.cbUploadImg.TabIndex = 21;
            this.cbUploadImg.Text = "Subir imagen de constancia";
            this.cbUploadImg.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 999);
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
            this.mepImg.ResumeLayout(false);
            this.mepImg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJustImg)).EndInit();
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetList)).EndInit();
            this.mepJustDetails.ResumeLayout(false);
            this.mepJustDetails.PerformLayout();
            this.mepRejectedPet.ResumeLayout(false);
            this.mepRejectedPet.PerformLayout();
            this.CrearPet.ResumeLayout(false);
            this.CrearPet.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.mepSendJustNotice.ResumeLayout(false);
            this.mepSendJustNotice.PerformLayout();
            this.mepAddProfessor.ResumeLayout(false);
            this.mepAddProfessor.PerformLayout();
            this.mepCreateUser.ResumeLayout(false);
            this.mepCreateUser.PerformLayout();
            this.mepFindStudent.ResumeLayout(false);
            this.mepFindStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.materialExpansionPanel1.ResumeLayout(false);
            this.materialExpansionPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManualImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ImagenesDeMenu;
        private MaterialSkin.Controls.MaterialTabControl mtcMenu;
        private System.Windows.Forms.TabPage ConfirmJust;
        private System.Windows.Forms.TabPage CrearPet;
        private MaterialSkin.Controls.MaterialExpansionPanel mepJustDetails;
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
        private MaterialSkin.Controls.MaterialLabel lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpStudentBirthDate;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialExpansionPanel mepAddProfessor;
        private MaterialSkin.Controls.MaterialTextBox2 tbCifSendPet;
        private MaterialSkin.Controls.MaterialTextBox2 tbUsername;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private System.Windows.Forms.DateTimePicker dtpPetDate;
        private MaterialSkin.Controls.MaterialLabel lblBirthDateSend;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialTextBox2 tbProfessorEmail;
        private MaterialSkin.Controls.MaterialTextBox2 tbProfessorName;
        private MaterialSkin.Controls.MaterialExpansionPanel mepSendJustNotice;
        private MaterialSkin.Controls.MaterialCheckbox cbJustDateCompletion;
        private MaterialSkin.Controls.MaterialCheckbox cbProfessorEmailCompletion;
        private MaterialSkin.Controls.MaterialCheckbox cbName;
        private MaterialSkin.Controls.MaterialCheckbox cbProfessorName;
        private MaterialSkin.Controls.MaterialCheckbox cbCifCompletion;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mltbEmailPreview;
        private MaterialSkin.Controls.MaterialLabel lblSelectClass;
        private MaterialSkin.Controls.MaterialButton btnAddOtherProfessor;
        private MaterialSkin.Controls.MaterialExpansionPanel mepRejectedPet;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mltbReasonForRejection;
        private MaterialSkin.Controls.MaterialTextBox tbDateRejected;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox tbClassRejected;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox tbCifRejected;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox tbNameRejected;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DataGridView dgvPetList;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblStudenInfo;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel lbPetList;
        private System.Windows.Forms.CheckedListBox cbStudentClasses;
        private MaterialSkin.Controls.MaterialTextBox2 tbPassword;
        private MaterialSkin.Controls.MaterialLabel lblStudenList;
        private MaterialSkin.Controls.MaterialExpansionPanel mepImg;
        private MaterialSkin.Controls.MaterialLabel lblImage;
        private System.Windows.Forms.PictureBox pbJustImg;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialSkin.Controls.MaterialButton btnSearchImg;
        private System.Windows.Forms.PictureBox pbManualImg;
        private MaterialSkin.Controls.MaterialCheckbox cbUploadImg;
    }
}