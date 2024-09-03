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
    public partial class PersonEditor : UserControl
    {
        private clsPerson _person = null;

        [Category("Appearance")]
        public virtual Color Theme
        {
            get
            {
                return pbProPic.HeaderColor;
            }
            set
            {
                pbProPic.HeaderColor = value;
                txtFirstName.HeaderColor = value;
                txtLastName.HeaderColor = value;
                txtEmail.HeaderColor = value;
                txtAddress.HeaderColor = value;
                phonesEditor.HeaderColor = value;
            }
        }

        protected clsPerson Person
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;
                if (value != null)
                {
                    _FillValues();
                    _person.SexChanged += _person_SexChanged;
                }
            }
        }


        public PersonEditor()
        {
            InitializeComponent();
        }

        protected virtual void _FillValues()
        {
            pbProPic.Person = Person;
            txtFirstName.Text = Person.FirstName;
            txtLastName.Text = Person.LastName;
            txtEmail.Text = Person.Email;
            txtAddress.Text = Person.Address;
            phonesEditor.Person = Person;
        }

        protected virtual void _SetValues()
        {
            Person.FirstName = txtFirstName.Text;
            Person.LastName = txtLastName.Text;
            Person.Email = txtEmail.Text;
            txtAddress.Text = txtAddress.Text;

        }

        private void _person_SexChanged(enSex sex)
        {
            if(!_person.HasImage)
                pbProPic.ProfileImage = _person.PImage;

            lblSex.Text = sex.ToString();
            SexShape.FillColor = tglSex.CheckedState.FillColor;
        }

        private void tglSex_CheckedChanged(object sender, EventArgs e)
        {
            _person.Sex = (tglSex.Checked) ? enSex.Male : enSex.Female;
        }
    }
}
