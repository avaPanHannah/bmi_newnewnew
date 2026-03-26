namespace bmi_newnewnew
{
    partial class frmBMI
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.pp = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.pp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.Gainsboro;
            this.grpInput.Controls.Add(this.btnRun);
            this.grpInput.Controls.Add(this.txtWeight);
            this.grpInput.Controls.Add(this.txtHeight);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.lblWeight);
            this.grpInput.Controls.Add(this.lblHeight);
            this.grpInput.Location = new System.Drawing.Point(43, 61);
            this.grpInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpInput.Size = new System.Drawing.Size(524, 287);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入";
            this.grpInput.Enter += new System.EventHandler(this.grpInput_Enter);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRun.Location = new System.Drawing.Point(407, 92);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(71, 82);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "計算";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(175, 148);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(197, 33);
            this.txtWeight.TabIndex = 4;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(175, 53);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(197, 33);
            this.txtHeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 2;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(40, 152);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(85, 24);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "體重(kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(40, 54);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(90, 24);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "身高(cm)";
            this.lblHeight.Click += new System.EventHandler(this.label1_Click);
            // 
            // pp
            // 
            this.pp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pp.Controls.Add(this.lblAdvice);
            this.pp.Controls.Add(this.lblStatus);
            this.pp.Controls.Add(this.lblResult);
            this.pp.Controls.Add(this.lblBMI);
            this.pp.Location = new System.Drawing.Point(43, 360);
            this.pp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pp.Name = "pp";
            this.pp.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pp.Size = new System.Drawing.Size(524, 253);
            this.pp.TabIndex = 1;
            this.pp.TabStop = false;
            this.pp.Text = "計算結果";
            this.pp.Enter += new System.EventHandler(this.pp_Enter);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(257, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(177, 28);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(40, 104);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(173, 24);
            this.lblBMI.TabIndex = 1;
            this.lblBMI.Text = "身體質量指數(bmi)";
            this.lblBMI.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(37, 174);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(192, 28);
            this.lblStatus.TabIndex = 3;
            // 
            // lblAdvice
            // 
            this.lblAdvice.Location = new System.Drawing.Point(37, 202);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(382, 27);
            this.lblAdvice.TabIndex = 4;
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 899);
            this.Controls.Add(this.pp);
            this.Controls.Add(this.grpInput);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmBMI";
            this.Text = "bmi計算機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.lblResult_Click);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.pp.ResumeLayout(false);
            this.pp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox pp;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAdvice;
    }
}

