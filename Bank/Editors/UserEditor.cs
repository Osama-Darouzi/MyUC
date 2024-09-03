using BankBusinessLayer;
using ControlsUtil;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using static BankBusinessLayer.AppGlobals;
using System.Windows.Forms;

namespace MyUC.Bank.Editors
{
    public partial class UserEditor : PersonEditor
    {
        private int Perm_ManageClients = 0;
        private int Perm_ManageUsers = 0;
        private int Perm_History = 0;

        private clsUser _user;


        public override Color Theme
        {
            get => base.Theme;
            set
            {
                base.Theme = value;
                txtUsername.HeaderColor = value;
                txtPassword.HeaderColor = value;
                gbPermissions.ForeColor = value;
            }
        }

        public clsUser User
        {
            get { return _user; }
            set
            {
                if (value == null)
                    value = new clsUser();

                _user = value;
                Person = value;

            
                gbPermissions.Enabled = SysUser.IsAdmin;

               _FillValues();
               
            }
        }
        public UserEditor()
        {
            InitializeComponent();
            _PreparePermissions();
        }

        private bool _CheckOn(enPermissions permission)
        {
            return (User.Permissions & (int)permission) == (int)permission;
        }

        private void _FillChkBoxesInContainer(ContainerControl container)
        {
            foreach (Control ctrl in container.Controls)
            {

                if (ctrl is ContainerControl)
                {
                    _FillChkBoxesInContainer((ContainerControl)ctrl);
                }

                if (ctrl is Guna2CheckBox && ctrl.Tag != null)
                {
                    Guna2CheckBox chk = (Guna2CheckBox)ctrl;
                    chk.Checked = _CheckOn((enPermissions)chk.Tag);
                }
            }
        }

        private void _FillPermissions()
        {
            if (chkAdmin.Checked = User.IsAdmin)
            {
                return;
            }
            
            _FillChkBoxesInContainer(gbPermissions);
        }

        protected override void _FillValues()
        {
            base._FillValues();
            txtUsername.Text = User.Username;
            txtPassword.Text = User.Password;

            if (User.IsAdmin)
                _FillPermissions();
        }

        protected override void _SetValues()
        {
            base._SetValues();
            User.Username = txtUsername.Text;
            User.Password = txtPassword.Text;

            if (User.IsAdmin)
                User.Permissions = _GetFinalPermissions();
        }

        private int _GetFinalPermissions()
        {
            if (chkAdmin.Checked) return _ValueOf(enPermissions.admin);

            int FinalP = 0;

            if (chkManageClients.Checked) FinalP += Perm_ManageClients;
            if (chkManageUsers.Checked) FinalP += Perm_ManageUsers;
            FinalP += Perm_History;

            return FinalP;
        }

        private void _PreparePermissions()
        {

            chkManageClients.Tag = enPermissions.ManageClients;
            chkAddClients.Tag = enPermissions.AddNewClient;
            chkShowClientsList.Tag = enPermissions.ShowClientsList;
            chkUpdateClients.Tag = enPermissions.UpdateClient;
            chkDeleteClients.Tag = enPermissions.DeleteClient;

            chkManageUsers.Tag = enPermissions.ManageUsers;
            chkAddUsers.Tag = enPermissions.AddNewUser;
            chkShowUsersList.Tag = enPermissions.ShowUsersList;
            chkUpdateUsers.Tag = enPermissions.UpdateUser;
            chkDeleteUsers.Tag = enPermissions.DeleteUser;
            chkTransferBalances.Tag = enPermissions.TransferBalances;
            
            chkClientsActions.Tag = enPermissions.ShowClientsActionsLog;
            chkTransferHistory.Tag = enPermissions.ShowTransferLog;

            chkUsersActions.Tag = enPermissions.ShowUsersActionsLog;
            chkLoginRegistry.Tag = enPermissions.LoginRegister;

            chkDeleteHistoryLog.Tag = enPermissions.DeleteHistoryRecords;
        }

        private int _ValueOf(object Tag)
        {
            return (int)(enPermissions)Tag;
        }

        private int _ValueOf(enPermissions permissions)
        {
            return (int)permissions;
        }

        private void chkManageClients_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox chk = (Guna2CheckBox)sender;

            if (chk.Checked)
            {
                Perm_ManageClients += _ValueOf(chk.Tag);
            }
            else
            {
                Perm_ManageClients -= _ValueOf(chk.Tag);
            }
        }

        private void chkManageUsers_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox chk = (Guna2CheckBox)sender;

            if (chk.Checked)
            {
                Perm_ManageUsers += _ValueOf(chk.Tag);
            }
            else
            {
                Perm_ManageUsers -= _ValueOf(chk.Tag);
            }
        }

        private void chkManageHistory_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox chk = (Guna2CheckBox)sender;

            if (chk.Checked)
            {
                Perm_History += _ValueOf(chk.Tag);
            }
            else
            {
                Perm_History -= _ValueOf(chk.Tag);
            }
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            chkManageClients.Enabled = chkManageUsers.Enabled = !chkAdmin.Checked;
            gbManageUsers.Enabled = gbManageClients.Enabled = gbActionsHistory.Enabled = !chkAdmin.Checked;
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Of Discarding Changes?!", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                ParentForm.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SetValues();
            User?.Save();
        }

        private void TextBoxes_Validating(object sender, CancelEventArgs e)
        {
            ctrlFramedTextBox textBox = sender as ctrlFramedTextBox;

            if (textBox.IsValid)
            {
                Err.RemoveErrorFromTxtBox(textBox, e);
            }
            else
            {
                Err.SetErrorOnTxtBox(textBox, $"Invalid Value for {textBox.HName}", e);
            }
        }


        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            bool Existence = clsUser.DoesExist(txtUsername.Text);

            if (txtUsername.IsValid && Existence)
            {
                Err.RemoveErrorFromTxtBox(txtUsername, e);
            }
            else
            {
                string ErrMessage = $"Invalid Value for {txtUsername.HName}";

                if(!Existence) ErrMessage = $"{txtUsername.Text} Already exists!";
                Err.SetErrorOnTxtBox(txtUsername, ErrMessage, e);
            }
        }
    }
}
