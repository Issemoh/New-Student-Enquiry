namespace New_Student_Enquiry
{
    partial class Form1
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
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDegreeCount = new System.Windows.Forms.Label();
            this.cbxHowDidYouHear = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.LstDegrees = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which department are you interes in?";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(73, 59);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(311, 21);
            this.cbxDepartment.TabIndex = 1;
            this.cbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxDepartment_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "What degree programs are you interested in?";
            // 
            // lblDegreeCount
            // 
            this.lblDegreeCount.AutoSize = true;
            this.lblDegreeCount.Location = new System.Drawing.Point(417, 264);
            this.lblDegreeCount.Name = "lblDegreeCount";
            this.lblDegreeCount.Size = new System.Drawing.Size(65, 15);
            this.lblDegreeCount.TabIndex = 4;
            this.lblDegreeCount.Text = "0 Selected";
            // 
            // cbxHowDidYouHear
            // 
            this.cbxHowDidYouHear.FormattingEnabled = true;
            this.cbxHowDidYouHear.Location = new System.Drawing.Point(73, 332);
            this.cbxHowDidYouHear.Name = "cbxHowDidYouHear";
            this.cbxHowDidYouHear.Size = new System.Drawing.Size(379, 21);
            this.cbxHowDidYouHear.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(167, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 25);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // LstDegrees
            // 
            this.LstDegrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstDegrees.FormattingEnabled = true;
            this.LstDegrees.ItemHeight = 12;
            this.LstDegrees.Location = new System.Drawing.Point(60, 166);
            this.LstDegrees.Name = "LstDegrees";
            this.LstDegrees.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LstDegrees.Size = new System.Drawing.Size(392, 88);
            this.LstDegrees.Sorted = true;
            this.LstDegrees.TabIndex = 10;
            this.LstDegrees.SelectedIndexChanged += new System.EventHandler(this.LstDegrees_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "How did you hear about us?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LstDegrees);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbxHowDidYouHear);
            this.Controls.Add(this.lblDegreeCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDegreeCount;
        private System.Windows.Forms.ComboBox cbxHowDidYouHear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox LstDegrees;
        private System.Windows.Forms.Label label4;
    }
}

