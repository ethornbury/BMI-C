namespace BMI
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblYourBmi = new System.Windows.Forms.Label();
            this.lblDisplyBmi = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.rdioImp = new System.Windows.Forms.RadioButton();
            this.rdioMetric = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(52, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BMI Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(13, 70);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(104, 20);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Enter height :";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(12, 101);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(106, 20);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Enter weight :";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(136, 69);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Text = "inches";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(136, 100);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.Text = "pounds";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalc.Location = new System.Drawing.Point(74, 198);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(86, 29);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblYourBmi
            // 
            this.lblYourBmi.AutoSize = true;
            this.lblYourBmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourBmi.Location = new System.Drawing.Point(19, 247);
            this.lblYourBmi.Name = "lblYourBmi";
            this.lblYourBmi.Size = new System.Drawing.Size(99, 20);
            this.lblYourBmi.TabIndex = 6;
            this.lblYourBmi.Text = "Your BMI is: ";
            // 
            // lblDisplyBmi
            // 
            this.lblDisplyBmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDisplyBmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplyBmi.Location = new System.Drawing.Point(136, 244);
            this.lblDisplyBmi.Name = "lblDisplyBmi";
            this.lblDisplyBmi.Size = new System.Drawing.Size(100, 23);
            this.lblDisplyBmi.TabIndex = 7;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRemarks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRemarks.Location = new System.Drawing.Point(21, 280);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(215, 41);
            this.lblRemarks.TabIndex = 8;
            // 
            // rdioImp
            // 
            this.rdioImp.AutoSize = true;
            this.rdioImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioImp.Location = new System.Drawing.Point(17, 135);
            this.rdioImp.Name = "rdioImp";
            this.rdioImp.Size = new System.Drawing.Size(81, 24);
            this.rdioImp.TabIndex = 9;
            this.rdioImp.TabStop = true;
            this.rdioImp.Text = "imperial";
            this.rdioImp.UseVisualStyleBackColor = true;
            // 
            // rdioMetric
            // 
            this.rdioMetric.AutoSize = true;
            this.rdioMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioMetric.Location = new System.Drawing.Point(17, 158);
            this.rdioMetric.Name = "rdioMetric";
            this.rdioMetric.Size = new System.Drawing.Size(70, 24);
            this.rdioMetric.TabIndex = 10;
            this.rdioMetric.TabStop = true;
            this.rdioMetric.Text = "metric";
            this.rdioMetric.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(272, 334);
            this.Controls.Add(this.rdioMetric);
            this.Controls.Add(this.rdioImp);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblDisplyBmi);
            this.Controls.Add(this.lblYourBmi);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblYourBmi;
        private System.Windows.Forms.Label lblDisplyBmi;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.RadioButton rdioImp;
        private System.Windows.Forms.RadioButton rdioMetric;
    }
}

