using System.DirectoryServices.ActiveDirectory;
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
            this.sideBar1 = new SideBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.CloseOvalShape = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.guideLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.windowExitButton1 = new WindowExitButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.guideLabel.Location = new System.Drawing.Point(108, 7);
            this.guideLabel.Name = "guideLabel";
            this.guideLabel.Size = new System.Drawing.Size(77, 21);
            this.guideLabel.TabIndex = 1;
            this.guideLabel.Text = "Updates";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.windowExitButton1);
            this.panel2.Location = new System.Drawing.Point(74, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 498);
            this.panel2.TabIndex = 2;
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
            this.Controls.Add(this.guideLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notify";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

    }
}

