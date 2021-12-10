using ipz_AUTOCHAIR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipz_AUTOCHAIR
{
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
        }

        private void bcgotomainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainProgramWindow newForm = new MainProgramWindow();
            newForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<Order> Orders { get; set; }
        private void OrderList_Load(object sender, EventArgs e)
        {
            Client client = new Client();
            client.SendCommand("[GETORDERS]");
            client.SendObject<int>(Client.ID);
            int sizeOfObj = client.GetSize();
            Orders = client.GetObject<List<Order>>(sizeOfObj);
            dataGridView1.DataSource = (from d in Orders orderby d.Chair.Name select new { d.Chair.Name, d.Prise, d.Count }).ToList();
            dataGridView1.Columns[0].HeaderCell.Value = "Name";
            dataGridView1.Columns[1].HeaderCell.Value = "Prise";
            dataGridView1.Columns[2].HeaderCell.Value = "Count";
            dataGridView1.Columns.Add("Full Prise", "Full Prise");
            int i = 0;
            foreach (var item in Orders)
            {
                dataGridView1.Rows[i].Cells[3].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                i++;
            }
        }
    }
}
