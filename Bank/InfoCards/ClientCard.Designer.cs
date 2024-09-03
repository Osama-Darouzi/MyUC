using Guna;
using MyUC;

namespace BankUC
{
    partial class ClientCard
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
            this.lblAccNum = new MyUC.ctrlLabel();
            this.lblPinCode = new MyUC.ctrlLabel();
            this.lblBalance = new MyUC.ctrlLabel();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.Size = new System.Drawing.Size(166, 89);
            // 
            // cbPhones
            // 
            this.cbPhones.Location = new System.Drawing.Point(203, 310);
            this.cbPhones.Size = new System.Drawing.Size(167, 55);
            // 
            // lblAccNum
            // 
            this.lblAccNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccNum.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.lblAccNum.HeaderText = "Account Number";
            this.lblAccNum.Location = new System.Drawing.Point(31, 405);
            this.lblAccNum.MinimumSize = new System.Drawing.Size(80, 48);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(340, 57);
            this.lblAccNum.TabIndex = 26;
            // 
            // lblPinCode
            // 
            this.lblPinCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPinCode.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.lblPinCode.HeaderText = "Pin Code";
            this.lblPinCode.Location = new System.Drawing.Point(31, 468);
            this.lblPinCode.MinimumSize = new System.Drawing.Size(80, 48);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(340, 57);
            this.lblPinCode.TabIndex = 27;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.lblBalance.HeaderText = "Balance";
            this.lblBalance.Location = new System.Drawing.Point(31, 531);
            this.lblBalance.MinimumSize = new System.Drawing.Size(80, 48);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(340, 57);
            this.lblBalance.TabIndex = 28;
            // 
            // ClientCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblPinCode);
            this.Controls.Add(this.lblAccNum);
            this.MinimumSize = new System.Drawing.Size(398, 602);
            this.Name = "ClientCard";
            this.Size = new System.Drawing.Size(398, 602);
            this.Controls.SetChildIndex(this.lblSex, 0);
            this.Controls.SetChildIndex(this.pbProPic, 0);
            this.Controls.SetChildIndex(this.cbPhones, 0);
            this.Controls.SetChildIndex(this.lblFullName, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblAddress, 0);
            this.Controls.SetChildIndex(this.lblAccNum, 0);
            this.Controls.SetChildIndex(this.lblPinCode, 0);
            this.Controls.SetChildIndex(this.lblBalance, 0);
            this.ResumeLayout(false);

        }

        #endregion

        protected ctrlLabel lblAccNum;
        protected ctrlLabel lblPinCode;
        protected ctrlLabel lblBalance;
    }
}
