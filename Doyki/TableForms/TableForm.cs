using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doyki
{
    abstract public partial class TableForm : Form
    {
        //protected DataTable dataSet;
        protected TableForm()
        {
            InitializeComponent();
        }
        /*public TableForm(Uchot_udoevDataSet1.CattleDataTable dataSet, Uchot_udoevDataSet1TableAdapters.CattleTableAdapter cattleTableAdapter, BindingSource source) : this()
        {
            this.Adapter = cattleTableAdapter;
            this.dataSet = dataSet;

            dataGridView1.DataSource = dataSet;
            Refresh_Click(null, null);
            //cattleTableAdapter.Fill();
            //this.cattleTableAdapter1.Fill(this.uchot_udoevDataSet1.Cattle)

        }*/


        abstract protected void Apply_Click(object sender, EventArgs e);
        /*{
            Adapter.Update(dataSet);

        }*/

        abstract protected void Refresh_Click(object sender, EventArgs e);
        /*{
            Adapter.Fill(dataSet);
        }*/
    }


}
