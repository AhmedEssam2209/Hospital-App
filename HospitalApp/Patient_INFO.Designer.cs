namespace HospitalApp
{
    partial class Patient_INFO
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Button();
            this.Lname = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(323, 318);
            this.dataGridView1.TabIndex = 2;
            // 
            // Pname
            // 
            this.Pname.FormattingEnabled = true;
            this.Pname.Location = new System.Drawing.Point(163, 32);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(87, 24);
            this.Pname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient\'s Name";
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(163, 396);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(121, 23);
            this.Info.TabIndex = 5;
            this.Info.Text = "Show Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Lname
            // 
            this.Lname.FormattingEnabled = true;
            this.Lname.Location = new System.Drawing.Point(256, 32);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(95, 24);
            this.Lname.TabIndex = 6;
            // 
            // Patient_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Patient_INFO";
            this.Text = "Patient_INFO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Pname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.ComboBox Lname;
    }
}