namespace HospitalApp
{
    partial class PatientSignUp
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
            this.PSignUp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.P_Password = new System.Windows.Forms.TextBox();
            this.P_PhoneNo = new System.Windows.Forms.TextBox();
            this.P_SSN = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PSignUp
            // 
            this.PSignUp.Location = new System.Drawing.Point(354, 349);
            this.PSignUp.Name = "PSignUp";
            this.PSignUp.Size = new System.Drawing.Size(75, 36);
            this.PSignUp.TabIndex = 23;
            this.PSignUp.Text = "Sign Up";
            this.PSignUp.UseVisualStyleBackColor = true;
            this.PSignUp.Click += new System.EventHandler(this.PSignUp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "SSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "First Name";
            // 
            // P_Password
            // 
            this.P_Password.Location = new System.Drawing.Point(365, 175);
            this.P_Password.Name = "P_Password";
            this.P_Password.Size = new System.Drawing.Size(100, 20);
            this.P_Password.TabIndex = 17;
            // 
            // P_PhoneNo
            // 
            this.P_PhoneNo.Location = new System.Drawing.Point(365, 270);
            this.P_PhoneNo.Name = "P_PhoneNo";
            this.P_PhoneNo.Size = new System.Drawing.Size(100, 20);
            this.P_PhoneNo.TabIndex = 16;
            // 
            // P_SSN
            // 
            this.P_SSN.Location = new System.Drawing.Point(365, 219);
            this.P_SSN.Name = "P_SSN";
            this.P_SSN.Size = new System.Drawing.Size(100, 20);
            this.P_SSN.TabIndex = 15;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(365, 129);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(100, 20);
            this.Lname.TabIndex = 14;
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(365, 76);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(100, 20);
            this.FName.TabIndex = 13;
            // 
            // PatientSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PSignUp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.P_Password);
            this.Controls.Add(this.P_PhoneNo);
            this.Controls.Add(this.P_SSN);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.FName);
            this.Name = "PatientSignUp";
            this.Text = "PatientSignUp";
            this.Load += new System.EventHandler(this.PatientSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PSignUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox P_Password;
        private System.Windows.Forms.TextBox P_PhoneNo;
        private System.Windows.Forms.TextBox P_SSN;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox FName;
    }
}