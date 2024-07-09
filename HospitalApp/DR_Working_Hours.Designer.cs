namespace HospitalApp
{
    partial class DR_Working_Hours
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
            this.DR_ID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.ComboBox();
            this.Add_wh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dr\'s ID ";
            // 
            // DR_ID
            // 
            this.DR_ID.FormattingEnabled = true;
            this.DR_ID.Location = new System.Drawing.Point(137, 57);
            this.DR_ID.Name = "DR_ID";
            this.DR_ID.Size = new System.Drawing.Size(121, 24);
            this.DR_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration";
            // 
            // Duration
            // 
            this.Duration.FormattingEnabled = true;
            this.Duration.Items.AddRange(new object[] {
            "6",
            "12",
            "24"});
            this.Duration.Location = new System.Drawing.Point(137, 124);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(121, 24);
            this.Duration.TabIndex = 3;
            // 
            // Add_wh
            // 
            this.Add_wh.Location = new System.Drawing.Point(183, 236);
            this.Add_wh.Name = "Add_wh";
            this.Add_wh.Size = new System.Drawing.Size(75, 23);
            this.Add_wh.TabIndex = 4;
            this.Add_wh.Text = "ADD";
            this.Add_wh.UseVisualStyleBackColor = true;
            this.Add_wh.Click += new System.EventHandler(this.Add_wh_Click);
            // 
            // DR_Working_Hours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 450);
            this.Controls.Add(this.Add_wh);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DR_ID);
            this.Controls.Add(this.label1);
            this.Name = "DR_Working_Hours";
            this.Text = "DR_Working_Hours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DR_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Duration;
        private System.Windows.Forms.Button Add_wh;
    }
}