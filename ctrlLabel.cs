﻿using System;
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
    public partial class ctrlLabel : UserControl
    {
        public ctrlLabel()
        {
            InitializeComponent();
        }

        public Label Label
        {
            get
            {
                return lblLabel;
            }
            //set
            //{
            //    lblLabel = value;
            //}
        }

        [Category("Appearance")]
        [DefaultValue("Header")]
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
        [DefaultValue(KnownColor.ControlText)]
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

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get
            {
                return lblLabel.Text;
            }
            set
            {
                lblLabel.Text = value;
            }
        }
    }
}