namespace Program
{
    partial class FrmCombo
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
            this.BtnMethod1 = new System.Windows.Forms.Button();
            this.BtnMethod2 = new System.Windows.Forms.Button();
            this.BtnRemoveLastitem = new System.Windows.Forms.Button();
            this.BtnRemove2ndItem = new System.Windows.Forms.Button();
            this.BtnRemoveName = new System.Windows.Forms.Button();
            this.BtnRemoveInd = new System.Windows.Forms.Button();
            this.BtnBackCombo = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnMethod1
            // 
            this.BtnMethod1.Location = new System.Drawing.Point(106, 55);
            this.BtnMethod1.Name = "BtnMethod1";
            this.BtnMethod1.Size = new System.Drawing.Size(166, 92);
            this.BtnMethod1.TabIndex = 0;
            this.BtnMethod1.Text = "Method1";
            this.BtnMethod1.UseVisualStyleBackColor = true;
            this.BtnMethod1.Click += new System.EventHandler(this.BtnMethod1_Click);
            // 
            // BtnMethod2
            // 
            this.BtnMethod2.Location = new System.Drawing.Point(322, 55);
            this.BtnMethod2.Name = "BtnMethod2";
            this.BtnMethod2.Size = new System.Drawing.Size(166, 92);
            this.BtnMethod2.TabIndex = 1;
            this.BtnMethod2.Text = "Method2";
            this.BtnMethod2.UseVisualStyleBackColor = true;
            this.BtnMethod2.Click += new System.EventHandler(this.BtnMethod2_Click);
            // 
            // BtnRemoveLastitem
            // 
            this.BtnRemoveLastitem.Location = new System.Drawing.Point(535, 55);
            this.BtnRemoveLastitem.Name = "BtnRemoveLastitem";
            this.BtnRemoveLastitem.Size = new System.Drawing.Size(166, 92);
            this.BtnRemoveLastitem.TabIndex = 2;
            this.BtnRemoveLastitem.Text = "Remove last item";
            this.BtnRemoveLastitem.UseVisualStyleBackColor = true;
            this.BtnRemoveLastitem.Click += new System.EventHandler(this.BtnRemoveLastitem_Click_1);
            // 
            // BtnRemove2ndItem
            // 
            this.BtnRemove2ndItem.Location = new System.Drawing.Point(106, 203);
            this.BtnRemove2ndItem.Name = "BtnRemove2ndItem";
            this.BtnRemove2ndItem.Size = new System.Drawing.Size(166, 92);
            this.BtnRemove2ndItem.TabIndex = 3;
            this.BtnRemove2ndItem.Text = "Remove second last item";
            this.BtnRemove2ndItem.UseVisualStyleBackColor = true;
            this.BtnRemove2ndItem.Click += new System.EventHandler(this.BtnRemove2ndItem_Click_1);
            // 
            // BtnRemoveName
            // 
            this.BtnRemoveName.Location = new System.Drawing.Point(322, 203);
            this.BtnRemoveName.Name = "BtnRemoveName";
            this.BtnRemoveName.Size = new System.Drawing.Size(166, 92);
            this.BtnRemoveName.TabIndex = 4;
            this.BtnRemoveName.Text = "Remove Name";
            this.BtnRemoveName.UseVisualStyleBackColor = true;
            this.BtnRemoveName.Click += new System.EventHandler(this.BtnRemoveName_Click);
            // 
            // BtnRemoveInd
            // 
            this.BtnRemoveInd.Location = new System.Drawing.Point(535, 203);
            this.BtnRemoveInd.Name = "BtnRemoveInd";
            this.BtnRemoveInd.Size = new System.Drawing.Size(166, 92);
            this.BtnRemoveInd.TabIndex = 5;
            this.BtnRemoveInd.Text = "Remove by index";
            this.BtnRemoveInd.UseVisualStyleBackColor = true;
            this.BtnRemoveInd.Click += new System.EventHandler(this.BtnRemoveInd_Click_1);
            // 
            // BtnBackCombo
            // 
            this.BtnBackCombo.Location = new System.Drawing.Point(535, 353);
            this.BtnBackCombo.Name = "BtnBackCombo";
            this.BtnBackCombo.Size = new System.Drawing.Size(166, 55);
            this.BtnBackCombo.TabIndex = 6;
            this.BtnBackCombo.Text = "Back";
            this.BtnBackCombo.UseVisualStyleBackColor = true;
            this.BtnBackCombo.Click += new System.EventHandler(this.BtnBackCombo_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(131, 353);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(181, 21);
            this.CmbDays.TabIndex = 7;
            this.CmbDays.Text = "Days";
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnBackCombo);
            this.Controls.Add(this.BtnRemoveInd);
            this.Controls.Add(this.BtnRemoveName);
            this.Controls.Add(this.BtnRemove2ndItem);
            this.Controls.Add(this.BtnRemoveLastitem);
            this.Controls.Add(this.BtnMethod2);
            this.Controls.Add(this.BtnMethod1);
            this.Name = "FrmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMethod1;
        private System.Windows.Forms.Button BtnMethod2;
        private System.Windows.Forms.Button BtnRemoveLastitem;
        private System.Windows.Forms.Button BtnRemove2ndItem;
        private System.Windows.Forms.Button BtnRemoveName;
        private System.Windows.Forms.Button BtnRemoveInd;
        private System.Windows.Forms.Button BtnBackCombo;
        private System.Windows.Forms.ComboBox CmbDays;
    }
}