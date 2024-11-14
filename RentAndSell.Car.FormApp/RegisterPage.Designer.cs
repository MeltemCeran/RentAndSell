namespace RentAndSell.Car.FormApp
{
    partial class RegisterPage
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
            gBoxRegister = new GroupBox();
            lblMessage = new Label();
            btnLogin = new Button();
            btnSave = new Button();
            txtPasswordAgain = new TextBox();
            txtPasssword = new TextBox();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            gBoxRegister.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxRegister
            // 
            gBoxRegister.Controls.Add(lblMessage);
            gBoxRegister.Controls.Add(btnLogin);
            gBoxRegister.Controls.Add(btnSave);
            gBoxRegister.Controls.Add(txtPasswordAgain);
            gBoxRegister.Controls.Add(txtPasssword);
            gBoxRegister.Controls.Add(txtUserName);
            gBoxRegister.Controls.Add(txtEmail);
            gBoxRegister.Controls.Add(txtLastName);
            gBoxRegister.Controls.Add(txtFirstName);
            gBoxRegister.Location = new Point(21, 23);
            gBoxRegister.Name = "gBoxRegister";
            gBoxRegister.Size = new Size(347, 245);
            gBoxRegister.TabIndex = 0;
            gBoxRegister.TabStop = false;
            gBoxRegister.Text = "Yeni Kayıt";
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(205, 30);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(136, 168);
            lblMessage.TabIndex = 9;
            lblMessage.Text = "Mesajlar";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(97, 210);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 23);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Girişe Git";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(16, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.Location = new Point(16, 175);
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.PasswordChar = '*';
            txtPasswordAgain.PlaceholderText = "Şifreniz Tekrar";
            txtPasswordAgain.Size = new Size(183, 23);
            txtPasswordAgain.TabIndex = 6;
            // 
            // txtPasssword
            // 
            txtPasssword.Location = new Point(16, 146);
            txtPasssword.Name = "txtPasssword";
            txtPasssword.PasswordChar = '*';
            txtPasssword.PlaceholderText = "Şifreniz";
            txtPasssword.Size = new Size(183, 23);
            txtPasssword.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(16, 117);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Kullanızı Adınız";
            txtUserName.Size = new Size(183, 23);
            txtUserName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(16, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-posta Adresiniz";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(16, 59);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Soyadınız";
            txtLastName.Size = new Size(183, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(16, 30);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Adınız";
            txtFirstName.Size = new Size(183, 23);
            txtFirstName.TabIndex = 1;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gBoxRegister);
            Name = "RegisterPage";
            Text = "RegisterPage";
            gBoxRegister.ResumeLayout(false);
            gBoxRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxRegister;
        private TextBox txtPasswordAgain;
        private TextBox txtPasssword;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblMessage;
        private Button btnLogin;
        private Button btnSave;
    }
}