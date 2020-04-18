namespace Program
{
    partial class frmRandomCombo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.rdoGreater = new System.Windows.Forms.RadioButton();
            this.rdoLess = new System.Windows.Forms.RadioButton();
            this.rdoGreater2 = new System.Windows.Forms.RadioButton();
            this.rdoLess2 = new System.Windows.Forms.RadioButton();
            this.cmbRandom = new System.Windows.Forms.ComboBox();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRandom);
            this.groupBox1.Controls.Add(this.rdoLess);
            this.groupBox1.Controls.Add(this.rdoGreater);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.BtnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(53, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random Gen1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbRandom2);
            this.groupBox2.Controls.Add(this.rdoGreater2);
            this.groupBox2.Controls.Add(this.rdoLess2);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Controls.Add(this.btnReset2);
            this.groupBox2.Location = new System.Drawing.Point(413, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random Gen2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(15, 46);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(85, 31);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(6, 159);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(101, 31);
            this.btnReset2.TabIndex = 1;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(6, 36);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(101, 31);
            this.BtnGenerate2.TabIndex = 2;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(15, 168);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 31);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(622, 324);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(103, 31);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // rdoGreater
            // 
            this.rdoGreater.AutoSize = true;
            this.rdoGreater.Location = new System.Drawing.Point(91, 97);
            this.rdoGreater.Name = "rdoGreater";
            this.rdoGreater.Size = new System.Drawing.Size(105, 17);
            this.rdoGreater.TabIndex = 4;
            this.rdoGreater.TabStop = true;
            this.rdoGreater.Text = "Greater than 500";
            this.rdoGreater.UseVisualStyleBackColor = true;
            this.rdoGreater.CheckedChanged += new System.EventHandler(this.rdoGreater_CheckedChanged);
            // 
            // rdoLess
            // 
            this.rdoLess.AutoSize = true;
            this.rdoLess.Location = new System.Drawing.Point(91, 131);
            this.rdoLess.Name = "rdoLess";
            this.rdoLess.Size = new System.Drawing.Size(92, 17);
            this.rdoLess.TabIndex = 5;
            this.rdoLess.TabStop = true;
            this.rdoLess.Text = "Less than 500";
            this.rdoLess.UseVisualStyleBackColor = true;
            this.rdoLess.CheckedChanged += new System.EventHandler(this.rdoLess_CheckedChanged);
            // 
            // rdoGreater2
            // 
            this.rdoGreater2.AutoSize = true;
            this.rdoGreater2.Location = new System.Drawing.Point(95, 84);
            this.rdoGreater2.Name = "rdoGreater2";
            this.rdoGreater2.Size = new System.Drawing.Size(99, 17);
            this.rdoGreater2.TabIndex = 6;
            this.rdoGreater2.TabStop = true;
            this.rdoGreater2.Text = "Greater than 50";
            this.rdoGreater2.UseVisualStyleBackColor = true;
            // 
            // rdoLess2
            // 
            this.rdoLess2.AutoSize = true;
            this.rdoLess2.Location = new System.Drawing.Point(95, 122);
            this.rdoLess2.Name = "rdoLess2";
            this.rdoLess2.Size = new System.Drawing.Size(86, 17);
            this.rdoLess2.TabIndex = 7;
            this.rdoLess2.TabStop = true;
            this.rdoLess2.Text = "Less than 50";
            this.rdoLess2.UseVisualStyleBackColor = true;
            // 
            // cmbRandom
            // 
            this.cmbRandom.FormattingEnabled = true;
            this.cmbRandom.Location = new System.Drawing.Point(229, 36);
            this.cmbRandom.Name = "cmbRandom";
            this.cmbRandom.Size = new System.Drawing.Size(88, 21);
            this.cmbRandom.TabIndex = 6;
            this.cmbRandom.SelectedIndexChanged += new System.EventHandler(this.cmbRandom_SelectedIndexChanged);
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(232, 36);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(93, 21);
            this.cmbRandom2.TabIndex = 7;
            this.cmbRandom2.SelectedIndexChanged += new System.EventHandler(this.cmbRandom2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRandomCombo";
            this.Text = "frmRandomCombo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoLess;
        private System.Windows.Forms.RadioButton rdoGreater;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoGreater2;
        private System.Windows.Forms.RadioButton rdoLess2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox cmbRandom;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.Label label1;
    }
}