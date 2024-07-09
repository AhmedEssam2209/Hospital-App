namespace HospitalApp
{
    partial class Doctor_Info
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
            this.Fname = new System.Windows.Forms.ComboBox();
            this.Lname = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor\'s Name";
            // 
            // Fname
            // 
            this.Fname.FormattingEnabled = true;
            this.Fname.Location = new System.Drawing.Point(150, 33);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(121, 24);
            this.Fname.TabIndex = 1;
            // 
            // Lname
            // 
            this.Lname.FormattingEnabled = true;
            this.Lname.Location = new System.Drawing.Point(277, 33);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(121, 24);
            this.Lname.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(348, 288);
            this.dataGridView1.TabIndex = 3;
            // 
            // DInfo
            // 
            this.DInfo.Location = new System.Drawing.Point(150, 395);
            this.DInfo.Name = "DInfo";
            this.DInfo.Size = new System.Drawing.Size(121, 23);
            this.DInfo.TabIndex = 4;
            this.DInfo.Text = "Show Info";
            this.DInfo.UseVisualStyleBackColor = true;
            this.DInfo.Click += new System.EventHandler(this.DInfo_Click);
            // 
            // Doctor_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.DInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.label1);
            this.Name = "Doctor_Info";
            this.Text = "Doctor_Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Fname;
        private System.Windows.Forms.ComboBox Lname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DInfo;
    }
}