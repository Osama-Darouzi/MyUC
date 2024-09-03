using BankBusinessLayer;
using ControlsUtil;
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
    public partial class ClientEditor : PersonEditor
    {
        private enMode _mode;
        private readonly Size EDIT_SIZE = new Size(474, 561);
        private readonly Size ADDNEW_SIZE = new Size(474, 620);

        private clsClient _client = null;

        private enMode Mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;

                switch (_mode)
                {
                    case enMode.AddNew:
                        txtBalance.Show();
                        break;
                    case enMode.Update:
                        txtBalance.Hide();
                        break;
                }
            }
        }

        public override Color Theme
        {
            get => base.Theme;
            
            set
            {
                base.Theme = value;
                txtAccNum.HeaderColor = value;
                txtPinCode.HeaderColor = value;
                txtBalance.HeaderColor = value;
            }
        }

        public clsClient Client
        {
            get
            {
                return _client;
            }
            set
            {
                if(value == null) value = new clsClient();

                _client = value;
                Person = value;

                _FillValues();
                _DetermineMode();
                
            }
        }

        public ClientEditor()
        {
            InitializeComponent();
            
        }

        private void _DetermineMode()
        {
            Mode = (Client.ID == -1) ? enMode.AddNew : enMode.Update;
        }

        protected override void _FillValues()
        {
            base._FillValues();
            txtAccNum.Text = Client.AccountNumber;
            txtPinCode.Text = Client.PinCode;
            txtBalance.Text = Client.Balance.ToString();
        }

        private void ClientEditor_Load(object sender, EventArgs e)
        {

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Of Discarding Changes?!", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                ParentForm.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client?.Save();
        }

        private void txtBalance_VisibleChanged(object sender, EventArgs e)
        {
            if (txtBalance.Visible)
            {
                Size = ADDNEW_SIZE;
            }
            else
            {
                Size = EDIT_SIZE;
            }
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

        private void txtAccNum_Validating(object sender, CancelEventArgs e)
        {
            bool Existence = clsClient.DoesExist(txtAccNum.Text);

            if (txtAccNum.IsValid && Existence)
            {
                Err.RemoveErrorFromTxtBox(txtAccNum, e);
            }
            else
            {
                string ErrMessage = $"Invalid Value for {txtAccNum.HName}";

                if(!Existence) ErrMessage = $"{txtAccNum.Text} Already exists!";
                Err.SetErrorOnTxtBox(txtAccNum, ErrMessage, e);
            }
        }
    }
}
