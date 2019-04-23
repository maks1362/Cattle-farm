using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Макс 26.03.19: Первая пункт меню будет комбо бокс из выбираемых таблиц(скот или доильные аппараты)
 * Далее пункт изменения данных в текущей таблице
 * Далее пункты отчётов и диаграмм(отдельные формы будут открываться)
 * */

namespace Doyki
{
    public partial class Form1 : Form
    {
        static Form form = Form1.ActiveForm;
        /*private static IList<string> dataTables = new List<string>
            {
                { "Скот" },//cattle
                { "Доильные аппараты" },//milking machine
                { "Лактации" },//и анализы молока
                { "Анализы крови" },//blood analyses
                { "Репродуктивность" }
               // new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
            };*/

        public Form1()
        {
            InitializeComponent();
        }


        public void Mess(string mes)
        {
            MessageBox.Show(mes);
        }

        private void cattleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.cattleTableAdapter1.Update(this.uchot_udoevDataSet1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchot_udoevDataSet1.Cattle". При необходимости она может быть перемещена или удалена.
            try
            {
                this.cattleTableAdapter1.Fill(this.uchot_udoevDataSet1.Cattle);
                

                //this.cattleTableAdapter1.Insert(123, "Хуинная", "asdas", "asdas", null, null, new DateTime(), new DateTime(), "qqq", "qqq", "qqq", 1, "qqq");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //dataGridView1.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchot_udoevDataSet.Cattle". При необходимости она может быть перемещена или удалена.

        }
    }
}
