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
    public partial class UCTableReproductive : UserControl
    {
        public UCTableReproductive()
        {
            InitializeComponent();
            this.reproductiveTableAdapter.Fill(this.uchot_udoevDataSet2.Reproductive);
        }

        private void ReproductiveBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reproductiveBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet2);

        }

        private void SearchStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < reproductiveDataGridView.RowCount; i++)
            {
                reproductiveDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < reproductiveDataGridView.ColumnCount; j++)
                    if (reproductiveDataGridView.Rows[i].Cells[j].Value != null)
                        if (reproductiveDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchStripTextBox.Text))
                        {
                            reproductiveDataGridView.Rows[i].Selected = true;
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
