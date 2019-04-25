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

    //this.CommandCollection[1] = this.CommandCollection[1].Clone();
    //this.CommandCollection[1].CommandText = "SELECT ID, Breed, Purity_of_breed, Gender, ID_mother, ID_father, Date_of_birth, D" +
    //"ate_of_death, Cause_of_death, Belongs, Place_of_birth, Generation_number, Line F" +
    //"ROM dbo.Cattle WHERE Date_of_birth IS NOT NULL";

namespace Doyki
{
    public partial class MainForm : Form
    {
        //static Form form = MainForm.ActiveForm;
        /*private static IList<string> dataTables = new List<string>
            {
                { "Скот" },//cattle
                { "Доильные аппараты" },//milking machine
                { "Лактации" },//и анализы молока
                { "Анализы крови" },//blood analyses
                { "Репродуктивность" }
               // new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
            };*/

        public MainForm()
        {
            InitializeComponent();
        }

        /*public void Mess(string mes)
        {
            MessageBox.Show(mes);
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchot_udoevDataSet1.Cattle". При необходимости она может быть перемещена или удалена.
            try
            {
                //this.cattleTableAdapter1.Fill(this.uchot_udoevDataSet1.Cattle);

                //this.uchot_udoevDataSet1.
                

                //this.cattleTableAdapter1.Insert(123, "Хуинная", "asdas", "asdas", null, null, new DateTime(), new DateTime(), "qqq", "qqq", "qqq", 1, "qqq");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void CattleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.cattleTableAdapter1.Update(this.uchot_udoevDataSet1);
            //this.cattleTableAdapter1.FillMain(this.uchot_udoevDataSet1.Cattle);

            TableForm TableCattle = new TableFormCattle(this.uchot_udoevDataSet1.Cattle, this.cattleTableAdapter1);
            TableCattle.Show();


        }
        private void ApparatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableFormApparat(this.uchot_udoevDataSet1.Apparat, this.apparatTableAdapter1);
            tableForm.Show();
        }
        private void AnalysisOfBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableFormAnalysis_of_blood(this.uchot_udoevDataSet1.Analysis_of_blood, this.analysis_of_bloodTableAdapter1);
            tableForm.Show();
        }
        private void LactationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableFormLactation(this.uchot_udoevDataSet1.Lactation, this.lactationTableAdapter1);
            tableForm.Show();
        }
        private void ReproductiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableFormReproductive(this.uchot_udoevDataSet1.Reproductive, this.reproductiveTableAdapter1);
            tableForm.Show();
        }
    }
}
