using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using Validations;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;

namespace MyUC
{
    public partial class ctrlFramedTextBox : UserControl
    {
        public enum enMode {Normal, Email, Phone}
        public ctrlFramedTextBox()
        {
            InitializeComponent();
            Max = 100;
            HName = "tb";
        }

        private bool _IsValid;
        private short _Min = 0;
        private short _Max = 0;
        private short _Length = 0;
        private readonly Color _NormalLabelsColor = Color.FromKnownColor(KnownColor.ActiveBorder);
        private readonly Color TBox_NORMAL_FOCUSEDCOLOR = Color.FromArgb(94, 148, 255);
        private readonly Color TBox_ERR_FOCUSEDCOLOR = Color.FromArgb(255, 60, 65);
        private Color _CurrentLblsColor;

        public bool IsValid {  get { return _IsValid; } }
        public short Min
        {
            get
            {
                return _Min;
            }
            set
            {
                if(Min > Max) value = Max;
                _Min = value;
            }
        }
        public short Max
        {
            get
            {
                return _Max;
            }

            set
            {
                _Max = value;
                lblMax.Text = "/ " + _Max.ToString();
                TBox.MaxLength = _Max;
            }
        }

        public enMode Mode { get; set; }

        private string _Name = "";

        [Category("Appearance")]
        public string HName
        {
            get
            {
                return _Name;
            }

            set
            { 
                _Name = value;
                gb1.Text = _Name;
            }
        }

        [Category("Appearance")]
        public Font HNameFont
        {
            get
            {
                return gb1.Font;
            }
            set
            {
                gb1.Font = value;
            }
        }

        [Category("Appearance")]
        public Color LengthLabelColor
        {
            get
            {
                return lblCurrent.ForeColor;
            }
            set
            {
                if (value == Color.Red)
                    value = _NormalLabelsColor;

                _CurrentLblsColor = value;
                lblCurrent.ForeColor = value; 
                lblMax.ForeColor = value;
            }
        }

        [Category("Appearance")]
        public Font LengthLabelFont
        {
            get
            {
                return lblCurrent.Font;
            }
            set
            {
                lblCurrent.Font = value;
                lblMax.Font = value;
            }
        }

        //[Category("Appearance")]
        public Color HeaderColor
        {
            get
            {
                return gb1.ForeColor;
            }
            set
            {
                gb1.ForeColor = value;
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return TBox.Text;  }
            set { TBox.Text = value; }
        }

        [Category("Appearance")]
        public Font TextBoxFont
        {
            get
            {
                return TBox.Font;
            }
            set
            {
                TBox.Font = value;
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Guna2TextBox BoxProperties
        {
            get
            {
                return TBox;
            }
        }

        public void _AppearanceAccToValidation()
        {
            if (IsValid)
                TBox.FocusedState.BorderColor = TBox_NORMAL_FOCUSEDCOLOR;
            else
                TBox.FocusedState.BorderColor = TBox_ERR_FOCUSEDCOLOR;

        }
        private void _ChangeLabelsColor(Color color)
        {
            lblCurrent.ForeColor = lblMax.ForeColor = color;
        }

        private void _RefreshStatus()
        {
            if (_Length < Min)
            {
                _ChangeLabelsColor(Color.Red);
                _IsValid = false;
            }
            else if (_Length == _Max)
            {
                _IsValid = true;
                _ChangeLabelsColor(Color.Black);
            }
            else if(lblMax.ForeColor != _CurrentLblsColor)
            {
                _IsValid = true;
                _ChangeLabelsColor(_CurrentLblsColor);
            }
        }

        private void ctrlFramedTextBox_SizeChanged(object sender, EventArgs e)
        {
            gb1.Location = new Point(3, gb1.Location.Y);
            gb1.Width = this.Width - 5;
            lblMax.Location = new Point(this.Width - lblMax.Width - 10, lblMax.Location.Y);
            lblCurrent.Location = new Point(lblMax.Location.X - lblCurrent.Width, lblCurrent.Location.Y);
        }

        private void TBox_Load(object sender, EventArgs e)
        {
            _RefreshStatus();
        }
        private void TBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Mode == enMode.Phone)
            {
                if (!(e.KeyValue >= 48 && e.KeyValue <= 57) && !(e.KeyData >= Keys.NumPad0 && e.KeyData <= Keys.NumPad9) && e.KeyCode != Keys.Back)
                {
                    e.SuppressKeyPress = true;
                    return;
                }
            }

            if (e.KeyCode == Keys.ControlKey)
            {
                return;
            }

            if (e.Control && e.KeyCode == Keys.Back)
            {
                for (int i = TBox.Text.Length - 1; i >= 0; i--)
                {
                    if (!char.IsLetter(TBox.Text[i]) || i == 0)
                    {
                        TBox.Text = TBox.Text.Remove(i);
                        e.SuppressKeyPress = true;
                        TBox.Select(i, 0);
                        break;
                    }
                }
            }
        }

        private void TBox_TextChanged(object sender, EventArgs e)
        {
            _Length = (short)TBox.Text.Length;
            lblCurrent.Text = TBox.Text.Length.ToString();
            _RefreshStatus();
        }

        private void TBox_Leave(object sender, EventArgs e)
        {
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValid)
            {
                _AppearanceAccToValidation();
                return ;
            }
            switch (Mode)
            {
                case enMode.Email:
                    _IsValid = StringValids.Email(TBox.Text);
                    break;
                case enMode.Phone:
                    _IsValid = StringValids.PhoneNumber(TBox.Text);
                    break;
            }
            _AppearanceAccToValidation();
        }
    }


}
