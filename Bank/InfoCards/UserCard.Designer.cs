using MyUC;

namespace BankUC
{
    partial class UserCard
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("On Clients", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("On History", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("On Users", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Show Clients Actions Log"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))), null);
            this.lblPassword = new MyUC.ctrlLabel();
            this.lblUsername = new MyUC.ctrlLabel();
            this.lvPermissions = new System.Windows.Forms.ListView();
            this.ch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPermission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbProPic
            // 
            this.pbProPic.Size = new System.Drawing.Size(644, 200);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(31, 245);
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(31, 308);
            // 
            // cbPhones
            // 
            this.cbPhones.Location = new System.Drawing.Point(197, 308);
            this.cbPhones.Size = new System.Drawing.Size(173, 54);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.lblPassword.HeaderText = "Password";
            this.lblPassword.Location = new System.Drawing.Point(31, 466);
            this.lblPassword.MinimumSize = new System.Drawing.Size(80, 48);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(340, 57);
            this.lblPassword.TabIndex = 30;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.lblUsername.HeaderText = "Username";
            this.lblUsername.Location = new System.Drawing.Point(31, 403);
            this.lblUsername.MinimumSize = new System.Drawing.Size(80, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(340, 57);
            this.lblUsername.TabIndex = 29;
            // 
            // lvPermissions
            // 
            this.lvPermissions.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvPermissions.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lvPermissions.BackColor = System.Drawing.SystemColors.Control;
            this.lvPermissions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch,
            this.chPermission});
            this.lvPermissions.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPermissions.FullRowSelect = true;
            listViewGroup1.Header = "On Clients";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "gClients";
            listViewGroup2.Header = "On History";
            listViewGroup2.Name = "gHistory";
            listViewGroup3.Header = "On Users";
            listViewGroup3.Name = "gUsers";
            this.lvPermissions.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.lvPermissions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvPermissions.HideSelection = false;
            this.lvPermissions.HoverSelection = true;
            this.lvPermissions.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvPermissions.Location = new System.Drawing.Point(401, 222);
            this.lvPermissions.MultiSelect = false;
            this.lvPermissions.Name = "lvPermissions";
            this.lvPermissions.Size = new System.Drawing.Size(214, 270);
            this.lvPermissions.TabIndex = 32;
            this.lvPermissions.TileSize = new System.Drawing.Size(168, 30);
            this.lvPermissions.UseCompatibleStateImageBehavior = false;
            this.lvPermissions.View = System.Windows.Forms.View.Details;
            // 
            // ch
            // 
            this.ch.Text = "";
            this.ch.Width = 1;
            // 
            // chPermission
            // 
            this.chPermission.Text = "Permission";
            this.chPermission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPermission.Width = 205;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.lblHeader.Location = new System.Drawing.Point(445, 182);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(129, 23);
            this.lblHeader.TabIndex = 33;
            this.lblHeader.Tag = "";
            this.lblHeader.Text = "Permissions";
            // 
            // UserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lvPermissions);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.MinimumSize = new System.Drawing.Size(644, 534);
            this.Name = "UserCard";
            this.Size = new System.Drawing.Size(644, 534);
            this.BackColorChanged += new System.EventHandler(this.UserCard_BackColorChanged);
            this.Controls.SetChildIndex(this.lblUsername, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.lvPermissions, 0);
            this.Controls.SetChildIndex(this.lblHeader, 0);
            this.Controls.SetChildIndex(this.pbProPic, 0);
            this.Controls.SetChildIndex(this.lblFullName, 0);
            this.Controls.SetChildIndex(this.lblSex, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblAddress, 0);
            this.Controls.SetChildIndex(this.cbPhones, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected ctrlLabel lblPassword;
        protected ctrlLabel lblUsername;
        private System.Windows.Forms.ListView lvPermissions;
        private System.Windows.Forms.ColumnHeader chPermission;
        private System.Windows.Forms.ColumnHeader ch;
        private System.Windows.Forms.Label lblHeader;
    }
}
