using BankBusinessLayer;
using MyUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using MyUC.Properties;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankUC
{
    public partial class PersonCard : UserControl
    {
        public PersonCard()
        {
            InitializeComponent();
            cbPhones.ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        [Category("Appearance")]
        public Color HeaderColor
        {
            get
            {
                return pbProPic.HeaderColor;
            }
            set
            {
                pbProPic.HeaderColor = value;
            }
        }

        public ctrlPfpHeader PfpHeader
        {
            get
            {
                return pbProPic;
            }
        }

        [Category("Appearance")]
        public Image PFP
        {
            get
            {
                return pbProPic.PFP.Image;
            }
            set
            {
                pbProPic.PFP.Image = value;
            }
        }

        [Category("Appearance")]
        public virtual Color Theme
        {
            get
            {
                return HeaderColor;
            }
            set
            {
                HeaderColor = value;
                pbProPic.PFP.ShadowDecoration.Color = value;
                lblFullName.HeaderColor = value;
                lblEmail.HeaderColor = value;
                lblAddress.HeaderColor = value;
                cbPhones.HeaderColor = value;
            }
        }

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
                if (value == null)
                    _EmptyValues();
                else
                    _SetValues();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //cbPhones.Width = lblAddress.Width;
            cbPhones.Location = new Point(lblAddress.Right + 6, lblAddress.Top);
            base.OnPaint(e);
        }

        protected virtual void _EmptyValues()
        {
            cbPhones.ComboBox.Items.Clear();
            PFP = Resources.google_contacts;
            lblSex.Text = string.Empty;
            lblFullName.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblAddress.Text = string.Empty;
        }

        private void _SetValues()
        {
            _SetSex(Person.Sex);
            lblFullName.Text = Person.FullName;
            lblEmail.Text = Person.Email;
            lblAddress.Text = Person.Address;
            PFP = Person.PImage;
            foreach (clsPhone phone in Person.Phones)
            {
                cbPhones.ComboBox.Items.Add(phone.Value);
            }
        }
        private void _SetSex(enSex sex)
        {
            lblSex.Text = sex.ToString();
        }

        private void ctrlLabel1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlComboBox1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }
    }
}
