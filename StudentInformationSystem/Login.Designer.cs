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
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            btn_Login = new Button();
            btn_RegisterAdmin = new Button();
            SuspendLayout();
            // 
            // tb_Username
            // 
            tb_Username.Location = new Point(288, 134);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(176, 23);
            tb_Username.TabIndex = 0;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(288, 195);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(176, 23);
            tb_Password.TabIndex = 1;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(288, 293);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(75, 23);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_RegisterAdmin
            // 
            btn_RegisterAdmin.Location = new Point(426, 293);
            btn_RegisterAdmin.Name = "btn_RegisterAdmin";
            btn_RegisterAdmin.Size = new Size(145, 23);
            btn_RegisterAdmin.TabIndex = 3;
            btn_RegisterAdmin.Text = "Register Admin";
            btn_RegisterAdmin.UseVisualStyleBackColor = true;
            btn_RegisterAdmin.Click += btn_RegisterAdmin_ClickAsync;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_RegisterAdmin);
            Controls.Add(btn_Login);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Username;
        private TextBox tb_Password;
        private Button btn_Login;
        private Button btn_RegisterAdmin;
    }
}
