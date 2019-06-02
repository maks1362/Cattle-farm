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

        private void СохранитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Сохранение";
            saveFileDialog1.FileName = "";
            saveFileDialog1.DefaultExt = "*.png";
            saveFileDialog1.Filter = "Файлы image (*.img)|*.png|Все файлы (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
