using BankBusinessLayer;
using MyUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Util;
using System.Windows.Forms;

namespace BankUC
{
    public partial class UserCard : PersonCard
    {
        public UserCard()
        {
            InitializeComponent();
        }

        private clsUser _User = null;
        public clsUser User
        {
            get
            {
                return _User;
            }
            set
            {
                _User = value;
                Person = value;
                if (_User == null)
                    _EmptyValues();
                else
                    _SetValues();
            }
        }

        private ListViewGroup _GroupSelector(enPermissions Permission)
        {
            int Value = (int)Permission;

            if (Value <= 1 << 4)
                return lvPermissions.Groups["gClients"];
            else if (Value <= 1 << 9)
                return lvPermissions.Groups["gHistory"];
            else return lvPermissions.Groups["gUsers"];

        }
        private ListViewItem _LvItemCreator(enPermissions Permission)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "";
            item.SubItems.Add(StringsU.SplitOnCaps(Permission.ToString()));
            item.Group = _GroupSelector(Permission);
            item.BackColor = Color.FromArgb(255, 224, 192);
            return item;
        }

        protected override void _EmptyValues()
        {
            base._EmptyValues();
            lblUsername.Text = string.Empty;
            lblPassword.Text = string.Empty;
        }

        private void _SetValues()
        {
            lblUsername.Text = User.Username;
            lblPassword.Text = User.Password;
            foreach (enPermissions permission in (enPermissions[])Enum.GetValues(typeof(enPermissions)))
            {
                if ((User.Permissions & (int)permission) == (int)permission)
                {
                    lvPermissions.Items.Add(_LvItemCreator(permission));
                }
            }
        }

        private void UserCard_BackColorChanged(object sender, EventArgs e)
        {
            lvPermissions.BackColor = BackColor;
        }
    }
}
