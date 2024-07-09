namespace HospitalApp
{
    partial class View_Medications_Tests
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
            this.EnterpatientSSN_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetMed_dataGridView = new System.Windows.Forms.DataGridView();
            this.GetTests_button = new System.Windows.Forms.Button();
            this.GetTests_dataGridView = new System.Windows.Forms.DataGridView();
            this.ViewMedications_button = new System.Windows.Forms.Button();
            this.PatID_textBox = new System.Windows.Forms.TextBox();
            this.GetPatId_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GetMed_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetTests_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterpatientSSN_textBox
            // 
            this.EnterpatientSSN_textBox.Location = new System.Drawing.Point(222, 25);
            this.EnterpatientSSN_textBox.Name = "EnterpatientSSN_textBox";
            this.EnterpatientSSN_textBox.Size = new System.Drawing.Size(100, 22);
            this.EnterpatientSSN_textBox.TabIndex = 0;
            this.EnterpatientSSN_textBox.TextChanged += new System.EventHandler(this.EnterpatientSSN_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Your SSN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GetMed_dataGridView
            // 
            this.GetMed_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GetMed_dataGridView.Location = new System.Drawing.Point(12, 99);
            this.GetMed_dataGridView.Name = "GetMed_dataGridView";
            this.GetMed_dataGridView.RowHeadersWidth = 51;
            this.GetMed_dataGridView.RowTemplate.Height = 24;
            this.GetMed_dataGridView.Size = new System.Drawing.Size(376, 339);
            this.GetMed_dataGridView.TabIndex = 3;
            // 
            // GetTests_button
            // 
            this.GetTests_button.Location = new System.Drawing.Point(556, 70);
            this.GetTests_button.Name = "GetTests_button";
            this.GetTests_button.Size = new System.Drawing.Size(75, 23);
            this.GetTests_button.TabIndex = 4;
            this.GetTests_button.Text = "Get Tests";
            this.GetTests_button.UseVisualStyleBackColor = true;
            this.GetTests_button.Click += new System.EventHandler(this.GetTests_button_Click);
            // 
            // GetTests_dataGridView
            // 
            this.GetTests_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GetTests_dataGridView.Location = new System.Drawing.Point(394, 99);
            this.GetTests_dataGridView.Name = "GetTests_dataGridView";
            this.GetTests_dataGridView.RowHeadersWidth = 51;
            this.GetTests_dataGridView.RowTemplate.Height = 24;
            this.GetTests_dataGridView.Size = new System.Drawing.Size(394, 339);
            this.GetTests_dataGridView.TabIndex = 5;
            this.GetTests_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetTests_dataGridView_CellContentClick);
            // 
            // ViewMedications_button
            // 
            this.ViewMedications_button.Location = new System.Drawing.Point(147, 70);
            this.ViewMedications_button.Name = "ViewMedications_button";
            this.ViewMedications_button.Size = new System.Drawing.Size(146, 23);
            this.ViewMedications_button.TabIndex = 6;
            this.ViewMedications_button.Text = "View Medications";
            this.ViewMedications_button.UseVisualStyleBackColor = true;
            this.ViewMedications_button.Click += new System.EventHandler(this.ViewMedications_button_Click);
            // 
            // PatID_textBox
            // 
            this.PatID_textBox.Location = new System.Drawing.Point(518, 25);
            this.PatID_textBox.Name = "PatID_textBox";
            this.PatID_textBox.ReadOnly = true;
            this.PatID_textBox.Size = new System.Drawing.Size(100, 22);
            this.PatID_textBox.TabIndex = 7;
            // 
            // GetPatId_button
            // 
            this.GetPatId_button.Location = new System.Drawing.Point(666, 28);
            this.GetPatId_button.Name = "GetPatId_button";
            this.GetPatId_button.Size = new System.Drawing.Size(122, 23);
            this.GetPatId_button.TabIndex = 8;
            this.GetPatId_button.Text = "Get Patient ID";
            this.GetPatId_button.UseVisualStyleBackColor = true;
            this.GetPatId_button.Click += new System.EventHandler(this.GetPatId_button_Click);
            // 
            // View_Medications_Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetPatId_button);
            this.Controls.Add(this.PatID_textBox);
            this.Controls.Add(this.ViewMedications_button);
            this.Controls.Add(this.GetTests_dataGridView);
            this.Controls.Add(this.GetTests_button);
            this.Controls.Add(this.GetMed_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterpatientSSN_textBox);
            this.Name = "View_Medications_Tests";
            this.Text = "View_Medications_Tests";
            this.Load += new System.EventHandler(this.View_Medications_Tests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetMed_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetTests_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterpatientSSN_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GetMed_dataGridView;
        private System.Windows.Forms.Button GetTests_button;
        private System.Windows.Forms.DataGridView GetTests_dataGridView;
        private System.Windows.Forms.Button ViewMedications_button;
        private System.Windows.Forms.TextBox PatID_textBox;
        private System.Windows.Forms.Button GetPatId_button;
    }
}