﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Doyki
{
    public partial class TableFormApparat : Doyki.TableForm
    {
        Uchot_udoevDataSet1TableAdapters.ApparatTableAdapter adapter;
        protected Uchot_udoevDataSet1.ApparatDataTable dataTable;
        public TableFormApparat(Uchot_udoevDataSet1.ApparatDataTable dataTable, Uchot_udoevDataSet1TableAdapters.ApparatTableAdapter adapter) : base()//dataSet, cattleTableAdapter, source)
        {
            //InitializeComponent();
            this.Text = "Таблица \"Аппараты\"";
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