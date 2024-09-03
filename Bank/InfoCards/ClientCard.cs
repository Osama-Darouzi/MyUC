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

namespace BankUC
{
    public partial class ClientCard : PersonCard
    {
        public ClientCard()
        {
            InitializeComponent();
        }

        private clsClient _Client = null;
        public clsClient Client
        {
            get
            {
                return _Client;
            }
            set
            {
                _Client = value;
                Person = value;
                if (_Client == null)
                    _EmptyValues();
                else
                    _SetValues();
            }
        }

        public override Color Theme 
        { 
            get => base.Theme; 

            set
            {
                base.Theme = value;
                lblAccNum.HeaderColor = value;
                lblPinCode.HeaderColor = value;
                lblBalance.HeaderColor = value;
            }
        }

        protected override void _EmptyValues()
        {
            base._EmptyValues();
            lblAccNum.Text = string.Empty;
            lblPinCode.Text = string.Empty;
            lblBalance.Text = string.Empty;
        }

        private void _SetValues()
        {
            lblAccNum.Text = Client.AccountNumber;
            lblPinCode.Text = Client.PinCode;
            lblBalance.Text = Client.Balance.ToString("C");
        }
    }
}
