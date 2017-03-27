using System;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;
using Notify;
using Notify.CustomControls;

namespace Notify
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guideLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pillLabel = new System.Windows.Forms.Label();
            this.windowExitButton4 = new Notify.CustomControls.WindowExitButton();
            this.windowExitButton2 = new Notify.CustomControls.WindowExitButton();
            this.windowExitButton3 = new Notify.CustomControls.WindowExitButton();
            this.sideBar1 = new Notify.SideBar();
            this.pillControl1 = new Notify.CustomControls.PillControl();
            this.windowExitButton1 = new Notify.CustomControls.WindowExitButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.windowExitButton4);
            this.panel1.Controls.Add(this.windowExitButton2);
            this.panel1.Controls.Add(this.windowExitButton3);
            this.panel1.Controls.Add(this.sideBar1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 572);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Notify.Properties.Resources.Circled_User_Male_50px_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 52);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guideLabel
            // 
            this.guideLabel.AutoSize = true;
            this.guideLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guideLabel.Location = new System.Drawing.Point(120, 95);
            this.guideLabel.Name = "guideLabel";
            this.guideLabel.Size = new System.Drawing.Size(77, 21);
            this.guideLabel.TabIndex = 1;
            this.guideLabel.Text = "Updates";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.guideLabel);
            this.panel2.Controls.Add(this.windowExitButton1);
            this.panel2.Location = new System.Drawing.Point(74, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 572);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.pillControl1);
            this.panel4.Controls.Add(this.linkLabel3);
            this.panel4.Controls.Add(this.linkLabel2);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Location = new System.Drawing.Point(313, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 419);
            this.panel4.TabIndex = 15;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.DarkOliveGreen;
            this.linkLabel3.Location = new System.Drawing.Point(9, 391);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(187, 17);
            this.linkLabel3.TabIndex = 22;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = ">> Introduction to Biochemistry";
            this.linkLabel3.Visible = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.DarkOliveGreen;
            this.linkLabel2.Location = new System.Drawing.Point(9, 364);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(187, 17);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = ">> Introduction to Biochemistry";
            this.linkLabel2.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkOliveGreen;
            this.linkLabel1.Location = new System.Drawing.Point(9, 334);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 17);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = ">> Introduction to Biochemistry";
            this.linkLabel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(321, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOTES:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.pillLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 572);
            this.panel3.TabIndex = 3;
            // 
            // pillLabel
            // 
            this.pillLabel.AutoSize = true;
            this.pillLabel.BackColor = System.Drawing.Color.White;
            this.pillLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pillLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.pillLabel.Location = new System.Drawing.Point(34, 62);
            this.pillLabel.Name = "pillLabel";
            this.pillLabel.Size = new System.Drawing.Size(87, 21);
            this.pillLabel.TabIndex = 5;
            this.pillLabel.Text = "COURSES:";
            // 
            // windowExitButton4
            // 
            this.windowExitButton4.AutoSize = true;
            this.windowExitButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.windowExitButton4.Click = null;
            this.windowExitButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowExitButton4.Location = new System.Drawing.Point(51, 6);
            this.windowExitButton4.MaximumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton4.MinimumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton4.Name = "windowExitButton4";
            this.windowExitButton4.Size = new System.Drawing.Size(17, 18);
            this.windowExitButton4.TabIndex = 4;
            this.windowExitButton4.Click += new System.EventHandler(this.windowExitButton4_Click);
            // 
            // windowExitButton2
            // 
            this.windowExitButton2.AutoSize = true;
            this.windowExitButton2.BackColor = System.Drawing.Color.Red;
            this.windowExitButton2.Click = null;
            this.windowExitButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowExitButton2.Location = new System.Drawing.Point(12, 6);
            this.windowExitButton2.MaximumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton2.MinimumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton2.Name = "windowExitButton2";
            this.windowExitButton2.Size = new System.Drawing.Size(17, 18);
            this.windowExitButton2.TabIndex = 0;
            this.windowExitButton2.Click += new System.EventHandler(this.windowExitButton2_Click);
            // 
            // windowExitButton3
            // 
            this.windowExitButton3.AutoSize = true;
            this.windowExitButton3.BackColor = System.Drawing.Color.DarkOrange;
            this.windowExitButton3.Click = null;
            this.windowExitButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowExitButton3.Location = new System.Drawing.Point(32, 6);
            this.windowExitButton3.MaximumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton3.MinimumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton3.Name = "windowExitButton3";
            this.windowExitButton3.Size = new System.Drawing.Size(17, 18);
            this.windowExitButton3.TabIndex = 3;
            this.windowExitButton3.Click += new System.EventHandler(this.windowExitButton3_Click);
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.Transparent;
            this.sideBar1.Location = new System.Drawing.Point(14, 114);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(48, 322);
            this.sideBar1.TabIndex = 2;
            // 
            // pillControl1
            // 
            this.pillControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pillControl1.AutoSize = true;
            this.pillControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.pillControl1.BackColor = System.Drawing.Color.Transparent;
            this.pillControl1.Click = null;
            this.pillControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pillControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pillControl1.Location = new System.Drawing.Point(12, 291);
            this.pillControl1.Name = "pillControl1";
            this.pillControl1.PillBackColor = System.Drawing.Color.Crimson;
            this.pillControl1.Size = new System.Drawing.Size(259, 40);
            this.pillControl1.TabIndex = 6;
            // 
            // windowExitButton1
            // 
            this.windowExitButton1.AutoSize = true;
            this.windowExitButton1.BackColor = System.Drawing.Color.DarkRed;
            this.windowExitButton1.Click = null;
            this.windowExitButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowExitButton1.Location = new System.Drawing.Point(38, 19);
            this.windowExitButton1.MaximumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton1.MinimumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton1.Name = "windowExitButton1";
            this.windowExitButton1.Size = new System.Drawing.Size(17, 18);
            this.windowExitButton1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SideBar sideBar1;
        private System.Windows.Forms.Label guideLabel;
        private System.Windows.Forms.Panel panel2;
        private global::Notify.CustomControls.WindowExitButton windowExitButton1;
        private System.Windows.Forms.Panel panel3;
        private WindowExitButton windowExitButton2;
        private Label label1;
        private Label pillLabel;
        private Panel panel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        public PillControl pillControl1;
        private WindowExitButton windowExitButton4;
        private WindowExitButton windowExitButton3;
    }
}