using BankBusinessLayer;
using BankUC;
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
    public partial class ctrlPfpEditor : ctrlPfpHeader
    {

        private enMode _mode;
        private clsPerson _person = null;

        private OpenFileDialog _fileDialog = new OpenFileDialog()
        {
            InitialDirectory = @"D:\Pictures",
            RestoreDirectory = true,
            AddExtension = true,
            CheckPathExists = true,
            CheckFileExists = true,
            Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
            DefaultExt = "png",
            Multiselect = false,
            ShowReadOnly = true,
            Title = "Picking a Profile Picture."
        };

        public delegate void ModeChangeEveHan(enMode Mode);
        public event ModeChangeEveHan OnModeChange;

        public enMode Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                OnModeChange?.Invoke(value);
            }
        }

        public clsPerson Person
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;
                pbProPic.Image = _person.PImage;
                _person.ProfilePicChanged += ProfilePic_Changed;
            }
        }

        public override Color HeaderColor
        {
            get => base.HeaderColor;
            set
            {
                base.HeaderColor = value;
                pbProPic.ShadowDecoration.Color = value;
                btnEditPic.ShadowDecoration.Color = value;
                btnRmvPic.ShadowDecoration.Color = value;
            }
        }

        public ctrlPfpEditor()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        private void _BehaviorAccToMode(enMode mode)
        {
            switch (mode)
            {
                case enMode.AddNew:
                    btnEditPic.Image = Properties.Resources.Add_Pic;
                    btnEditPic.FillColor = Color.LimeGreen;
                    btnRmvPic.Hide();
                    break;
                case enMode.Update:
                    btnEditPic.Image = Properties.Resources.Edit_Pic;
                    btnEditPic.FillColor = Color.LightSkyBlue;
                    btnRmvPic.Show();
                    break;
            }
        }

        private void ProfilePic_Changed(Image NewPfp)
        {
            if (NewPfp != null)
            {
                pbProPic.Image = NewPfp;
                Mode = enMode.Update;
            }
            else
            {
                Mode = enMode.AddNew;
            }
        }

        private void btnEditPic_Click(object sender, EventArgs e)
        { 
            if (_fileDialog.ShowDialog() == DialogResult.OK && _fileDialog.FileName != "")
            {
                _person.PImage = Image.FromFile(_fileDialog.FileName);
            }
        }

        private void btnRmvPic_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure of Removing The Profile Pic?!", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                _person.PImage = null;
            }
        }
    }
}
