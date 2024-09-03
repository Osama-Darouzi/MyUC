namespace MyUC.Bank.Editors
{
    partial class UserEditor
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
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiscard = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new MyUC.ctrlFramedTextBox();
            this.txtUsername = new MyUC.ctrlFramedTextBox();
            this.gbManageClients = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkDeleteClients = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkUpdateClients = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkAddClients = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkShowClientsList = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gbManageUsers = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkTransferBalances = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkDeleteUsers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkUpdateUsers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkAddUsers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkShowUsersList = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gbActionsHistory = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkDeleteHistoryLog = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkTransferHistory = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkClientsActions = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkLoginRegistry = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkUsersActions = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gbPermissions = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkAdmin = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkManageUsers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkManageClients = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gbManageClients.SuspendLayout();
            this.gbManageUsers.SuspendLayout();
            this.gbActionsHistory.SuspendLayout();
            this.gbPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbProPic
            // 
            this.pbProPic.Size = new System.Drawing.Size(763, 165);
            // 
            // txtFirstName
            // 
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
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
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
            this.btnSave.Location = new System.Drawing.Point(257, 544);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Depth = 50;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnSave.Size = new System.Drawing.Size(114, 40);
            this.btnSave.TabIndex = 13;
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
            this.btnDiscard.Location = new System.Drawing.Point(60, 544);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.ShadowDecoration.Depth = 50;
            this.btnDiscard.ShadowDecoration.Enabled = true;
            this.btnDiscard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnDiscard.Size = new System.Drawing.Size(114, 40);
            this.btnDiscard.TabIndex = 12;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.TextOffset = new System.Drawing.Point(0, -1);
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.txtPassword.HName = "Password";
            this.txtPassword.HNameFont = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.LengthLabelColor = System.Drawing.Color.Red;
            this.txtPassword.LengthLabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.txtPassword.Location = new System.Drawing.Point(257, 429);
            this.txtPassword.Max = ((short)(15));
            this.txtPassword.Min = ((short)(8));
            this.txtPassword.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 56);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextBoxFont = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsername.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.txtUsername.HName = "Username";
            this.txtUsername.HNameFont = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.LengthLabelColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.LengthLabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.txtUsername.Location = new System.Drawing.Point(33, 429);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsername.Max = ((short)(30));
            this.txtUsername.Min = ((short)(0));
            this.txtUsername.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 56);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.TextBoxFont = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // gbManageClients
            // 
            this.gbManageClients.BorderRadius = 5;
            this.gbManageClients.Controls.Add(this.chkDeleteClients);
            this.gbManageClients.Controls.Add(this.chkUpdateClients);
            this.gbManageClients.Controls.Add(this.chkAddClients);
            this.gbManageClients.Controls.Add(this.chkShowClientsList);
            this.gbManageClients.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.gbManageClients.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageClients.ForeColor = System.Drawing.Color.Black;
            this.gbManageClients.Location = new System.Drawing.Point(5, 72);
            this.gbManageClients.Name = "gbManageClients";
            this.gbManageClients.Size = new System.Drawing.Size(245, 85);
            this.gbManageClients.TabIndex = 14;
            this.gbManageClients.Text = "Manage Clients";
            this.gbManageClients.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbManageClients.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // chkDeleteClients
            // 
            this.chkDeleteClients.AutoSize = true;
            this.chkDeleteClients.BackColor = System.Drawing.Color.Transparent;
            this.chkDeleteClients.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDeleteClients.CheckedState.BorderRadius = 1;
            this.chkDeleteClients.CheckedState.BorderThickness = 1;
            this.chkDeleteClients.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkDeleteClients.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteClients.Location = new System.Drawing.Point(134, 60);
            this.chkDeleteClients.Name = "chkDeleteClients";
            this.chkDeleteClients.Size = new System.Drawing.Size(106, 21);
            this.chkDeleteClients.TabIndex = 3;
            this.chkDeleteClients.Text = "Delete Clients";
            this.chkDeleteClients.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDeleteClients.UncheckedState.BorderRadius = 1;
            this.chkDeleteClients.UncheckedState.BorderThickness = 1;
            this.chkDeleteClients.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkDeleteClients.UseVisualStyleBackColor = false;
            this.chkDeleteClients.CheckedChanged += new System.EventHandler(this.chkManageClients_CheckedChanged);
            // 
            // chkUpdateClients
            // 
            this.chkUpdateClients.AutoSize = true;
            this.chkUpdateClients.BackColor = System.Drawing.Color.Transparent;
            this.chkUpdateClients.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkUpdateClients.CheckedState.BorderRadius = 1;
            this.chkUpdateClients.CheckedState.BorderThickness = 1;
            this.chkUpdateClients.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkUpdateClients.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateClients.Location = new System.Drawing.Point(134, 33);
            this.chkUpdateClients.Name = "chkUpdateClients";
            this.chkUpdateClients.Size = new System.Drawing.Size(112, 21);
            this.chkUpdateClients.TabIndex = 2;
            this.chkUpdateClients.Text = "Update Clients";
            this.chkUpdateClients.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkUpdateClients.UncheckedState.BorderRadius = 1;
            this.chkUpdateClients.UncheckedState.BorderThickness = 1;
            this.chkUpdateClients.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkUpdateClients.UseVisualStyleBackColor = false;
            this.chkUpdateClients.CheckedChanged += new System.EventHandler(this.chkManageClients_CheckedChanged);
            // 
            // chkAddClients
            // 
            this.chkAddClients.AutoSize = true;
            this.chkAddClients.BackColor = System.Drawing.Color.Transparent;
            this.chkAddClients.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAddClients.CheckedState.BorderRadius = 1;
            this.chkAddClients.CheckedState.BorderThickness = 1;
            this.chkAddClients.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkAddClients.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddClients.Location = new System.Drawing.Point(5, 60);
            this.chkAddClients.Name = "chkAddClients";
            this.chkAddClients.Size = new System.Drawing.Size(93, 21);
            this.chkAddClients.TabIndex = 1;
            this.chkAddClients.Text = "Add Clients";
            this.chkAddClients.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAddClients.UncheckedState.BorderRadius = 1;
            this.chkAddClients.UncheckedState.BorderThickness = 1;
            this.chkAddClients.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkAddClients.UseVisualStyleBackColor = false;
            this.chkAddClients.CheckedChanged += new System.EventHandler(this.chkManageClients_CheckedChanged);
            // 
            // chkShowClientsList
            // 
            this.chkShowClientsList.AutoSize = true;
            this.chkShowClientsList.BackColor = System.Drawing.Color.Transparent;
            this.chkShowClientsList.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowClientsList.CheckedState.BorderRadius = 1;
            this.chkShowClientsList.CheckedState.BorderThickness = 1;
            this.chkShowClientsList.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkShowClientsList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowClientsList.Location = new System.Drawing.Point(5, 33);
            this.chkShowClientsList.Name = "chkShowClientsList";
            this.chkShowClientsList.Size = new System.Drawing.Size(123, 21);
            this.chkShowClientsList.TabIndex = 0;
            this.chkShowClientsList.Text = "Show Clients List";
            this.chkShowClientsList.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowClientsList.UncheckedState.BorderRadius = 1;
            this.chkShowClientsList.UncheckedState.BorderThickness = 1;
            this.chkShowClientsList.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkShowClientsList.UseVisualStyleBackColor = false;
            this.chkShowClientsList.CheckedChanged += new System.EventHandler(this.chkManageClients_CheckedChanged);
            // 
            // gbManageUsers
            // 
            this.gbManageUsers.BorderRadius = 5;
            this.gbManageUsers.Controls.Add(this.chkTransferBalances);
            this.gbManageUsers.Controls.Add(this.chkDeleteUsers);
            this.gbManageUsers.Controls.Add(this.chkUpdateUsers);
            this.gbManageUsers.Controls.Add(this.chkAddUsers);
            this.gbManageUsers.Controls.Add(this.chkShowUsersList);
            this.gbManageUsers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.gbManageUsers.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageUsers.ForeColor = System.Drawing.Color.Black;
            this.gbManageUsers.Location = new System.Drawing.Point(5, 191);
            this.gbManageUsers.Name = "gbManageUsers";
            this.gbManageUsers.Size = new System.Drawing.Size(245, 110);
            this.gbManageUsers.TabIndex = 15;
            this.gbManageUsers.Text = "Manage Users";
            this.gbManageUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbManageUsers.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // chkTransferBalances
            // 
            this.chkTransferBalances.AutoSize = true;
            this.chkTransferBalances.BackColor = System.Drawing.Color.Transparent;
            this.chkTransferBalances.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkTransferBalances.CheckedState.BorderRadius = 1;
            this.chkTransferBalances.CheckedState.BorderThickness = 1;
            this.chkTransferBalances.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkTransferBalances.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransferBalances.Location = new System.Drawing.Point(58, 87);
            this.chkTransferBalances.Name = "chkTransferBalances";
            this.chkTransferBalances.Size = new System.Drawing.Size(128, 21);
            this.chkTransferBalances.TabIndex = 5;
            this.chkTransferBalances.Text = "Transfer Balances";
            this.chkTransferBalances.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkTransferBalances.UncheckedState.BorderRadius = 1;
            this.chkTransferBalances.UncheckedState.BorderThickness = 1;
            this.chkTransferBalances.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkTransferBalances.UseVisualStyleBackColor = false;
            this.chkTransferBalances.CheckedChanged += new System.EventHandler(this.chkManageUsers_CheckedChanged);
            // 
            // chkDeleteUsers
            // 
            this.chkDeleteUsers.AutoSize = true;
            this.chkDeleteUsers.BackColor = System.Drawing.Color.Transparent;
            this.chkDeleteUsers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDeleteUsers.CheckedState.BorderRadius = 1;
            this.chkDeleteUsers.CheckedState.BorderThickness = 1;
            this.chkDeleteUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkDeleteUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteUsers.Location = new System.Drawing.Point(134, 60);
            this.chkDeleteUsers.Name = "chkDeleteUsers";
            this.chkDeleteUsers.Size = new System.Drawing.Size(101, 21);
            this.chkDeleteUsers.TabIndex = 3;
            this.chkDeleteUsers.Text = "Delete Users";
            this.chkDeleteUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDeleteUsers.UncheckedState.BorderRadius = 1;
            this.chkDeleteUsers.UncheckedState.BorderThickness = 1;
            this.chkDeleteUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkDeleteUsers.UseVisualStyleBackColor = false;
            this.chkDeleteUsers.CheckedChanged += new System.EventHandler(this.chkManageUsers_CheckedChanged);
            // 
            // chkUpdateUsers
            // 
            this.chkUpdateUsers.AutoSize = true;
            this.chkUpdateUsers.BackColor = System.Drawing.Color.Transparent;
            this.chkUpdateUsers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkUpdateUsers.CheckedState.BorderRadius = 1;
            this.chkUpdateUsers.CheckedState.BorderThickness = 1;
            this.chkUpdateUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkUpdateUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateUsers.Location = new System.Drawing.Point(134, 33);
            this.chkUpdateUsers.Name = "chkUpdateUsers";
            this.chkUpdateUsers.Size = new System.Drawing.Size(107, 21);
            this.chkUpdateUsers.TabIndex = 2;
            this.chkUpdateUsers.Text = "Update Users";
            this.chkUpdateUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkUpdateUsers.UncheckedState.BorderRadius = 1;
            this.chkUpdateUsers.UncheckedState.BorderThickness = 1;
            this.chkUpdateUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkUpdateUsers.UseVisualStyleBackColor = false;
            this.chkUpdateUsers.CheckedChanged += new System.EventHandler(this.chkManageUsers_CheckedChanged);
            // 
            // chkAddUsers
            // 
            this.chkAddUsers.AutoSize = true;
            this.chkAddUsers.BackColor = System.Drawing.Color.Transparent;
            this.chkAddUsers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAddUsers.CheckedState.BorderRadius = 1;
            this.chkAddUsers.CheckedState.BorderThickness = 1;
            this.chkAddUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkAddUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddUsers.Location = new System.Drawing.Point(5, 60);
            this.chkAddUsers.Name = "chkAddUsers";
            this.chkAddUsers.Size = new System.Drawing.Size(88, 21);
            this.chkAddUsers.TabIndex = 1;
            this.chkAddUsers.Text = "Add Users";
            this.chkAddUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAddUsers.UncheckedState.BorderRadius = 1;
            this.chkAddUsers.UncheckedState.BorderThickness = 1;
            this.chkAddUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkAddUsers.UseVisualStyleBackColor = false;
            this.chkAddUsers.CheckedChanged += new System.EventHandler(this.chkManageUsers_CheckedChanged);
            // 
            // chkShowUsersList
            // 
            this.chkShowUsersList.AutoSize = true;
            this.chkShowUsersList.BackColor = System.Drawing.Color.Transparent;
            this.chkShowUsersList.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowUsersList.CheckedState.BorderRadius = 1;
            this.chkShowUsersList.CheckedState.BorderThickness = 1;
            this.chkShowUsersList.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkShowUsersList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowUsersList.Location = new System.Drawing.Point(5, 33);
            this.chkShowUsersList.Name = "chkShowUsersList";
            this.chkShowUsersList.Size = new System.Drawing.Size(118, 21);
            this.chkShowUsersList.TabIndex = 0;
            this.chkShowUsersList.Text = "Show Users List";
            this.chkShowUsersList.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowUsersList.UncheckedState.BorderRadius = 1;
            this.chkShowUsersList.UncheckedState.BorderThickness = 1;
            this.chkShowUsersList.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkShowUsersList.UseVisualStyleBackColor = false;
            this.chkShowUsersList.CheckedChanged += new System.EventHandler(this.chkManageUsers_CheckedChanged);
            // 
            // gbActionsHistory
            // 
            this.gbActionsHistory.BorderRadius = 5;
            this.gbActionsHistory.Controls.Add(this.chkDeleteHistoryLog);
            this.gbActionsHistory.Controls.Add(this.chkTransferHistory);
            this.gbActionsHistory.Controls.Add(this.chkClientsActions);
            this.gbActionsHistory.Controls.Add(this.chkLoginRegistry);
            this.gbActionsHistory.Controls.Add(this.chkUsersActions);
            this.gbActionsHistory.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.gbActionsHistory.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActionsHistory.ForeColor = System.Drawing.Color.Black;
            this.gbActionsHistory.Location = new System.Drawing.Point(6, 306);
            this.gbActionsHistory.Name = "gbActionsHistory";
            this.gbActionsHistory.Size = new System.Drawing.Size(245, 110);
            this.gbActionsHistory.TabIndex = 16;
            this.gbActionsHistory.Text = "Actions History";
            this.gbActionsHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbActionsHistory.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // chkDeleteHistoryLog
            // 
            this.chkDeleteHistoryLog.AutoSize = true;
            this.chkDeleteHistoryLog.BackColor = System.Drawing.Color.Transparent;
            this.chkDeleteHistoryLog.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDeleteHistoryLog.CheckedState.BorderRadius = 1;
            this.chkDeleteHistoryLog.CheckedState.BorderThickness = 1;
            this.chkDeleteHistoryLog.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkDeleteHistoryLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteHistoryLog.Location = new System.Drawing.Point(57, 87);
            this.chkDeleteHistoryLog.Name = "chkDeleteHistoryLog";
            this.chkDeleteHistoryLog.Size = new System.Drawing.Size(135, 21);
            this.chkDeleteHistoryLog.TabIndex = 4;
            this.chkDeleteHistoryLog.Text = "Delete History Log";
            this.chkDeleteHistoryLog.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDeleteHistoryLog.UncheckedState.BorderRadius = 1;
            this.chkDeleteHistoryLog.UncheckedState.BorderThickness = 1;
            this.chkDeleteHistoryLog.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkDeleteHistoryLog.UseVisualStyleBackColor = false;
            this.chkDeleteHistoryLog.CheckedChanged += new System.EventHandler(this.chkManageHistory_CheckedChanged);
            // 
            // chkTransferHistory
            // 
            this.chkTransferHistory.AutoSize = true;
            this.chkTransferHistory.BackColor = System.Drawing.Color.Transparent;
            this.chkTransferHistory.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkTransferHistory.CheckedState.BorderRadius = 1;
            this.chkTransferHistory.CheckedState.BorderThickness = 1;
            this.chkTransferHistory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkTransferHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransferHistory.Location = new System.Drawing.Point(130, 60);
            this.chkTransferHistory.Name = "chkTransferHistory";
            this.chkTransferHistory.Size = new System.Drawing.Size(119, 21);
            this.chkTransferHistory.TabIndex = 3;
            this.chkTransferHistory.Text = "Transfer History";
            this.chkTransferHistory.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkTransferHistory.UncheckedState.BorderRadius = 1;
            this.chkTransferHistory.UncheckedState.BorderThickness = 1;
            this.chkTransferHistory.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkTransferHistory.UseVisualStyleBackColor = false;
            this.chkTransferHistory.CheckedChanged += new System.EventHandler(this.chkManageHistory_CheckedChanged);
            // 
            // chkClientsActions
            // 
            this.chkClientsActions.AutoSize = true;
            this.chkClientsActions.BackColor = System.Drawing.Color.Transparent;
            this.chkClientsActions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkClientsActions.CheckedState.BorderRadius = 1;
            this.chkClientsActions.CheckedState.BorderThickness = 1;
            this.chkClientsActions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkClientsActions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClientsActions.Location = new System.Drawing.Point(130, 33);
            this.chkClientsActions.Name = "chkClientsActions";
            this.chkClientsActions.Size = new System.Drawing.Size(111, 21);
            this.chkClientsActions.TabIndex = 2;
            this.chkClientsActions.Text = "Clients Actions";
            this.chkClientsActions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkClientsActions.UncheckedState.BorderRadius = 1;
            this.chkClientsActions.UncheckedState.BorderThickness = 1;
            this.chkClientsActions.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkClientsActions.UseVisualStyleBackColor = false;
            this.chkClientsActions.CheckedChanged += new System.EventHandler(this.chkManageHistory_CheckedChanged);
            // 
            // chkLoginRegistry
            // 
            this.chkLoginRegistry.AutoSize = true;
            this.chkLoginRegistry.BackColor = System.Drawing.Color.Transparent;
            this.chkLoginRegistry.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkLoginRegistry.CheckedState.BorderRadius = 1;
            this.chkLoginRegistry.CheckedState.BorderThickness = 1;
            this.chkLoginRegistry.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkLoginRegistry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoginRegistry.Location = new System.Drawing.Point(5, 60);
            this.chkLoginRegistry.Name = "chkLoginRegistry";
            this.chkLoginRegistry.Size = new System.Drawing.Size(110, 21);
            this.chkLoginRegistry.TabIndex = 1;
            this.chkLoginRegistry.Text = "Login Registry";
            this.chkLoginRegistry.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkLoginRegistry.UncheckedState.BorderRadius = 1;
            this.chkLoginRegistry.UncheckedState.BorderThickness = 1;
            this.chkLoginRegistry.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkLoginRegistry.UseVisualStyleBackColor = false;
            this.chkLoginRegistry.CheckedChanged += new System.EventHandler(this.chkManageHistory_CheckedChanged);
            // 
            // chkUsersActions
            // 
            this.chkUsersActions.AutoSize = true;
            this.chkUsersActions.BackColor = System.Drawing.Color.Transparent;
            this.chkUsersActions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkUsersActions.CheckedState.BorderRadius = 1;
            this.chkUsersActions.CheckedState.BorderThickness = 1;
            this.chkUsersActions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkUsersActions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsersActions.Location = new System.Drawing.Point(5, 33);
            this.chkUsersActions.Name = "chkUsersActions";
            this.chkUsersActions.Size = new System.Drawing.Size(106, 21);
            this.chkUsersActions.TabIndex = 0;
            this.chkUsersActions.Text = "Users Actions";
            this.chkUsersActions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkUsersActions.UncheckedState.BorderRadius = 1;
            this.chkUsersActions.UncheckedState.BorderThickness = 1;
            this.chkUsersActions.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkUsersActions.UseVisualStyleBackColor = false;
            this.chkUsersActions.CheckedChanged += new System.EventHandler(this.chkManageHistory_CheckedChanged);
            // 
            // gbPermissions
            // 
            this.gbPermissions.BackColor = System.Drawing.Color.Transparent;
            this.gbPermissions.BorderRadius = 5;
            this.gbPermissions.Controls.Add(this.chkAdmin);
            this.gbPermissions.Controls.Add(this.chkManageUsers);
            this.gbPermissions.Controls.Add(this.chkManageClients);
            this.gbPermissions.Controls.Add(this.gbManageClients);
            this.gbPermissions.Controls.Add(this.gbActionsHistory);
            this.gbPermissions.Controls.Add(this.gbManageUsers);
            this.gbPermissions.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gbPermissions.FillColor = System.Drawing.Color.Transparent;
            this.gbPermissions.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.gbPermissions.Location = new System.Drawing.Point(486, 176);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(256, 422);
            this.gbPermissions.TabIndex = 15;
            this.gbPermissions.Text = "Permissions";
            this.gbPermissions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbPermissions.TextOffset = new System.Drawing.Point(0, -9);
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.BackColor = System.Drawing.Color.Transparent;
            this.chkAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAdmin.CheckedState.BorderRadius = 1;
            this.chkAdmin.CheckedState.BorderThickness = 1;
            this.chkAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkAdmin.ForeColor = System.Drawing.Color.Black;
            this.chkAdmin.Location = new System.Drawing.Point(96, 24);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(68, 21);
            this.chkAdmin.TabIndex = 19;
            this.chkAdmin.Text = "Admin";
            this.chkAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAdmin.UncheckedState.BorderRadius = 1;
            this.chkAdmin.UncheckedState.BorderThickness = 1;
            this.chkAdmin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkAdmin.UseVisualStyleBackColor = false;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.chkAdmin_CheckedChanged);
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.AutoSize = true;
            this.chkManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.chkManageUsers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkManageUsers.CheckedState.BorderRadius = 1;
            this.chkManageUsers.CheckedState.BorderThickness = 1;
            this.chkManageUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkManageUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageUsers.ForeColor = System.Drawing.Color.Black;
            this.chkManageUsers.Location = new System.Drawing.Point(11, 169);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(95, 21);
            this.chkManageUsers.TabIndex = 17;
            this.chkManageUsers.Text = "Give Access";
            this.chkManageUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkManageUsers.UncheckedState.BorderRadius = 1;
            this.chkManageUsers.UncheckedState.BorderThickness = 1;
            this.chkManageUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkManageUsers.UseVisualStyleBackColor = false;
            this.chkManageUsers.CheckedChanged += new System.EventHandler(this.chkManageUsers_CheckedChanged);
            // 
            // chkManageClients
            // 
            this.chkManageClients.AutoSize = true;
            this.chkManageClients.BackColor = System.Drawing.Color.Transparent;
            this.chkManageClients.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkManageClients.CheckedState.BorderRadius = 1;
            this.chkManageClients.CheckedState.BorderThickness = 1;
            this.chkManageClients.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.chkManageClients.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageClients.ForeColor = System.Drawing.Color.Black;
            this.chkManageClients.Location = new System.Drawing.Point(10, 49);
            this.chkManageClients.Name = "chkManageClients";
            this.chkManageClients.Size = new System.Drawing.Size(95, 21);
            this.chkManageClients.TabIndex = 4;
            this.chkManageClients.Text = "Give Access";
            this.chkManageClients.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkManageClients.UncheckedState.BorderRadius = 1;
            this.chkManageClients.UncheckedState.BorderThickness = 1;
            this.chkManageClients.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chkManageClients.UseVisualStyleBackColor = false;
            this.chkManageClients.CheckedChanged += new System.EventHandler(this.chkManageClients_CheckedChanged);
            // 
            // UserEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPermissions);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.MinimumSize = new System.Drawing.Size(763, 607);
            this.Name = "UserEditor";
            this.Size = new System.Drawing.Size(763, 607);
            this.Controls.SetChildIndex(this.txtUsername, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.btnDiscard, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.pbProPic, 0);
            this.Controls.SetChildIndex(this.txtFirstName, 0);
            this.Controls.SetChildIndex(this.txtLastName, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.phonesEditor, 0);
            this.Controls.SetChildIndex(this.gbPermissions, 0);
            this.gbManageClients.ResumeLayout(false);
            this.gbManageClients.PerformLayout();
            this.gbManageUsers.ResumeLayout(false);
            this.gbManageUsers.PerformLayout();
            this.gbActionsHistory.ResumeLayout(false);
            this.gbActionsHistory.PerformLayout();
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected Guna.UI2.WinForms.Guna2Button btnSave;
        protected Guna.UI2.WinForms.Guna2Button btnDiscard;
        protected ctrlFramedTextBox txtPassword;
        protected ctrlFramedTextBox txtUsername;
        private Guna.UI2.WinForms.Guna2GroupBox gbManageClients;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowClientsList;
        private Guna.UI2.WinForms.Guna2CheckBox chkDeleteClients;
        private Guna.UI2.WinForms.Guna2CheckBox chkUpdateClients;
        private Guna.UI2.WinForms.Guna2CheckBox chkAddClients;
        private Guna.UI2.WinForms.Guna2GroupBox gbManageUsers;
        private Guna.UI2.WinForms.Guna2CheckBox chkDeleteUsers;
        private Guna.UI2.WinForms.Guna2CheckBox chkUpdateUsers;
        private Guna.UI2.WinForms.Guna2CheckBox chkAddUsers;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowUsersList;
        private Guna.UI2.WinForms.Guna2GroupBox gbActionsHistory;
        private Guna.UI2.WinForms.Guna2CheckBox chkDeleteHistoryLog;
        private Guna.UI2.WinForms.Guna2CheckBox chkTransferHistory;
        private Guna.UI2.WinForms.Guna2CheckBox chkClientsActions;
        private Guna.UI2.WinForms.Guna2CheckBox chkLoginRegistry;
        private Guna.UI2.WinForms.Guna2CheckBox chkUsersActions;
        private Guna.UI2.WinForms.Guna2GroupBox gbPermissions;
        private Guna.UI2.WinForms.Guna2CheckBox chkManageUsers;
        private Guna.UI2.WinForms.Guna2CheckBox chkManageClients;
        private Guna.UI2.WinForms.Guna2CheckBox chkAdmin;
        private Guna.UI2.WinForms.Guna2CheckBox chkTransferBalances;
    }
}
