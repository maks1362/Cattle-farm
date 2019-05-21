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

        int idChart;
        int idCow;

        public ChartForm(int idChart, int idCow)
        {
            InitializeComponent();

            this.idChart = idChart;
            this.idCow = idCow;
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            if (idChart == 1)
                Lactations();
            else if (idChart == 2)
                Breeds();
            else if (idChart == 3)
                Lines();
            else if (idChart == 4)
                Families();
            else if (idChart == 5)
                AllAnimals();
            else
            {

            }
        }

        public async void Lactations()
        {

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
                string Breed = "";
                sqlCommand = new SqlCommand("SELECT * FROM [Cattle] WHERE [ID] = @idCow", sqlConnection);
                sqlCommand.Parameters.AddWithValue("idCow", idCow);
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                    Breed = Convert.ToString(sqlDataReader["Breed"]);
                sqlDataReader.Close();
                int[] idCows = new int[1];
                int c = 0;
                sqlCommand = new SqlCommand("SELECT * FROM [Cattle] WHERE [Breed] = @Breed", sqlConnection);
                sqlCommand.Parameters.AddWithValue("Breed", Breed);
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    if (c > 0)
                        Array.Resize(ref idCows, idCows.Length + 1);
                    idCows[c] = Convert.ToInt32(sqlDataReader["ID"]);
                    c = c + 1;
                }
                sqlDataReader.Close();
                for (int i = 0; i < idCows.Length; i++)
                {
                    sqlCommand = new SqlCommand("SELECT * FROM [Analysis_of_blood] WHERE [ID_cow] = @idCow", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("idCow", idCows[i]);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        chart1.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Hemoglobin"]));
                        chart2.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Hematocrit"]));
                        chart3.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["SOE"]));
                        chart4.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Leukocytes"]));
                        chart5.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Erythrocytes"]));
                        chart6.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Protein"]));
                        chart7.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Selk_reserve"]));
                        chart8.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Calcium"]));
                        chart9.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Phosphorus"]));
                        chart10.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Glucose"]));
                        chart11.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Carotene"]));
                        chart12.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Globulins"]));
                        chart13.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Albumins"]));
                        chart14.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Lipids"]));
                        chart15.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Silk_phosphotase"]));
                        chart16.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Magnesium"]));
                        chart17.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Urea"]));
                        chart18.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["ALT"]));
                        chart19.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["AST"]));
                    }
                    sqlDataReader.Close();
                }
            }
        }

        public async void Lines()
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
                int Father = 0;
                sqlCommand = new SqlCommand("SELECT * FROM [Cattle] WHERE [ID] = @idCow", sqlConnection);
                sqlCommand.Parameters.AddWithValue("idCow", idCow);
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                    Father = Convert.ToInt32(sqlDataReader["ID_father"]);
                sqlDataReader.Close();
                int[] idCows = new int[1];
                int c = 0;
                sqlCommand = new SqlCommand("SELECT * FROM [Cattle] WHERE [ID_father] = @Father", sqlConnection);
                sqlCommand.Parameters.AddWithValue("Father", Father);
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    if (c > 0)
                        Array.Resize(ref idCows, idCows.Length + 1);
                    idCows[c] = Convert.ToInt32(sqlDataReader["ID"]);
                    c = c + 1;
                }
                sqlDataReader.Close();
                for (int i = 0; i < idCows.Length; i++)
                {
                    sqlCommand = new SqlCommand("SELECT * FROM [Analysis_of_blood] WHERE [ID_cow] = @idCow", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("idCow", idCows[i]);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        chart1.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Hemoglobin"]));
                        chart2.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Hematocrit"]));
                        chart3.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["SOE"]));
                        chart4.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Leukocytes"]));
                        chart5.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Erythrocytes"]));
                        chart6.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Protein"]));
                        chart7.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Selk_reserve"]));
                        chart8.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Calcium"]));
                        chart9.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Phosphorus"]));
                        chart10.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Glucose"]));
                        chart11.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Carotene"]));
                        chart12.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Globulins"]));
                        chart13.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Albumins"]));
                        chart14.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Lipids"]));
                        chart15.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Silk_phosphotase"]));
                        chart16.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Magnesium"]));
                        chart17.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Urea"]));
                        chart18.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["ALT"]));
                        chart19.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["AST"]));
                    }
                    sqlDataReader.Close();
                }
            }
        }

        public async void Families()
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
                int Mother = 0;
                sqlCommand = new SqlCommand("SELECT * FROM [Cattle] WHERE [ID] = @idCow", sqlConnection);
                sqlCommand.Parameters.AddWithValue("idCow", idCow);
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                    Mother = Convert.ToInt32(sqlDataReader["ID_mother"]);
                sqlDataReader.Close();
                int[] idCows = new int[1];
                int c = 0;
                sqlCommand = new SqlCommand("SELECT * FROM [Cattle] WHERE [ID_mother] = @Mother", sqlConnection);
                sqlCommand.Parameters.AddWithValue("Mother", Mother);
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    if (c > 0)
                        Array.Resize(ref idCows, idCows.Length + 1);
                    idCows[c] = Convert.ToInt32(sqlDataReader["ID"]);
                    c = c + 1;
                }
                sqlDataReader.Close();
                for (int i = 0; i < idCows.Length; i++)
                {
                    sqlCommand = new SqlCommand("SELECT * FROM [Analysis_of_blood] WHERE [ID_cow] = @idCow", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("idCow", idCows[i]);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        chart1.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Hemoglobin"]));
                        chart2.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Hematocrit"]));
                        chart3.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["SOE"]));
                        chart4.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Leukocytes"]));
                        chart5.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Erythrocytes"]));
                        chart6.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Protein"]));
                        chart7.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Selk_reserve"]));
                        chart8.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Calcium"]));
                        chart9.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Phosphorus"]));
                        chart10.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Glucose"]));
                        chart11.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Carotene"]));
                        chart12.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Globulins"]));
                        chart13.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Albumins"]));
                        chart14.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Lipids"]));
                        chart15.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Silk_phosphotase"]));
                        chart16.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Magnesium"]));
                        chart17.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Urea"]));
                        chart18.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["ALT"]));
                        chart19.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["AST"]));
                    }
                    sqlDataReader.Close();
                }
            }
        }

        public async void AllAnimals()
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
                int[] idCows = new int[1];
                int c = 0;
                sqlCommand = new SqlCommand("SELECT * FROM [Cattle]", sqlConnection);
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    if (c > 0)
                        Array.Resize(ref idCows, idCows.Length + 1);
                    idCows[c] = Convert.ToInt32(sqlDataReader["ID"]);
                    c = c + 1;
                }
                sqlDataReader.Close();
                for (int i = 0; i < idCows.Length; i++)
                {
                    sqlCommand = new SqlCommand("SELECT * FROM [Analysis_of_blood] WHERE [ID_cow] = @idCow", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("idCow", idCows[i]);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        chart1.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Hemoglobin"]));
                        chart2.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Hematocrit"]));
                        chart3.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["SOE"]));
                        chart4.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Leukocytes"]));
                        chart5.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Erythrocytes"]));
                        chart6.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Protein"]));
                        chart7.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Selk_reserve"]));
                        chart8.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Calcium"]));
                        chart9.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Phosphorus"]));
                        chart10.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Glucose"]));
                        chart11.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Carotene"]));
                        chart12.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Globulins"]));
                        chart13.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Albumins"]));
                        chart14.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Lipids"]));
                        chart15.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Silk_phosphotase"]));
                        chart16.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Magnesium"]));
                        chart17.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Urea"]));
                        chart18.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["ALT"]));
                        chart19.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["AST"]));
                    }
                    sqlDataReader.Close();
                }
            }
        }
    }
}
