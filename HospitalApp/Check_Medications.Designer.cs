namespace HospitalApp
{
    partial class Check_Medications
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
            this.DrugID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QTY = new System.Windows.Forms.Label();
            this.CheckMed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drug\'s Number";
            // 
            // DrugID
            // 
            this.DrugID.FormattingEnabled = true;
            this.DrugID.Location = new System.Drawing.Point(162, 55);
            this.DrugID.Name = "DrugID";
            this.DrugID.Size = new System.Drawing.Size(121, 24);
            this.DrugID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remaining Quantity";
            // 
            // QTY
            // 
            this.QTY.AutoSize = true;
            this.QTY.Location = new System.Drawing.Point(159, 124);
            this.QTY.Name = "QTY";
            this.QTY.Size = new System.Drawing.Size(0, 16);
            this.QTY.TabIndex = 3;
            // 
            // CheckMed
            // 
            this.CheckMed.Location = new System.Drawing.Point(208, 241);
            this.CheckMed.Name = "CheckMed";
            this.CheckMed.Size = new System.Drawing.Size(75, 23);
            this.CheckMed.TabIndex = 4;
            this.CheckMed.Text = "Check";
            this.CheckMed.UseVisualStyleBackColor = true;
            this.CheckMed.Click += new System.EventHandler(this.CheckMed_Click);
            // 
            // Check_Medications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 312);
            this.Controls.Add(this.CheckMed);
            this.Controls.Add(this.QTY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DrugID);
            this.Controls.Add(this.label1);
            this.Name = "Check_Medications";
            this.Text = "Check_Medications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DrugID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label QTY;
        private System.Windows.Forms.Button CheckMed;
    }
}