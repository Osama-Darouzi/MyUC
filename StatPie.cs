using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace MyUC
{
    public partial class StatPie : UserControl
    {
        public StatPie()
        {
            InitializeComponent();
        }

        private Rectangle _Position;

        private float _PieAngle = 0;
        private byte _Percentage = 0;

        private Rectangle _PartDescriber;
        private float _Part = 0;
        [Category("Values")]
        public float Part
        {
            get
            {
                return _Part; 
            }
            set
            {
                _Part = value;
                _RefreshPercentages();
            }
        }

        private Rectangle _TotalDescriber;
        private float _Total = 0;
        [Category("Values")]
        public float Total
        {
            get
            {
                return _Total; 
            }
            set
            {
                _Total = value;
                _RefreshPercentages();
            }
        }

        private Color _PartColor = Color.IndianRed;
        private Color _TotalColor = Color.CornflowerBlue;
        public Color PartColor
        {
            get
            {
                return _PartColor;
            }
            set
            {
                _PartColor = value;
                Invalidate();
            }
        }
        public Color TotalColor
        {
            get
            {
                return _TotalColor;
            }
            set
            {
                _TotalColor = value;
                Invalidate();
            }
        }

        [Category("Names")]
        public string TotalName
        {
            get
            {
                return lblTotal.Text;
            }
            set
            {
                lblTotal.Text = value;
            }
        }
        [Category("Names")]
        public string PartName
        {
            get
            {
                return lblPart.Text;
            }
            set
            {
                lblPart.Text = value;
            }
        }
    
        private void _RefreshPercentages()
        { 
            if (_Total != 0 && _Part <= _Total)
            {
                _PieAngle = _Part * 360 / _Total;
                _Percentage = Convert.ToByte(_Part * 100 / _Total);
            }
            else
            {
                _Percentage = 0;
                _PieAngle = 0;
            }
            lblPercentage.Text = _Percentage.ToString() + "%";
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _Position = new Rectangle(-1, -1, Width, 3 * Height / 4);
            _PartDescriber = new Rectangle(Width / 7, 4*Height / 6 + Height/8, Width / 15, Height / 20);
            _TotalDescriber = new Rectangle(Width/7, _PartDescriber.Y + Height/8, Width/15, Height / 20);

            Brush PartColor = new SolidBrush(_PartColor);
            Brush TotalColor = new SolidBrush(_TotalColor);

            e.Graphics.CompositingMode = CompositingMode.SourceOver;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            e.Graphics.FillRectangle(TotalColor, _TotalDescriber);
            e.Graphics.FillRectangle(PartColor, _PartDescriber);

            lblPercentage.Font = lblTotal.Font = lblPart.Font = new Font("Segoe UI Semibold", _TotalDescriber.Height, FontStyle.Bold);
            lblPart.Location = new Point(_PartDescriber.X + _PartDescriber.Width, _PartDescriber.Y - _PartDescriber.Height/2);
            lblTotal.Location = new Point(_TotalDescriber.X + _TotalDescriber.Width, _TotalDescriber.Y - _TotalDescriber.Height/2);
            lblPercentage.Location = new Point(_Position.X + 3, _Position.Height - lblPercentage.Height);

            e.Graphics.FillEllipse(TotalColor, _Position);
            e.Graphics.FillPie(PartColor, _Position, -90, -_PieAngle);
            short SmallEllipse = Convert.ToInt16(_Position.Width / 6);
            e.Graphics.FillEllipse(TotalColor, _Position.Width/2 - SmallEllipse/2, _Position.Height/2 - SmallEllipse/2, SmallEllipse, SmallEllipse);

            base.OnPaint(e);
        }

        private void StatPie_Resize(object sender, EventArgs e)
        {
            if (Size.Width < 140)
            {
                Size = new Size(140, 120);
            }
            Size = new Size(Width,Width + 3*Width/10);
        }
    }
}
