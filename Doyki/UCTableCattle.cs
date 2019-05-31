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
    public partial class UCTableCattle : UserControl
    {
        int idChart;
        int idCow;

        public UCTableCattle()
        {
            InitializeComponent();
        }

        private void CattleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cattleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet1);
        }

        private void LactationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idChart = 1;
            /*{
                int temp = cattleDataGridView.CurrentCell.RowIndex;
                idCow = Convert.ToInt32(cattleDataGridView[0, temp].Value);
            }*/
            idCow = 1001;
            ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
            this.Hide();
            chartForm.ShowDialog();
            this.Show();
        }

        private void BreedsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            idChart = 2;
            idCow = 1001;
            ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
            this.Hide();
            chartForm.ShowDialog();
            this.Show();
        }

        private void LinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idChart = 3;
            idCow = 1001;
            ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
            this.Hide();
            chartForm.ShowDialog();
            this.Show();
        }

        private void FamiliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idChart = 4;
            idCow = 1001;
            ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
            this.Hide();
            chartForm.ShowDialog();
            this.Show();
        }

        private void AllAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idChart = 5;
            idCow = 1001;
            ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
            this.Hide();
            chartForm.ShowDialog();
            this.Show();
        }

        private void AverageMilkYieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idChart = 6;
            idCow = 1001;
            ChartForm chartForm = new ChartForm(this.idChart, this.idCow);
            this.Hide();
            chartForm.ShowDialog();
            this.Show();
        }
    }
}
