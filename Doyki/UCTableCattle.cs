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
        Uchot_udoevDataSet1TableAdapters.CattleTableAdapter adapter;
        protected Uchot_udoevDataSet1.CattleDataTable dataTable;
        public UCTableCattle(Uchot_udoevDataSet1.CattleDataTable dataTable, Uchot_udoevDataSet1TableAdapters.CattleTableAdapter adapter)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.adapter = adapter;
            adapter.Fill(dataTable);
            this.cattleDataGridView.DataSource = dataTable;
        }

        private void CattleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cattleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet1);
        }
    }
}
