using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Doyki
{
    class DataTable
    {
        //static string DataBaseServer { get; set; }
        static string UserID { get; set; } = "as";
        static string Password { get; set; }
        static string InitialCatalog { get; set; }
        static string Server { get; set; }

        DataTable()
        {

                //Создание строки подключения             
                string ConnectString = "Integrated Security=false;User Id="+ UserID + ";Password="+ Password + ";Initial Catalog="+ InitialCatalog + ";server="+ Server;
            //Объявление новой переменной типа SqlConection             
            SqlConnection con = new SqlConnection(ConnectString);
            //new SqlConnection();
            Exception error = null;//Переменная, представляющая ошибки, появляющиеся во время выполнения приложения             
            try
            {
                con.Open();  //Открытие подключения             
            }
            catch (Exception ex) //При возникновении неполадок при подключении появится сообщение с информацией об ошибке             
            {
                error = ex;//Переменная error запоминает конкретную ошибку                 
                 MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (error==null)//Если переменная не изменилась, то ошибок при подключении не было и соединение с БД Установлено                 
                {
                    MessageBox.Show("Подключение установлено");
                }
                con.Close();
            }     
        }
    }
}
