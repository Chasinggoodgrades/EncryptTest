namespace EncryptTest
{
    partial class MainForm
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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.boxTitleOne = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.encryptedPWBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.determineSecretKeyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.actualSecretKeyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.passwordBox.AcceptsReturn = true;
            this.passwordBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(241, 70);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordBox.Name = "textBox1";
            this.passwordBox.Size = new System.Drawing.Size(305, 29);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxTitleOne
            // 
            this.boxTitleOne.AutoSize = true;
            this.boxTitleOne.BackColor = System.Drawing.Color.Transparent;
            this.boxTitleOne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTitleOne.ForeColor = System.Drawing.SystemColors.Window;
            this.boxTitleOne.Location = new System.Drawing.Point(304, 47);
            this.boxTitleOne.Name = "boxTitleOne";
            this.boxTitleOne.Size = new System.Drawing.Size(183, 18);
            this.boxTitleOne.TabIndex = 1;
            this.boxTitleOne.Text = "Generate A Password";
            this.boxTitleOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EncryptButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(662, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save As";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveAsButton);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(356, 107);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton);
            // 
            // textBox2
            // 
            this.encryptedPWBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedPWBox.Location = new System.Drawing.Point(241, 154);
            this.encryptedPWBox.Name = "textBox2";
            this.encryptedPWBox.Size = new System.Drawing.Size(305, 32);
            this.encryptedPWBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(304, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Encrypted Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.determineSecretKeyBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.determineSecretKeyBox.Location = new System.Drawing.Point(241, 327);
            this.determineSecretKeyBox.Name = "textBox3";
            this.determineSecretKeyBox.Size = new System.Drawing.Size(305, 32);
            this.determineSecretKeyBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(304, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Determine Secret Key";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Find Key";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.FindKeyButton);
            // 
            // textBox4
            // 
            this.actualSecretKeyBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualSecretKeyBox.Location = new System.Drawing.Point(241, 248);
            this.actualSecretKeyBox.Name = "textBox4";
            this.actualSecretKeyBox.Size = new System.Drawing.Size(305, 32);
            this.actualSecretKeyBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(316, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Actual Secret Key";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.actualSecretKeyBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.determineSecretKeyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptedPWBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxTitleOne);
            this.Controls.Add(this.passwordBox);
            this.Name = "MainForm";
            this.Text = "Password Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label boxTitleOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox encryptedPWBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox determineSecretKeyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox actualSecretKeyBox;
        private System.Windows.Forms.Label label3;
    }


}

