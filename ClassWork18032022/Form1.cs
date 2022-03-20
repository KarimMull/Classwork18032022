using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork18032022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet(); // создаем новый пустой кэш данных
            ds.ReadXml(@"XMLFile1.xml"); // записываем в него XML-данные из файла

            foreach (DataRow item in ds.Tables["buyer"].Rows)
            {
                Buyer_Data.Rows.Add(item["name"], item["age"], item["country"], item["wallet"]);
            }
            foreach (DataRow item in ds.Tables["product"].Rows)
            {
                Product_Data.Rows.Add(item["name"], item["price"]);
            }
            foreach (DataRow item in ds.Tables["transaction"].Rows)
            {
                Transactions.Rows.Add(item["name"], item["product"]);
            }
        }
    }
}
