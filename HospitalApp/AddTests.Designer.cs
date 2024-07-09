namespace HospitalApp
{
    partial class AddTests
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
            this.PID_comboBox = new System.Windows.Forms.ComboBox();
            this.TID_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTest_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PID_comboBox
            // 
            this.PID_comboBox.FormattingEnabled = true;
            this.PID_comboBox.Location = new System.Drawing.Point(114, 49);
            this.PID_comboBox.Name = "PID_comboBox";
            this.PID_comboBox.Size = new System.Drawing.Size(115, 24);
            this.PID_comboBox.TabIndex = 0;
            // 
            // TID_comboBox
            // 
            this.TID_comboBox.FormattingEnabled = true;
            this.TID_comboBox.Location = new System.Drawing.Point(114, 138);
            this.TID_comboBox.Name = "TID_comboBox";
            this.TID_comboBox.Size = new System.Drawing.Size(114, 24);
            this.TID_comboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test ID";
            // 
            // AddTest_button
            // 
            this.AddTest_button.Location = new System.Drawing.Point(394, 96);
            this.AddTest_button.Name = "AddTest_button";
            this.AddTest_button.Size = new System.Drawing.Size(173, 42);
            this.AddTest_button.TabIndex = 4;
            this.AddTest_button.Text = "Add Test";
            this.AddTest_button.UseVisualStyleBackColor = true;
            this.AddTest_button.Click += new System.EventHandler(this.AddTest_button_Click);
            // 
            // AddTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddTest_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TID_comboBox);
            this.Controls.Add(this.PID_comboBox);
            this.Name = "AddTests";
            this.Text = "AddTests";
            this.Load += new System.EventHandler(this.AddTests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PID_comboBox;
        private System.Windows.Forms.ComboBox TID_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddTest_button;
    }
}