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
    public partial class ChartForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public ChartForm()
        {
            InitializeComponent();
            Breeds();
        }

        public async void Breeds()
        {
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.Uchot_udoevConnectionString1);
            try
            {
                await Task.Run(() => sqlConnection.Open());
            }
            catch
            {
                MessageBox.Show("Ошибка \r\n 1. Отсутствует подключение к интернету \r\n 2. SQL сервер не запущен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                string[] Breeds = new string[1];
                int m = 0, n = 0;
                {
                    int c = 0;
                    sqlCommand = new SqlCommand("SELECT * FROM [Cattle]", sqlConnection);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        m = m + 1;
                        if (Convert.ToString(sqlDataReader["Breed"]) == "")
                        {
                            n = n + 1;
                        }
                        else if (c > 0)
                        {
                            bool check = false;
                            for (int i = 0; i < Breeds.Length; i++)
                            {
                                if (Breeds[i] == Convert.ToString(sqlDataReader["Breed"]))
                                    check = true;
                            }
                            if (!check)
                            {
                                Array.Resize(ref Breeds, Breeds.Length + 1);
                                Breeds[c] = Convert.ToString(sqlDataReader["Breed"]);
                                c = c + 1;
                            }
                        }
                        else
                        {
                            Breeds[0] = Convert.ToString(sqlDataReader["Breed"]);
                            c = c + 1;
                        }
                    }
                    sqlDataReader.Close();
                }
                int[] Сount = new int[Breeds.Length];
                for (int i = 0; i < Сount.Length; i++)
                    Сount[i] = 0;
                {
                    sqlCommand = new SqlCommand("SELECT * FROM [Cattle]", sqlConnection);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        for (int i = 0; i < Breeds.Length; i++)
                        {
                            if (Convert.ToString(sqlDataReader["Breed"]) == Breeds[i])
                                Сount[i] = Сount[i] + 1;
                        }
                    }
                    sqlDataReader.Close();
                }
                for(int i = 0; i < Breeds.Length; i++)
                    chart1.Series[0].Points.AddXY(Breeds[i], Сount[i]);
                label1.Text = "Всего коров в базе данных: " + m + "\r\n" + "Коров, у которых не указана порода: " + n;
            }
        }
    }
}
