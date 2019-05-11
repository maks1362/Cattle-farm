using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Doyki
{
    public partial class ChildForm : Doyki.MainForm
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        protected override void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
