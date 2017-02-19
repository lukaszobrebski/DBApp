namespace DataBaseApp
{
    partial class Form1
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.notRegisteredLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.incorrectLoginDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(317, 74);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Witaj w systemie wypożyczania rowerów.\r\nAby uzyskać dostęp do sekcji wypożyczania" +
    ",\r\nzaloguj się z użyciem loginu i hasła.\r\n\r\n";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.loginTextBox.Location = new System.Drawing.Point(12, 131);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(317, 26);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(12, 195);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(317, 26);
            this.passwordTextBox.TabIndex = 2;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.loginLabel.Location = new System.Drawing.Point(12, 110);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(51, 18);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.passwordLabel.Location = new System.Drawing.Point(12, 174);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(52, 18);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Hasło:";
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Arial", 12F);
            this.logInButton.Location = new System.Drawing.Point(15, 227);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(314, 37);
            this.logInButton.TabIndex = 5;
            this.logInButton.Text = "Zaloguj";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // notRegisteredLabel
            // 
            this.notRegisteredLabel.AutoSize = true;
            this.notRegisteredLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.notRegisteredLabel.Location = new System.Drawing.Point(12, 277);
            this.notRegisteredLabel.Name = "notRegisteredLabel";
            this.notRegisteredLabel.Size = new System.Drawing.Size(124, 18);
            this.notRegisteredLabel.TabIndex = 6;
            this.notRegisteredLabel.Text = "Nie masz konta?";
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Arial", 12F);
            this.registerButton.Location = new System.Drawing.Point(12, 298);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(317, 36);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Zarejestruj";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // incorrectLoginDataLabel
            // 
            this.incorrectLoginDataLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incorrectLoginDataLabel.Location = new System.Drawing.Point(69, 106);
            this.incorrectLoginDataLabel.Name = "incorrectLoginDataLabel";
            this.incorrectLoginDataLabel.Size = new System.Drawing.Size(261, 22);
            this.incorrectLoginDataLabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 369);
            this.Controls.Add(this.incorrectLoginDataLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.notRegisteredLabel);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.Text = "Rowerowy Wrocław";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label notRegisteredLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label incorrectLoginDataLabel;
    }
}

