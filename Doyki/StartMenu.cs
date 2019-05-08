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
            loading_L.Left = loading_L.Left + offset;
            if (loading_L.Left > 305)
            {
                loading_L.Left = -80;
            }
            if (loading_L.Left < -100)
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
            loading_L.Left = 0;
            timer1.Tick += new EventHandler(move);
            timer1.Interval = 5;
            timer1.Start();
        }

        private async void connect_Click(object sender, EventArgs e)
        {
            //Запуск загрузки
            loading_B.Show();   //B- background
            loading_L.Show();   //L- line
            //Всё остальное
            pictureBox2.Hide();
            status.Text = "Подключение...";
            status.Refresh();
            SqlConnection Test = new SqlConnection(global::Doyki.Properties.Settings.Default.Uchot_udoevConnectionString1);
            try
            {
                await Task.Run(() => Test.Open());  //Мультипоток
            }
            catch
            {
                status.Text = "Ошибка \r\n 1. Нет подкл. к интернету \r\n 2. SQL сервер не запущен";
                loading_B.Hide();
                loading_L.Hide();
                pictureBox2.Show();
            }
            if (Test.State == System.Data.ConnectionState.Open)
            {
                this.Hide();
                MainForm Main = new MainForm();
                Main.Show();
                timer1.Stop();
            }
        }
    }
}
