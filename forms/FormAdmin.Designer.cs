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
            this.mtcMenu.SuspendLayout();
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
            this.mtcMenu.Size = new System.Drawing.Size(794, 383);
            this.mtcMenu.TabIndex = 0;
            // 
            // ConfirmJust
            // 
            this.ConfirmJust.ImageKey = "Aprobar.png";
            this.ConfirmJust.Location = new System.Drawing.Point(4, 39);
            this.ConfirmJust.Name = "ConfirmJust";
            this.ConfirmJust.Padding = new System.Windows.Forms.Padding(3);
            this.ConfirmJust.Size = new System.Drawing.Size(786, 340);
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
            this.CrearPet.Size = new System.Drawing.Size(786, 340);
            this.CrearPet.TabIndex = 1;
            this.CrearPet.Text = "Crear Petición";
            this.CrearPet.ToolTipText = "Crear la petición del estudiante. ";
            this.CrearPet.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtcMenu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mtcMenu;
            this.Name = "FormAdmin";
            this.Text = "Panel de Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.mtcMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ImagenesDeMenu;
        private MaterialSkin.Controls.MaterialTabControl mtcMenu;
        private System.Windows.Forms.TabPage ConfirmJust;
        private System.Windows.Forms.TabPage CrearPet;
    }
}