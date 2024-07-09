namespace HospitalApp
{
    partial class ViewPatientsInfo
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
            this.DrID_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewAllPat_button = new System.Windows.Forms.Button();
            this.GetallPat_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GetallPat_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DrID_textBox
            // 
            this.DrID_textBox.Location = new System.Drawing.Point(237, 36);
            this.DrID_textBox.Name = "DrID_textBox";
            this.DrID_textBox.Size = new System.Drawing.Size(118, 22);
            this.DrID_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Your ID";
            // 
            // ViewAllPat_button
            // 
            this.ViewAllPat_button.Location = new System.Drawing.Point(630, 22);
            this.ViewAllPat_button.Name = "ViewAllPat_button";
            this.ViewAllPat_button.Size = new System.Drawing.Size(148, 50);
            this.ViewAllPat_button.TabIndex = 2;
            this.ViewAllPat_button.Text = "View all Patients";
            this.ViewAllPat_button.UseVisualStyleBackColor = true;
            this.ViewAllPat_button.Click += new System.EventHandler(this.ViewAllPat_button_Click);
            // 
            // GetallPat_dataGridView
            // 
            this.GetallPat_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GetallPat_dataGridView.Location = new System.Drawing.Point(0, 173);
            this.GetallPat_dataGridView.Name = "GetallPat_dataGridView";
            this.GetallPat_dataGridView.RowHeadersWidth = 51;
            this.GetallPat_dataGridView.RowTemplate.Height = 24;
            this.GetallPat_dataGridView.Size = new System.Drawing.Size(794, 265);
            this.GetallPat_dataGridView.TabIndex = 3;
            // 
            // ViewPatientsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetallPat_dataGridView);
            this.Controls.Add(this.ViewAllPat_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrID_textBox);
            this.Name = "ViewPatientsInfo";
            this.Text = "ViewPatientsInfo";
            ((System.ComponentModel.ISupportInitialize)(this.GetallPat_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DrID_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewAllPat_button;
        private System.Windows.Forms.DataGridView GetallPat_dataGridView;
    }
}