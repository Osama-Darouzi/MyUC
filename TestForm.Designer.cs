using BankUC;
using System.Drawing;

namespace MyUC
{
    partial class TestForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.personCard1 = new BankUC.PersonCard();
            this.ctrlFramedTextBox1 = new MyUC.ctrlFramedTextBox();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonCommand1 = new Krypton.Toolkit.KryptonCommand();
            this.SuspendLayout();
            // 
            // personCard1
            // 
            this.personCard1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.personCard1.Location = new System.Drawing.Point(0, 0);
            this.personCard1.MinimumSize = new System.Drawing.Size(398, 417);
            this.personCard1.Name = "personCard1";
            this.personCard1.Person = null;
            this.personCard1.PFP = ((System.Drawing.Image)(resources.GetObject("personCard1.PFP")));
            this.personCard1.Size = new System.Drawing.Size(535, 450);
            this.personCard1.TabIndex = 1;
            this.personCard1.Theme = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.personCard1.Load += new System.EventHandler(this.personCard1_Load);
            // 
            // ctrlFramedTextBox1
            // 
            this.ctrlFramedTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlFramedTextBox1.HeaderColor = System.Drawing.SystemColors.ControlText;
            this.ctrlFramedTextBox1.HName = "tb";
            this.ctrlFramedTextBox1.HNameFont = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFramedTextBox1.LengthLabelColor = System.Drawing.SystemColors.ControlText;
            this.ctrlFramedTextBox1.LengthLabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlFramedTextBox1.Location = new System.Drawing.Point(0, 0);
            this.ctrlFramedTextBox1.Max = ((short)(100));
            this.ctrlFramedTextBox1.Min = ((short)(0));
            this.ctrlFramedTextBox1.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.ctrlFramedTextBox1.Name = "ctrlFramedTextBox1";
            this.ctrlFramedTextBox1.Size = new System.Drawing.Size(249, 56);
            this.ctrlFramedTextBox1.TabIndex = 0;
            this.ctrlFramedTextBox1.TextBoxFont = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // kryptonCommand1
            // 
            this.kryptonCommand1.Text = "kryptonCommand1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.personCard1);
            this.Controls.Add(this.ctrlFramedTextBox1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private ctrlFramedTextBox ctrlFramedTextBox1;
        private PersonCard personCard1;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonCommand kryptonCommand1;
    }
}