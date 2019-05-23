using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Doyki
{
    public partial class MainForm : Form
    {
        //Загрузка котролов с таблицами
        private readonly UCTableCattle UCT1 = new UCTableCattle();
        private readonly UCTableAnalysisOfBlood UCT2 = new UCTableAnalysisOfBlood();
        private readonly UCTableLactation UCT3 = new UCTableLactation();
        private readonly UCTableApparat UCT4 = new UCTableApparat();
        private readonly UCTableReproductive UCT5 = new UCTableReproductive();

        //Для захвата позиции мышки
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //Resize
        protected override void WndProc(ref Message m)
        {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;

            const UInt32 HTBOTTOMRIGHT = 17;

            const int RESIZE_HANDLE_SIZE = 30;
            bool handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                Size formSize = this.Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {{HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)}};

                foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                {
                    if (hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }

        //Закрыть
        protected virtual void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Сверенуть
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Создание доч. окна
        private void PlusWindowButton_Click(object sender, EventArgs e)
        {
            Form Child = new ChildForm();
            Child.Show();
        }

        private void NameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void CattleButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            this.Text = "Скот";
            nameLabel.Text = "Скот";
            if (this.UCT1.Parent == null)
            {
                this.Controls.Add(UCT1);
                this.UCT1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.UCT1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            }
            else
            {
                this.UCT1.Show();
            }
        }

        private void AnalysOfBloodButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            this.Text = "Анализ крови";
            nameLabel.Text = "Анализ крови";
            if (this.UCT2.Parent == null)
            {
                this.Controls.Add(UCT2);
                this.UCT2.Dock = System.Windows.Forms.DockStyle.Fill;
                this.UCT2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            }
            else
            {
                this.UCT2.Show();
            }

        }

        private void LactationButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            this.Text = "Лактация";
            nameLabel.Text = "Лактация";
            if (this.UCT3.Parent == null)
            {
                this.Controls.Add(UCT3);
                this.UCT3.Dock = System.Windows.Forms.DockStyle.Fill;
                this.UCT3.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            }
            else
            {
                this.UCT3.Show();
            }
        }

        private void ApparatButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            this.Text = "Доильный аппарат";
            nameLabel.Text = "Доильный аппарат";
            if (this.UCT4.Parent == null)
            {
                this.Controls.Add(UCT4);
                this.UCT4.Dock = System.Windows.Forms.DockStyle.Fill;
                this.UCT4.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            }
            else
            {
                this.UCT4.Show();
            }
        }

        private void ReproductiveButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            this.Text = "Репродуктивность";
            nameLabel.Text = "Репродуктивность";
            if (this.UCT5.Parent == null)
            {
                this.Controls.Add(UCT5);
                this.UCT5.Dock = System.Windows.Forms.DockStyle.Fill;
                this.UCT5.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            }
            else
            {
                this.UCT5.Show();
            }
        }

        private void TableLayoutPanel1_VisibleChanged(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Visible == true)
            {
                this.Text = "Выберите таблицу";
                nameLabel.Text = "Выберите таблицу";
            }
        }
    }
}
