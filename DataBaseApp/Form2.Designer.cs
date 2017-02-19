namespace DataBaseApp
{
    partial class Form2
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
            this.regInfoLabel = new System.Windows.Forms.Label();
            this.peselLabel = new System.Windows.Forms.Label();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.incorrectRegisterDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regInfoLabel
            // 
            this.regInfoLabel.AutoSize = true;
            this.regInfoLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.regInfoLabel.Location = new System.Drawing.Point(12, 26);
            this.regInfoLabel.Name = "regInfoLabel";
            this.regInfoLabel.Size = new System.Drawing.Size(338, 18);
            this.regInfoLabel.TabIndex = 0;
            this.regInfoLabel.Text = "Uzupełnij poniższe pola i kliknij ZAREJESTRUJ.";
            // 
            // peselLabel
            // 
            this.peselLabel.AutoSize = true;
            this.peselLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.peselLabel.Location = new System.Drawing.Point(12, 59);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(65, 18);
            this.peselLabel.TabIndex = 1;
            this.peselLabel.Text = "PESEL:";
            // 
            // peselTextBox
            // 
            this.peselTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.peselTextBox.Location = new System.Drawing.Point(15, 80);
            this.peselTextBox.MaxLength = 11;
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(335, 26);
            this.peselTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.nameLabel.Location = new System.Drawing.Point(12, 109);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 18);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Imię:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.nameTextBox.Location = new System.Drawing.Point(15, 130);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(335, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.surnameLabel.Location = new System.Drawing.Point(12, 159);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(79, 18);
            this.surnameLabel.TabIndex = 5;
            this.surnameLabel.Text = "Nazwisko:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.surnameTextBox.Location = new System.Drawing.Point(15, 180);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(335, 26);
            this.surnameTextBox.TabIndex = 6;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.loginLabel.Location = new System.Drawing.Point(12, 209);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(51, 18);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "Login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.loginTextBox.Location = new System.Drawing.Point(15, 230);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(335, 26);
            this.loginTextBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.passwordLabel.Location = new System.Drawing.Point(12, 259);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 18);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(15, 280);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(335, 26);
            this.passwordTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F);
            this.button1.Location = new System.Drawing.Point(15, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Zarejestruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // incorrectRegisterDataLabel
            // 
            this.incorrectRegisterDataLabel.AutoSize = true;
            this.incorrectRegisterDataLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.incorrectRegisterDataLabel.Location = new System.Drawing.Point(83, 59);
            this.incorrectRegisterDataLabel.Name = "incorrectRegisterDataLabel";
            this.incorrectRegisterDataLabel.Size = new System.Drawing.Size(0, 18);
            this.incorrectRegisterDataLabel.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 371);
            this.Controls.Add(this.incorrectRegisterDataLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.peselTextBox);
            this.Controls.Add(this.peselLabel);
            this.Controls.Add(this.regInfoLabel);
            this.Name = "Form2";
            this.Text = "Rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regInfoLabel;
        private System.Windows.Forms.Label peselLabel;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label incorrectRegisterDataLabel;
    }
}