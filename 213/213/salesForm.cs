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
        private string itemID, items, itemIDS, paymentMethod, itemName, specialorder, promotion, warranty, dateTimeSale, status, saleid;
        //private string branch = Properties.Settings.Default.Branch;
        private string branch = "Klerksdorp";
        private double itemCost, newtotalCost;
        private double totalCost, totalPaid, change, discount, discountTot, labour;
        private int totalItems;
        private bool Promotion, SpecialOrder, prom, cms;

        private string appPath = AppDomain.CurrentDomain.BaseDirectory;//verander as networking reg is

        List<string> product = new List<string>();
        List<double> price = new List<double>();
        List<int> totalPerItem = new List<int>();

        List<string> barcodes = new List<string>();
        List<double> discountTotal = new List<double>();

        List<string> productW = new List<string>();
        List<string> WarrantyP = new List<string>();
        List<int> totalWarrantyP = new List<int>();
        //private string newQuantity;

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
                pnlCompleteSale.Hide();
                pnlCustoms.Hide();
                pnlReturns.Hide();
            }
            if (cmbSalesMenu.SelectedIndex == 1)
            {
                pnlAddSale.Hide();
                pnlPrevSaleCancel.Hide();
                pnlCompleteSale.Hide();
                pnlCustoms.Show();
                pnlReturns.Hide();
            }
            if (cmbSalesMenu.SelectedIndex == 2)
            {
                pnlAddSale.Hide();
                pnlPrevSaleCancel.Hide();
                pnlCompleteSale.Hide();
                pnlCustoms.Hide();
                pnlReturns.Show();
            }
            if (cmbSalesMenu.SelectedIndex == 3)
            {
                pnlAddSale.Hide();
                pnlPrevSaleCancel.Show();
                pnlCompleteSale.Hide();
                pnlCustoms.Hide();
                pnlReturns.Hide();
            }
            if (cmbSalesMenu.SelectedIndex == 4)
            {
                //Go to Stock Search
            }
            if (cmbSalesMenu.SelectedIndex == 5)
            {
                //Go to orders
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
                    //SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'In Stock' WHERE item_id ='" + code + "' AND branch = '" + branch + "'", con);
                    SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'In Stock' WHERE item_id ='" + code + "'", con);
                    SqlCommand comm2 = new SqlCommand(@"UPDATE Stock SET last_updated = '" + dateTimeSale + "' WHERE item_id ='" + itemID + "'", con);
                    comm.ExecuteNonQuery();
                    comm2.ExecuteNonQuery();
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

                //SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'In Stock' WHERE item_id ='" + itemToBeRemoved + "' AND branch = '" + branch + "'", con);
                SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'In Stock' WHERE item_id ='" + itemToBeRemoved + "'", con);
                SqlCommand comm2 = new SqlCommand(@"UPDATE Stock SET last_updated = '" + dateTimeSale + "' WHERE item_id ='" + itemID + "'", con);
                comm.ExecuteNonQuery();
                comm2.ExecuteNonQuery();
                //SqlCommand FindDescription = new SqlCommand(@"SELECT description FROM Stock WHERE item_id = '" + itemToBeRemoved + "' AND branch = '" + branch + "'", con);
                SqlCommand FindDescription = new SqlCommand(@"SELECT description FROM Stock WHERE item_id = '" + itemToBeRemoved + "'", con);
                description = FindDescription.ExecuteScalar().ToString();
                //checkPromo(description);
                //SqlCommand FindPrice = new SqlCommand(@"SELECT retail_price FROM Stock WHERE item_id = '" + itemToBeRemoved + "' AND branch = '" + branch + "'", con);
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
                    lbxSaleReceipt.Items.Clear();
                }
                else if (totalPerItem[indeksProduct] == 1)
                {
                    product.Remove(product[indeksProduct]);
                    totalPerItem.Remove(totalPerItem[indeksProduct]);
                    price.Remove(price[indeksProduct]);
                    barcodes.Remove(barcodes[indeksBarcode]);
                    totalCost = price.Sum();
                }
                else if (totalPerItem[indeksProduct] > 1)
                {
                    totalPerItem[indeksProduct] = totalPerItem[indeksProduct] - 1;
                    price[indeksProduct] = price[indeksProduct] - itemPrice;
                    totalCost = price.Sum();
                    barcodes.Remove(barcodes[indeksBarcode]);
                }
                //UNDO PROMO////////////////////////////////////////////////////////////////////////////////////////////////////
                int promo, indeksProm;
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                con.Open();
                //SqlCommand command = new SqlCommand(@"SELECT COUNT(*) FROM Promotions WHERE item_name = '" + description + "' AND branch = '" + branch + "'", con);
                SqlCommand command = new SqlCommand(@"SELECT COUNT(*) FROM Promotions WHERE item_name = '" + description + "'", con);
                promo = Convert.ToInt16(command.ExecuteScalar());
                con.Close();
                if(promo == 1)
                {
                    indeksProm = discountTotal.IndexOf(discountTotal.Last());
                    discountTotal.Remove(discountTotal[indeksProm]);
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
                lbxSaleReceipt.Items.Add("Branch: " + branch);
                //lbxSaleReceipt.Items.Add("Sale No.: " + saleID);
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
                if (getcheckPromo() == true)
                {
                    lbxSaleReceipt.Items.Add(@"Discount: R" + discountTot.ToString());
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
            
            btnPrintReceipt_Sales.Enabled = false;
        }

        private void btnCompleteSalePaid_Click(object sender, EventArgs e)
        {
            saleid = GenerateSaleID().ToString();
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
            cms = false;
            btnAddToSale.Enabled = false;
            btnCancelSale.Enabled = false;
            btnRemoveSaleItem.Enabled = false;
            btnCancelSaleBusy.Enabled = false;
            txtProductID_Sale.Enabled = false;
            btnCompleteSale.Enabled = false;
            //btnPrintReceipt_Sales.Enabled = false;

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand(@"INSERT INTO Sales(sale_branch, sale_id, sale_date, items, item_ids, total_cost, total_paid, payment_method, promotion, special_order, cms) VALUES (@sale_branch, @sale_id, @sale_date, @items, @item_ids, @total_cost, @total_paid, @payment_method, @promotion, @special_order, @cms)", con); 
            comm.Parameters.AddWithValue("@sale_branch", branch);
            comm.Parameters.AddWithValue("@sale_id", saleid);
            comm.Parameters.AddWithValue("@sale_date", dateTimeSale);
            comm.Parameters.AddWithValue("@items", items);
            comm.Parameters.AddWithValue("@item_ids", itemIDS);
            comm.Parameters.AddWithValue("@total_cost", newtotalCost.ToString());
            comm.Parameters.AddWithValue("@total_paid", totalPaid.ToString());
            comm.Parameters.AddWithValue("@payment_method", paymentMethod);
            comm.Parameters.AddWithValue("@promotion", Promotion);
            comm.Parameters.AddWithValue("@special_order", SpecialOrder);
            comm.Parameters.AddWithValue("@cms", cms);
            comm.ExecuteNonQuery();
            con.Close();

            //Save Receipt////////////////////////////////////////////////////////////////////////////////////////////
            /*string newFile = saleID.ToString() + ".txt";
            string date = (DateTime.Now.Date).ToString();
            //+@"\Receipts" + @"\'" + date + "'" +
            StreamWriter outstream = File.CreateText(appPath + newFile);
            for(int i = 0; i <= lbxSaleReceipt.Items.Count; i++)
            {
                outstream.WriteLine(lbxSaleReceipt.Items[i]);
            } 
            outstream.Close();
            MessageBox.Show("Sale Completed!");  */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void lbxCustomReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblIDReturn.Show();
            txtProductReturn.Show();
            btnReturnAdd.Show();
            btnPrintReturn.Show();
            btnCompleteReturn.Show();
            string saleID = txtSaleIDReturn.Text;
            string itemIDs;
            int plek;
            string resultString = "";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            //SqlCommand comm = new SqlCommand(@"SELECT item_ids FROM Sales WHERE sale_id = '" + saleID + "' AND sale_branch = '" + branch + "'", con);
            SqlCommand comm = new SqlCommand(@"SELECT item_ids FROM Sales WHERE sale_id = '" + saleID + "'", con);
            itemIDs = comm.ExecuteScalar().ToString();
            con.Close();

            while (itemIDs != "")
            {
                plek = itemIDs.IndexOf(",");
                resultString = itemIDs.Substring(0, plek);
                itemIDs = itemIDs.Remove(0, plek + 1);
                barcodes.Add(resultString);
            }

            for (int i = 0; i < barcodes.Count(); i++)
            {
                lbxReturns.Items.Add(barcodes[i]);
            }




        }

        private void btnAddCustom_Click(object sender, EventArgs e)
        {
            dateTimeSale = (DateTime.Now).ToString();
            string cmsID = txtCmsID.Text;
            string itemIDs;
            int plek;
            string resultString;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand(@"SELECT cms_itemIDs FROM cms WHERE cms_id = '" + cmsID + "'", con);
            itemIDs = comm.ExecuteScalar().ToString();
            con.Close();

            while (itemIDs != "")
            {
                plek = itemIDs.IndexOf(",");
                resultString = itemIDs.Substring(0, plek);
                itemIDs = itemIDs.Remove(0, plek + 1);
                barcodes.Add(resultString);
            }

            for (int i = 0; i < barcodes.Count(); i++)
            {
                lbxCustomReceipt.Items.Add(barcodes[i]);
                checkStockStatus(barcodes[i]);

                if (getStockSatus() != cmsID.ToString())
                {
                    MessageBox.Show("Not in order!");
                }
                else
                {
                    //barcodes.Add(barcodes[i]);
                    setWarranty(barcodes[i]);
                    changeStockStatus(barcodes[i]);
                    setItemName(barcodes[i]);
                    setItemPrice(barcodes[i]);
                    checkPromo(getItemName());
                    if (getcheckPromo() == true)
                    {
                        Promotion = true;
                        promotion = "Yes";
                        changeQuantityMin(getItemName());
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
                        if (productW.Contains(getItemName()) == true)
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

                    lbxCustomReceipt.Items.Clear();
                    lbxCustomReceipt.Items.Add("=========================");
                    lbxCustomReceipt.Items.Add("MATRIX WAREHOUSE");
                    lbxCustomReceipt.Items.Add("Branch: " + branch);
                    lbxCustomReceipt.Items.Add("Custom Sale No.: " + cmsID.ToString());
                    //lbxCustomReceipt.Items.Add(branch);
                    
                    lbxCustomReceipt.Items.Add(dateTimeSale);
                    lbxCustomReceipt.Items.Add("=========================");
                    lbxCustomReceipt.Items.Add("Cashier:");
                    lbxCustomReceipt.Items.Add("");
                    for (int b = 0; b < product.Count(); b++)
                    {
                        lbxCustomReceipt.Items.Add(totalPerItem[b].ToString() + "x " + product[b] + " R" + price[b].ToString());
                    }
                    
                    totalCost = price.Sum(); 
                    totalItems = totalPerItem.Sum();   
                }
            }
            btnAddLabour.Enabled = true;
            lblLabour.Enabled = true;
            txtLabour.Enabled = true;
            txtLabour.Focus();
        }

        private void btnAddLabour_Click(object sender, EventArgs e)
        {
            
            labour = Convert.ToDouble(txtLabour.Text);
            discountTot = discountTotal.Sum();
            newtotalCost = totalCost - discountTot + labour;
            lbxCustomReceipt.Items.Add("Labour: R" + labour);
            lbxCustomReceipt.Items.Add("=========================");
            lbxCustomReceipt.Items.Add(@"Total (VAT incl): R" + newtotalCost.ToString());
            lbxCustomReceipt.Items.Add(@"Discount:         R" + discountTot.ToString());
            lbxCustomReceipt.Items.Add("=========================");
            btnCompletecms.Enabled = true;
            btnPrintCms.Enabled = true;
            btnCancelCms.Enabled = true;
        }

        private void btnCompletecms_Click(object sender, EventArgs e)
        {
            pnlCustoms.Hide();
            pnlCompleteCustom.Show();
            lblcmsTotal.Text = "Total payable: R" + newtotalCost.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCompletecmsSale_Click(object sender, EventArgs e)
        {
            
            if (cmbPaymentcms.SelectedIndex == 0)
            {
                paymentMethod = "Cash";
            }
            if (cmbPaymentcms.SelectedIndex == 1)
            {
                paymentMethod = "Credit";
            }
            if (cmbPaymentcms.SelectedIndex == 2)
            {
                paymentMethod = "Debit";
            }
            if (cmbPaymentcms.SelectedIndex == 3)
            {
                paymentMethod = "Tjek";
            }

            totalPaid = Convert.ToInt32(txtTotalcmsPaid.Text);
            for (int i = 0; i < product.Count(); i++)
            {
                items = items + totalPerItem[i] + "x" + product[i] + ",";
            }
            for (int i = 0; i < barcodes.Count(); i++)
            {
                itemIDS = itemIDS + barcodes[i] + ",";
            }
            lbxCustomReceipt.Items.Add("=========================");
            lbxCustomReceipt.Items.Add("Total after discount: R" + newtotalCost.ToString());
            lbxCustomReceipt.Items.Add("Promotion: " + promotion);
            lbxCustomReceipt.Items.Add("=========================");
            lbxCustomReceipt.Items.Add(paymentMethod + ": R" + totalPaid.ToString());
            change = totalPaid - newtotalCost;
            lbxCustomReceipt.Items.Add("Change:               R" + change);
            lbxCustomReceipt.Items.Add("Total items: " + totalItems.ToString());
   
            lbxCustomReceipt.Items.Add("=========================");
            lbxCustomReceipt.Items.Add("Thank you for shopping at ");
            lbxCustomReceipt.Items.Add("MATRIX WAREHOUSE!");
            lbxCustomReceipt.Items.Add("=========================");
            lbxCustomReceipt.Items.Add("WARRANTY:");
            lbxCustomReceipt.Items.Add("");
            for (int i = 0; i < productW.Count(); i++)
            {
                lbxCustomReceipt.Items.Add(totalWarrantyP[i] + "x " + productW[i] + ": " + WarrantyP[i]);
            }
            lbxCustomReceipt.Items.Add("");
            lbxCustomReceipt.Items.Add("=========================");
            pnlCompleteCustom.Hide();
            txtCmsID.Enabled = false;
            txtCmsID.Clear();
            btnAddCustom.Enabled = false;
            txtLabour.Enabled = false;
            txtLabour.Clear();
            btnAddLabour.Enabled = false;
            btnCompletecms.Enabled = false;
            btnCancelCms.Enabled = false;


            pnlCustoms.Show();
            cms = true;

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand(@"INSERT INTO Sales(sale_branch, sale_id, sale_date, items, item_ids, total_cost, total_paid, payment_method, promotion, special_order, cms) VALUES (@sale_branch, @sale_id, @sale_date, @items, @item_ids, @total_cost, @total_paid, @payment_method, @promotion, @special_order, @cms)", con);
            comm.Parameters.AddWithValue("@sale_branch", branch);
            comm.Parameters.AddWithValue("@sale_id", saleid);
            comm.Parameters.AddWithValue("@sale_date", dateTimeSale);
            comm.Parameters.AddWithValue("@items", items);
            comm.Parameters.AddWithValue("@item_ids", itemIDS);
            comm.Parameters.AddWithValue("@total_cost", newtotalCost.ToString());
            comm.Parameters.AddWithValue("@total_paid", totalPaid.ToString());
            comm.Parameters.AddWithValue("@payment_method", paymentMethod);
            comm.Parameters.AddWithValue("@promotion", Promotion);
            comm.Parameters.AddWithValue("@special_order", SpecialOrder);
            comm.Parameters.AddWithValue("@cms", cms);
            comm.ExecuteNonQuery();
            con.Close();
        }

        private void pnlCompleteSale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCompleteCustom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaleSearch_Click(object sender, EventArgs e)
        {

            //DateTimePicker Value
            //dtpSaleDateSearch.Value();
            //SqlConnection conString = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            //SqlCommand createSale = new SqlCommand(@"INSERT INTO Sales VALUES()");
        }

        private void btnNewSale_Click(object sender, EventArgs e)
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
        }

        private void btnNewSalecms_Click(object sender, EventArgs e)
        {
            lbxCustomReceipt.Items.Clear();
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
            labour = 0;
            txtLabour.Clear();
            txtCmsID.Clear();
            txtTotalcmsPaid.Clear();
            btnNewSalecms.Enabled = false;
            btnPrintCms.Enabled = false;
        }

        private void btnCancelCms_Click(object sender, EventArgs e)
        {
            if (barcodes.Count() == 0)
            {
                MessageBox.Show("There is no sale to cancel!");
            }
            else
            {
                lbxCustomReceipt.Items.Clear();
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
                labour = 0;
                int indeks = barcodes.IndexOf(barcodes.Last());
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                con.Open();
                while (indeks != -1)
                {
                    string code = barcodes[indeks];
                    //SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'In Stock' WHERE item_id ='" + code + "'  AND branch = '" + branch + "'", con);
                    SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'In Stock' WHERE item_id ='" + code + "'", con);
                    comm.ExecuteNonQuery();
                    barcodes.Remove(barcodes.Last());
                    indeks = indeks - 1;
                }
                con.Close();
            }
        }


        private void pnlAddSale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddToSale_Click(object sender, EventArgs e)
        {
            itemID = txtProductID_Sale.Text;
            dateTimeSale = (DateTime.Now).ToString();
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
                if (getcheckPromo() == true)
                {
                    Promotion = true;
                    promotion = "Yes";
                    changeQuantityMin(getItemName());
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
                
                //lbxSaleReceipt.Items.Add("Sale No.: " + saleID);
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
            //SqlCommand comm = new SqlCommand(@"SELECT description FROM Stock WHERE item_id = '" + itemID + "' AND branch = '" + branch + "'", con);
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
            //SqlCommand comm = new SqlCommand(@"SELECT retail_price FROM Stock WHERE item_id = '" + itemID + "' AND branch = '" + branch + "'", con);
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
            //SqlCommand comm = new SqlCommand(@"SELECT discount FROM Promotions WHERE item_name = '" + itemName + "' AND branch = '" + branch + "'", con);
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
            int Q;
            bool act;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            //SqlCommand checkPromo = new SqlCommand(@"SELECT active FROM Promotions WHERE item_name = '" + itemName + "' AND branch = '" + branch + "'", con);
            SqlCommand checkPromo = new SqlCommand(@"SELECT active FROM Promotions WHERE item_name = '" + itemName + "'", con);
            //SqlCommand checkQuantity = new SqlCommand(@"SELECT quantity FROM Promotions WHERE item_name = '" + itemName + "'  AND branch = '" + branch + "'", con);
            SqlCommand checkQuantity = new SqlCommand(@"SELECT quantity FROM Promotions WHERE item_name = '" + itemName + "'", con);
            Q = Convert.ToInt16(checkQuantity.ExecuteScalar());
            act = Convert.ToBoolean(checkPromo.ExecuteScalar());
            if(act == true && Q != 0)
            {
                prom = true;
            }
            else
            {
                prom = false;
            }
            con.Close();
        }
        private bool getcheckPromo()
        {
            return prom;
        }
//changeQuantityPLus////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void changeQuantityPlus(string itemName)
        {
            int NewQuantity;
            int Quantity;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            //SqlCommand getQuantity = new SqlCommand(@"SELECT quantity FROM Promotions WHERE item_name = '" + itemName + "'  AND branch = '" + branch + "'", con);
            SqlCommand getQuantity = new SqlCommand(@"SELECT quantity FROM Promotions WHERE item_name = '" + itemName + "'", con);
            Quantity = Convert.ToInt16(getQuantity.ExecuteScalar());
            NewQuantity = Quantity + 1;
            //SqlCommand changePromo = new SqlCommand(@"UPDATE Promotions SET quantity = '" + NewQuantity + "' WHERE item_name = '" + itemName + "' AND branch = '" + branch + "'", con);
            SqlCommand changePromo = new SqlCommand(@"UPDATE Promotions SET quantity = '" + NewQuantity + "' WHERE item_name = '" + itemName + "'", con);
            changePromo.ExecuteNonQuery();
            con.Close();
        }
//changeQuantityMin////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void changeQuantityMin(string itemName)
        {
            int NewQuantity;
            int Quantity;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            //SqlCommand getQuantity = new SqlCommand(@"SELECT quantity FROM Promotions WHERE item_name = '" + itemName + "' AND branch = '" + branch + "'", con);
            SqlCommand getQuantity = new SqlCommand(@"SELECT quantity FROM Promotions WHERE item_name = '" + itemName + "'", con);
            Quantity = Convert.ToInt16(getQuantity.ExecuteScalar());
            NewQuantity = Quantity - 1;
            // SqlCommand changePromo = new SqlCommand(@"UPDATE Promotions SET quantity = '" + NewQuantity + "' WHERE item_name = '" + itemName + "' AND branch = '" + branch + "'", con);
            SqlCommand changePromo = new SqlCommand(@"UPDATE Promotions SET quantity = '" + NewQuantity + "' WHERE item_name = '" + itemName + "'", con);
            changePromo.ExecuteNonQuery();
            con.Close();
        }
        //GET AND SET Warranty////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setWarranty(string itemID)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            //SqlCommand comm = new SqlCommand(@"SELECT warranty FROM Stock WHERE item_id = '" + itemID + "'  AND branch = '" + branch + "'", con);
            SqlCommand comm = new SqlCommand(@"SELECT warranty FROM Stock WHERE item_id = '" + itemID + "'", con);
            warranty = comm.ExecuteScalar().ToString();
            con.Close();
        }
        private string getWarranty()
        {
            return warranty;
        }
        //Generate Sale ID////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int GenerateSaleID()
        {
            int saleID;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            //SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) FROM Sales WHERE branch = '" + branch + "'", con);
            SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) FROM Sales", con);
            if (comm.ExecuteScalar() == null)
            {
                saleID = 0;
            }
            else
            {
                saleID = Convert.ToInt16(comm.ExecuteScalar());
                saleID = saleID + 1;
            }
            con.Close();
            
            return saleID; 
        }

        //Check status of Stock////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkStockStatus(string itemID)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            //SqlCommand comm = new SqlCommand(@"SELECT status FROM Stock WHERE item_id = '" + itemID + "' AND branch = '" + branch + "'", con);
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
            //SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'Sold' WHERE item_id ='" + itemID + "'  AND branch = '" + branch + "'", con);
            SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'Sold' WHERE item_id ='" + itemID + "'", con);
            //SqlCommand comm2 = new SqlCommand(@"UPDATE Stock SET last_updated = '" + dateTimeSale + "' WHERE item_id ='" + itemID + "'  AND branch = '" + branch + "'", con);
            SqlCommand comm2 = new SqlCommand(@"UPDATE Stock SET last_updated = '" + dateTimeSale + "' WHERE item_id ='" + itemID + "'", con);
            comm.ExecuteNonQuery();
            comm2.ExecuteNonQuery();
            con.Close();
        }
    }
}
    

