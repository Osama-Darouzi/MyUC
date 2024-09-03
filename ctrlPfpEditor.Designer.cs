namespace MyUC
{
    partial class ctrlPfpEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPfpEditor));
            this.btnEditPic = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnRmvPic = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProPic
            // 
            this.pbProPic.ShadowDecoration.Depth = 50;
            this.pbProPic.ShadowDecoration.Enabled = true;
            this.pbProPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            // 
            // btnEditPic
            // 
            this.btnEditPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditPic.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditPic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditPic.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditPic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditPic.ForeColor = System.Drawing.Color.White;
            this.btnEditPic.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPic.Image")));
            this.btnEditPic.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnEditPic.ImageSize = new System.Drawing.Size(29, 29);
            this.btnEditPic.Location = new System.Drawing.Point(280, 113);
            this.btnEditPic.Name = "btnEditPic";
            this.btnEditPic.ShadowDecoration.Depth = 50;
            this.btnEditPic.ShadowDecoration.Enabled = true;
            this.btnEditPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEditPic.Size = new System.Drawing.Size(42, 42);
            this.btnEditPic.TabIndex = 10;
            this.btnEditPic.UseTransparentBackground = true;
            this.btnEditPic.Click += new System.EventHandler(this.btnEditPic_Click);
            // 
            // btnRmvPic
            // 
            this.btnRmvPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRmvPic.BackColor = System.Drawing.Color.Transparent;
            this.btnRmvPic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRmvPic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRmvPic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRmvPic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRmvPic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnRmvPic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRmvPic.ForeColor = System.Drawing.Color.White;
            this.btnRmvPic.Image = global::MyUC.Properties.Resources.Remove_Pic;
            this.btnRmvPic.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnRmvPic.ImageSize = new System.Drawing.Size(29, 29);
            this.btnRmvPic.Location = new System.Drawing.Point(170, 113);
            this.btnRmvPic.Name = "btnRmvPic";
            this.btnRmvPic.ShadowDecoration.Depth = 50;
            this.btnRmvPic.ShadowDecoration.Enabled = true;
            this.btnRmvPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRmvPic.Size = new System.Drawing.Size(42, 42);
            this.btnRmvPic.TabIndex = 11;
            this.btnRmvPic.UseTransparentBackground = true;
            this.btnRmvPic.Click += new System.EventHandler(this.btnRmvPic_Click);
            // 
            // ctrlPfpEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRmvPic);
            this.Controls.Add(this.btnEditPic);
            this.Name = "ctrlPfpEditor";
            this.Controls.SetChildIndex(this.pbProPic, 0);
            this.Controls.SetChildIndex(this.btnEditPic, 0);
            this.Controls.SetChildIndex(this.btnRmvPic, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnEditPic;
        private Guna.UI2.WinForms.Guna2CircleButton btnRmvPic;
    }
}
