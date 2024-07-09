namespace HospitalApp
{
    partial class P_UpdateAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.AppointmentTime_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateAppointment_button = new System.Windows.Forms.Button();
            this.DeleteAppointment_button = new System.Windows.Forms.Button();
            this.PatSSN_textBox = new System.Windows.Forms.TextBox();
            this.GetPatId_button = new System.Windows.Forms.Button();
            this.PatID_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your SSN";
            // 
            // AppointmentTime_textBox
            // 
            this.AppointmentTime_textBox.Location = new System.Drawing.Point(272, 57);
            this.AppointmentTime_textBox.Name = "AppointmentTime_textBox";
            this.AppointmentTime_textBox.Size = new System.Drawing.Size(100, 22);
            this.AppointmentTime_textBox.TabIndex = 2;
            this.AppointmentTime_textBox.TextChanged += new System.EventHandler(this.AppointmentTime_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Suitable Time for Appointment";
            // 
            // UpdateAppointment_button
            // 
            this.UpdateAppointment_button.Location = new System.Drawing.Point(232, 134);
            this.UpdateAppointment_button.Name = "UpdateAppointment_button";
            this.UpdateAppointment_button.Size = new System.Drawing.Size(226, 57);
            this.UpdateAppointment_button.TabIndex = 4;
            this.UpdateAppointment_button.Text = "Update Appointment";
            this.UpdateAppointment_button.UseVisualStyleBackColor = true;
            this.UpdateAppointment_button.Click += new System.EventHandler(this.UpdateAppointment_button_Click);
            // 
            // DeleteAppointment_button
            // 
            this.DeleteAppointment_button.Location = new System.Drawing.Point(522, 134);
            this.DeleteAppointment_button.Name = "DeleteAppointment_button";
            this.DeleteAppointment_button.Size = new System.Drawing.Size(226, 59);
            this.DeleteAppointment_button.TabIndex = 5;
            this.DeleteAppointment_button.Text = "Delete Appointment";
            this.DeleteAppointment_button.UseVisualStyleBackColor = true;
            this.DeleteAppointment_button.Click += new System.EventHandler(this.DeleteAppointment_button_Click);
            // 
            // PatSSN_textBox
            // 
            this.PatSSN_textBox.Location = new System.Drawing.Point(272, 9);
            this.PatSSN_textBox.Name = "PatSSN_textBox";
            this.PatSSN_textBox.Size = new System.Drawing.Size(100, 22);
            this.PatSSN_textBox.TabIndex = 6;
            // 
            // GetPatId_button
            // 
            this.GetPatId_button.Location = new System.Drawing.Point(628, 12);
            this.GetPatId_button.Name = "GetPatId_button";
            this.GetPatId_button.Size = new System.Drawing.Size(168, 23);
            this.GetPatId_button.TabIndex = 7;
            this.GetPatId_button.Text = "Get Your ID";
            this.GetPatId_button.UseVisualStyleBackColor = true;
            this.GetPatId_button.Click += new System.EventHandler(this.GetPatId_button_Click);
            // 
            // PatID_textBox
            // 
            this.PatID_textBox.Location = new System.Drawing.Point(500, 13);
            this.PatID_textBox.Name = "PatID_textBox";
            this.PatID_textBox.ReadOnly = true;
            this.PatID_textBox.Size = new System.Drawing.Size(100, 22);
            this.PatID_textBox.TabIndex = 8;
            // 
            // P_UpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PatID_textBox);
            this.Controls.Add(this.GetPatId_button);
            this.Controls.Add(this.PatSSN_textBox);
            this.Controls.Add(this.DeleteAppointment_button);
            this.Controls.Add(this.UpdateAppointment_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AppointmentTime_textBox);
            this.Controls.Add(this.label1);
            this.Name = "P_UpdateAppointment";
            this.Text = "P_UpdateAppointment";
            this.Load += new System.EventHandler(this.P_UpdateAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AppointmentTime_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateAppointment_button;
        private System.Windows.Forms.Button DeleteAppointment_button;
        private System.Windows.Forms.TextBox PatSSN_textBox;
        private System.Windows.Forms.Button GetPatId_button;
        private System.Windows.Forms.TextBox PatID_textBox;
    }
}