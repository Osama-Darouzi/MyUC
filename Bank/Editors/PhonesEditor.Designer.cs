namespace MyUC.Bank.Editors
{
    partial class PhonesEditor
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
            this.cbPhones = new System.Windows.Forms.ComboBox();
            this.btnRefreshMode = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtEditor = new MyUC.ctrlFramedTextBox();
            this.SuspendLayout();
            // 
            // cbPhones
            // 
            this.cbPhones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbPhones.BackColor = System.Drawing.SystemColors.Control;
            this.cbPhones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhones.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhones.FormattingEnabled = true;
            this.cbPhones.Location = new System.Drawing.Point(222, 13);
            this.cbPhones.Name = "cbPhones";
            this.cbPhones.Size = new System.Drawing.Size(141, 33);
            this.cbPhones.TabIndex = 4;
            this.cbPhones.SelectedIndexChanged += new System.EventHandler(this.cbPhones_SelectedIndexChanged);
            // 
            // btnRefreshMode
            // 
            this.btnRefreshMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefreshMode.BorderRadius = 5;
            this.btnRefreshMode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshMode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshMode.FillColor = System.Drawing.Color.Transparent;
            this.btnRefreshMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshMode.ForeColor = System.Drawing.Color.White;
            this.btnRefreshMode.Image = global::MyUC.Properties.Resources.loading_arrow;
            this.btnRefreshMode.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnRefreshMode.ImageSize = new System.Drawing.Size(14, 14);
            this.btnRefreshMode.Location = new System.Drawing.Point(174, 42);
            this.btnRefreshMode.Name = "btnRefreshMode";
            this.btnRefreshMode.Size = new System.Drawing.Size(15, 14);
            this.btnRefreshMode.TabIndex = 5;
            this.btnRefreshMode.Click += new System.EventHandler(this.btnRefreshMode_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::MyUC.Properties.Resources.delete;
            this.btnDelete.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(186, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::MyUC.Properties.Resources.add;
            this.btnEdit.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnEdit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEdit.Location = new System.Drawing.Point(147, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEditor.BackColor = System.Drawing.Color.Transparent;
            this.txtEditor.HName = "Phone";
            this.txtEditor.LengthLabelColor = System.Drawing.Color.Red;
            this.txtEditor.Location = new System.Drawing.Point(0, 0);
            this.txtEditor.Max = ((short)(10));
            this.txtEditor.Min = ((short)(10));
            this.txtEditor.Mode = MyUC.ctrlFramedTextBox.enMode.Phone;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(141, 56);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.Text = "09";
            this.txtEditor.TextBoxFont = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEditor.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditor_Validating);
            // 
            // PhonesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefreshMode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.cbPhones);
            this.MinimumSize = new System.Drawing.Size(366, 56);
            this.Name = "PhonesEditor";
            this.Size = new System.Drawing.Size(366, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFramedTextBox txtEditor;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.ComboBox cbPhones;
        private Guna.UI2.WinForms.Guna2Button btnRefreshMode;
    }
}
