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
            saveFileDialog1.Title = "Сохранение изображения";
            saveFileDialog1.FileName = "Picture";
            saveFileDialog1.DefaultExt = "*.png";
            saveFileDialog1.Filter = "Файл PNG|*.png|Файл JPG|*.jpg|Файл JPEG|*.jpeg|Файл BMP|*.bmp|Все файлы (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
