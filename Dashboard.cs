using System;
using System.Windows.Forms;

namespace SmartWarehouseUI_New
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddProduct().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Supplier().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Order().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StockReport().Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Screen().Show();
        }
    }
}