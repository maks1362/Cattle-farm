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

        private void BreedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm();
            this.Hide();
            chartForm.ShowDialog();
            this.Show();
        }
    }
}
