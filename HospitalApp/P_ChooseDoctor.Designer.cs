namespace HospitalApp
{
    partial class P_ChooseDoctor
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
            this.DrID_comboBox = new System.Windows.Forms.ComboBox();
            this.DrInfo_dataGridView = new System.Windows.Forms.DataGridView();
            this.DrFeedback_dataGridView = new System.Windows.Forms.DataGridView();
            this.DrInfo_button = new System.Windows.Forms.Button();
            this.DrFeedback_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectYourDoctor_button = new System.Windows.Forms.Button();
            this.PatientSSN_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrInfo_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrFeedback_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your SSN";
            // 
            // DrID_comboBox
            // 
            this.DrID_comboBox.FormattingEnabled = true;
            this.DrID_comboBox.Location = new System.Drawing.Point(245, 341);
            this.DrID_comboBox.Name = "DrID_comboBox";
            this.DrID_comboBox.Size = new System.Drawing.Size(121, 24);
            this.DrID_comboBox.TabIndex = 3;
            this.DrID_comboBox.SelectedIndexChanged += new System.EventHandler(this.DrID_comboBox_SelectedIndexChanged);
            // 
            // DrInfo_dataGridView
            // 
            this.DrInfo_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrInfo_dataGridView.Location = new System.Drawing.Point(-3, 41);
            this.DrInfo_dataGridView.Name = "DrInfo_dataGridView";
            this.DrInfo_dataGridView.RowHeadersWidth = 51;
            this.DrInfo_dataGridView.RowTemplate.Height = 24;
            this.DrInfo_dataGridView.Size = new System.Drawing.Size(356, 245);
            this.DrInfo_dataGridView.TabIndex = 4;
            // 
            // DrFeedback_dataGridView
            // 
            this.DrFeedback_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrFeedback_dataGridView.Location = new System.Drawing.Point(419, 41);
            this.DrFeedback_dataGridView.Name = "DrFeedback_dataGridView";
            this.DrFeedback_dataGridView.RowHeadersWidth = 51;
            this.DrFeedback_dataGridView.RowTemplate.Height = 24;
            this.DrFeedback_dataGridView.Size = new System.Drawing.Size(339, 245);
            this.DrFeedback_dataGridView.TabIndex = 5;
            // 
            // DrInfo_button
            // 
            this.DrInfo_button.Location = new System.Drawing.Point(111, 12);
            this.DrInfo_button.Name = "DrInfo_button";
            this.DrInfo_button.Size = new System.Drawing.Size(147, 23);
            this.DrInfo_button.TabIndex = 6;
            this.DrInfo_button.Text = "Doctor Information";
            this.DrInfo_button.UseVisualStyleBackColor = true;
            this.DrInfo_button.Click += new System.EventHandler(this.DrInfo_button_Click);
            // 
            // DrFeedback_button
            // 
            this.DrFeedback_button.Location = new System.Drawing.Point(528, 12);
            this.DrFeedback_button.Name = "DrFeedback_button";
            this.DrFeedback_button.Size = new System.Drawing.Size(143, 23);
            this.DrFeedback_button.TabIndex = 7;
            this.DrFeedback_button.Text = "Doctor feedback";
            this.DrFeedback_button.UseVisualStyleBackColor = true;
            this.DrFeedback_button.Click += new System.EventHandler(this.DrFeedback_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose your Doctor ";
            // 
            // SelectYourDoctor_button
            // 
            this.SelectYourDoctor_button.Location = new System.Drawing.Point(528, 342);
            this.SelectYourDoctor_button.Name = "SelectYourDoctor_button";
            this.SelectYourDoctor_button.Size = new System.Drawing.Size(209, 23);
            this.SelectYourDoctor_button.TabIndex = 11;
            this.SelectYourDoctor_button.Text = "Select Your Doctor";
            this.SelectYourDoctor_button.UseVisualStyleBackColor = true;
            this.SelectYourDoctor_button.Click += new System.EventHandler(this.SelectYourDoctor_button_Click);
            // 
            // PatientSSN_textBox
            // 
            this.PatientSSN_textBox.Location = new System.Drawing.Point(253, 297);
            this.PatientSSN_textBox.Name = "PatientSSN_textBox";
            this.PatientSSN_textBox.Size = new System.Drawing.Size(100, 22);
            this.PatientSSN_textBox.TabIndex = 12;
            // 
            // P_ChooseDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PatientSSN_textBox);
            this.Controls.Add(this.SelectYourDoctor_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DrFeedback_button);
            this.Controls.Add(this.DrInfo_button);
            this.Controls.Add(this.DrFeedback_dataGridView);
            this.Controls.Add(this.DrInfo_dataGridView);
            this.Controls.Add(this.DrID_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "P_ChooseDoctor";
            this.Text = "P_ChooseDoctor";
            this.Load += new System.EventHandler(this.P_ChooseDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrInfo_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrFeedback_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DrID_comboBox;
        private System.Windows.Forms.DataGridView DrInfo_dataGridView;
        private System.Windows.Forms.DataGridView DrFeedback_dataGridView;
        private System.Windows.Forms.Button DrInfo_button;
        private System.Windows.Forms.Button DrFeedback_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectYourDoctor_button;
        private System.Windows.Forms.TextBox PatientSSN_textBox;
    }
}