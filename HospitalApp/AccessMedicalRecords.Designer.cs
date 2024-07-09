namespace HospitalApp
{
    partial class AccessMedicalRecords
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
            this.PID_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Surgeries_button = new System.Windows.Forms.Button();
            this.allergies_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // PID_textBox
            // 
            this.PID_textBox.Location = new System.Drawing.Point(78, 39);
            this.PID_textBox.Name = "PID_textBox";
            this.PID_textBox.Size = new System.Drawing.Size(147, 22);
            this.PID_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert Patient ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(304, 177);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(454, 97);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(306, 176);
            this.dataGridView2.TabIndex = 3;
            // 
            // Surgeries_button
            // 
            this.Surgeries_button.Location = new System.Drawing.Point(106, 318);
            this.Surgeries_button.Name = "Surgeries_button";
            this.Surgeries_button.Size = new System.Drawing.Size(155, 49);
            this.Surgeries_button.TabIndex = 4;
            this.Surgeries_button.Text = "Click for Past surgeries";
            this.Surgeries_button.UseVisualStyleBackColor = true;
            this.Surgeries_button.Click += new System.EventHandler(this.Surgeries_button_Click);
            // 
            // allergies_button
            // 
            this.allergies_button.Location = new System.Drawing.Point(514, 322);
            this.allergies_button.Name = "allergies_button";
            this.allergies_button.Size = new System.Drawing.Size(171, 44);
            this.allergies_button.TabIndex = 5;
            this.allergies_button.Text = "Click for allergies";
            this.allergies_button.UseVisualStyleBackColor = true;
            this.allergies_button.Click += new System.EventHandler(this.allergies_button_Click);
            // 
            // AccessMedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allergies_button);
            this.Controls.Add(this.Surgeries_button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PID_textBox);
            this.Name = "AccessMedicalRecords";
            this.Text = "AccessMedicalRecords";
            this.Load += new System.EventHandler(this.AccessMedicalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PID_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Surgeries_button;
        private System.Windows.Forms.Button allergies_button;
    }
}