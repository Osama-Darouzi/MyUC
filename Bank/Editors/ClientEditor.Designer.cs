namespace MyUC.Bank.Editors
{
    partial class ClientEditor
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
            this.components = new System.ComponentModel.Container();
            this.txtPinCode = new MyUC.ctrlFramedTextBox();
            this.txtAccNum = new MyUC.ctrlFramedTextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiscard = new Guna.UI2.WinForms.Guna2Button();
            this.txtBalance = new MyUC.ctrlFramedTextBox();
            this.TTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(31, 168);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(31, 292);
            this.txtAddress.Size = new System.Drawing.Size(406, 69);
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // phonesEditor
            // 
            this.phonesEditor.Location = new System.Drawing.Point(31, 367);
            this.phonesEditor.Size = new System.Drawing.Size(406, 56);
            // 
            // txtPinCode
            // 
            this.txtPinCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPinCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtPinCode.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.txtPinCode.HName = "PIN Code";
            this.txtPinCode.HNameFont = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.LengthLabelColor = System.Drawing.Color.Red;
            this.txtPinCode.LengthLabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.txtPinCode.Location = new System.Drawing.Point(266, 429);
            this.txtPinCode.Max = ((short)(5));
            this.txtPinCode.Min = ((short)(5));
            this.txtPinCode.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(169, 56);
            this.txtPinCode.TabIndex = 6;
            this.txtPinCode.TextBoxFont = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPinCode.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // txtAccNum
            // 
            this.txtAccNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAccNum.BackColor = System.Drawing.SystemColors.Control;
            this.txtAccNum.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.txtAccNum.HName = "Account Number";
            this.txtAccNum.HNameFont = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNum.LengthLabelColor = System.Drawing.SystemColors.ControlText;
            this.txtAccNum.LengthLabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.txtAccNum.Location = new System.Drawing.Point(31, 429);
            this.txtAccNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAccNum.Max = ((short)(30));
            this.txtAccNum.Min = ((short)(0));
            this.txtAccNum.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(187, 56);
            this.txtAccNum.TabIndex = 5;
            this.txtAccNum.TextBoxFont = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccNum_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(303, 557);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Depth = 50;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnSave.Size = new System.Drawing.Size(114, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextOffset = new System.Drawing.Point(0, -1);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDiscard.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscard.BorderRadius = 10;
            this.btnDiscard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiscard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiscard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnDiscard.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscard.ForeColor = System.Drawing.Color.White;
            this.btnDiscard.Location = new System.Drawing.Point(58, 557);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.ShadowDecoration.Depth = 50;
            this.btnDiscard.ShadowDecoration.Enabled = true;
            this.btnDiscard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnDiscard.Size = new System.Drawing.Size(114, 40);
            this.btnDiscard.TabIndex = 8;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.TextOffset = new System.Drawing.Point(0, -1);
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBalance.BackColor = System.Drawing.SystemColors.Control;
            this.txtBalance.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.txtBalance.HName = "Initial Balance";
            this.txtBalance.HNameFont = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.LengthLabelColor = System.Drawing.SystemColors.ControlText;
            this.txtBalance.LengthLabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.txtBalance.Location = new System.Drawing.Point(58, 491);
            this.txtBalance.Max = ((short)(5));
            this.txtBalance.Min = ((short)(0));
            this.txtBalance.Mode = MyUC.ctrlFramedTextBox.enMode.Phone;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(359, 56);
            this.txtBalance.TabIndex = 7;
            this.txtBalance.TextBoxFont = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBalance.VisibleChanged += new System.EventHandler(this.txtBalance_VisibleChanged);
            this.txtBalance.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // ClientEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.txtAccNum);
            this.MinimumSize = new System.Drawing.Size(474, 561);
            this.Name = "ClientEditor";
            this.Size = new System.Drawing.Size(474, 620);
            this.Load += new System.EventHandler(this.ClientEditor_Load);
            this.Controls.SetChildIndex(this.pbProPic, 0);
            this.Controls.SetChildIndex(this.txtFirstName, 0);
            this.Controls.SetChildIndex(this.txtLastName, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.phonesEditor, 0);
            this.Controls.SetChildIndex(this.txtAccNum, 0);
            this.Controls.SetChildIndex(this.txtPinCode, 0);
            this.Controls.SetChildIndex(this.btnDiscard, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtBalance, 0);
            this.ResumeLayout(false);

        }

        #endregion

        protected ctrlFramedTextBox txtPinCode;
        protected ctrlFramedTextBox txtAccNum;
        protected Guna.UI2.WinForms.Guna2Button btnSave;
        protected Guna.UI2.WinForms.Guna2Button btnDiscard;
        protected ctrlFramedTextBox txtBalance;
        private System.Windows.Forms.ToolTip TTip;
    }
}
