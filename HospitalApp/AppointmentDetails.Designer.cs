namespace HospitalApp
{
    partial class AppointmentDetails
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
            this.PatientSSN_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewAppointment_button = new System.Windows.Forms.Button();
            this.AppointmentDetails_dataGridView = new System.Windows.Forms.DataGridView();
            this.PatID_textBox = new System.Windows.Forms.TextBox();
            this.GetPatID_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDetails_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientSSN_textBox
            // 
            this.PatientSSN_textBox.Location = new System.Drawing.Point(190, 12);
            this.PatientSSN_textBox.Name = "PatientSSN_textBox";
            this.PatientSSN_textBox.Size = new System.Drawing.Size(100, 22);
            this.PatientSSN_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter Your SSN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewAppointment_button
            // 
            this.ViewAppointment_button.Location = new System.Drawing.Point(231, 97);
            this.ViewAppointment_button.Name = "ViewAppointment_button";
            this.ViewAppointment_button.Size = new System.Drawing.Size(251, 23);
            this.ViewAppointment_button.TabIndex = 2;
            this.ViewAppointment_button.Text = "View Appointment";
            this.ViewAppointment_button.UseVisualStyleBackColor = true;
            this.ViewAppointment_button.Click += new System.EventHandler(this.ViewAppointment_button_Click);
            // 
            // AppointmentDetails_dataGridView
            // 
            this.AppointmentDetails_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentDetails_dataGridView.Location = new System.Drawing.Point(50, 126);
            this.AppointmentDetails_dataGridView.Name = "AppointmentDetails_dataGridView";
            this.AppointmentDetails_dataGridView.RowHeadersWidth = 51;
            this.AppointmentDetails_dataGridView.RowTemplate.Height = 24;
            this.AppointmentDetails_dataGridView.Size = new System.Drawing.Size(580, 220);
            this.AppointmentDetails_dataGridView.TabIndex = 3;
            // 
            // PatID_textBox
            // 
            this.PatID_textBox.Location = new System.Drawing.Point(491, 15);
            this.PatID_textBox.Name = "PatID_textBox";
            this.PatID_textBox.ReadOnly = true;
            this.PatID_textBox.Size = new System.Drawing.Size(100, 22);
            this.PatID_textBox.TabIndex = 4;
            // 
            // GetPatID_button
            // 
            this.GetPatID_button.Location = new System.Drawing.Point(624, 11);
            this.GetPatID_button.Name = "GetPatID_button";
            this.GetPatID_button.Size = new System.Drawing.Size(145, 23);
            this.GetPatID_button.TabIndex = 5;
            this.GetPatID_button.Text = "Get Patient ID";
            this.GetPatID_button.UseVisualStyleBackColor = true;
            this.GetPatID_button.Click += new System.EventHandler(this.GetPatID_button_Click);
            // 
            // AppointmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetPatID_button);
            this.Controls.Add(this.PatID_textBox);
            this.Controls.Add(this.AppointmentDetails_dataGridView);
            this.Controls.Add(this.ViewAppointment_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientSSN_textBox);
            this.Name = "AppointmentDetails";
            this.Text = "AppointmentDetails";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDetails_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PatientSSN_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewAppointment_button;
        private System.Windows.Forms.DataGridView AppointmentDetails_dataGridView;
        private System.Windows.Forms.TextBox PatID_textBox;
        private System.Windows.Forms.Button GetPatID_button;
    }
}