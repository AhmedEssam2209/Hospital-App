namespace HospitalApp
{
    partial class PChangePass
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
            this.PATFirstName_textbox = new System.Windows.Forms.TextBox();
            this.pChangePass_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PChangePassword_button = new System.Windows.Forms.Button();
            this.PatientLastName_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PATFirstName_textbox
            // 
            this.PATFirstName_textbox.Location = new System.Drawing.Point(295, 54);
            this.PATFirstName_textbox.Name = "PATFirstName_textbox";
            this.PATFirstName_textbox.Size = new System.Drawing.Size(186, 22);
            this.PATFirstName_textbox.TabIndex = 0;
            // 
            // pChangePass_textBox
            // 
            this.pChangePass_textBox.Location = new System.Drawing.Point(292, 128);
            this.pChangePass_textBox.Name = "pChangePass_textBox";
            this.pChangePass_textBox.Size = new System.Drawing.Size(188, 22);
            this.pChangePass_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter New Password";
            // 
            // PChangePassword_button
            // 
            this.PChangePassword_button.Location = new System.Drawing.Point(274, 237);
            this.PChangePassword_button.Name = "PChangePassword_button";
            this.PChangePassword_button.Size = new System.Drawing.Size(188, 45);
            this.PChangePassword_button.TabIndex = 4;
            this.PChangePassword_button.Text = "Change Password";
            this.PChangePassword_button.UseVisualStyleBackColor = true;
            this.PChangePassword_button.Click += new System.EventHandler(this.PChangePassword_button_Click);
            // 
            // PatientLastName_textBox
            // 
            this.PatientLastName_textBox.Location = new System.Drawing.Point(295, 89);
            this.PatientLastName_textBox.Name = "PatientLastName_textBox";
            this.PatientLastName_textBox.Size = new System.Drawing.Size(185, 22);
            this.PatientLastName_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Your Last Name";
            // 
            // PChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PatientLastName_textBox);
            this.Controls.Add(this.PChangePassword_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pChangePass_textBox);
            this.Controls.Add(this.PATFirstName_textbox);
            this.Name = "PChangePass";
            this.Text = "PChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PATFirstName_textbox;
        private System.Windows.Forms.TextBox pChangePass_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PChangePassword_button;
        private System.Windows.Forms.TextBox PatientLastName_textBox;
        private System.Windows.Forms.Label label3;
    }
}