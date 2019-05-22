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
    public partial class UCTableLactation : UserControl
    {
        public UCTableLactation()
        {
            InitializeComponent();
            this.lactationTableAdapter.Fill(this.uchot_udoevDataSet2.Lactation);
        }

        private void LactationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lactationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet2);
        }
    }
}
