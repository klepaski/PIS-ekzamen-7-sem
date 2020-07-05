using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WFWebService
{
    public partial class Form1 : Form
    {
        WS.Service1Client client;

        private void makeColumnOrder()
        {
            dataGridView1.Columns["Id"].DisplayIndex = 0;
            dataGridView1.Columns["FIO"].DisplayIndex = 1;
            dataGridView1.Columns["Telephone"].DisplayIndex = 2;
        }

        public Form1()
        {
            InitializeComponent();
            this.client = new WS.Service1Client();
            UpdateTable();
            makeColumnOrder();
        }

        public void UpdateTable()
        {
            List<WS.Phone> phones = this.client.GetDict().ToList();
            WS.Phone phone = new WS.Phone();
            phone.Id = 0;
            phone.FIO = "";
            phone.Telephone = "";
            phones.Add(phone);
            dataGridView1.DataSource = phones;
        }
        private void button1_Click(object sender, EventArgs e)
        {
			UpdateTable();
        }
    }
}
