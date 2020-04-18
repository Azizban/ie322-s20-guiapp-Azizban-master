namespace Program
{
    partial class frmRandom
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
            this.BtnGenerateRandomColor = new System.Windows.Forms.Button();
            this.BtnNumber = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGenerateRandomColor
            // 
            this.BtnGenerateRandomColor.Location = new System.Drawing.Point(88, 191);
            this.BtnGenerateRandomColor.Name = "BtnGenerateRandomColor";
            this.BtnGenerateRandomColor.Size = new System.Drawing.Size(123, 119);
            this.BtnGenerateRandomColor.TabIndex = 0;
            this.BtnGenerateRandomColor.Text = "Generate Random Color";
            this.BtnGenerateRandomColor.UseVisualStyleBackColor = true;
            this.BtnGenerateRandomColor.Click += new System.EventHandler(this.BtnGenerateRandomColor_Click);
            // 
            // BtnNumber
            // 
            this.BtnNumber.Location = new System.Drawing.Point(88, 26);
            this.BtnNumber.Name = "BtnNumber";
            this.BtnNumber.Size = new System.Drawing.Size(123, 119);
            this.BtnNumber.TabIndex = 1;
            this.BtnNumber.Text = "Random Number";
            this.BtnNumber.UseVisualStyleBackColor = true;
            this.BtnNumber.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(577, 297);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(128, 40);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnNumber);
            this.Controls.Add(this.BtnGenerateRandomColor);
            this.Name = "frmRandom";
            this.Text = "frmRandom";
            this.Load += new System.EventHandler(this.frmRandom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerateRandomColor;
        private System.Windows.Forms.Button BtnNumber;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
    }
}