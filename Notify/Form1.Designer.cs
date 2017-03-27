using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;
using Notify;
using Notify.CustomControls;

namespace Notify
{
    partial class Notify
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
            this.sideBar1 = new Notify.SideBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.CloseOvalShape = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.guideLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.windowExitButton2 = new Notify.CustomControls.WindowExitButton();
            this.windowExitButton1 = new Notify.CustomControls.WindowExitButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.sideBar1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 572);
            this.panel1.TabIndex = 0;
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.Transparent;
            this.sideBar1.Location = new System.Drawing.Point(14, 114);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(48, 322);
            this.sideBar1.TabIndex = 2;
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape3,
            this.ovalShape2,
            this.CloseOvalShape});
            this.shapeContainer1.Size = new System.Drawing.Size(76, 572);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape3
            // 
            this.ovalShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ovalShape3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ovalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape3.Location = new System.Drawing.Point(52, 7);
            this.ovalShape3.Name = "ovalShape3";
            this.ovalShape3.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ovalShape3.Size = new System.Drawing.Size(10, 10);
            // 
            // ovalShape2
            // 
            this.ovalShape2.BorderColor = System.Drawing.Color.DarkOrange;
            this.ovalShape2.FillColor = System.Drawing.Color.DarkOrange;
            this.ovalShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape2.Location = new System.Drawing.Point(33, 7);
            this.ovalShape2.Name = "ovalShape2";
            this.ovalShape2.SelectionColor = System.Drawing.Color.DarkOrange;
            this.ovalShape2.Size = new System.Drawing.Size(10, 10);
            // 
            // CloseOvalShape
            // 
            this.CloseOvalShape.BackColor = System.Drawing.Color.Red;
            this.CloseOvalShape.BorderColor = System.Drawing.Color.Red;
            this.CloseOvalShape.FillColor = System.Drawing.Color.Red;
            this.CloseOvalShape.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.CloseOvalShape.Location = new System.Drawing.Point(14, 7);
            this.CloseOvalShape.Name = "CloseOvalShape";
            this.CloseOvalShape.SelectionColor = System.Drawing.Color.Red;
            this.CloseOvalShape.Size = new System.Drawing.Size(10, 10);
            this.CloseOvalShape.Click += new System.EventHandler(this.CloseOvalShape_Click);
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.windowExitButton2);
            this.panel2.Controls.Add(this.guideLabel);
            this.panel2.Controls.Add(this.windowExitButton1);
            this.panel2.Location = new System.Drawing.Point(74, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 572);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "GST221 - Nigeri and culture";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.shapeContainer2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 572);
            this.panel3.TabIndex = 3;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(281, 572);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.FillColor = System.Drawing.Color.Crimson;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(13, 54);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(254, 34);
            // 
            // windowExitButton2
            // 
            this.windowExitButton2.AutoSize = true;
            this.windowExitButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowExitButton2.Location = new System.Drawing.Point(475, 133);
            this.windowExitButton2.MaximumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton2.MinimumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton2.Name = "windowExitButton2";
            this.windowExitButton2.Size = new System.Drawing.Size(17, 18);
            this.windowExitButton2.TabIndex = 0;
            // 
            // windowExitButton1
            // 
            this.windowExitButton1.AutoSize = true;
            this.windowExitButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowExitButton1.Location = new System.Drawing.Point(38, 19);
            this.windowExitButton1.MaximumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton1.MinimumSize = new System.Drawing.Size(17, 18);
            this.windowExitButton1.Name = "windowExitButton1";
            this.windowExitButton1.Size = new System.Drawing.Size(17, 18);
            this.windowExitButton1.TabIndex = 0;
            // 
            // Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notify";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape CloseOvalShape;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SideBar sideBar1;
        private System.Windows.Forms.Label guideLabel;
        private System.Windows.Forms.Panel panel2;
        private global::Notify.CustomControls.WindowExitButton windowExitButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private WindowExitButton windowExitButton2;

    }
}

