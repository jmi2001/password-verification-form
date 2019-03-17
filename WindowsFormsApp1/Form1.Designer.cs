namespace WindowsFormsApp1
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPasswordRule1 = new System.Windows.Forms.Label();
            this.labelPasswordRule2 = new System.Windows.Forms.Label();
            this.labelPasswordRule3 = new System.Windows.Forms.Label();
            this.labelPasswordRule4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelIsValid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(104, 17);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(118, 20);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Password :";
            // 
            // labelPasswordRule1
            // 
            this.labelPasswordRule1.AutoSize = true;
            this.labelPasswordRule1.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordRule1.Location = new System.Drawing.Point(8, 63);
            this.labelPasswordRule1.Name = "labelPasswordRule1";
            this.labelPasswordRule1.Size = new System.Drawing.Size(169, 13);
            this.labelPasswordRule1.TabIndex = 2;
            this.labelPasswordRule1.Text = "-Length must be 3 to 8 characters.";
            // 
            // labelPasswordRule2
            // 
            this.labelPasswordRule2.AutoSize = true;
            this.labelPasswordRule2.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordRule2.Location = new System.Drawing.Point(8, 76);
            this.labelPasswordRule2.Name = "labelPasswordRule2";
            this.labelPasswordRule2.Size = new System.Drawing.Size(450, 13);
            this.labelPasswordRule2.TabIndex = 3;
            this.labelPasswordRule2.Text = "-The first character must be uppercase letter while  the last character must be l" +
    "owercase letter.";
            // 
            // labelPasswordRule3
            // 
            this.labelPasswordRule3.AutoSize = true;
            this.labelPasswordRule3.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordRule3.Location = new System.Drawing.Point(8, 89);
            this.labelPasswordRule3.Name = "labelPasswordRule3";
            this.labelPasswordRule3.Size = new System.Drawing.Size(290, 13);
            this.labelPasswordRule3.TabIndex = 4;
            this.labelPasswordRule3.Text = "-There should be a digit between the first and last character.";
            // 
            // labelPasswordRule4
            // 
            this.labelPasswordRule4.AutoSize = true;
            this.labelPasswordRule4.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordRule4.Location = new System.Drawing.Point(8, 102);
            this.labelPasswordRule4.Name = "labelPasswordRule4";
            this.labelPasswordRule4.Size = new System.Drawing.Size(225, 13);
            this.labelPasswordRule4.TabIndex = 5;
            this.labelPasswordRule4.Text = "-Password should be letters and numbers only.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelIsValid);
            this.groupBox1.Controls.Add(this.labelPasswordRule4);
            this.groupBox1.Controls.Add(this.labelPasswordRule3);
            this.groupBox1.Controls.Add(this.labelPasswordRule2);
            this.groupBox1.Controls.Add(this.labelPasswordRule1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Location = new System.Drawing.Point(209, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valid Password";
            // 
            // labelIsValid
            // 
            this.labelIsValid.AutoSize = true;
            this.labelIsValid.ForeColor = System.Drawing.Color.Black;
            this.labelIsValid.Location = new System.Drawing.Point(228, 20);
            this.labelIsValid.Name = "labelIsValid";
            this.labelIsValid.Size = new System.Drawing.Size(97, 13);
            this.labelIsValid.TabIndex = 7;
            this.labelIsValid.Text = "Password is valid!!!";
            this.labelIsValid.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 449);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Valid Password";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPasswordRule1;
        private System.Windows.Forms.Label labelPasswordRule2;
        private System.Windows.Forms.Label labelPasswordRule3;
        private System.Windows.Forms.Label labelPasswordRule4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelIsValid;
    }
}

