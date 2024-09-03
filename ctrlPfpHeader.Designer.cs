namespace MyUC
{
    partial class ctrlPfpHeader
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
            this.shHeader = new Guna.UI2.WinForms.Guna2Shapes();
            this.pbProPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            this.SuspendLayout();
            // 
            // shHeader
            // 
            this.shHeader.BorderThickness = 0;
            this.shHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.shHeader.Location = new System.Drawing.Point(0, 0);
            this.shHeader.Name = "shHeader";
            this.shHeader.PolygonSkip = 1;
            this.shHeader.Rotate = 0F;
            this.shHeader.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.shHeader.Size = new System.Drawing.Size(490, 136);
            this.shHeader.TabIndex = 3;
            this.shHeader.Text = "guna2Shapes1";
            this.shHeader.Zoom = 100;
            // 
            // pbProPic
            // 
            this.pbProPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbProPic.BackColor = System.Drawing.Color.Transparent;
            this.pbProPic.FillColor = System.Drawing.Color.Transparent;
            this.pbProPic.Image = global::MyUC.Properties.Resources.google_contacts;
            this.pbProPic.ImageRotate = 0F;
            this.pbProPic.Location = new System.Drawing.Point(170, 5);
            this.pbProPic.Margin = new System.Windows.Forms.Padding(6);
            this.pbProPic.Name = "pbProPic";
            this.pbProPic.ShadowDecoration.Depth = 50;
            this.pbProPic.ShadowDecoration.Enabled = true;
            this.pbProPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbProPic.Size = new System.Drawing.Size(150, 150);
            this.pbProPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProPic.TabIndex = 2;
            this.pbProPic.TabStop = false;
            this.pbProPic.UseTransparentBackground = true;
            // 
            // ctrlPfpHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbProPic);
            this.Controls.Add(this.shHeader);
            this.Name = "ctrlPfpHeader";
            this.Size = new System.Drawing.Size(490, 158);
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Guna.UI2.WinForms.Guna2CirclePictureBox pbProPic;
        protected Guna.UI2.WinForms.Guna2Shapes shHeader;
    }
}
