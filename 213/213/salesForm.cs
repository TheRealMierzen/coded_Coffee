using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _213
{
    public partial class salesForm : Form
    {
        private string itemID, items, itemIDS, paymentMethod, itemName;
        private double itemCost;
        public double totalCost, totalPaid, change;
        private bool Promotion, SpecialOrder;

        List<string> product = new List<string>();
        List<double> price = new List<double>();
        List<int> totalPerItem = new List<int>();

        public salesForm()
        {
            InitializeComponent();
        }

        private void cmbSalesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
           // SqlConnection conString = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
           // SqlCommand createSale = new SqlCommand();
           if(cmbSalesMenu.SelectedIndex == 0)
            {
                pnlAddSale.Show();
                pnlPrevSaleCancel.Hide();
            }
            if (cmbSalesMenu.SelectedIndex == 1)
            {
                pnlPrevSaleCancel.Show();
                pnlAddSale.Hide();
            }
            if (cmbSalesMenu.SelectedIndex == 2)
            {
                //Gaan na Dyl se stock search form..
            }
            if (cmbSalesMenu.SelectedIndex == 3)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            if (cmbSalesMenu.SelectedIndex == 4)
            {
                Application.Exit();
            }


        }

        private void salesForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            totalCost = 0;
        }

        private void btnSalesBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnCancelSaleBusy_Click(object sender, EventArgs e)
        {
            lbxSaleReceipt.Items.Clear();
            txtProductID_Sale.Clear();
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add("MATRIX WAREHOUSE");
            //lbxSaleReceipt.Items.Add(branch);
            lbxSaleReceipt.Items.Add(DateTime.Now);
            lbxSaleReceipt.Items.Add("=========================");
            product.Clear();
            totalPerItem.Clear();
            price.Clear();
            
        }

        private void salesForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_stockI_TDataSet.Sales' table. You can move, or remove it, as needed.
           // this.salesTableAdapter.Fill(this._stockI_TDataSet.Sales);
            // TODO: This line of code loads data into the '_stockI_TDataSet.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this._stockI_TDataSet.Stock);
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add("MATRIX WAREHOUSE");
            //lbxSaleReceipt.Items.Add(branch);
            lbxSaleReceipt.Items.Add(DateTime.Now);
            lbxSaleReceipt.Items.Add("=========================");
            product.Clear();
            totalPerItem.Clear();
            price.Clear();

        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            CompleteSale f1 = new CompleteSale();
            f1.Show();
        }

        private void lbxSaleReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaleSearch_Click(object sender, EventArgs e)
        {

            //DateTimePicker Value
            //dtpSaleDateSearch.Value();
            //SqlConnection conString = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            //SqlCommand createSale = new SqlCommand(@"INSERT INTO Sales VALUES()");
        }

        private void pnlAddSale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddToSale_Click(object sender, EventArgs e)
        {
            itemID = txtProductID_Sale.Text;

            setItemName(itemID);
            setItemPrice(itemID);

            //display die hoeveelheid, item en prys van elk...
            if(product.Contains(getItemName()) == false)
            {
                product.Add(getItemName());
                price.Add(getItemPrice());
                totalPerItem.Add(1);
            }
            else
            {
                int indeks = product.IndexOf(getItemName());
                if (indeks != -1)
                {
                    totalPerItem[indeks] = totalPerItem[indeks] + 1;
                    price[indeks] = price[indeks] + getItemPrice();
                }
            }

            lbxSaleReceipt.Items.Clear();
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add("MATRIX WAREHOUSE");
            //lbxSaleReceipt.Items.Add(branch);
            lbxSaleReceipt.Items.Add(DateTime.Now);
            lbxSaleReceipt.Items.Add("=========================");
            for(int i = 0; i < product.Count(); i++)
            {
                lbxSaleReceipt.Items.Add(totalPerItem[i].ToString() + "x " + product[i] + " R" + price[i].ToString());     
            }
            totalCost = price.Sum();
            lbxSaleReceipt.Items.Add("R" + totalCost.ToString());


        }

//GET AND SET ITEMNAME////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setItemName(string itemID)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            using (SqlCommand comm = new SqlCommand(@"SELECT description FROM Stock WHERE item_id = '" + itemID + "'", con))
            {
                con.Open();
                if (comm.ExecuteScalar() == null)
                {
                    MessageBox.Show("DIE ID BESTAAN NIE!");
                }
                else
                {
                    itemName = comm.ExecuteScalar().ToString();
                }
                con.Close();
            }
        }

        private string getItemName()
        {
            return itemName;
        }
//GET AND SET ITEMPRICE////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setItemPrice(string itemID)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            using (SqlCommand comm = new SqlCommand(@"SELECT retail_price FROM Stock WHERE item_id = '" + itemID + "'", con))
            {
                con.Open();
                if (comm.ExecuteScalar() == null)
                {
                    MessageBox.Show("DIE ID BESTAAN NIE!");
                }
                else
                {
                    itemCost = Convert.ToDouble(comm.ExecuteScalar());
                }
                con.Close();
            }
        }

        private double getItemPrice()
        {
            return itemCost;
        }
    }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}
