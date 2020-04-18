namespace Program
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.BtnPictureBox = new System.Windows.Forms.Button();
            this.BtnRandomCombo = new System.Windows.Forms.Button();
            this.BtnCheckBox = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button20 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.BtnEXIT = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Location = new System.Drawing.Point(59, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(150, 175);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(102, 28);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(127, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(124, 52);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(127, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCombo);
            this.groupBox2.Controls.Add(this.BtnRandom);
            this.groupBox2.Controls.Add(this.BtnRadio);
            this.groupBox2.Location = new System.Drawing.Point(360, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Controls";
            // 
            // BtnCombo
            // 
            this.BtnCombo.Location = new System.Drawing.Point(207, 28);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(120, 34);
            this.BtnCombo.TabIndex = 6;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = true;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.Location = new System.Drawing.Point(6, 31);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(120, 34);
            this.BtnRandom.TabIndex = 5;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // BtnRadio
            // 
            this.BtnRadio.Location = new System.Drawing.Point(117, 71);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(120, 34);
            this.BtnRadio.TabIndex = 4;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = true;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.BtnPictureBox);
            this.groupBox3.Controls.Add(this.BtnRandomCombo);
            this.groupBox3.Controls.Add(this.BtnCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(360, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 143);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphical";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(207, 29);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 34);
            this.button9.TabIndex = 7;
            this.button9.Text = "GroubieApp";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // BtnPictureBox
            // 
            this.BtnPictureBox.Location = new System.Drawing.Point(207, 84);
            this.BtnPictureBox.Name = "BtnPictureBox";
            this.BtnPictureBox.Size = new System.Drawing.Size(120, 34);
            this.BtnPictureBox.TabIndex = 6;
            this.BtnPictureBox.Text = "PictureBox";
            this.BtnPictureBox.UseVisualStyleBackColor = true;
            this.BtnPictureBox.Click += new System.EventHandler(this.BtnPictureBox_Click);
            // 
            // BtnRandomCombo
            // 
            this.BtnRandomCombo.Location = new System.Drawing.Point(27, 84);
            this.BtnRandomCombo.Name = "BtnRandomCombo";
            this.BtnRandomCombo.Size = new System.Drawing.Size(117, 34);
            this.BtnRandomCombo.TabIndex = 5;
            this.BtnRandomCombo.Text = "RandomCombo";
            this.BtnRandomCombo.UseVisualStyleBackColor = true;
            this.BtnRandomCombo.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // BtnCheckBox
            // 
            this.BtnCheckBox.Location = new System.Drawing.Point(27, 29);
            this.BtnCheckBox.Name = "BtnCheckBox";
            this.BtnCheckBox.Size = new System.Drawing.Size(117, 34);
            this.BtnCheckBox.TabIndex = 4;
            this.BtnCheckBox.Text = "CheckBox";
            this.BtnCheckBox.UseVisualStyleBackColor = true;
            this.BtnCheckBox.Click += new System.EventHandler(this.BtnCheckBox_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Location = new System.Drawing.Point(796, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 119);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Controls";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(136, 69);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(119, 34);
            this.button13.TabIndex = 7;
            this.button13.Text = "RandomCom";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(136, 29);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(119, 34);
            this.button12.TabIndex = 6;
            this.button12.Text = "Random";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(10, 29);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 34);
            this.button11.TabIndex = 5;
            this.button11.Text = "Timer";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(10, 69);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 34);
            this.button10.TabIndex = 4;
            this.button10.Text = "Progress";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button15);
            this.groupBox5.Controls.Add(this.button14);
            this.groupBox5.Location = new System.Drawing.Point(360, 365);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(369, 76);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Draw and Talk";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(207, 29);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(120, 34);
            this.button15.TabIndex = 5;
            this.button15.Text = "Talk";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(27, 29);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(117, 34);
            this.button14.TabIndex = 4;
            this.button14.Text = "Draw";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button19);
            this.groupBox6.Controls.Add(this.button18);
            this.groupBox6.Controls.Add(this.button17);
            this.groupBox6.Controls.Add(this.button16);
            this.groupBox6.Location = new System.Drawing.Point(796, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(286, 111);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Exam Apps";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(150, 28);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(118, 34);
            this.button19.TabIndex = 4;
            this.button19.Text = "Johari";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(10, 28);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(126, 34);
            this.button18.TabIndex = 4;
            this.button18.Text = "ABC Analysis";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(10, 71);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(126, 34);
            this.button17.TabIndex = 5;
            this.button17.Text = "Robotic Cell";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(150, 71);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(118, 34);
            this.button16.TabIndex = 4;
            this.button16.Text = "Manufacturing Cell";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button20);
            this.groupBox7.Location = new System.Drawing.Point(806, 179);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(260, 76);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Macro Controls";
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(71, 29);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(120, 34);
            this.button20.TabIndex = 4;
            this.button20.Text = "Arduino";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button23);
            this.groupBox8.Controls.Add(this.button22);
            this.groupBox8.Controls.Add(this.button21);
            this.groupBox8.Location = new System.Drawing.Point(50, 263);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(199, 165);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Collection of Classes and Methods";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(46, 94);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(106, 63);
            this.button23.TabIndex = 6;
            this.button23.Text = "A simple Calculator";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(124, 19);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(55, 69);
            this.button22.TabIndex = 5;
            this.button22.Text = "ATM";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(22, 19);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(55, 69);
            this.button21.TabIndex = 4;
            this.button21.Text = "Cars";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(6, 42);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(61, 85);
            this.button24.TabIndex = 4;
            this.button24.Text = "Arrays";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // BtnEXIT
            // 
            this.BtnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEXIT.Location = new System.Drawing.Point(877, 407);
            this.BtnEXIT.Name = "BtnEXIT";
            this.BtnEXIT.Size = new System.Drawing.Size(135, 66);
            this.BtnEXIT.TabIndex = 5;
            this.BtnEXIT.Text = "Exit";
            this.BtnEXIT.UseVisualStyleBackColor = true;
            this.BtnEXIT.Click += new System.EventHandler(this.BtnEXIT_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button24);
            this.groupBox9.Location = new System.Drawing.Point(255, 263);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(73, 157);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Arrays";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 500);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.BtnEXIT);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button BtnPictureBox;
        private System.Windows.Forms.Button BtnRandomCombo;
        private System.Windows.Forms.Button BtnCheckBox;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button BtnEXIT;
        private System.Windows.Forms.GroupBox groupBox9;
    }
}

