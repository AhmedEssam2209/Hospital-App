namespace HospitalApp
{
    partial class D_Shifts
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
            this.DR_ID = new System.Windows.Forms.ComboBox();
            this.Shift = new System.Windows.Forms.ComboBox();
            this.Assign_dr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dr\'s ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assigned Shift";
            // 
            // DR_ID
            // 
            this.DR_ID.FormattingEnabled = true;
            this.DR_ID.Location = new System.Drawing.Point(167, 66);
            this.DR_ID.Name = "DR_ID";
            this.DR_ID.Size = new System.Drawing.Size(121, 24);
            this.DR_ID.TabIndex = 2;
            // 
            // Shift
            // 
            this.Shift.FormattingEnabled = true;
            this.Shift.Items.AddRange(new object[] {
            "6 hours",
            "Day",
            "Night",
            "Full Day"});
            this.Shift.Location = new System.Drawing.Point(167, 122);
            this.Shift.Name = "Shift";
            this.Shift.Size = new System.Drawing.Size(121, 24);
            this.Shift.TabIndex = 3;
            // 
            // Assign_dr
            // 
            this.Assign_dr.Location = new System.Drawing.Point(213, 225);
            this.Assign_dr.Name = "Assign_dr";
            this.Assign_dr.Size = new System.Drawing.Size(75, 23);
            this.Assign_dr.TabIndex = 4;
            this.Assign_dr.Text = "Assign";
            this.Assign_dr.UseVisualStyleBackColor = true;
            this.Assign_dr.Click += new System.EventHandler(this.Assign_dr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 191);
            this.dataGridView1.TabIndex = 5;
            // 
            // D_Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 287);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Assign_dr);
            this.Controls.Add(this.Shift);
            this.Controls.Add(this.DR_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "D_Shifts";
            this.Text = "D_Shifts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DR_ID;
        private System.Windows.Forms.ComboBox Shift;
        private System.Windows.Forms.Button Assign_dr;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}