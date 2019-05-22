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
        private UCTableCattle UCT1 = new UCTableCattle();
        //private UCTableCattle UCT1 = new UCTableCattle();
        private UCTableLactation UCT3 = new UCTableLactation();
        //private UCTableCattle UCT1 = new UCTableCattle();
        //private UCTableCattle UCT1 = new UCTableCattle();
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        protected virtual void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PlusWindowButton_Click(object sender, EventArgs e)
        {
            Form Child  = new ChildForm();
            Child.Owner = this;
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
            this.Controls.Add(UCT1);
            this.UCT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCT1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.UCT1.Show();
        }

        private void AnalysOfBloodButton_Click(object sender, EventArgs e)
        {

        }

        private void LactationButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            this.Text = "Лактация";
            nameLabel.Text = "Лактация";
            this.Controls.Add(UCT3);
            this.UCT3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCT3.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
        }

        private void ApparatButton_Click(object sender, EventArgs e)
        {

        }

        private void ReproductiveButton_Click(object sender, EventArgs e)
        {

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
