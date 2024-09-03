namespace MyUC.Bank.Editors
{
    partial class PersonEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonEditor));
            this.txtLastName = new MyUC.ctrlFramedTextBox();
            this.txtFirstName = new MyUC.ctrlFramedTextBox();
            this.txtEmail = new MyUC.ctrlFramedTextBox();
            this.txtAddress = new MyUC.ctrlFramedTextBox();
            this.phonesEditor = new MyUC.Bank.Editors.PhonesEditor();
            this.pbProPic = new MyUC.ctrlPfpEditor();
            this.tglSex = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.SexShape = new Guna.UI2.WinForms.Guna2Shapes();
            this.lblSex = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastName.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.txtLastName.HName = "Last Name";
            this.txtLastName.HNameFont = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.LengthLabelColor = System.Drawing.SystemColors.ControlText;
            this.txtLastName.LengthLabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.txtLastName.Location = new System.Drawing.Point(257, 168);
            this.txtLastName.Max = ((short)(30));
            this.txtLastName.Min = ((short)(0));
            this.txtLastName.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 56);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextBoxFont = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.txtFirstName.HName = "FirstName";
            this.txtFirstName.HNameFont = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.LengthLabelColor = System.Drawing.SystemColors.ControlText;
            this.txtFirstName.LengthLabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.txtFirstName.Location = new System.Drawing.Point(33, 168);
            this.txtFirstName.Max = ((short)(30));
            this.txtFirstName.Min = ((short)(0));
            this.txtFirstName.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 56);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextBoxFont = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.txtEmail.HName = "Email";
            this.txtEmail.HNameFont = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.LengthLabelColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.LengthLabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.txtEmail.Location = new System.Drawing.Point(183, 230);
            this.txtEmail.Max = ((short)(100));
            this.txtEmail.Min = ((short)(0));
            this.txtEmail.Mode = MyUC.ctrlFramedTextBox.enMode.Email;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 56);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextBoxFont = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.txtAddress.HName = "Address";
            this.txtAddress.HNameFont = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.LengthLabelColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.LengthLabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.txtAddress.Location = new System.Drawing.Point(33, 292);
            this.txtAddress.Max = ((short)(255));
            this.txtAddress.Min = ((short)(0));
            this.txtAddress.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(404, 69);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextBoxFont = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // phonesEditor
            // 
            this.phonesEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phonesEditor.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.phonesEditor.Location = new System.Drawing.Point(33, 367);
            this.phonesEditor.MinimumSize = new System.Drawing.Size(366, 56);
            this.phonesEditor.Name = "phonesEditor";
            this.phonesEditor.Size = new System.Drawing.Size(404, 56);
            this.phonesEditor.TabIndex = 4;
            // 
            // pbProPic
            // 
            this.pbProPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbProPic.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.pbProPic.Location = new System.Drawing.Point(0, 0);
            this.pbProPic.Mode = BankBusinessLayer.enMode.AddNew;
            this.pbProPic.Name = "pbProPic";
            this.pbProPic.ProfileImage = ((System.Drawing.Image)(resources.GetObject("pbProPic.ProfileImage")));
            this.pbProPic.Size = new System.Drawing.Size(474, 165);
            this.pbProPic.TabIndex = 5;
            this.pbProPic.TabStop = false;
            // 
            // tglSex
            // 
            this.tglSex.Checked = true;
            this.tglSex.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglSex.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglSex.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglSex.CheckedState.InnerBorderRadius = 8;
            this.tglSex.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tglSex.Location = new System.Drawing.Point(39, 246);
            this.tglSex.Name = "tglSex";
            this.tglSex.Size = new System.Drawing.Size(51, 28);
            this.tglSex.TabIndex = 6;
            this.tglSex.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tglSex.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tglSex.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglSex.UncheckedState.InnerBorderRadius = 8;
            this.tglSex.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tglSex.CheckedChanged += new System.EventHandler(this.tglSex_CheckedChanged);
            // 
            // SexShape
            // 
            this.SexShape.BorderThickness = 0;
            this.SexShape.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SexShape.Location = new System.Drawing.Point(96, 242);
            this.SexShape.Name = "SexShape";
            this.SexShape.PolygonSkip = 1;
            this.SexShape.Rotate = 0F;
            this.SexShape.RoundedRadius = 19;
            this.SexShape.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.SexShape.Size = new System.Drawing.Size(81, 37);
            this.SexShape.TabIndex = 7;
            this.SexShape.Zoom = 100;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = false;
            this.lblSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblSex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(105, 249);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(62, 23);
            this.lblSex.TabIndex = 8;
            this.lblSex.Text = "Male";
            this.lblSex.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PersonEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.SexShape);
            this.Controls.Add(this.tglSex);
            this.Controls.Add(this.phonesEditor);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.pbProPic);
            this.MinimumSize = new System.Drawing.Size(474, 433);
            this.Name = "PersonEditor";
            this.Size = new System.Drawing.Size(474, 433);
            this.ResumeLayout(false);

        }

        #endregion
        protected ctrlFramedTextBox txtFirstName;
        protected ctrlFramedTextBox txtLastName;
        protected ctrlFramedTextBox txtEmail;
        protected ctrlFramedTextBox txtAddress;
        protected PhonesEditor phonesEditor;
        protected ctrlPfpEditor pbProPic;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tglSex;
        private Guna.UI2.WinForms.Guna2Shapes SexShape;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSex;
    }
}
