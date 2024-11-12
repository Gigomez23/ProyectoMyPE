namespace ProyectoMarjorie.forms
{
    partial class CrearUsuario
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
            this.tbName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.tbCif = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCif = new MaterialSkin.Controls.MaterialLabel();
            this.lblBirthDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddUser = new MaterialSkin.Controls.MaterialButton();
            this.btnReturn = new MaterialSkin.Controls.MaterialButton();
            this.fabAddClass = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.AnimateReadOnly = false;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Depth = 0;
            this.tbName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbName.LeadingIcon = null;
            this.tbName.Location = new System.Drawing.Point(236, 127);
            this.tbName.MaxLength = 50;
            this.tbName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(269, 50);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "";
            this.tbName.TrailingIcon = null;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(144, 146);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre:";
            // 
            // tbCif
            // 
            this.tbCif.AnimateReadOnly = false;
            this.tbCif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCif.Depth = 0;
            this.tbCif.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCif.LeadingIcon = null;
            this.tbCif.Location = new System.Drawing.Point(236, 212);
            this.tbCif.MaxLength = 50;
            this.tbCif.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCif.Multiline = false;
            this.tbCif.Name = "tbCif";
            this.tbCif.Size = new System.Drawing.Size(136, 50);
            this.tbCif.TabIndex = 2;
            this.tbCif.Text = "";
            this.tbCif.TrailingIcon = null;
            // 
            // lblCif
            // 
            this.lblCif.AutoSize = true;
            this.lblCif.Depth = 0;
            this.lblCif.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCif.Location = new System.Drawing.Point(177, 228);
            this.lblCif.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCif.Name = "lblCif";
            this.lblCif.Size = new System.Drawing.Size(28, 19);
            this.lblCif.TabIndex = 3;
            this.lblCif.Text = "CIF:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Depth = 0;
            this.lblBirthDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBirthDate.Location = new System.Drawing.Point(72, 306);
            this.lblBirthDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(133, 19);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Fecha Nacimiento:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(236, 306);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(228, 20);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSize = false;
            this.btnAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddUser.Depth = 0;
            this.btnAddUser.HighEmphasis = true;
            this.btnAddUser.Icon = null;
            this.btnAddUser.Location = new System.Drawing.Point(347, 408);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddUser.Size = new System.Drawing.Size(158, 36);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddUser.UseAccentColor = false;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = false;
            this.btnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReturn.Depth = 0;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.HighEmphasis = true;
            this.btnReturn.Icon = null;
            this.btnReturn.Location = new System.Drawing.Point(75, 408);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReturn.Size = new System.Drawing.Size(158, 36);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Regresar";
            this.btnReturn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReturn.UseAccentColor = false;
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // fabAddClass
            // 
            this.fabAddClass.AnimateShowHideButton = true;
            this.fabAddClass.BackColor = System.Drawing.SystemColors.Control;
            this.fabAddClass.Depth = 0;
            this.fabAddClass.Icon = null;
            this.fabAddClass.Location = new System.Drawing.Point(493, 517);
            this.fabAddClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.fabAddClass.Name = "fabAddClass";
            this.fabAddClass.Size = new System.Drawing.Size(56, 56);
            this.fabAddClass.TabIndex = 8;
            this.fabAddClass.Text = "Agregar Clase a Horario";
            this.fabAddClass.UseVisualStyleBackColor = false;
            // 
            // CrearUsuario
            // 
            this.AcceptButton = this.btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(586, 597);
            this.Controls.Add(this.fabAddClass);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblCif);
            this.Controls.Add(this.tbCif);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.MaximizeBox = false;
            this.Name = "CrearUsuario";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearUsuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tbName;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialTextBox tbCif;
        private MaterialSkin.Controls.MaterialLabel lblCif;
        private MaterialSkin.Controls.MaterialLabel lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private MaterialSkin.Controls.MaterialButton btnAddUser;
        private MaterialSkin.Controls.MaterialButton btnReturn;
        private MaterialSkin.Controls.MaterialFloatingActionButton fabAddClass;
    }
}