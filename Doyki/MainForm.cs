using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
        //Для захвата позиции мышки
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int cGrip = 300;
        private const int cCaption = 600;


        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        //Переменные

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
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        /*public void Mess(string mes)
        {
            MessageBox.Show(mes);
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

        protected virtual void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PlusWindowButton_Click(object sender, EventArgs e)
        {
            Form Child  = new ChildForm();
            Child.Owner = this;
            Child.Show();
        }

        private void NameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        //Resize - не работает  
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
    }
}
