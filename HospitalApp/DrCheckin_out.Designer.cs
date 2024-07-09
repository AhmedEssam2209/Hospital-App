namespace HospitalApp
{
    partial class DrCheckin_out
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
            this.submit = new System.Windows.Forms.Button();
            this.CheckOut = new System.Windows.Forms.DateTimePicker();
            this.CheckIn = new System.Windows.Forms.DateTimePicker();
            this.DrId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(412, 341);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 13;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // CheckOut
            // 
            this.CheckOut.Location = new System.Drawing.Point(366, 240);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(200, 22);
            this.CheckOut.TabIndex = 12;
            // 
            // CheckIn
            // 
            this.CheckIn.Location = new System.Drawing.Point(366, 165);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(200, 22);
            this.CheckIn.TabIndex = 11;
            // 
            // DrId
            // 
            this.DrId.FormattingEnabled = true;
            this.DrId.Location = new System.Drawing.Point(366, 87);
            this.DrId.Name = "DrId";
            this.DrId.Size = new System.Drawing.Size(121, 24);
            this.DrId.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Exit date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Entry date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dr\'s ID";
            // 
            // DrCheckin_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.CheckIn);
            this.Controls.Add(this.DrId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DrCheckin_out";
            this.Text = "DrCheckin_out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DateTimePicker CheckOut;
        private System.Windows.Forms.DateTimePicker CheckIn;
        private System.Windows.Forms.ComboBox DrId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}