namespace ProyectoMarjorie
{
    partial class LoginForm
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
            this.tbUsername = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.btnAddUser = new MaterialSkin.Controls.MaterialButton();
            this.pbUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
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
            this.tbUsername.Location = new System.Drawing.Point(135, 220);
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
            this.tbUsername.Size = new System.Drawing.Size(250, 48);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TabStop = false;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsername.TrailingIcon = null;
            this.tbUsername.UseSystemPasswordChar = false;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.AnimateReadOnly = false;
            this.tbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPassword.Depth = 0;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.HideSelection = true;
            this.tbPassword.Hint = "Contraseña:";
            this.tbPassword.LeadingIcon = null;
            this.tbPassword.LeaveOnEnterKey = true;
            this.tbPassword.Location = new System.Drawing.Point(135, 312);
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
            this.tbPassword.Size = new System.Drawing.Size(250, 48);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TabStop = false;
            this.tbPassword.Tag = "";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TrailingIcon = null;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.Enabled = false;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(279, 412);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(153, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddUser.Depth = 0;
            this.btnAddUser.HighEmphasis = true;
            this.btnAddUser.Icon = null;
            this.btnAddUser.Location = new System.Drawing.Point(81, 412);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddUser.Size = new System.Drawing.Size(153, 36);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddUser.UseAccentColor = false;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pbUser
            // 
            this.pbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUser.Image = global::ProyectoMarjorie.Properties.Resources.user_stroke_rounded;
            this.pbUser.Location = new System.Drawing.Point(194, 102);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(112, 98);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUser.TabIndex = 5;
            this.pbUser.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 529);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.DrawerShowIconsWhenHidden = true;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 tbUsername;
        private MaterialSkin.Controls.MaterialTextBox2 tbPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialButton btnAddUser;
        private System.Windows.Forms.PictureBox pbUser;
    }
}

