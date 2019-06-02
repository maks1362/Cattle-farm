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
            this.cattleTableAdapter.Fill(this.uchot_udoevDataSet2.Cattle);
        }

        private void CattleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cattleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet2);
        }

        //Ивент поиска по кнопке
        private void SearchStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cattleDataGridView.RowCount; i++)
            {
                cattleDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < cattleDataGridView.ColumnCount; j++)
                    if (cattleDataGridView.Rows[i].Cells[j].Value != null)
                        if (cattleDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchStripTextBox.Text))
                        {
                            cattleDataGridView.Rows[i].Selected = true;
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

        private void ВапToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
