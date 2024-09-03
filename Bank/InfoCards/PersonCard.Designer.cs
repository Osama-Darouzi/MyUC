using MyUC;

namespace BankUC
{
    partial class PersonCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonCard));
            this.lblSex = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbPhones = new MyUC.ctrlComboBox();
            this.lblAddress = new MyUC.ctrlLabel();
            this.lblEmail = new MyUC.ctrlLabel();
            this.lblFullName = new MyUC.ctrlLabel();
            this.pbProPic = new MyUC.ctrlPfpHeader();
            this.SexShape = new Guna.UI2.WinForms.Guna2Shapes();
            this.SuspendLayout();
            // 
            // lblSex
            // 
            this.lblSex.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSex.AutoSize = false;
            this.lblSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblSex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(297, 180);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(57, 19);
            this.lblSex.TabIndex = 9;
            this.lblSex.Text = "Male";
            this.lblSex.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cbPhones
            // 
            this.cbPhones.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPhones.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.cbPhones.HeaderText = "Phones";
            this.cbPhones.Location = new System.Drawing.Point(204, 310);
            this.cbPhones.MinimumSize = new System.Drawing.Size(90, 43);
            this.cbPhones.Name = "cbPhones";
            this.cbPhones.Size = new System.Drawing.Size(163, 54);
            this.cbPhones.TabIndex = 4;
            this.cbPhones.Load += new System.EventHandler(this.ctrlComboBox1_Load);
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.lblAddress.HeaderText = "Address";
            this.lblAddress.Location = new System.Drawing.Point(31, 310);
            this.lblAddress.MinimumSize = new System.Drawing.Size(80, 55);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(160, 89);
            this.lblAddress.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.lblEmail.HeaderText = "Email";
            this.lblEmail.Location = new System.Drawing.Point(31, 247);
            this.lblEmail.MinimumSize = new System.Drawing.Size(80, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(340, 57);
            this.lblEmail.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.lblFullName.HeaderText = "Full Name";
            this.lblFullName.Location = new System.Drawing.Point(31, 184);
            this.lblFullName.MinimumSize = new System.Drawing.Size(80, 55);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(340, 57);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Load += new System.EventHandler(this.ctrlLabel1_Load);
            // 
            // pbProPic
            // 
            this.pbProPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbProPic.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.pbProPic.Location = new System.Drawing.Point(0, 0);
            this.pbProPic.Name = "pbProPic";
            this.pbProPic.ProfileImage = ((System.Drawing.Image)(resources.GetObject("pbProPic.ProfileImage")));
            this.pbProPic.Size = new System.Drawing.Size(398, 200);
            this.pbProPic.TabIndex = 0;
            // 
            // SexShape
            // 
            this.SexShape.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SexShape.BorderThickness = 0;
            this.SexShape.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SexShape.Location = new System.Drawing.Point(283, 178);
            this.SexShape.Name = "SexShape";
            this.SexShape.PolygonSkip = 1;
            this.SexShape.Rotate = 0F;
            this.SexShape.RoundedEdges.BottomLeft = false;
            this.SexShape.RoundedEdges.BottomRight = false;
            this.SexShape.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.SexShape.Size = new System.Drawing.Size(84, 23);
            this.SexShape.TabIndex = 10;
            this.SexShape.Text = "guna2Shapes1";
            this.SexShape.Zoom = 100;
            this.SexShape.Click += new System.EventHandler(this.guna2Shapes1_Click);
            // 
            // PersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.SexShape);
            this.Controls.Add(this.cbPhones);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pbProPic);
            this.MinimumSize = new System.Drawing.Size(398, 417);
            this.Name = "PersonCard";
            this.Size = new System.Drawing.Size(398, 417);
            this.ResumeLayout(false);

        }

        #endregion

        protected ctrlPfpHeader pbProPic;
        protected ctrlLabel lblFullName;
        protected ctrlLabel lblEmail;
        protected ctrlLabel lblAddress;
        protected ctrlComboBox cbPhones;
        protected Guna.UI2.WinForms.Guna2HtmlLabel lblSex;
        protected Guna.UI2.WinForms.Guna2Shapes SexShape;
    }
}
