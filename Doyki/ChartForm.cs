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
            else if (idChart == 6)
                MDB();
            else if (idChart == 7)
                MDZH();
            else if (idChart == 8)
                AMYDaily();
            else if (idChart == 9)
                AMYMonthly();
            else if (idChart == 10)
                AMYYearly();
            else if (idChart == 11)
                AMYLactations();
            else if (idChart == 12)
                AMYLactation();
            else
                Close();
        }

        public async void Lactations()
        {
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                int i = 0;
                sqlCommand = new SqlCommand("SELECT * FROM [Analysis_of_blood] WHERE [ID_cow] = @idCow", sqlConnection);
                sqlCommand.Parameters.AddWithValue("idCow", idCow);
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    chart2.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Hemoglobin"]));
                    chart1.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Hematocrit"]));
                    chart2.Series[1].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["SOE"]));
                    chart2.Series[2].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Leukocytes"]));
                    chart1.Series[1].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Erythrocytes"]));
                    chart2.Series[3].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Protein"]));
                    chart1.Series[2].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Selk_reserve"]));
                    chart1.Series[3].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Calcium"]));
                    chart1.Series[4].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Phosphorus"]));
                    chart1.Series[5].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Glucose"]));
                    chart3.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Carotene"]));
                    chart3.Series[1].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Globulins"]));
                    chart3.Series[2].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Albumins"]));
                    chart1.Series[6].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Lipids"]));
                    chart3.Series[3].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Silk_phosphotase"]));
                    chart1.Series[7].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Magnesium"]));
                    chart1.Series[8].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Urea"]));
                    chart3.Series[4].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["ALT"]));
                    chart3.Series[5].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["AST"]));
                    i = i + 1;
                }
            }
        }

        public async void Breeds()
        {
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                try
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
                            chart2.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Hemoglobin"]));
                            chart1.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Hematocrit"]));
                            chart2.Series[1].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["SOE"]));
                            chart2.Series[2].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Leukocytes"]));
                            chart1.Series[1].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Erythrocytes"]));
                            chart2.Series[3].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Protein"]));
                            chart1.Series[2].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Selk_reserve"]));
                            chart1.Series[3].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Calcium"]));
                            chart1.Series[4].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Phosphorus"]));
                            chart1.Series[5].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Glucose"]));
                            chart3.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Carotene"]));
                            chart3.Series[1].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Globulins"]));
                            chart3.Series[2].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Albumins"]));
                            chart1.Series[6].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Lipids"]));
                            chart3.Series[3].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Silk_phosphotase"]));
                            chart1.Series[7].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Magnesium"]));
                            chart1.Series[8].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Urea"]));
                            chart3.Series[4].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["ALT"]));
                            chart3.Series[5].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["AST"]));
                        }
                        sqlDataReader.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("У выбранной коровы отсутствуют данные о породе, выберите другую корову", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        public async void Lines()
        {
            try
            {
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                            chart2.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Hemoglobin"]));
                            chart1.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Hematocrit"]));
                            chart2.Series[1].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["SOE"]));
                            chart2.Series[2].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Leukocytes"]));
                            chart1.Series[1].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Erythrocytes"]));
                            chart2.Series[3].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Protein"]));
                            chart1.Series[2].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Selk_reserve"]));
                            chart1.Series[3].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Calcium"]));
                            chart1.Series[4].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Phosphorus"]));
                            chart1.Series[5].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Glucose"]));
                            chart3.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Carotene"]));
                            chart3.Series[1].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Globulins"]));
                            chart3.Series[2].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Albumins"]));
                            chart1.Series[6].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Lipids"]));
                            chart3.Series[3].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Silk_phosphotase"]));
                            chart1.Series[7].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Magnesium"]));
                            chart1.Series[8].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Urea"]));
                            chart3.Series[4].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["ALT"]));
                            chart3.Series[5].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["AST"]));
                        }
                        sqlDataReader.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("У выбранной коровы отсутствуют данные об отце, выберите другую корову", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        public async void Families()
        {
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                try
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
                            chart2.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Hemoglobin"]));
                            chart1.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Hematocrit"]));
                            chart2.Series[1].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["SOE"]));
                            chart2.Series[2].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Leukocytes"]));
                            chart1.Series[1].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Erythrocytes"]));
                            chart2.Series[3].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Protein"]));
                            chart1.Series[2].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Selk_reserve"]));
                            chart1.Series[3].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Calcium"]));
                            chart1.Series[4].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Phosphorus"]));
                            chart1.Series[5].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Glucose"]));
                            chart3.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Carotene"]));
                            chart3.Series[1].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Globulins"]));
                            chart3.Series[2].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Albumins"]));
                            chart1.Series[6].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Lipids"]));
                            chart3.Series[3].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Silk_phosphotase"]));
                            chart1.Series[7].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Magnesium"]));
                            chart1.Series[8].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Urea"]));
                            chart3.Series[4].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["ALT"]));
                            chart3.Series[5].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["AST"]));
                        }
                        sqlDataReader.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("У выбранной коровы отсутствуют данные о матери, выберите другую корову", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        public async void AllAnimals()
        {
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                        chart2.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Hemoglobin"]));
                        chart1.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Hematocrit"]));
                        chart2.Series[1].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["SOE"]));
                        chart2.Series[2].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Leukocytes"]));
                        chart1.Series[1].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Erythrocytes"]));
                        chart2.Series[3].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Protein"]));
                        chart1.Series[2].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Selk_reserve"]));
                        chart1.Series[3].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Calcium"]));
                        chart1.Series[4].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Phosphorus"]));
                        chart1.Series[5].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Glucose"]));
                        chart3.Series[0].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Carotene"]));
                        chart3.Series[1].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Globulins"]));
                        chart3.Series[2].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Albumins"]));
                        chart1.Series[6].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Lipids"]));
                        chart3.Series[3].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["Silk_phosphotase"]));
                        chart1.Series[7].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Magnesium"]));
                        chart1.Series[8].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["Urea"]));
                        chart3.Series[4].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["ALT"]));
                        chart3.Series[5].Points.AddXY(i + 1, Convert.ToInt32(sqlDataReader["AST"]));
                    }
                    sqlDataReader.Close();
                }
            }
        }

        public async void MDB()
        {
            ChartWork();
            chart1.Series[0].Name = "МДБ (%)";
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                int i = 0;
                sqlCommand = new SqlCommand("SELECT * FROM [Lactation] WHERE [ID_cow] = @idCow", sqlConnection);
                sqlCommand.Parameters.AddWithValue("idCow", idCow);
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    chart1.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["MDB"]));
                    i = i + 1;
                }
            }
        }

        public async void MDZH()
        {
            ChartWork();
            chart1.Series[0].Name = "МДЖ (%)";
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                int i = 0;
                sqlCommand = new SqlCommand("SELECT * FROM [Lactation] WHERE [ID_cow] = @idCow", sqlConnection);
                sqlCommand.Parameters.AddWithValue("idCow", idCow);
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    chart1.Series[0].Points.AddXY(i + 1, Convert.ToDecimal(sqlDataReader["MDJ"]));
                    i = i + 1;
                }
            }
        }

        public async void AMYDaily()
        {
            ChartWork();
            chart1.Series[0].Name = "Средний удой за день (кг)";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                sqlCommand = new SqlCommand("SELECT * FROM [Apparat] WHERE [Date] BETWEEN @dateStart AND @dateEnd", sqlConnection);
                sqlCommand.Parameters.AddWithValue("dateStart", DateTime.Now.AddDays(-1).ToString("dd.MM.yyyy"));
                sqlCommand.Parameters.AddWithValue("dateEnd", DateTime.Now.ToString("dd.MM.yyyy"));
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    bool Check = false;
                    for (int i = 0; i < idCows.Length; i++)
                    {
                        if (Convert.ToInt32(sqlDataReader["ID_cow"]) == idCows[i])
                            Check = true;
                    }
                    if (!Check)
                    {
                        if (c > 0)
                            Array.Resize(ref idCows, idCows.Length + 1);
                        idCows[c] = Convert.ToInt32(sqlDataReader["ID_cow"]);
                        c = c + 1;
                    }
                }
                sqlDataReader.Close();
                int[] milkYield = new int[idCows.Length];
                for (int i = 0; i < idCows.Length; i++)
                {
                    sqlCommand = new SqlCommand("SELECT * FROM [Apparat] WHERE [ID_cow] = @idCow AND [Date] BETWEEN @dateStart AND @dateEnd", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("idCow", idCows[i]);
                    sqlCommand.Parameters.AddWithValue("dateStart", DateTime.Now.AddDays(-1).ToString("dd.MM.yyyy"));
                    sqlCommand.Parameters.AddWithValue("dateEnd", DateTime.Now.ToString("dd.MM.yyyy"));
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                        milkYield[i] = milkYield[i] + Convert.ToInt32(sqlDataReader["Count_of_milk"]);
                    sqlDataReader.Close();
                    chart1.Series[0].Points.AddXY(i + 1, milkYield[i]);
                }
            }
        }

        public async void AMYMonthly()
        {
            ChartWork();
            chart1.Series[0].Name = "Средний удой за месяц (кг)";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                sqlCommand = new SqlCommand("SELECT * FROM [Apparat] WHERE [Date] BETWEEN @dateStart AND @dateEnd", sqlConnection);
                sqlCommand.Parameters.AddWithValue("dateStart", DateTime.Now.AddMonths(-1).ToString("dd.MM.yyyy"));
                sqlCommand.Parameters.AddWithValue("dateEnd", DateTime.Now.ToString("dd.MM.yyyy"));
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    bool Check = false;
                    for (int i = 0; i < idCows.Length; i++)
                    {
                        if (Convert.ToInt32(sqlDataReader["ID_cow"]) == idCows[i])
                            Check = true;
                    }
                    if (!Check)
                    {
                        if (c > 0)
                            Array.Resize(ref idCows, idCows.Length + 1);
                        idCows[c] = Convert.ToInt32(sqlDataReader["ID_cow"]);
                        c = c + 1;
                    }
                }
                sqlDataReader.Close();
                int[] milkYield = new int[idCows.Length];
                for (int i = 0; i < idCows.Length; i++)
                {
                    sqlCommand = new SqlCommand("SELECT * FROM [Apparat] WHERE [ID_cow] = @idCow AND [Date] BETWEEN @dateStart AND @dateEnd", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("idCow", idCows[i]);
                    sqlCommand.Parameters.AddWithValue("dateStart", DateTime.Now.AddMonths(-1).ToString("dd.MM.yyyy"));
                    sqlCommand.Parameters.AddWithValue("dateEnd", DateTime.Now.ToString("dd.MM.yyyy"));
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                        milkYield[i] = milkYield[i] + Convert.ToInt32(sqlDataReader["Count_of_milk"]);
                    sqlDataReader.Close();
                    chart1.Series[0].Points.AddXY(i + 1, milkYield[i]);
                }
            }
        }

        public async void AMYYearly()
        {
            ChartWork();
            chart1.Series[0].Name = "Средний удой за год (кг)";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                sqlCommand = new SqlCommand("SELECT * FROM [Apparat] WHERE [Date] BETWEEN @dateStart AND @dateEnd", sqlConnection);
                sqlCommand.Parameters.AddWithValue("dateStart", DateTime.Now.AddYears(-1).ToString("dd.MM.yyyy"));
                sqlCommand.Parameters.AddWithValue("dateEnd", DateTime.Now.ToString("dd.MM.yyyy"));
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    bool Check = false;
                    for (int i = 0; i < idCows.Length; i++)
                    {
                        if (Convert.ToInt32(sqlDataReader["ID_cow"]) == idCows[i])
                            Check = true;
                    }
                    if (!Check)
                    {
                        if (c > 0)
                            Array.Resize(ref idCows, idCows.Length + 1);
                        idCows[c] = Convert.ToInt32(sqlDataReader["ID_cow"]);
                        c = c + 1;
                    }
                }
                sqlDataReader.Close();
                int[] milkYield = new int[idCows.Length];
                for (int i = 0; i < idCows.Length; i++)
                {
                    sqlCommand = new SqlCommand("SELECT * FROM [Apparat] WHERE [ID_cow] = @idCow AND [Date] BETWEEN @dateStart AND @dateEnd", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("idCow", idCows[i]);
                    sqlCommand.Parameters.AddWithValue("dateStart", DateTime.Now.AddYears(-1).ToString("dd.MM.yyyy"));
                    sqlCommand.Parameters.AddWithValue("dateEnd", DateTime.Now.ToString("dd.MM.yyyy"));
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                        milkYield[i] = milkYield[i] + Convert.ToInt32(sqlDataReader["Count_of_milk"]);
                    sqlDataReader.Close();
                    chart1.Series[0].Points.AddXY(i + 1, milkYield[i]);
                }
            }
        }

        public async void AMYLactations()
        {
            ChartWork();
            chart1.Series[0].Name = "Средний удой по всем лактациям (кг)";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                sqlCommand = new SqlCommand("SELECT * FROM [Apparat]", sqlConnection);
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    bool Check = false;
                    for (int i = 0; i < idCows.Length; i++)
                    {
                        if (Convert.ToInt32(sqlDataReader["ID_cow"]) == idCows[i])
                            Check = true;
                    }
                    if (!Check)
                    {
                        if (c > 0)
                            Array.Resize(ref idCows, idCows.Length + 1);
                        idCows[c] = Convert.ToInt32(sqlDataReader["ID_cow"]);
                        c = c + 1;
                    }
                }
                sqlDataReader.Close();
                int[] milkYield = new int[idCows.Length];
                for (int i = 0; i < idCows.Length; i++)
                {
                    sqlCommand = new SqlCommand("SELECT * FROM [Apparat] WHERE [ID_cow] = @idCow", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("idCow", idCows[i]);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                        milkYield[i] = milkYield[i] + Convert.ToInt32(sqlDataReader["Count_of_milk"]);
                    sqlDataReader.Close();
                    chart1.Series[0].Points.AddXY(i + 1, milkYield[i]);
                }
            }
        }

        public async void AMYLactation()
        {
            ChartWork();
            chart1.Series[0].Name = "Средний удой по последней лактации (кг)";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            sqlConnection = new SqlConnection(global::Doyki.Properties.Settings.Default.sqlConnectionString);
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
                sqlCommand = new SqlCommand("SELECT * FROM [Apparat] WHERE [Date] BETWEEN @dateStart AND @dateEnd", sqlConnection);
                sqlCommand.Parameters.AddWithValue("dateStart", DateTime.Now.AddMonths(-10).ToString("dd.MM.yyyy"));
                sqlCommand.Parameters.AddWithValue("dateEnd", DateTime.Now.ToString("dd.MM.yyyy"));
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (sqlDataReader.Read())
                {
                    bool Check = false;
                    for (int i = 0; i < idCows.Length; i++)
                    {
                        if (Convert.ToInt32(sqlDataReader["ID_cow"]) == idCows[i])
                            Check = true;
                    }
                    if (!Check)
                    {
                        if (c > 0)
                            Array.Resize(ref idCows, idCows.Length + 1);
                        idCows[c] = Convert.ToInt32(sqlDataReader["ID_cow"]);
                        c = c + 1;
                    }
                }
                sqlDataReader.Close();
                int[] milkYield = new int[idCows.Length];
                for (int i = 0; i < idCows.Length; i++)
                {
                    sqlCommand = new SqlCommand("SELECT * FROM [Apparat] WHERE [ID_cow] = @idCow AND [Date] BETWEEN @dateStart AND @dateEnd", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("idCow", idCows[i]);
                    sqlCommand.Parameters.AddWithValue("dateStart", DateTime.Now.AddMonths(-10).ToString("dd.MM.yyyy"));
                    sqlCommand.Parameters.AddWithValue("dateEnd", DateTime.Now.ToString("dd.MM.yyyy"));
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                        milkYield[i] = milkYield[i] + Convert.ToInt32(sqlDataReader["Count_of_milk"]);
                    sqlDataReader.Close();
                    chart1.Series[0].Points.AddXY(i + 1, milkYield[i]);
                }
            }
        }

        public void ChartWork()
        {
            chart1.Series[1].Enabled = false;
            chart1.Series[2].Enabled = false;
            chart1.Series[3].Enabled = false;
            chart1.Series[4].Enabled = false;
            chart1.Series[5].Enabled = false;
            chart1.Series[6].Enabled = false;
            chart1.Series[7].Enabled = false;
            chart1.Series[8].Enabled = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart1.Dock = DockStyle.Fill;
        }
    }
}
