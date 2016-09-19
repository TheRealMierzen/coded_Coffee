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
        private string itemID, items, itemIDS, paymentMethod, itemName, specialorder, promotion, warranty, saleID, dateTimeSale;
        private double itemCost, newtotalCost;
        private double totalCost, totalPaid, change, discount, discountTot;
        private bool Promotion = false;
        private bool SpecialOrder = false;
        private int totalItems, prom, teller;

        List<string> product = new List<string>();
        List<string> productW = new List<string>();
        List<string> WarrantyP = new List<string>();
        List<double> price = new List<double>();
        List<double> discountTotal = new List<double>();
        List<int> totalPerItem = new List<int>();
        List<string> barcodes = new List<string>();

        public salesForm()
        {
            InitializeComponent();
        }

        private void cmbSalesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            promotion = "No";
            Promotion = false;
            // SqlConnection conString = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            // SqlCommand createSale = new SqlCommand();
            if (cmbSalesMenu.SelectedIndex == 0)
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
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
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
            txtProductID_Sale.Clear();;
            product.Clear();
            totalPerItem.Clear();
            price.Clear();

        }

        private void salesForm_Load_1(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            product.Clear();
            totalPerItem.Clear();
            price.Clear();
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            pnlAddSale.Hide();
            pnlCompleteSale.Show();
            pnlPrevSaleCancel.Hide();
            lblTotal.Text = "Total payable: R" + newtotalCost.ToString();     
        }

        private void lbxSaleReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            pnlAddSale.Show();
            pnlCompleteSale.Hide();
            pnlPrevSaleCancel.Hide();
            txtPaid.Clear();
            cbxMethodOfPayment.ResetText();
            cbxSpecialOrder.Checked = false;
        }

        private void btnCompleteSalePaid_Click(object sender, EventArgs e)
        {
            teller = teller + 1;
            saleID = GenerateSaleID(teller);
            if (cbxMethodOfPayment.SelectedIndex == 0)
            {
                paymentMethod = "Cash";
            }
            if (cbxMethodOfPayment.SelectedIndex == 1)
            {
                paymentMethod = "Credit";
            }
            if (cbxMethodOfPayment.SelectedIndex == 2)
            {
                paymentMethod = "Debit";
            }
            if (cbxMethodOfPayment.SelectedIndex == 3)
            {
                paymentMethod = "Tjek";
            }

            totalPaid = Convert.ToInt32(txtPaid.Text);


            if (cbxSpecialOrder.Checked == true)
            {
                SpecialOrder = true;
                specialorder = "Yes";
            }
            else
            {
                SpecialOrder = false;
                specialorder = "No";
            }
            for(int i = 0; i < product.Count(); i++)
            {
                items = items + totalPerItem[i] + "x" + product[i] + ",";
            }
            for (int i = 0; i < barcodes.Count(); i++)
            {
                itemIDS = itemIDS + barcodes[i] + ",";
            }
            lbxSaleReceipt.Items.Add(paymentMethod + ":     R" + totalCost.ToString());
            newtotalCost = totalCost - discountTot;
            change = totalPaid - newtotalCost;
            lbxSaleReceipt.Items.Add("Change:               R" + change);
            lbxSaleReceipt.Items.Add("Total items: " + totalItems.ToString());
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add("Special Order: " + specialorder);
            lbxSaleReceipt.Items.Add("Promotion: " + promotion);
            lbxSaleReceipt.Items.Add( "=========================");
            lbxSaleReceipt.Items.Add("Total after discount: R" + newtotalCost.ToString());
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add("Sale ID: " + saleID);
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add("Thank you for shopping at ");
            lbxSaleReceipt.Items.Add("MATRIX WAREHOUSE!");
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add("WARRANTY:");
            lbxSaleReceipt.Items.Add("");
            for (int i = 0; i < productW.Count(); i++)
            {
                lbxSaleReceipt.Items.Add(productW[i] + ": " + WarrantyP[i]);
            }
            lbxSaleReceipt.Items.Add("");
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add(items);
            lbxSaleReceipt.Items.Add(itemIDS);

            pnlAddSale.Show();
            pnlCompleteSale.Hide();
            pnlPrevSaleCancel.Hide();
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
            barcodes.Add(itemID);
            checkPromo(itemID);
            setWarranty(itemID);

            //Check if on promotion//
            //Calculate Discount//
            if (getcheckPromo() >= 1)
            {
                Promotion = true;
                promotion = "Yes";
                setPromotion(itemID);
                discountTotal.Add(Convert.ToDouble(getPromotion()));
            }

            setItemName(itemID);
            setItemPrice(itemID);

            //display die hoeveelheid, item en prys van elk...
            if (product.Contains(getItemName()) == false)
            {
                product.Add(getItemName());
                price.Add(getItemPrice());
                totalPerItem.Add(1);
                //deleteStock(itemID);
            }
            else
            {
                int indeks = product.IndexOf(getItemName());
                if (indeks != -1)
                {
                    totalPerItem[indeks] = totalPerItem[indeks] + 1;
                    price[indeks] = price[indeks] + getItemPrice();
                    //deleteStock(itemID);
                }
            }

            if (getWarranty() != "n/a")
            {
                productW.Add(getItemName());
                WarrantyP.Add(getWarranty());
            }

            lbxSaleReceipt.Items.Clear();
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add("MATRIX WAREHOUSE");
            //lbxSaleReceipt.Items.Add(branch);
            dateTimeSale = (DateTime.Now).ToString();
            lbxSaleReceipt.Items.Add(dateTimeSale);
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add(@"Cashier:");
            lbxSaleReceipt.Items.Add("");
            for (int i = 0; i < product.Count(); i++)
            {
                lbxSaleReceipt.Items.Add(totalPerItem[i].ToString() + "x " + product[i] + " R" + price[i].ToString());
            }
            totalCost = price.Sum();
            totalItems = totalPerItem.Sum();
            discountTot = discountTotal.Sum();
            newtotalCost = totalCost - discountTot;
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add(@"Total (VAT incl): R" + totalCost.ToString());
            if(getcheckPromo() >= 1)
            {
                lbxSaleReceipt.Items.Add(@"Discount:         R" + discount.ToString());
            }
            lbxSaleReceipt.Items.Add("=========================");


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
        //GET AND SET Promotion////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setPromotion(string itemID)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            using (SqlCommand comm = new SqlCommand(@"SELECT discount FROM Promotions WHERE item_id = '" + itemID + "'", con))
            {
                con.Open();
                if (comm.ExecuteScalar() == null)
                {
                    discount = 0.0;
                }
                else
                {
                    discount = Convert.ToDouble(comm.ExecuteScalar());
                }
                con.Close();
            }
        }
        private double getPromotion()
        {
            return discount;
        }
        //checkPromo////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkPromo(string itemID)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) FROM Promotions WHERE item_id = '" + itemID + "'", con);
            //comm.ExecuteNonQuery();
            prom = Convert.ToInt16(comm.ExecuteScalar());
            con.Close();

        }
        private int getcheckPromo()
        {
            return prom;
        }
        //GET AND SET Warranty////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setWarranty(string itemID)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            using (SqlCommand comm = new SqlCommand(@"SELECT warranty FROM Stock WHERE item_id = '" + itemID + "'", con))
            {
                con.Open();
                if (comm.ExecuteScalar() == null)
                {
                    warranty = "None!";
                }
                else
                {
                    warranty = comm.ExecuteScalar().ToString();
                }
                con.Close();
            }
        }
        private string getWarranty()
        {
            return warranty;
        }
        //Generate Sale ID////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public string GenerateSaleID(int teller)
        {
            string saleID;
            saleID = "S" + teller.ToString(); 
            return saleID; 
        }
        //DELETE STOCK FROM TABLE////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*private void deleteStock(string ID)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            using (SqlCommand comm = new SqlCommand(@"DELETE FROM Stock WHERE item_id '" + itemID + "'", con))
            {
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();
            }
        }*/
    }
}
    

