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
        Timer timer1 = new Timer();     //Таймер для анимации
        private int offset = 2;

        public StartMenu()
        {
            InitializeComponent();
        }

        void move(object sender, EventArgs e)
        {
            loadingLinePanel.Left = loadingLinePanel.Left + offset;
            if (loadingLinePanel.Left > 320)
            {
                loadingLinePanel.Left = -80;
            }
            if (loadingLinePanel.Left < -80)
            {
                offset = 2;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            loadingLinePanel.Left = 0;
            timer1.Tick += new EventHandler(move);
            timer1.Interval = 5;
            timer1.Start();
        }

        private async void connect_Click(object sender, EventArgs e)
        {
            //Запуск загрузки
            loadingBackgroundPanel.Show();
            loadingLinePanel.Show();
            //Всё остальное
            ErrorPictureBox.Hide();
            statusLabel.Text = "\r\nПодключение...";
            SqlConnection testConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.Uchot_udoevConnectionString1);
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
