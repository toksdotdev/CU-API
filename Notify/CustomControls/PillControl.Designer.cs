namespace Notify.CustomControls
{
    sealed partial class PillControl
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pillLabel = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pillLabel);
            this.panel4.Controls.Add(this.shapeContainer3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 40);
            this.panel4.TabIndex = 4;
            this.panel4.Click += new System.EventHandler(this.PillControl_Click);
            // 
            // pillLabel
            // 
            this.pillLabel.AutoSize = true;
            this.pillLabel.BackColor = System.Drawing.Color.Crimson;
            this.pillLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pillLabel.ForeColor = System.Drawing.Color.White;
            this.pillLabel.Location = new System.Drawing.Point(19, 9);
            this.pillLabel.Name = "pillLabel";
            this.pillLabel.Size = new System.Drawing.Size(86, 21);
            this.pillLabel.TabIndex = 1;
            this.pillLabel.Text = "PillControl";
            this.pillLabel.Click += new System.EventHandler(this.PillControl_Click);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer3.Size = new System.Drawing.Size(259, 40);
            this.shapeContainer3.TabIndex = 0;
            this.shapeContainer3.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.rectangleShape1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.FillColor = System.Drawing.Color.Crimson;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(3, 2);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(251, 34);
            this.rectangleShape1.Click += new System.EventHandler(this.PillControl_Click);
            // 
            // PillControl
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.panel4);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "PillControl";
            this.Size = new System.Drawing.Size(259, 40);
            this.Click += new System.EventHandler(this.PillControl_Click);
            this.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.Resize += new System.EventHandler(this.PillControl_Resize);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label pillLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}
