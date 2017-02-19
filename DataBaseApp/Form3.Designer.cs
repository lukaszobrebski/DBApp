namespace DataBaseApp
{
    partial class Form3
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
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetNameTextBox = new System.Windows.Forms.TextBox();
            this.rentButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.reportBrokenCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.streetLabel.Location = new System.Drawing.Point(12, 9);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(89, 18);
            this.streetLabel.TabIndex = 0;
            this.streetLabel.Text = "Podaj ulice,\r\n";
            // 
            // streetNameTextBox
            // 
            this.streetNameTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.streetNameTextBox.Location = new System.Drawing.Point(15, 47);
            this.streetNameTextBox.Name = "streetNameTextBox";
            this.streetNameTextBox.Size = new System.Drawing.Size(312, 26);
            this.streetNameTextBox.TabIndex = 1;
            // 
            // rentButton
            // 
            this.rentButton.Font = new System.Drawing.Font("Arial", 12F);
            this.rentButton.Location = new System.Drawing.Point(15, 79);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(312, 40);
            this.rentButton.TabIndex = 2;
            this.rentButton.Text = "Wypożycz";
            this.rentButton.UseVisualStyleBackColor = true;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Arial", 12F);
            this.returnButton.Location = new System.Drawing.Point(15, 168);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(312, 42);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Zwróć Rower";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.infoLabel.Location = new System.Drawing.Point(12, 138);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(236, 18);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Tu wyświetlane będą komunikaty.";
            // 
            // reportBrokenCheckBox
            // 
            this.reportBrokenCheckBox.AutoSize = true;
            this.reportBrokenCheckBox.Location = new System.Drawing.Point(15, 216);
            this.reportBrokenCheckBox.Name = "reportBrokenCheckBox";
            this.reportBrokenCheckBox.Size = new System.Drawing.Size(157, 17);
            this.reportBrokenCheckBox.TabIndex = 5;
            this.reportBrokenCheckBox.Text = "Czy chcesz zgłosić awarie?";
            this.reportBrokenCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 257);
            this.Controls.Add(this.reportBrokenCheckBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.rentButton);
            this.Controls.Add(this.streetNameTextBox);
            this.Controls.Add(this.streetLabel);
            this.Name = "Form3";
            this.Text = "Rowerowy Wrocław";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetNameTextBox;
        private System.Windows.Forms.Button rentButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.CheckBox reportBrokenCheckBox;
    }
}