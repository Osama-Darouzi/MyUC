namespace MyUC.Forms
{
    partial class frmScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScreen));
            this.PnlHead = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lnkFullName = new System.Windows.Forms.LinkLabel();
            this.pbProPic = new System.Windows.Forms.PictureBox();
            this.pbStar = new System.Windows.Forms.PictureBox();
            this.btnRestore = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.BackColor = System.Drawing.Color.Transparent;
            this.PnlHead.Controls.Add(this.lblUsername);
            this.PnlHead.Controls.Add(this.lblTime);
            this.PnlHead.Controls.Add(this.lnkFullName);
            this.PnlHead.Controls.Add(this.pbProPic);
            this.PnlHead.Controls.Add(this.pbStar);
            this.PnlHead.Controls.Add(this.btnRestore);
            this.PnlHead.Controls.Add(this.btnMinimize);
            this.PnlHead.Controls.Add(this.btnClose);
            this.PnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHead.Location = new System.Drawing.Point(0, 0);
            this.PnlHead.Name = "PnlHead";
            this.PnlHead.Size = new System.Drawing.Size(800, 96);
            this.PnlHead.TabIndex = 0;
            this.PnlHead.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHead_Paint);
            this.PnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseDown);
            this.PnlHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseMove);
            this.PnlHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseUp);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(391, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 16);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(628, 8);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(81, 20);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "12:00 am";
            this.lblTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseDown);
            this.lblTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseMove);
            this.lblTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseUp);
            // 
            // lnkFullName
            // 
            this.lnkFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnkFullName.AutoSize = true;
            this.lnkFullName.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFullName.LinkColor = System.Drawing.Color.Black;
            this.lnkFullName.Location = new System.Drawing.Point(388, 16);
            this.lnkFullName.MaximumSize = new System.Drawing.Size(215, 0);
            this.lnkFullName.Name = "lnkFullName";
            this.lnkFullName.Size = new System.Drawing.Size(86, 21);
            this.lnkFullName.TabIndex = 9;
            this.lnkFullName.TabStop = true;
            this.lnkFullName.Text = "FullName";
            this.lnkFullName.Click += new System.EventHandler(this.lnkFullName_Click);
            // 
            // pbProPic
            // 
            this.pbProPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbProPic.Image = global::MyUC.Properties.Resources.google_contacts;
            this.pbProPic.Location = new System.Drawing.Point(287, 1);
            this.pbProPic.Name = "pbProPic";
            this.pbProPic.Size = new System.Drawing.Size(95, 94);
            this.pbProPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProPic.TabIndex = 8;
            this.pbProPic.TabStop = false;
            this.pbProPic.Paint += new System.Windows.Forms.PaintEventHandler(this.pbProPic_Paint);
            // 
            // pbStar
            // 
            this.pbStar.Image = ((System.Drawing.Image)(resources.GetObject("pbStar.Image")));
            this.pbStar.Location = new System.Drawing.Point(2, 1);
            this.pbStar.Name = "pbStar";
            this.pbStar.Size = new System.Drawing.Size(95, 94);
            this.pbStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStar.TabIndex = 7;
            this.pbStar.TabStop = false;
            this.pbStar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseDown);
            this.pbStar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseMove);
            this.pbStar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseUp);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.BorderRadius = 5;
            this.btnRestore.BorderThickness = 1;
            this.btnRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestore.FillColor = System.Drawing.Color.Transparent;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.HoverState.FillColor = System.Drawing.Color.LightGreen;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnRestore.ImageSize = new System.Drawing.Size(22, 22);
            this.btnRestore.Location = new System.Drawing.Point(740, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(27, 28);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderRadius = 5;
            this.btnMinimize.BorderThickness = 1;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnMinimize.Location = new System.Drawing.Point(710, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 28);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 5;
            this.btnClose.BorderThickness = 1;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(1, -1);
            this.btnClose.ImageSize = new System.Drawing.Size(45, 45);
            this.btnClose.Location = new System.Drawing.Point(770, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmScreen";
            this.Text = "frmScreen";
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        protected System.Windows.Forms.Panel PnlHead;
        protected System.Windows.Forms.PictureBox pbStar;
        protected System.Windows.Forms.PictureBox pbProPic;
        protected System.Windows.Forms.LinkLabel lnkFullName;
        protected System.Windows.Forms.Label lblTime;
        protected Guna.UI2.WinForms.Guna2Button btnRestore;
        protected Guna.UI2.WinForms.Guna2Button btnMinimize;
        protected Guna.UI2.WinForms.Guna2Button btnClose;
        protected System.Windows.Forms.Label lblUsername;
    }
}