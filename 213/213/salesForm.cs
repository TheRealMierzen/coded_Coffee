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
using System.IO;

namespace _213
{
    public partial class salesForm : Form
    {
        private string itemID, items, itemIDS, paymentMethod, itemName, specialorder, promotion, warranty, saleID, dateTimeSale, status;
        private string branch = "KLD";
        private double itemCost, newtotalCost;
        private double totalCost, totalPaid, change, discount, discountTot;
        private int totalItems, teller, Promotion, SpecialOrder, prom;

        List<string> product = new List<string>();
        List<double> price = new List<double>();
        List<int> totalPerItem = new List<int>();

        List<string> barcodes = new List<string>();
        List<double> discountTotal = new List<double>();

        List<string> productW = new List<string>();
        List<string> WarrantyP = new List<string>();
        List<int> totalWarrantyP = new List<int>();

        public salesForm()
        {
            InitializeComponent();
        }

        private void cmbSalesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            promotion = "No";
            Promotion = 0;
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
            if (barcodes.Count() == 0)
            {
                MessageBox.Show("There is no sale to cancel!");
            }
            else
            {
                lbxSaleReceipt.Items.Clear();
                txtProductID_Sale.Clear(); ;
                product.Clear();
                totalPerItem.Clear();
                price.Clear();
                productW.Clear();
                totalWarrantyP.Clear();
                discountTotal.Clear();
                WarrantyP.Clear();
                discount = 0;
                discountTot = 0;
                discountTotal.Clear();
                int indeks = barcodes.IndexOf(barcodes.Last());
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                con.Open();
                while (indeks != -1)
                {
                    string code = barcodes[indeks];
                    SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'In Stock' WHERE item_id ='" + code + "'", con);
                    comm.ExecuteNonQuery();
                    barcodes.Remove(barcodes.Last());
                    indeks = indeks - 1;
                }
                con.Close();
            }   
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
            if(barcodes.Count() == 0)
            {
                MessageBox.Show("No items to be sold!");
            }
            else
            {
                pnlAddSale.Hide();
                pnlCompleteSale.Show();
                pnlPrevSaleCancel.Hide();
                lblTotal.Text = "Total payable: R" + newtotalCost.ToString();
            }       
        }

        private void lbxSaleReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveSaleItem_Click(object sender, EventArgs e)
        {
            int indeksBarcode, indeksProduct, indeksProductW;
            string itemToBeRemoved;
            string description;
            double itemPrice;
            if (barcodes.Count() == 0)
            {
                MessageBox.Show("There are no items to undo!");
            }
            else
            {
                indeksBarcode = barcodes.IndexOf(barcodes.Last());
                //lbxSaleReceipt.Items.Add(indeks.ToString());
                itemToBeRemoved = barcodes[indeksBarcode];
           
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                con.Open();
                SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'In Stock' WHERE item_id ='" + itemToBeRemoved + "'", con);
                comm.ExecuteNonQuery();
                SqlCommand FindDescription = new SqlCommand(@"SELECT description FROM Stock WHERE item_id = '" + itemToBeRemoved + "'", con);
                description = FindDescription.ExecuteScalar().ToString();
                //checkPromo(description);
                SqlCommand FindPrice = new SqlCommand(@"SELECT retail_price FROM Stock WHERE item_id = '" + itemToBeRemoved + "'", con);
                itemPrice = Convert.ToDouble(FindPrice.ExecuteScalar());
                con.Close();

                indeksProduct = product.IndexOf(description);
                indeksProductW = productW.IndexOf(description);
//UNDO ITEM///////////////////////////////////////////////////////////////////////////////////////////////////////
                if ((indeksProduct == 0) && (totalPerItem[indeksProduct] == 1))
                {
                    product.Clear();
                    price.Clear();
                    barcodes.Clear();
                    totalPerItem.Clear();
                    totalCost = 0.0;
                    discountTotal.Clear();
                }
                else if (totalPerItem[indeksProduct] == 1)
                {
                    product.Remove(product[indeksProduct]);
                    totalPerItem.Remove(totalPerItem[indeksProduct]);
                    price.Remove(price[indeksProduct]);
                    barcodes.Remove(barcodes[indeksBarcode]);
                    discountTotal.Remove(discountTotal[discountTotal.IndexOf(discountTotal.Last())]);
                    totalCost = price.Sum();

                }
                else if (totalPerItem[indeksProduct] > 1)
                {
                    totalPerItem[indeksProduct] = totalPerItem[indeksProduct] - 1;
                    price[indeksProduct] = price[indeksProduct] - itemPrice;
                    totalCost = price.Sum();
                    barcodes.Remove(barcodes[indeksBarcode]);
                    discountTotal.Remove(discountTotal[discountTotal.IndexOf(discountTotal.Last())]);
                }
//UNDO WARRANTY////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if ((indeksProductW == 0) && (totalWarrantyP[indeksProductW] == 1))
                {
                    productW.Clear();
                    WarrantyP.Clear();
                    totalWarrantyP.Clear();
                }
                else if (totalWarrantyP[indeksProductW] == 1)
                {
                    productW.Remove(productW[indeksProductW]);
                    WarrantyP.Remove(WarrantyP[indeksProductW]);
                    totalWarrantyP.Remove(totalWarrantyP[indeksProductW]);
                }
                else if (totalWarrantyP[indeksProductW] > 1)
                {
                    totalWarrantyP[indeksProductW] = totalWarrantyP[indeksProductW] - 1;
                }
//REDISPLAY THE RECEIPT////////////////////////////////////////////////////////////////////////////////////////////
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
                if (getcheckPromo() >= 1)
                {
                    lbxSaleReceipt.Items.Add(@"Discount:         R" + discountTot.ToString());
                }
                lbxSaleReceipt.Items.Add("=========================");
            }
       
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
                SpecialOrder = 1;
                specialorder = "Yes";
            }
            else
            {
                SpecialOrder = 0;
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
            lbxSaleReceipt.Items.Add(paymentMethod + ": R" + totalPaid.ToString());
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
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add("Thank you for shopping at ");
            lbxSaleReceipt.Items.Add("MATRIX WAREHOUSE!");
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add("WARRANTY:");
            lbxSaleReceipt.Items.Add("");
            for (int i = 0; i < productW.Count(); i++)
            {
                lbxSaleReceipt.Items.Add(totalWarrantyP[i] + "x " + productW[i] + ": " + WarrantyP[i]);
            }
            lbxSaleReceipt.Items.Add("");
            lbxSaleReceipt.Items.Add("=========================");
            lbxSaleReceipt.Items.Add(items);
            lbxSaleReceipt.Items.Add(itemIDS);

            pnlAddSale.Show();
            pnlCompleteSale.Hide();
            pnlPrevSaleCancel.Hide();

           /* using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            using (SqlCommand comm = new SqlCommand(@"INSERT INTO Sales(sale_branch, sale_id, sale_date, items, item_ids, total_cost, total_paid, payment_method, promotion, special_order) VALUES (@sale_branch, @sale_id, @sale_date, @items, @item_ids, @total_cost, @total_paid, @payment_method, @promotion, @special_order)", con))
            {
                
                comm.Parameters.AddWithValue("@sale_branch", branch);
                comm.Parameters.AddWithValue("@sale_id", saleID);
                comm.Parameters.AddWithValue("@sale_date", dateTimeSale);
                comm.Parameters.AddWithValue("@items", items);
                comm.Parameters.AddWithValue("@item_ids", itemIDS);
                comm.Parameters.AddWithValue("@total_cost", totalCost);
                comm.Parameters.AddWithValue("@total_paid", totalPaid);
                comm.Parameters.AddWithValue("@payment_method", paymentMethod);
                comm.Parameters.AddWithValue("@promotion", Promotion);
                comm.Parameters.AddWithValue("@special_order", SpecialOrder);
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();
            }*/
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
            
            checkStockStatus(itemID);

            if(getStockSatus() != "In Stock")
            { 
                MessageBox.Show("Not in stock!");
            }
            else
            {
                barcodes.Add(itemID);
                setWarranty(itemID);
                changeStockStatus(itemID);
                setItemName(itemID);
                setItemPrice(itemID);
                checkPromo(getItemName());
                if (getcheckPromo() >= 1)
                {
                    Promotion = 1;
                    promotion = "Yes";
                    setPromotion(getItemName());
                    discountTotal.Add(Convert.ToDouble(getPromotion()));
                }
                //display die hoeveelheid, item en prys van elk...
                if (product.Contains(getItemName()) == false)
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

                if (getWarranty() != "n/a")
                {
                    if(productW.Contains(getItemName()) == true)
                    {
                        int index = productW.IndexOf(getItemName());
                        if (index != -1)
                        {
                            totalWarrantyP[index] = totalWarrantyP[index] + 1;
                        }
                        
                    }
                    else
                    {
                        productW.Add(getItemName());
                        WarrantyP.Add(getWarranty());
                        totalWarrantyP.Add(1);
                    }
                }

                lbxSaleReceipt.Items.Clear();
                lbxSaleReceipt.Items.Add("=========================");
                lbxSaleReceipt.Items.Add("MATRIX WAREHOUSE");
                //lbxSaleReceipt.Items.Add(branch);
                dateTimeSale = (DateTime.Now).ToString();
                lbxSaleReceipt.Items.Add(dateTimeSale);
                lbxSaleReceipt.Items.Add("=========================");
                lbxSaleReceipt.Items.Add("Cashier:");
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
                lbxSaleReceipt.Items.Add(@"Discount:         R" + discountTot.ToString());
                lbxSaleReceipt.Items.Add("=========================");
            }
            //Check if on promotion//
            //Calculate Discount//
            


        }

        //GET AND SET ITEMNAME////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setItemName(string itemID)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand(@"SELECT description FROM Stock WHERE item_id = '" + itemID + "'", con);
            itemName = comm.ExecuteScalar().ToString();
            con.Close();
        }

        private string getItemName()
        {
            return itemName;
        }
        //GET AND SET ITEMPRICE////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setItemPrice(string itemID)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand(@"SELECT retail_price FROM Stock WHERE item_id = '" + itemID + "'", con);
            itemCost = Convert.ToDouble(comm.ExecuteScalar());
            con.Close();
        }

        private double getItemPrice()
        {
            return itemCost;
        }
        //GET AND SET Promotion////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setPromotion(string itemName)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand(@"SELECT discount FROM Promotions WHERE item_name = '" + itemName + "'", con);
            discount = Convert.ToDouble(comm.ExecuteScalar());
            con.Close();
        }
        private double getPromotion()
        {
            return discount;
        }
        //checkPromo////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkPromo(string itemName)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            SqlCommand checkPromo = new SqlCommand(@"SELECT active FROM Promotions WHERE item_name = '" + itemName + "'", con);
            prom = Convert.ToInt16(checkPromo.ExecuteScalar());
            con.Close();

        }
        private int getcheckPromo()
        {
            return prom;
        }
        //GET AND SET Warranty////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setWarranty(string itemID)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand(@"SELECT warranty FROM Stock WHERE item_id = '" + itemID + "'", con);
            warranty = comm.ExecuteScalar().ToString();
            con.Close();
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

        //Check status of Stock////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkStockStatus(string itemID)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand(@"SELECT status FROM Stock WHERE item_id = '" + itemID + "'", con);
            status = Convert.ToString(comm.ExecuteScalar());
            con.Close();

        }
        private string getStockSatus()
        {
            return status;
        }
        //UPDATE STOCK_Status FROM TABLE////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void changeStockStatus(string itemID)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'Sold' WHERE item_id ='" + itemID + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
        }
        //Save Receipt////////////////////////////////////////////////////////////////////////////////////////////
        /*public void saveReceipt()
        {
            if (File.Exists(appPath))
            {
                StreamWriter outstream = File.AppendText(appPath + @"\stockI.T" + @"\Datum" +  @"\Receipt.txt");
                outstream.WriteLine();
                outstream.Close();
            }
            else
            {        
                File.CreateText(appPath).Close();
                StreamWriter outstream = File.AppendText(appPath);
                outstream.WriteLine();
                outstream.Close();
            }
        }*/
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
    

