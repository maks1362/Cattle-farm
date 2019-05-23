using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Doyki
{
    public partial class StartMenu : Form
    {
        readonly Timer timer1 = new Timer();     //Таймер для анимации
        private int offset = 2;

        public StartMenu()
        {
            InitializeComponent();
        }

        //Переопределение WndProc для перемещение окна
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        //Функця смещения полосы загрузки
        private void Moving(object sender, EventArgs e)
        {
            loadingLinePanel.Left += offset;
            if (loadingLinePanel.Left > 320)
            {
                loadingLinePanel.Left = -80;
            }
            if (loadingLinePanel.Left < -80)
            {
                offset = 2;
            }
        }

        //Ивент кнопки "Закрыть"
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            loadingLinePanel.Left = 0;
            timer1.Tick += new EventHandler(Moving);
            timer1.Interval = 5;
            timer1.Start();
        }

        //Ивент кнопки "Подключиться"
        private async void Connect_Click(object sender, EventArgs e)
        {
            //Запуск загрузки
            loadingBackgroundPanel.Show();
            loadingLinePanel.Show();
            //Всё остальное
            ErrorPictureBox.Hide();
            statusLabel.Text = "\r\nПодключение...";
            SqlConnection testConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);   //Переменная прописана в Settings.settings
            try
            {
               await Task.Run(() => testConnection.Open());  //Мультипоток
            }
            catch
            {
                statusLabel.Text = "Ошибка \r\n 1. Нет подкл. к интернету \r\n 2. SQL сервер не запущен";
                loadingBackgroundPanel.Hide();
                loadingLinePanel.Hide();
                ErrorPictureBox.Show();
            }
            if (testConnection.State == System.Data.ConnectionState.Open)
            {
                this.Hide();
                MainForm Main = new MainForm();
                Main.Show();
                timer1.Stop();
            }
        }
    }
}
