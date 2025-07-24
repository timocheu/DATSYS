namespace StudentInformationSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_RegisterAdmin = new Button();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            tb_Username = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lbl_UsernameInput = new Label();
            lbl_Password = new Label();
            SuspendLayout();
            // 
            // btn_RegisterAdmin
            // 
            btn_RegisterAdmin.Location = new Point(24, 603);
            btn_RegisterAdmin.Name = "btn_RegisterAdmin";
            btn_RegisterAdmin.Size = new Size(145, 23);
            btn_RegisterAdmin.TabIndex = 3;
            btn_RegisterAdmin.Text = "Register Admin";
            btn_RegisterAdmin.UseVisualStyleBackColor = true;
            btn_RegisterAdmin.Click += btn_RegisterAdmin_ClickAsync;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(307, 384);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(140, 36);
            materialButton1.TabIndex = 4;
            materialButton1.Text = "Login";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // tb_Username
            // 
            tb_Username.AnimateReadOnly = false;
            tb_Username.AutoCompleteMode = AutoCompleteMode.None;
            tb_Username.AutoCompleteSource = AutoCompleteSource.None;
            tb_Username.BackgroundImageLayout = ImageLayout.None;
            tb_Username.CharacterCasing = CharacterCasing.Normal;
            tb_Username.Depth = 0;
            tb_Username.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_Username.HideSelection = true;
            tb_Username.Hint = "Username";
            tb_Username.LeadingIcon = null;
            tb_Username.Location = new Point(197, 195);
            tb_Username.MaxLength = 32767;
            tb_Username.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Username.Name = "tb_Username";
            tb_Username.PasswordChar = '\0';
            tb_Username.PrefixSuffixText = null;
            tb_Username.ReadOnly = false;
            tb_Username.RightToLeft = RightToLeft.No;
            tb_Username.SelectedText = "";
            tb_Username.SelectionLength = 0;
            tb_Username.SelectionStart = 0;
            tb_Username.ShortcutsEnabled = true;
            tb_Username.Size = new Size(250, 48);
            tb_Username.TabIndex = 5;
            tb_Username.TabStop = false;
            tb_Username.TextAlign = HorizontalAlignment.Left;
            tb_Username.TrailingIcon = null;
            tb_Username.UseSystemPasswordChar = false;
            // 
            // tb_Password
            // 
            tb_Password.AnimateReadOnly = false;
            tb_Password.AutoCompleteMode = AutoCompleteMode.None;
            tb_Password.AutoCompleteSource = AutoCompleteSource.None;
            tb_Password.BackgroundImageLayout = ImageLayout.None;
            tb_Password.CharacterCasing = CharacterCasing.Normal;
            tb_Password.Depth = 0;
            tb_Password.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_Password.HideSelection = true;
            tb_Password.Hint = "Password";
            tb_Password.LeadingIcon = null;
            tb_Password.Location = new Point(197, 293);
            tb_Password.MaxLength = 32767;
            tb_Password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '\0';
            tb_Password.PrefixSuffixText = null;
            tb_Password.ReadOnly = false;
            tb_Password.RightToLeft = RightToLeft.No;
            tb_Password.SelectedText = "";
            tb_Password.SelectionLength = 0;
            tb_Password.SelectionStart = 0;
            tb_Password.ShortcutsEnabled = true;
            tb_Password.Size = new Size(250, 48);
            tb_Password.TabIndex = 6;
            tb_Password.TabStop = false;
            tb_Password.TextAlign = HorizontalAlignment.Left;
            tb_Password.TrailingIcon = null;
            tb_Password.UseSystemPasswordChar = false;
            // 
            // lbl_UsernameInput
            // 
            lbl_UsernameInput.AutoSize = true;
            lbl_UsernameInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_UsernameInput.Location = new Point(197, 172);
            lbl_UsernameInput.Name = "lbl_UsernameInput";
            lbl_UsernameInput.Size = new Size(83, 20);
            lbl_UsernameInput.TabIndex = 7;
            lbl_UsernameInput.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_Password.Location = new Point(197, 270);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(78, 20);
            lbl_Password.TabIndex = 8;
            lbl_Password.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1184, 661);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_UsernameInput);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Controls.Add(materialButton1);
            Controls.Add(btn_RegisterAdmin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_RegisterAdmin;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Username;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Password;
        private Label lbl_UsernameInput;
        private Label lbl_Password;
    }
}
