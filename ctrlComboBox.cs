using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUC
{
    public partial class ctrlComboBox : UserControl
    {
        public ctrlComboBox()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public Guna2ComboBox ComboBox
        {
            get
            {
                return cb;
            }
            set
            {
                cb = value;
            }
        }

        [Category("Appearance")]
        public string HeaderText
        {
            get
            {
                return lblHeader.Text;
            }
            set
            {
                lblHeader.Text = value;
            }
        }

        [Category("Appearance")]
        public Color HeaderColor
        {
            get
            {
                return lblHeader.ForeColor;
            }
            set
            {
                lblHeader.ForeColor = value;
            }
        }



        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
