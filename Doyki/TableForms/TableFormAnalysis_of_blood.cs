using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Doyki
{
    public partial class TableFormAnalysis_of_blood : Doyki.TableForm
    {
        Uchot_udoevDataSet1TableAdapters.Analysis_of_bloodTableAdapter adapter;
        protected Uchot_udoevDataSet1.Analysis_of_bloodDataTable dataTable;
        public TableFormAnalysis_of_blood(Uchot_udoevDataSet1.Analysis_of_bloodDataTable dataTable, Uchot_udoevDataSet1TableAdapters.Analysis_of_bloodTableAdapter adapter) : base()//dataSet, cattleTableAdapter, source)
        {
            //InitializeComponent();
            this.Text = "Таблица \"Анализы крови\"";
            this.dataGridView1.DataSource = dataTable;

            this.dataTable = dataTable;
            this.adapter = adapter;
            Refresh_Click(null, null);
        }

        override protected void Refresh_Click(object sender, EventArgs e)
        {
            adapter.Fill(dataTable);
        }
        override protected void Apply_Click(object sender, EventArgs e)
        {
             adapter.Update(dataTable);
        }
    }
}
