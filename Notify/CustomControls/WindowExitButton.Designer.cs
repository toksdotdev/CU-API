using System.Drawing;

namespace Notify.CustomControls
{
    sealed partial class WindowExitButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseOvalShape = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CloseOvalShape
            // 
            this.CloseOvalShape.BackColor = System.Drawing.Color.Transparent;
            this.CloseOvalShape.BorderColor = System.Drawing.Color.Red;
            this.CloseOvalShape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseOvalShape.FillColor = System.Drawing.Color.Red;
            this.CloseOvalShape.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.CloseOvalShape.Location = new System.Drawing.Point(1, 1);
            this.CloseOvalShape.Name = "CloseOvalShape";
            this.CloseOvalShape.SelectionColor = System.Drawing.Color.Transparent;
            this.CloseOvalShape.Size = new System.Drawing.Size(12, 12);
            this.CloseOvalShape.MouseEnter += new System.EventHandler(this.WindowExitButton_Enter);
            this.CloseOvalShape.MouseLeave += new System.EventHandler(this.WindowExitButton_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.CloseOvalShape});
            this.shapeContainer1.Size = new System.Drawing.Size(16, 16);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BackgroundImage = global::Notify.Properties.Resources.Resize_Diagonal_10px;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(9, 9);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            this.panel1.MouseEnter += new System.EventHandler(this.WindowExitButton_Enter);
            this.panel1.MouseLeave += new System.EventHandler(this.WindowExitButton_Leave);
            // 
            // WindowExitButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(13, 13);
            this.MinimumSize = new System.Drawing.Size(16, 16);
            this.Name = "WindowExitButton";
            this.Size = new System.Drawing.Size(16, 16);
            this.MouseEnter += new System.EventHandler(this.WindowExitButton_Enter);
            this.MouseLeave += new System.EventHandler(this.WindowExitButton_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.OvalShape CloseOvalShape;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel panel1;
    }
}
