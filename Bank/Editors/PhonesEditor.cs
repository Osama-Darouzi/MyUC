using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUC.Bank.Editors
{
    public partial class PhonesEditor : UserControl
    {

        [Category("Appearance")]
        public Color HeaderColor
        {
            get
            {
                return txtEditor.HeaderColor;
            }
            set
            {
                txtEditor.HeaderColor = value;
            }
        }
        private enum enMode {New, Update}
        
        private enMode _mode;

        private enMode Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                _BehaviorAccToMode();
            }
        }

        private Action btnEditAction;

        private clsPerson _person;
        public clsPerson Person
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;
                _FillComboBx();
            }
        }

        public PhonesEditor()
        {
            InitializeComponent();
            Mode = enMode.New;
        }

        private void _BehaviorAccToMode()
        {
            switch (Mode)
            {
                case enMode.New:
                    cbPhones.SelectedIndex = -1;
                    btnEdit.Image = Properties.Resources.add;
                    btnEdit.FillColor = Color.LimeGreen;
                    btnDelete.Hide();
                    btnRefreshMode.Hide();
                    btnEditAction = _AddPhone;
                    txtEditor.Text = "09";
                    break;
                case enMode.Update:
                    btnEdit.Image = Properties.Resources.edit_button;
                    btnEdit.FillColor = Color.FromArgb(94, 148, 255);
                    btnDelete.Show();
                    btnRefreshMode.Show();
                    btnEditAction = _EditPhone;
                    break;
            }
        }

        private void _AddPhone()
        {
            if (!clsPhone.DoesExistIn(_person.Phones, txtEditor.Text))
            {
                clsPhone NewPhone = Person.AddPhone(txtEditor.Text);
                cbPhones.Items.Add(NewPhone);
            }
                Mode = enMode.New;
        }

        private void _EditPhone()
        {
            clsPhone CurrPhone = cbPhones.SelectedItem as clsPhone;

            if (MessageBox.Show("Are You Sure To Edit This Phone", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CurrPhone.Value = txtEditor.Text;
                _FillComboBx();
                Mode = enMode.New;
            }
        }

        private void _FillComboBx()
        {
            cbPhones.Items.Clear();
            foreach (clsPhone phone in _person.Phones)
            {
                if (!phone.DeleteMark)
                    cbPhones.Items.Add(phone);
            }
        }

        private void cbPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhones.SelectedIndex == -1) return;

            Mode = enMode.Update;
            txtEditor.Text = cbPhones.SelectedItem.ToString();
            txtEditor.Tag = cbPhones.SelectedItem;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEditAction();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cbPhones.SelectedIndex == -1) return; 

            clsPhone CurrPhone = cbPhones.SelectedItem as clsPhone;
            cbPhones.Items.Remove(cbPhones.SelectedItem);

            if (MessageBox.Show("Are You Sure To Delete This Phone", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                CurrPhone.DeleteMark = true;
        }

        private void txtEditor_Validating(object sender, CancelEventArgs e)
        {
            if (txtEditor.IsValid)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnRefreshMode_Click(object sender, EventArgs e)
        {
            Mode = enMode.New;
        }
    }
}
