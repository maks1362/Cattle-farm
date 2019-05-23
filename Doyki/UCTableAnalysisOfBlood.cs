using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doyki
{
    public partial class UCTableAnalysisOfBlood : UserControl
    {
        public UCTableAnalysisOfBlood()
        {
            InitializeComponent();
            this.analysis_of_bloodTableAdapter.Fill(this.uchot_udoevDataSet2.Analysis_of_blood);
        }

        private void Analysis_of_bloodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analysis_of_bloodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet2);

        }

        //Ивент поиска по кнопке
        private void SearchStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < analysis_of_bloodDataGridView.RowCount; i++)
            {
                analysis_of_bloodDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < analysis_of_bloodDataGridView.ColumnCount; j++)
                    if (analysis_of_bloodDataGridView.Rows[i].Cells[j].Value != null)
                        if (analysis_of_bloodDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchStripTextBox.Text))
                        {
                            analysis_of_bloodDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = (MainForm)this.Parent;
            main.tableLayoutPanel1.Show();
        }
    }
}
