using MyUC.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using ControlsUtil;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace MyUC.Forms
{
    public partial class frmScreen : Form
    {
        private enum enTimes{Sunrise, Afternoon, Sunset, Night}

        private static Color[] _PanelColors = new Color[]{Color.LightSkyBlue, Color.Moccasin, Color.Crimson, Color.Black };
        private static Color[] _BackColors = new Color[] { Color.FromArgb(210, 236, 255), Color.FromArgb(255, 245, 235), Color.FromArgb(255, 229, 225), Color.FromKnownColor(KnownColor.Control) };
        private static Image[] SunMoons = new Image[] { Resources.sunrise, Resources.sun, Resources.sunset, Resources.moon };

        private static DateTime _Now;
        private static Timer _timer = new Timer()
        {
            Interval = 1000
        };
        private enTimes _Time;
        private enMode _Mode;
        private enBtnColor _BtnsColor;

        private bool _FreePbStar = false;
        private bool _TimeSynchronization = true;

        private enTimes Time
        {
            get
            {
                return _Time;
            }
            set
            {
                _Time = value;
                PnlHead.BackColor = _PanelColors[(byte)_Time];
                BackColor = _BackColors[(byte)_Time];
                pbStar.Image = SunMoons[(byte)_Time];
                _SetPropertiesForNight(_Time);
            }
        }

        private void _NormalMode()
        {
            this.MinimumSize = PnlHead.MinimumSize = new Size(0, 35);
            PnlHead.Size = new Size(Width, MinimumSize.Height);
            pbProPic.Visible = false;
            lnkFullName.Visible = false;
        }

        private void _UserMode()
        {
            this.MinimumSize = PnlHead.MinimumSize = new Size(0, pbProPic.Height);
            PnlHead.Size = new Size(Width, MinimumSize.Height);
            pbProPic.Visible = true;
            lnkFullName.Visible = true;
        }

        protected void _RefreshLblTime(DateTime time)
        {
            lblTime.Text = time.ToString("h:mm tt");
        }

        protected void _RefreshTime(DateTime Now)
        {
            byte H = (byte)Now.TimeOfDay.Hours;

            bool Sunrise = H >= 6 && H < 12;
            bool AfterNoon = H >= 12 && H < 18;
            bool Sunset = H >= 18 && H < 21;
            //bool Night = H >= 21;

            if (Sunrise)
                Time = enTimes.Sunrise;
            else if (AfterNoon)
                Time = enTimes.Afternoon;
            else if (Sunset)
                Time = enTimes.Sunset;
            else
                Time = enTimes.Night;

            _RefreshLblTime(Now);
        }

        private void _RefreshFormAccToMode()
        {
            switch (Mode)
            {
                case enMode.Normal:
                    _NormalMode();
                    break;
                case enMode.User:
                    _UserMode();
                    break;
            }
        }

        private void _SetPropertiesForNight(enTimes time)
        {
            
            if(time == enTimes.Night)
            {
                FormBtnsColor = enBtnColor.White;

                pbProPic.BackColor = lblTime.ForeColor = lnkFullName.LinkColor = lblUsername.ForeColor = Color.White;
            }
            else 
            {
                FormBtnsColor = enBtnColor.Black;

                lblTime.ForeColor = lnkFullName.LinkColor = lblUsername.ForeColor = Color.Black;
                pbProPic.BackColor = Color.Transparent;
            }
        }

        private void _StaticsInFrmLoad()
        {
            _RefreshTime(_Now = DateTime.Now);
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        public frmScreen()
        {
            InitializeComponent();
            Mode = enMode.Normal;
            _StaticsInFrmLoad();
        }

        public frmScreen(string Username, Image pfp)
        {
            InitializeComponent ();
            Mode = enMode.User;
            this.FullName = Username;
            this.pfp = pfp;
            _StaticsInFrmLoad();
        }

        public enum enMode {Normal, User}
        public enum enBtnColor {White, Black}

        public bool FreePbStar
        {
            get { return _FreePbStar; }
            set
            {
                _FreePbStar = value;

                if (_FreePbStar)
                {
                    pbStar.Parent = this;
                    pbStar.Location = new Point(Width/2, Height/2);
                }
                else
                {
                    pbStar.Parent = PnlHead;
                    pbStar.Location = new Point(1, 0);
                }
                PnlHead.Refresh();
            }
        }

        public bool TimeSynchronization
        {
            get
            {
                return _TimeSynchronization;
            }

            set
            {
                _TimeSynchronization = value;

                if (value)
                {
                    _RefreshLblTime(DateTime.Now);
                    _RefreshTime(DateTime.Now);
                }
                else
                {
                    PnlHead.BackColor = Color.Transparent;
                    BackColor = Color.FromKnownColor(KnownColor.Control);
                }

                pbStar.Visible = value;
                lblTime.Visible = value;

            }
        }

        public enBtnColor FormBtnsColor
        {
            get
            {
                return _BtnsColor;
            }

            set
            {
                _BtnsColor = value;
                switch (value)
                {
                    case enBtnColor.White:
                        btnClose.Image = Resources.close_W;
                        btnRestore.Image = Resources.restore_down_W;
                        btnMinimize.Image = Resources.window_minimize_W;
                        btnClose.BorderColor = btnMinimize.BorderColor = btnRestore.BorderColor = Color.White;
                        break;
                    case enBtnColor.Black:
                        btnClose.Image = Resources.close_B;
                        btnRestore.Image = Resources.restore_down_B;
                        btnMinimize.Image = Resources.window_minimize_B;
                        btnClose.BorderColor = btnMinimize.BorderColor = btnRestore.BorderColor = Color.Black;
                        break;
                }
            }
        }

        [Category("Appearance")]
        public bool RestoreButton
        {
            get
            {
                return btnRestore.Visible;
            }
            set
            {
                btnRestore.Visible = value;
            }
        }

        [Category("Appearance")]
        public bool MinimizeButton
        {
            get
            {
                return btnMinimize.Visible;
            }
            set
            {
                btnMinimize.Visible = value;
            }
        }

        public enMode Mode
        {
            get { return _Mode; }
            set
            {
                _Mode = value; 
                _RefreshFormAccToMode();
            }
        }

        public string FullName
        {
            get{return lnkFullName.Text;}
            set{lnkFullName.Text = value;}
        }

        public string Username
        {
            get
            {
                return lblUsername.Text;
            }
            set
            {
                lblUsername.Text = value;
            }
        }

        public Image pfp
        {
            get{ return pbProPic.Image;}
            set{pbProPic.Image = value;}
        }

        public event EventHandler FullNameClicked;

        private void _timer_Tick(object sender, EventArgs e)
        {
            if(_TimeSynchronization)
            {   
                _Now = DateTime.Now;
                _RefreshLblTime(_Now);

                byte minutes = (byte)_Now.Minute;
                if (_Now.Hour % 3 == 0 && _Now.Minute % 10 <= 1)
                {
                    _RefreshTime(_Now);
                }

            }
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void btnRestore_Click(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    WindowState = FormWindowState.Maximized;
                    break;
                case FormWindowState.Maximized:
                    WindowState = FormWindowState.Normal;
                    break;
                default:
                    break;
            }
        }

        protected void btnMinimize_Click(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Minimized;
        }

        private int _MouseX_Diff;
        private int _MouseY_Diff;
        private bool _AllowMoving = false;
        private void PnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            _AllowMoving = true;
            _MouseX_Diff = e.X ;
            _MouseY_Diff = e.Y ;
        }
        private void PnlHead_MouseUp(object sender, MouseEventArgs e)
        {
            _AllowMoving = false;
        }

        private void PnlHead_MouseMove(object sender, MouseEventArgs e)
        {
            Size Mouse = new Size(e.X - _MouseX_Diff, e.Y - _MouseY_Diff);
            if (_AllowMoving)
            {
                this.Location = Point.Add(Location, Mouse);
            }
        }

        private void PnlHead_Paint(object sender, PaintEventArgs e)
        {
            List<Control> lsCntrl = new List<Control>()
            {
                btnClose
            };
            if (RestoreButton)
                lsCntrl.Add(btnRestore);
            if(MinimizeButton)
                lsCntrl.Add(btnMinimize);

            btnClose.Location = new Point(PnlHead.Width - 30, 3);

            for (byte i = 1; i < lsCntrl.Count; i++)
            {
                lsCntrl[i].Location = new Point(lsCntrl[i-1].Location.X - 30, 3);
            }

            lblTime.Location = new Point(lsCntrl[lsCntrl.Count - 1].Location.X - lblTime.Width, btnMinimize.Location.Y + 5);


            if (pbStar.Parent == PnlHead)
            {
                pbStar.Size = new Size(PnlHead.Height, PnlHead.Height);
            }
        }

        //private void lnkUsername_TextChanged(object sender, EventArgs e)
        //{
        //    lnkUsername.Text = lnkUsername.Text.Replace(' ', '\n');
        //}

        private void lnkFullName_Click(object sender, EventArgs e)
        {
            FullNameClicked?.Invoke(this, e);
        }

        private void pbProPic_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.CompositingMode = CompositingMode.SourceOver;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rec = new RectangleF(-1, -1, pbProPic.Width + 1, pbProPic.Height + 1);
            GraphicsPath graphicsPath = new GraphicsPath();

            graphicsPath.AddEllipse(rec);
            Region region = new Region(graphicsPath);
            g.Clip = region;
            pbProPic.Region = region;
            

            g.DrawEllipse(new Pen(new SolidBrush(pbProPic.BackColor), 1), rec);
            g.Save();
        }
    }
}
