using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Doyki
{
    public partial class TableFormReproductive : Doyki.TableForm
    {
        Uchot_udoevDataSet1TableAdapters.ReproductiveTableAdapter adapter;
        protected Uchot_udoevDataSet1.ReproductiveDataTable dataTable;
        public TableFormReproductive(Uchot_udoevDataSet1.ReproductiveDataTable dataTable, Uchot_udoevDataSet1TableAdapters.ReproductiveTableAdapter adapter) : base()//dataSet, cattleTableAdapter, source)
        {
            //InitializeComponent();
            this.Text = "Таблица \"Репродуктивность\"";
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
