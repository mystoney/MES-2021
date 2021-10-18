using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.form.Order
{
    public partial class OrderListMain : Form
    {
        public OrderListMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OrderAdd oa = new OrderAdd();
            oa.ShowDialog();
        }

        private void GridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
