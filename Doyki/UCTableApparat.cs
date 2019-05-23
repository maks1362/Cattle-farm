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
    public partial class UCTableApparat : UserControl
    {
        public UCTableApparat()
        {
            InitializeComponent();
            this.apparatTableAdapter.Fill(this.uchot_udoevDataSet2.Apparat);
        }

        private void ApparatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.apparatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet2);

        }

        private void SearchStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < apparatDataGridView.RowCount; i++)
            {
                apparatDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < apparatDataGridView.ColumnCount; j++)
                    if (apparatDataGridView.Rows[i].Cells[j].Value != null)
                        if (apparatDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchStripTextBox.Text))
                        {
                            apparatDataGridView.Rows[i].Selected = true;
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
