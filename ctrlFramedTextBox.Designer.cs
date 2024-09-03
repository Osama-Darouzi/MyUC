namespace MyUC
{
    partial class ctrlFramedTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBox
            // 
            this.TBox.BorderThickness = 3;
            this.TBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBox.DefaultText = "";
            this.TBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
            this.TBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBox.Location = new System.Drawing.Point(3, 18);
            this.TBox.Name = "TBox";
            this.TBox.PasswordChar = '\0';
            this.TBox.PlaceholderText = "";
            this.TBox.SelectedText = "";
            this.TBox.Size = new System.Drawing.Size(237, 30);
            this.TBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TBox.TabIndex = 0;
            this.TBox.TextChanged += new System.EventHandler(this.TBox_TextChanged);
            this.TBox.Load += new System.EventHandler(this.TBox_Load);
            this.TBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBox_KeyDown);
            this.TBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // gb1
            // 
            this.gb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb1.BackColor = System.Drawing.Color.Transparent;
            this.gb1.Controls.Add(this.TBox);
            this.gb1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(3, 2);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(243, 51);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "UC Box";
            // 
            // lblMax
            // 
            this.lblMax.BackColor = System.Drawing.Color.Transparent;
            this.lblMax.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMax.Location = new System.Drawing.Point(196, 4);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(44, 13);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "/ 32767";
            // 
            // lblCurrent
            // 
            this.lblCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrent.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCurrent.Location = new System.Drawing.Point(170, 4);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrent.Size = new System.Drawing.Size(26, 13);
            this.lblCurrent.TabIndex = 2;
            this.lblCurrent.Text = "0";
            // 
            // ctrlFramedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.gb1);
            this.Name = "ctrlFramedTextBox";
            this.Size = new System.Drawing.Size(249, 56);
            this.Resize += new System.EventHandler(this.ctrlFramedTextBox_SizeChanged);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.gb1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblCurrent;
        public Guna.UI2.WinForms.Guna2TextBox TBox;
        private System.Windows.Forms.GroupBox gb1;
    }
}
