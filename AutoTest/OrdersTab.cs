using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AutoTest
{
    public partial class OrdersTab : Form
    {
        public OrdersTab()
        {
            InitializeComponent();
            this.Fill();
        }
        private void Fill()
        {
            DGVorders.DataSource = DBObjects.Entities.Orders.ToList();
            this.DGVorders.Columns["Code_order"].Visible = false;
            this.DGVorders.Columns["Code_client_ind"].Visible = false;
            this.DGVorders.Columns["Code_client_org"].Visible = false;
            this.DGVorders.Columns["Code_worker"].Visible = false;
            this.DGVorders.Columns["Code_Autotest"].Visible = false;
        }
        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ClientTab formClient = new ClientTab();
            formClient.ShowDialog();
            this.Close();
        }

        private void добавитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            WorkerTab formWorker = new WorkerTab();
            formWorker.ShowDialog();
            this.Close();
        }

        private void DGVorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Orders orders = (Orders)DGVorders.Rows[e.RowIndex].DataBoundItem;
            //FormOrders formOrders = new FormOrders(orders);
            //formOrders.ShowDialog();
            Fill();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            //FormOrders formOrders = new FormOrders(orders);
            //formOrders.ShowDialog();
            Fill();
        }
    }
}
