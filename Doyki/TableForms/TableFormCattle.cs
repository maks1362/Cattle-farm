using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Doyki
{
    public partial class TableFormCattle : Doyki.TableForm
    {
        private bool AllCattle = true;
        Uchot_udoevDataSet1TableAdapters.CattleTableAdapter adapter;
        protected Uchot_udoevDataSet1.CattleDataTable dataTable;
        public TableFormCattle(Uchot_udoevDataSet1.CattleDataTable dataTable, Uchot_udoevDataSet1TableAdapters.CattleTableAdapter adapter) : base()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = dataTable;

            this.dataTable = dataTable;
            this.adapter = adapter;
            Refresh_Click(null, null);

            this.changeToolStripMenuItem.Click += new System.EventHandler(this.ChangeListCattle);

        }

        private void ChangeListCattle(object sender, EventArgs e)
        {
            AllCattle = AllCattle ? false : true;
            changeToolStripMenuItem.Text = AllCattle ? "Скот только с датой рождения" : "Отобразить весь скот";
            Refresh_Click(null, null);
        }
        override protected void Refresh_Click(object sender, EventArgs e)
        {
            if (AllCattle)
            {
                adapter.Fill(dataTable);
            }
            else
            {
                adapter.FillMain(dataTable);
            }
        }
        override protected void Apply_Click(object sender, EventArgs e)
        {
            adapter.Update(dataTable);
        }
    }
}
