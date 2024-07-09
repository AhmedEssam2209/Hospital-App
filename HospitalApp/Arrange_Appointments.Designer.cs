namespace HospitalApp
{
    partial class Arrange_Appointments
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PID = new System.Windows.Forms.ComboBox();
            this.Rno = new System.Windows.Forms.ComboBox();
            this.DID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient\'s ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dr\'s ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Number";
            // 
            // PID
            // 
            this.PID.FormattingEnabled = true;
            this.PID.Location = new System.Drawing.Point(227, 50);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(121, 24);
            this.PID.TabIndex = 3;
            // 
            // Rno
            // 
            this.Rno.FormattingEnabled = true;
            this.Rno.Location = new System.Drawing.Point(227, 165);
            this.Rno.Name = "Rno";
            this.Rno.Size = new System.Drawing.Size(121, 24);
            this.Rno.TabIndex = 4;
            // 
            // DID
            // 
            this.DID.FormattingEnabled = true;
            this.DID.Location = new System.Drawing.Point(227, 104);
            this.DID.Name = "DID";
            this.DID.Size = new System.Drawing.Size(121, 24);
            this.DID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(227, 236);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(244, 22);
            this.date.TabIndex = 8;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(227, 295);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(121, 22);
            this.cost.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cost";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Appointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Arrange_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DID);
            this.Controls.Add(this.Rno);
            this.Controls.Add(this.PID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Arrange_Appointments";
            this.Text = "Arrange_Appointments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PID;
        private System.Windows.Forms.ComboBox Rno;
        private System.Windows.Forms.ComboBox DID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}