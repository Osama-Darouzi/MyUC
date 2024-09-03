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
    public partial class ctrlPfpHeader : UserControl
    {
        public ctrlPfpHeader()
        {
            InitializeComponent();
        }

        public virtual Color HeaderColor
        {
            get
            {
                return shHeader.FillColor;
            }
            set
            {
                shHeader.FillColor = value;
            }
        }

        public Guna2Shapes Header
        {
            get
            {
                return shHeader;
            }
            set
            {
                shHeader = value;
            }
        }

        public Guna2CirclePictureBox PFP
        {
            get
            {
                return pbProPic;
            }
            set
            {
                pbProPic = value;
            }
        }

        [Category("Appearance")]
        public Image ProfileImage
        {
            get
            {
                return pbProPic.Image;
            }
            set
            {
                pbProPic.Image = value;
            }
        }
    }
}
