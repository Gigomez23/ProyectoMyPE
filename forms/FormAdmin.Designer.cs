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
            this.CrearPet = new System.Windows.Forms.TabPage();
            this.lvPetitions = new MaterialSkin.Controls.MaterialListView();
            this.mepJustDetails = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.tbName = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCif = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCif = new MaterialSkin.Controls.MaterialLabel();
            this.tbClass = new MaterialSkin.Controls.MaterialTextBox();
            this.lblClass = new MaterialSkin.Controls.MaterialLabel();
            this.tbDate = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.mlblEmailPreview = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.mtcMenu.SuspendLayout();
            this.ConfirmJust.SuspendLayout();
            this.mepJustDetails.SuspendLayout();
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
            this.mtcMenu.Size = new System.Drawing.Size(1445, 795);
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
            this.ConfirmJust.Size = new System.Drawing.Size(1437, 752);
            this.ConfirmJust.TabIndex = 0;
            this.ConfirmJust.Text = "Confirmar Justificaciónes";
            this.ConfirmJust.ToolTipText = "Confirmar Justificaciónes de estudiantes.";
            this.ConfirmJust.UseVisualStyleBackColor = true;
            // 
            // CrearPet
            // 
            this.CrearPet.ImageKey = "Documento.png";
            this.CrearPet.Location = new System.Drawing.Point(4, 39);
            this.CrearPet.Name = "CrearPet";
            this.CrearPet.Padding = new System.Windows.Forms.Padding(3);
            this.CrearPet.Size = new System.Drawing.Size(1043, 479);
            this.CrearPet.TabIndex = 1;
            this.CrearPet.Text = "Crear Petición";
            this.CrearPet.ToolTipText = "Crear la petición del estudiante. ";
            this.CrearPet.UseVisualStyleBackColor = true;
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
            this.lvPetitions.Location = new System.Drawing.Point(44, 41);
            this.lvPetitions.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvPetitions.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvPetitions.MouseState = MaterialSkin.MouseState.OUT;
            this.lvPetitions.Name = "lvPetitions";
            this.lvPetitions.OwnerDraw = true;
            this.lvPetitions.Scrollable = false;
            this.lvPetitions.Size = new System.Drawing.Size(539, 675);
            this.lvPetitions.TabIndex = 0;
            this.lvPetitions.UseCompatibleStateImageBehavior = false;
            this.lvPetitions.View = System.Windows.Forms.View.Details;
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
            this.mepJustDetails.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mepJustDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mepJustDetails.Location = new System.Drawing.Point(664, 41);
            this.mepJustDetails.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.mepJustDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.mepJustDetails.Name = "mepJustDetails";
            this.mepJustDetails.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mepJustDetails.Size = new System.Drawing.Size(703, 675);
            this.mepJustDetails.TabIndex = 1;
            this.mepJustDetails.Title = "Detalles";
            this.mepJustDetails.ValidationButtonText = "Aprobar";
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
            // tbCif
            // 
            this.tbCif.AnimateReadOnly = false;
            this.tbCif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCif.Depth = 0;
            this.tbCif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // tbClass
            // 
            this.tbClass.AnimateReadOnly = false;
            this.tbClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbClass.Depth = 0;
            this.tbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // tbDate
            // 
            this.tbDate.AnimateReadOnly = false;
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Depth = 0;
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // mlblEmailPreview
            // 
            this.mlblEmailPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlblEmailPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlblEmailPreview.Depth = 0;
            this.mlblEmailPreview.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblEmailPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblEmailPreview.Location = new System.Drawing.Point(70, 389);
            this.mlblEmailPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblEmailPreview.Name = "mlblEmailPreview";
            this.mlblEmailPreview.Size = new System.Drawing.Size(561, 178);
            this.mlblEmailPreview.TabIndex = 10;
            this.mlblEmailPreview.Text = resources.GetString("mlblEmailPreview.Text");
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 862);
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
    }
}