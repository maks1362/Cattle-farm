using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doyki
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void connect_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            status.Text = "Подключение...";
            status.Refresh();
            SqlConnection Test = new SqlConnection(global::Doyki.Properties.Settings.Default.Uchot_udoevConnectionString1);
            try
            {
                Test.Open();
            }
            catch
            {
                status.Text = "Ошибка \r\n 1. Нет подкл. к интернету \r\n 2. SQL сервер не запущен";
                pictureBox2.Show();
            }
            if (Test.State == System.Data.ConnectionState.Open)
            {
                this.Hide();
                MainForm Main = new MainForm();
                Main.Show();
            }
        }
    }
}
