using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doyki
{
    public partial class TreeCowForm : Form
    {
        public TreeCowForm()
        {
            InitializeComponent();
        }
        public void RefreshImage(Image image)
        {
            pictureBox1.Image = image;
        }
    }
}
