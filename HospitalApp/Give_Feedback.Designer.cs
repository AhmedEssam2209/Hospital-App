namespace HospitalApp
{
    partial class Give_Feedback
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitFeedback_button = new System.Windows.Forms.Button();
            this.Feedback_textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PSSN_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DrLname_textBox = new System.Windows.Forms.TextBox();
            this.DrFname_textBox = new System.Windows.Forms.TextBox();
            this.GetPatID_button = new System.Windows.Forms.Button();
            this.PID_textBox = new System.Windows.Forms.TextBox();
            this.DRID_textBox = new System.Windows.Forms.TextBox();
            this.GetDrID_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your SSN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubmitFeedback_button
            // 
            this.SubmitFeedback_button.Location = new System.Drawing.Point(309, 309);
            this.SubmitFeedback_button.Name = "SubmitFeedback_button";
            this.SubmitFeedback_button.Size = new System.Drawing.Size(129, 60);
            this.SubmitFeedback_button.TabIndex = 2;
            this.SubmitFeedback_button.Text = "Submit Feedback";
            this.SubmitFeedback_button.UseVisualStyleBackColor = true;
            this.SubmitFeedback_button.Click += new System.EventHandler(this.SubmitFeedback_button_Click);
            // 
            // Feedback_textBox
            // 
            this.Feedback_textBox.Location = new System.Drawing.Point(260, 249);
            this.Feedback_textBox.Name = "Feedback_textBox";
            this.Feedback_textBox.Size = new System.Drawing.Size(255, 22);
            this.Feedback_textBox.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Dr First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Write Your FeedBack ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PSSN_textBox
            // 
            this.PSSN_textBox.Location = new System.Drawing.Point(149, 20);
            this.PSSN_textBox.Name = "PSSN_textBox";
            this.PSSN_textBox.Size = new System.Drawing.Size(100, 22);
            this.PSSN_textBox.TabIndex = 9;
            this.PSSN_textBox.TextChanged += new System.EventHandler(this.PSSN_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Please Click on your and Doctor GetID before submitting your Feedback";
            // 
            // DrLname_textBox
            // 
            this.DrLname_textBox.Location = new System.Drawing.Point(404, 86);
            this.DrLname_textBox.Name = "DrLname_textBox";
            this.DrLname_textBox.Size = new System.Drawing.Size(100, 22);
            this.DrLname_textBox.TabIndex = 11;
            // 
            // DrFname_textBox
            // 
            this.DrFname_textBox.Location = new System.Drawing.Point(149, 83);
            this.DrFname_textBox.Name = "DrFname_textBox";
            this.DrFname_textBox.Size = new System.Drawing.Size(100, 22);
            this.DrFname_textBox.TabIndex = 12;
            // 
            // GetPatID_button
            // 
            this.GetPatID_button.Location = new System.Drawing.Point(681, 19);
            this.GetPatID_button.Name = "GetPatID_button";
            this.GetPatID_button.Size = new System.Drawing.Size(107, 23);
            this.GetPatID_button.TabIndex = 13;
            this.GetPatID_button.Text = "GetYourID";
            this.GetPatID_button.UseVisualStyleBackColor = true;
            this.GetPatID_button.Click += new System.EventHandler(this.GetPatID_button_Click);
            // 
            // PID_textBox
            // 
            this.PID_textBox.Location = new System.Drawing.Point(544, 22);
            this.PID_textBox.Name = "PID_textBox";
            this.PID_textBox.ReadOnly = true;
            this.PID_textBox.Size = new System.Drawing.Size(100, 22);
            this.PID_textBox.TabIndex = 15;
            // 
            // DRID_textBox
            // 
            this.DRID_textBox.Location = new System.Drawing.Point(544, 86);
            this.DRID_textBox.Name = "DRID_textBox";
            this.DRID_textBox.ReadOnly = true;
            this.DRID_textBox.Size = new System.Drawing.Size(100, 22);
            this.DRID_textBox.TabIndex = 16;
            // 
            // GetDrID_button
            // 
            this.GetDrID_button.Location = new System.Drawing.Point(681, 89);
            this.GetDrID_button.Name = "GetDrID_button";
            this.GetDrID_button.Size = new System.Drawing.Size(107, 23);
            this.GetDrID_button.TabIndex = 17;
            this.GetDrID_button.Text = "Get Doctor ID";
            this.GetDrID_button.UseVisualStyleBackColor = true;
            this.GetDrID_button.Click += new System.EventHandler(this.GetDrID_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Enter Dr Last Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Give_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GetDrID_button);
            this.Controls.Add(this.DRID_textBox);
            this.Controls.Add(this.PID_textBox);
            this.Controls.Add(this.GetPatID_button);
            this.Controls.Add(this.DrFname_textBox);
            this.Controls.Add(this.DrLname_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PSSN_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Feedback_textBox);
            this.Controls.Add(this.SubmitFeedback_button);
            this.Controls.Add(this.label1);
            this.Name = "Give_Feedback";
            this.Text = "Give_Feedback";
            this.Load += new System.EventHandler(this.Give_Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitFeedback_button;
        private System.Windows.Forms.TextBox Feedback_textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PSSN_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DrLname_textBox;
        private System.Windows.Forms.TextBox DrFname_textBox;
        private System.Windows.Forms.Button GetPatID_button;
        private System.Windows.Forms.TextBox PID_textBox;
        private System.Windows.Forms.TextBox DRID_textBox;
        private System.Windows.Forms.Button GetDrID_button;
        private System.Windows.Forms.Label label5;
    }
}