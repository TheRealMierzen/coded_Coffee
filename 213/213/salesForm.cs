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
using iTextSharp.text.pdf;

namespace _213
{
    public partial class salesForm : Form
    {
        private string itemID, items, itemIDS, paymentMethod, itemName, specialorder, promotion, warranty, dateTimeSale, status, saleid, username;
        //private string branch = Properties.Settings.Default.Branch;
        private string branch = "Klerksdorp";
        private string SavePath = AppDomain.CurrentDomain.BaseDirectory;
        private double itemCost, newtotalCost;
        private double totalCost, totalPaid, change, discount, discountTot, labour;
        private int totalItems;
        private bool Promotion, SpecialOrder, prom, cms;
        Form1 klas = new Form1();
        private gebruik util = new gebruik();

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
            username = klas.user;
            // SqlConnection conString = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            // SqlCommand createSale = new SqlCommand();
            if (cmbSalesMenu.SelectedIndex == 0)
            {
                promotion = "No";
                Promotion = false;
                pnlAddSale.Show();
                pnlPrevSaleCancel.Hide();
                pnlCompleteSale.Hide();
                pnlCustoms.Hide();
                pnlReturns.Hide();
                lbxSaleReceipt.Items.Clear();
                txtProductID_Sale.Clear();
                txtCmsID.Clear();
                txtLabour.Clear();
                product.Clear();
                totalPerItem.Clear();
                price.Clear();
                productW.Clear();
                totalWarrantyP.Clear();
                discountTotal.Clear();
                WarrantyP.Clear();
                discount = 0; discountTot = 0; discountTotal.Clear(); labour = 0; itemID = ""; items = ""; itemIDS = "";
                paymentMethod = ""; itemName = ""; specialorder = ""; promotion = ""; warranty = ""; dateTimeSale = "";
                status = ""; saleid = ""; username = ""; itemCost = 0; newtotalCost = 0; totalCost = 0; totalPaid = 0;
                change = 0; discount = 0; discountTot = 0; labour = 0; totalItems = 0;
                Promotion = false; SpecialOrder = false; prom = false; cms = false;
                txtProductID_Sale.Enabled = true;
                btnCompleteSale.Enabled = true;
                btnAddToSale.Enabled = true;
                btnRemoveSaleItem.Enabled = true;
                btnCancelSaleBusy.Enabled = true;
                btnNewSale.Enabled = false;
                btnPrintReceipt_Sales.Enabled = false; ;
            }
            if (cmbSalesMenu.SelectedIndex == 1)
            {
                pnlAddSale.Hide();
                pnlPrevSaleCancel.Hide();
                pnlCompleteSale.Hide();
                pnlCustoms.Show();
                pnlReturns.Hide();
                txtCmsID.Enabled = true;
                btnAddCustom.Enabled = true;
                txtLabour.Enabled = false;
                btnAddLabour.Enabled = false;
                btnCancelCms.Enabled = false;
                btnCompletecms.Enabled = false;
                btnNewSalecms.Enabled = false;
                btnPrintCms.Enabled = false;

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
                //dtpSaleDateSearch.MaxDate = DateTime.Now.Date;
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
                txtProductID_Sale.Clear();
                txtCmsID.Clear();
                txtLabour.Clear();
                product.Clear();
                totalPerItem.Clear();
                price.Clear();
                productW.Clear();
                totalWarrantyP.Clear();
                discountTotal.Clear();
                WarrantyP.Clear();
                discount = 0; discountTot = 0; discountTotal.Clear(); labour = 0; itemID = ""; items = ""; itemIDS = "";
                paymentMethod = ""; itemName = ""; specialorder = ""; promotion = ""; warranty = ""; dateTimeSale = "";
                status = ""; saleid = ""; username = ""; itemCost = 0; newtotalCost = 0; totalCost = 0; totalPaid = 0;
                change = 0; discount = 0; discountTot = 0; labour = 0; totalItems = 0;
                Promotion = false; SpecialOrder = false; prom = false; cms = false;
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
            cbxMethodOfPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentcms.DropDownStyle = ComboBoxStyle.DropDownList;
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
                txtProductID_Sale.Clear();
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
            txtProductID_Sale.Clear();
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
                /*int promo, indeksProm;
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                conn.Open();
                //SqlCommand command = new SqlCommand(@"SELECT COUNT(*) FROM Promotions WHERE item_name = '" + description + "' AND branch = '" + branch + "'", con);
                SqlCommand command = new SqlCommand(@"SELECT COUNT(*) FROM Promotions WHERE item_name = '" + description + "'", con);
                promo = Convert.ToInt16(command.ExecuteScalar());
                conn.Close();
                if(promo == 1)
                {
                    indeksProm = discountTotal.IndexOf(discountTotal.Last());
                    discountTotal.Remove(discountTotal[indeksProm]);
                }*/
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
                lbxSaleReceipt.Items.Add("==================================");
                lbxSaleReceipt.Items.Add("MATRIX WAREHOUSE");
                lbxSaleReceipt.Items.Add("Branch: " + branch);
                //lbxSaleReceipt.Items.Add("Sale No.: " + saleID);
                dateTimeSale = (DateTime.Now).ToString();
                lbxSaleReceipt.Items.Add(dateTimeSale);
                lbxSaleReceipt.Items.Add("==================================");
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
                lbxSaleReceipt.Items.Add("==================================");
                lbxSaleReceipt.Items.Add(@"Total (VAT incl): R" + totalCost.ToString());
                if (getcheckPromo() == true)
                {
                    lbxSaleReceipt.Items.Add(@"Discount: R" + discountTot.ToString());
                }
                lbxSaleReceipt.Items.Add("==================================");
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
            if ((txtPaid.Text == "") || (cbxMethodOfPayment.Text == ""))
            {
                MessageBox.Show("Please fil in all fields!");
            }
            else if (Convert.ToInt16(txtPaid.Text) < newtotalCost)
            {
                MessageBox.Show("Ammount paid not enough!");
            }
            else
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
                    paymentMethod = "Cheque";
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
                for (int i = 0; i < product.Count(); i++)
                {
                    items = items + totalPerItem[i] + "x" + product[i] + ",";
                }
                for (int i = 0; i < barcodes.Count(); i++)
                {
                    itemIDS = itemIDS + barcodes[i] + ",";
                }
                lbxSaleReceipt.Items.Add(paymentMethod + ":" + "\t" + "\t" + "\t" + "R" + totalPaid.ToString());
                newtotalCost = totalCost - discountTot;
                change = totalPaid - newtotalCost;
                lbxSaleReceipt.Items.Add("Change:" + "\t" + "\t" + "\t" + "R" + change);
                lbxSaleReceipt.Items.Add("Total items:" + "\t" + "\t" + totalItems.ToString());
                lbxSaleReceipt.Items.Add("==================================");
                lbxSaleReceipt.Items.Add("Special Order:" + "\t" + "\t" + specialorder);
                lbxSaleReceipt.Items.Add("Promotion:" + "\t" + "\t" + promotion);
                lbxSaleReceipt.Items.Add("==================================");
                lbxSaleReceipt.Items.Add("Total after discount:" + "\t" + "R" + newtotalCost.ToString());
                lbxSaleReceipt.Items.Add("==================================");
                lbxSaleReceipt.Items.Add("==================================");
                lbxSaleReceipt.Items.Add("Thank you for shopping at ");
                lbxSaleReceipt.Items.Add("MATRIX WAREHOUSE!");
                lbxSaleReceipt.Items.Add("==================================");
                lbxSaleReceipt.Items.Add("WARRANTY:");
                lbxSaleReceipt.Items.Add("");
                for (int i = 0; i < productW.Count(); i++)
                {
                    lbxSaleReceipt.Items.Add(totalWarrantyP[i] + "x " + productW[i] + ": " + WarrantyP[i]);
                }
                lbxSaleReceipt.Items.Add("");
                lbxSaleReceipt.Items.Add("==================================");
                //lbxSaleReceipt.Items.Add(items);
                // lbxSaleReceipt.Items.Add(itemIDS);

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
                btnPrintReceipt_Sales.Enabled = true;
                //btnPrintReceipt_Sales.Enabled = false;

                AddSale(branch, saleid, dateTimeSale, items, itemIDS, newtotalCost, totalPaid, paymentMethod, Promotion, SpecialOrder, cms);

                //SAVE PDF///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string pdfItems = "";
                string pdfWarranty = "";

                for(int a = 0; a < product.Count(); a++)
                {
                    pdfItems = pdfItems + totalPerItem[a] + " x " + product[a] + " R" + price[a] + "\n";
                }

                for(int b = 0; b < productW.Count(); b++)
                {
                    pdfWarranty = pdfWarranty + totalWarrantyP[b] + " x " + productW[b] + ": " + WarrantyP[b] + "\n";
                }

                string pdfTemplate = @"C:\Users\Clarise Bouwer\Documents\coded_Coffee\213\213\Resources\Sale.pdf";//VERANDER!!
                string newFile = @"C:\Users\Clarise Bouwer\Documents\coded_Coffee\213\213\Resources\" + @"\" + saleid + ".pdf";
                //string salepdfname = "Sale_" + saleid + ".pdf";
                //string newFile = SavePath + @"\Sales\" + salepdfname;
                PdfReader pdfReader = new PdfReader(pdfTemplate);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));

                AcroFields pdfFormFields = pdfStamper.AcroFields;
                // set form pdfFormFields                                
                pdfFormFields.SetField("SaleID", saleid);
                pdfFormFields.SetField("DateTime", branch + " " + dateTimeSale);
                pdfFormFields.SetField("Cashier", username);
                pdfFormFields.SetField("Items", pdfItems);
                pdfFormFields.SetField("Special order", specialorder);
                pdfFormFields.SetField("Promotion", promotion);
                pdfFormFields.SetField("TotalAfterDiscount", newtotalCost.ToString());
                pdfFormFields.SetField("Warranty", pdfWarranty);

                pdfStamper.Close();
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //gebruik.log(DateTime.Now, username, "Sale");
                txtProductID_Sale.Clear();
                txtCmsID.Clear();
                txtLabour.Clear();
                product.Clear();
                totalPerItem.Clear();
                price.Clear();
                productW.Clear();
                totalWarrantyP.Clear();
                discountTotal.Clear();
                WarrantyP.Clear();
                discount = 0; discountTot = 0; discountTotal.Clear(); labour = 0; itemID = ""; items = ""; itemIDS = "";
                paymentMethod = ""; itemName = ""; specialorder = ""; promotion = ""; warranty = ""; dateTimeSale = "";
                status = ""; saleid = ""; username = ""; itemCost = 0; newtotalCost = 0; totalCost = 0; totalPaid = 0;
                change = 0; discount = 0; discountTot = 0; labour = 0; totalItems = 0;
                Promotion = false; SpecialOrder = false; prom = false; cms = false;
                btnNewSale.Enabled = true;
                btnPrintReceipt_Sales.Enabled = true;
            }


        }
        private void AddSale(string branch, string saleid, string dateTimeSale, string items, string itemIDS, double newtotalCost, double totalPaid, string paymentMethod, bool Promotion, bool SpecialOrder, bool cms)
        {
            //try
            //{
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
            //}

            /*catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if(other.CheckConnection())
                    {
                        AddSale(branch, saleid, dateTimeSale, items, itemIDS, newtotalCost, totalPaid, paymentMethod, Promotion, SpecialOrder, cms);
                    }
                }
            }*/
        }

        private void lbxCustomReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAddCustom_Click(object sender, EventArgs e)
        {
            if (txtCmsID.Text == "")
            {
                MessageBox.Show("Fill in the Custom Build ID!");
            }
            else
            {

                dateTimeSale = (DateTime.Now).ToString();
                string cmsID = txtCmsID.Text;
                string itemIDs;
                txtCmsID.Clear();
                
                int plek;
                string resultString;
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                con.Open();
                SqlCommand comm = new SqlCommand(@"SELECT cms_itemIDs FROM cms WHERE cms_id = '" + cmsID + "'", con);
                SqlCommand comm2 = new SqlCommand(@"UPDATE Stock SET status = 'Sold' WHERE item_id ='" + cmsID + "'", con);
                itemIDs = comm.ExecuteScalar().ToString();
                comm2.ExecuteNonQuery();
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
                    checkStockStatus(barcodes[i]);

                    if (getStockSatus() == "Sold" || getStockSatus() != cmsID)
                    {
                        MessageBox.Show("Some items are not in stock for custom build " + cmsID + "!");
                        barcodes.Clear();
                        product.Clear();
                        txtCmsID.Clear();
                        price.Clear();
                        lbxCustomReceipt.Items.Clear();
                        txtProductID_Sale.Clear();
                        txtCmsID.Clear();
                        txtLabour.Clear();
                        product.Clear();
                        totalPerItem.Clear();
                        price.Clear();
                        productW.Clear();
                        totalWarrantyP.Clear();
                        discountTotal.Clear();
                        WarrantyP.Clear();
                        discount = 0; discountTot = 0; discountTotal.Clear(); labour = 0; itemID = ""; items = ""; itemIDS = "";
                        paymentMethod = ""; itemName = ""; specialorder = ""; promotion = ""; warranty = ""; dateTimeSale = "";
                        status = ""; saleid = ""; username = ""; itemCost = 0; newtotalCost = 0; totalCost = 0; totalPaid = 0;
                        change = 0; discount = 0; discountTot = 0; labour = 0; totalItems = 0;
                        Promotion = false; SpecialOrder = false; prom = false; cms = false;
                        txtCmsID.Enabled = true;
                        btnAddCustom.Enabled = true;
                        txtLabour.Enabled = false;
                        btnAddLabour.Enabled = false;
                        btnCancelCms.Enabled = false;
                        btnCompletecms.Enabled = false;
                        btnNewSalecms.Enabled = false;
                        btnPrintCms.Enabled = false;

                    }
                    else
                    {
                        saleid = GenerateSaleID().ToString();
                        lbxCustomReceipt.Items.Add(barcodes[i]);

                        btnAddLabour.Enabled = true;
                        lblLabour.Enabled = true;
                        txtLabour.Enabled = true;
                        txtLabour.Focus();
                        btnAddCustom.Enabled = false;
                        txtCmsID.Enabled = false;

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
                        lbxCustomReceipt.Items.Add("==================================");
                        lbxCustomReceipt.Items.Add("\t" + "MATRIX WAREHOUSE");
                        lbxCustomReceipt.Items.Add("\t" + dateTimeSale);
                        lbxCustomReceipt.Items.Add("Sale No.:" + "\t" + "\t" + "\t" + saleid);
                        lbxCustomReceipt.Items.Add("Custom Sale No.:" + "\t" + "\t" + cmsID);
                        lbxCustomReceipt.Items.Add("Branch:" + "\t" + "\t" + "\t" + branch);
                        lbxCustomReceipt.Items.Add("==================================");
                        lbxCustomReceipt.Items.Add("Cashier:" + "\t" + "\t" + "\t" + "user");
                        lbxCustomReceipt.Items.Add("");
                        for (int b = 0; b < product.Count(); b++)
                        {
                            lbxCustomReceipt.Items.Add(totalPerItem[b].ToString() + "x " + product[b] + " R" + price[b].ToString());
                        }

                        totalCost = price.Sum();
                        totalItems = totalPerItem.Sum();

                    }
                    
                }
                    
            }
            
        }

        private void btnAddLabour_Click(object sender, EventArgs e)
        {
            //barcodes.Clear();
            if (txtLabour.Text == "")
            {
                MessageBox.Show("Please fill in labour cost!");
            }
            else
            {
                labour = Convert.ToDouble(txtLabour.Text);
                discountTot = discountTotal.Sum();
                newtotalCost = totalCost - discountTot + labour;
                lbxCustomReceipt.Items.Add("Labour:" + "\t" + "\t" + "\t" + "R" + labour);
                lbxCustomReceipt.Items.Add("==================================");
                lbxCustomReceipt.Items.Add(@"Total (VAT incl):" + "\t" + "\t" + "R" + newtotalCost.ToString());
                lbxCustomReceipt.Items.Add(@"Discount:" + "\t" + "\t" + "\t" + "R" + discountTot.ToString());
                lbxCustomReceipt.Items.Add("==================================");
                btnCompletecms.Enabled = true;
                //btnPrintCms.Enabled = true;
                btnCancelCms.Enabled = true;
                txtLabour.Enabled = false;
                btnAddLabour.Enabled = false;
            }
            
        }

        private void btnCompletecms_Click(object sender, EventArgs e)
        {
            if (barcodes.Count() == 0)
            {
                MessageBox.Show("No sale to complete!"); 
            }
            else
            {
                pnlCustoms.Hide();
                pnlCompleteCustom.Show();
                lblcmsTotal.Text = "Total payable: R" + newtotalCost.ToString();
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCompletecmsSale_Click(object sender, EventArgs e)
        {
            if((txtTotalcmsPaid.Text == "") || (cmbPaymentcms.Text == ""))
            {
                MessageBox.Show("Please fil in all fields!");
            }
            else if(Convert.ToInt16(txtTotalcmsPaid.Text) < newtotalCost)
            {
                MessageBox.Show("Ammount paid not enough!");
            }
            else
            {
                saleid = GenerateSaleID().ToString();
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
                    paymentMethod = "Cheque";
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
                lbxCustomReceipt.Items.Add("==================================");
                lbxCustomReceipt.Items.Add("Total after discount:" + "\t" + "R" + newtotalCost.ToString());
                lbxCustomReceipt.Items.Add("Promotion:" + "\t" + "\t" + promotion);
                lbxCustomReceipt.Items.Add("==================================");
                lbxCustomReceipt.Items.Add(paymentMethod + ":" + "\t" + "\t" + "\t" + "R" + totalPaid.ToString());
                change = totalPaid - newtotalCost;
                lbxCustomReceipt.Items.Add("Change:" + "\t" + "\t" + "\t" + "R" + change);
                lbxCustomReceipt.Items.Add("Total items:" + "\t" + "\t" + totalItems.ToString());

                lbxCustomReceipt.Items.Add("==================================");
                lbxCustomReceipt.Items.Add("Thank you for shopping at ");
                lbxCustomReceipt.Items.Add("MATRIX WAREHOUSE!");
                lbxCustomReceipt.Items.Add("==================================");
                lbxCustomReceipt.Items.Add("WARRANTY:");
                lbxCustomReceipt.Items.Add("");
                for (int i = 0; i < productW.Count(); i++)
                {
                    lbxCustomReceipt.Items.Add(totalWarrantyP[i] + "x " + productW[i] + ": " + WarrantyP[i]);
                }
                lbxCustomReceipt.Items.Add("");
                lbxCustomReceipt.Items.Add("==================================");
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

                AddSale(branch, saleid, dateTimeSale, items, itemIDS, newtotalCost, totalPaid, paymentMethod, Promotion, SpecialOrder, cms);

                btnNewSalecms.Enabled = true;
                //SAVE PDF///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string pdfItems = "";
                string pdfWarranty = "";

                for (int a = 0; a < product.Count(); a++)
                {
                    pdfItems = pdfItems + totalPerItem[a] + " x " + product[a] + " R" + price[a] + "\n";
                }

                for (int b = 0; b < productW.Count(); b++)
                {
                    pdfWarranty = pdfWarranty + totalWarrantyP[b] + " x " + productW[b] + ": " + WarrantyP[b] + "\n";
                }

                string pdfTemplate = @"C:\Users\Clarise Bouwer\Documents\coded_Coffee\213\213\Resources\Sale.pdf";//VERANDER!!
                string newFile = @"C:\Users\Clarise Bouwer\Documents\coded_Coffee\213\213\Resources\" + @"\" + saleid + ".pdf";
                //string salepdfname = "Sale_" + saleid + ".pdf";
                //string newFile = SavePath + @"\Sales\" + salepdfname;
                PdfReader pdfReader = new PdfReader(pdfTemplate);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));

                AcroFields pdfFormFields = pdfStamper.AcroFields;
                // set form pdfFormFields                                
                pdfFormFields.SetField("SaleID", saleid);
                pdfFormFields.SetField("DateTime", branch + " " + dateTimeSale);
                pdfFormFields.SetField("Cashier", username);
                pdfFormFields.SetField("Items", pdfItems);
                pdfFormFields.SetField("Special order", "No");
                pdfFormFields.SetField("Promotion", promotion);
                pdfFormFields.SetField("TotalAfterDiscount", newtotalCost.ToString());
                pdfFormFields.SetField("Warranty", pdfWarranty);

                pdfStamper.Close();
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //gebruik.log(DateTime.Now, username, "Sale");
            }

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
            txtProductID_Sale.Clear();
            txtCmsID.Clear();
            txtLabour.Clear();
            product.Clear();
            totalPerItem.Clear();
            price.Clear();
            productW.Clear();
            totalWarrantyP.Clear();
            discountTotal.Clear();
            WarrantyP.Clear();
            discount = 0; discountTot = 0; discountTotal.Clear(); labour = 0; itemID = ""; items = ""; itemIDS = "";
            paymentMethod = ""; itemName = ""; specialorder = ""; promotion = ""; warranty = ""; dateTimeSale = "";
            status = ""; saleid = ""; username = ""; itemCost = 0; newtotalCost = 0; totalCost = 0; totalPaid = 0;
            change = 0; discount = 0; discountTot = 0; labour = 0; totalItems = 0;
            Promotion = false; SpecialOrder = false; prom = false; cms = false;
            txtProductID_Sale.Enabled = true;
            btnCompleteSale.Enabled = true;
            btnAddToSale.Enabled = true;
            btnRemoveSaleItem.Enabled = true;
            btnCancelSaleBusy.Enabled = true;
            btnNewSale.Enabled = false;
            btnPrintReceipt_Sales.Enabled = false;

        }

        private void btnNewSalecms_Click(object sender, EventArgs e)
        {
            lbxCustomReceipt.Items.Clear();
            txtProductID_Sale.Clear(); ;
            product.Clear();
            totalPerItem.Clear();
            price.Clear();
            productW.Clear();
            barcodes.Clear();
            totalWarrantyP.Clear();
            discountTotal.Clear();
            WarrantyP.Clear();
            discount = 0;
            discountTot = 0;
            discountTotal.Clear();
            labour = 0;

            txtLabour.Clear();
            txtLabour.Enabled = false;
            btnAddLabour.Enabled = false;

            btnAddCustom.Enabled = true;
            txtCmsID.Enabled = true;
            txtCmsID.Clear();
            txtTotalcmsPaid.Clear();

            btnNewSalecms.Enabled = false;
            btnPrintCms.Enabled = false;

            btnCompletecms.Enabled = false;
            btnCancelSale.Enabled = false;


        }

        private void btnCancelCms_Click(object sender, EventArgs e)
        {
                lbxCustomReceipt.Items.Clear();
                txtProductID_Sale.Clear();
                txtCmsID.Clear();
                txtLabour.Clear();
                product.Clear();
                totalPerItem.Clear();
                price.Clear();
                productW.Clear();
                totalWarrantyP.Clear();
                discountTotal.Clear();
                WarrantyP.Clear();
                discount = 0; discountTot = 0; discountTotal.Clear();labour = 0; itemID = ""; items = ""; itemIDS = "";
                paymentMethod = ""; itemName = ""; specialorder = ""; promotion = "";  warranty = ""; dateTimeSale = "";
                status = "";  saleid = ""; username = "";  itemCost = 0;  newtotalCost = 0;  totalCost = 0;  totalPaid = 0;
                change = 0; discount = 0; discountTot = 0; labour = 0; totalItems = 0;
                Promotion = false;  SpecialOrder = false; prom = false; cms = false;
                txtCmsID.Enabled = true;
                btnAddCustom.Enabled = true;
                txtLabour.Enabled = false;
                btnAddLabour.Enabled = false;
                btnCancelCms.Enabled = false;
                btnCompletecms.Enabled = false;
                btnNewSalecms.Enabled = false;
                btnPrintCms.Enabled = false;

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


        private void pnlAddSale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTotalcmsPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPaid_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dtpSaleDateSearch_ValueChanged(object sender, EventArgs e)
        {
           // dtpSaleDateSearch.MaxDate = DateTime.Now.Date;
        }

        private void btnReturnAdd_Click(object sender, EventArgs e)
        {
            itemID = txtProductReturn.Text;
            ReturnAdd(itemID, dateTimeSale);    
        }

        private void ReturnAdd(string itemID, string dateTimeSale)
        {
            //try
            //{
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            //SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'Returned' WHERE item_id ='" + itemID + "'  AND branch = '" + branch + "'", con);
            SqlCommand comm = new SqlCommand(@"UPDATE Stock SET status = 'Returned' WHERE item_id ='" + itemID + "'", con);
            //SqlCommand comm2 = new SqlCommand(@"UPDATE Stock SET last_updated = '" + dateTimeSale + "' WHERE item_id ='" + itemID + "'  AND branch = '" + branch + "'", con);
            SqlCommand comm2 = new SqlCommand(@"UPDATE Stock SET last_updated = '" + dateTimeSale + "' WHERE item_id ='" + itemID + "'", con);

            SqlCommand comm3 = new SqlCommand(@"SELECT description FROM Stock WHERE item_id = '" + itemID + "'", con);
            comm.ExecuteNonQuery();
            comm2.ExecuteNonQuery();

            con.Close();
            //}
            /*catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if(other.CheckConnection())
                    {
                        setWarranty(itemID);
                    }
                }
            }*/
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPaymentcms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefund_Click_1(object sender, EventArgs e)
        {
            int returnID;
            string saleID = txtSaleReturn.Text;
            string productID = txtProductReturn.Text;
            string date = DateTime.Now.ToString();

            if ((txtProductReturn.Text == "") || (txtSaleReturn.Text == ""))
            {
                MessageBox.Show("Fill in all fields!");
            }
            else
            {
                txtProductReturn.Clear();
                txtSaleReturn.Clear();
                //GenerateReturnID///////////////////////////////////////////////////////////////////////////////////////////////////////////////
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                con.Open();
                //SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) FROM Sales WHERE branch = '" + branch + "'", con);
                SqlCommand comm = new SqlCommand(@"SELECT COUNT(*) FROM Returns", con);
                if (comm.ExecuteScalar() == null)
                {
                    returnID = 0;
                }
                else
                {
                    returnID = Convert.ToInt16(comm.ExecuteScalar());
                    returnID = returnID + 1;
                }
                con.Close();
                //GetDescription///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string description;
                setItemName(productID);
                description = getItemName();

                //GetCash////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                double cash;
                setItemPrice(productID);
                cash = getItemPrice();
                //Test Sale//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string IDS, result;
                int indeks;

                SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                con.Open();
                SqlCommand getIDS = new SqlCommand(@"SELECT item_ids FROM Sales WHERE sale_id = '" + saleID + "'", con);
                if (getIDS.ExecuteScalar() == null)
                {
                    MessageBox.Show("There is no such existing sale no: " + saleID);
                    IDS = "";
                }
                else
                {
                    IDS = getIDS.ExecuteScalar().ToString();
                }
                
                connect.Close();

                while (IDS != "")
                {
                    indeks = IDS.IndexOf(",");
                    result = IDS.Substring(0, indeks);
                    IDS = IDS.Remove(0, indeks + 1);
                    barcodes.Add(result);
                }

                if (barcodes.Contains(productID) == true)
                {
                    //Add to database////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    
                    AddReturn(branch, returnID.ToString(), saleID, productID, description, date, cash);
                    //Confirm////////////////
                    MessageBox.Show("Return Accepted!" + "\n" + "Give cash: R" + cash.ToString());
                    //gebruik.log(DateTime.Now, username, "Return");
                    txtSaleReturn.Clear();
                    txtProductReturn.Clear();
                }
                else
                {
                    MessageBox.Show("Sale does not contain product!");
                }
            }


        }
        private void AddReturn(string branch, string return_id, string sale_id, string item_id, string description, string return_date, double cash_return)
        {
            //try
            //{
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                conn.Open();
                SqlCommand Add = new SqlCommand(@"INSERT INTO Returns(branch, return_id, sale_id, item_id, description, return_date, cash_return) VALUES (@branch, @return_id, @sale_id, @item_id, @description, @return_date, @cash_return)", conn);
                Add.Parameters.AddWithValue("@branch", branch);
                Add.Parameters.AddWithValue("@return_id", return_id);
                Add.Parameters.AddWithValue("@sale_id", sale_id);
                Add.Parameters.AddWithValue("@item_id", item_id);
                Add.Parameters.AddWithValue("@description", description);
                Add.Parameters.AddWithValue("@return_date", return_date);
                Add.Parameters.AddWithValue("@cash_return", cash_return);
                Add.ExecuteNonQuery();
                conn.Close();
            //}
            /*catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                    {
                        AddReturn( branch,  return_id,  sale_id,  item_id,  description, return_date,  cash_return);
                    }
                }
            }*/

        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            saleid = txtSaleSearch.Text;
            string filepath = @"C:\Users\Clarise Bouwer\Documents\coded_Coffee\213\213\Resources\" + @"\" + saleid + ".pdf";//VERANDER
            if (File.Exists(filepath) == true)
            {
                //Maak pdf oop en display in component..
                MessageBox.Show("Found file!");
            }
            else
            {
                MessageBox.Show("Could not find file!");
            }
        }

        private void cbxMethodOfPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPaymentcms_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cmbPaymentcms_KeyDown(object sender, KeyEventArgs e)
        {
            cmbPaymentcms.Text = "";
        }

        private void txtProductReturn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelcmsSale_Click(object sender, EventArgs e)
        {
            pnlCustoms.Show();
            pnlCompleteCustom.Hide();
            //pnlPrevSaleCancel.Hide();
            txtTotalcmsPaid.Clear();
            cmbPaymentcms.ResetText();
            txtTotalcmsPaid.Clear();
            cmbPaymentcms.ResetText();
        }

        //private void txtLabour_KeyPress_1(object sender, KeyPressEventArgs e)
        //{

        //}

        private void txtLabour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAddToSale_Click(object sender, EventArgs e)
        {
            if(txtProductID_Sale.Text == "")
            {
                MessageBox.Show("Please fill in the barcode!");
            }
            else
            {
                itemID = txtProductID_Sale.Text;
                dateTimeSale = (DateTime.Now).ToString();
                checkStockStatus(itemID);
                txtProductID_Sale.Clear();
                if (getStockSatus() != "In Stock")
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

                    lbxSaleReceipt.Items.Clear();
                    lbxSaleReceipt.Items.Add("==================================");
                    lbxSaleReceipt.Items.Add("\t" + "MATRIX WAREHOUSE");
                    //lbxSaleReceipt.Items.Add("Sale No.: " + saleID);
                    lbxSaleReceipt.Items.Add("\t" + dateTimeSale);
                    lbxSaleReceipt.Items.Add("Branch:" + "\t" + "\t" + "\t" + branch);
                    lbxSaleReceipt.Items.Add("==================================");
                    lbxSaleReceipt.Items.Add("Cashier:" + "\t" + "\t" + "\t" + username);
                    lbxSaleReceipt.Items.Add("");
                    for (int i = 0; i < product.Count(); i++)
                    {
                        lbxSaleReceipt.Items.Add(totalPerItem[i].ToString() + "x " + product[i] + "R" + price[i].ToString());
                    }
                    totalCost = price.Sum();
                    totalItems = totalPerItem.Sum();
                    discountTot = discountTotal.Sum();
                    newtotalCost = totalCost - discountTot;
                    lbxSaleReceipt.Items.Add("==================================");
                    lbxSaleReceipt.Items.Add(@"Total (VAT incl):" + "\t" + "\t" + "R" + totalCost.ToString());
                    lbxSaleReceipt.Items.Add(@"Discount:" + "\t" + "\t" + "\t" + "R" + discountTot.ToString());
                    lbxSaleReceipt.Items.Add("==================================");
                }
            }
        }

        //GET AND SET ITEMNAME////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setItemName(string itemID)
        {
            //try
            //{
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                con.Open();
                //SqlCommand comm = new SqlCommand(@"SELECT description FROM Stock WHERE item_id = '" + itemID + "' AND branch = '" + branch + "'", con);
                SqlCommand comm = new SqlCommand(@"SELECT description FROM Stock WHERE item_id = '" + itemID + "'", con);
                itemName = comm.ExecuteScalar().ToString();
                con.Close();
            //}
            /*catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if(other.CheckConnection())
                    {
                        setItemName(itemID);
                    }
                }
            }*/
        }

        private string getItemName()
        {
            return itemName;
        }
        //GET AND SET ITEMPRICE////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setItemPrice(string itemID)
        {
            //try
            //{
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                con.Open();
                //SqlCommand comm = new SqlCommand(@"SELECT retail_price FROM Stock WHERE item_id = '" + itemID + "' AND branch = '" + branch + "'", con);
                SqlCommand comm = new SqlCommand(@"SELECT retail_price FROM Stock WHERE item_id = '" + itemID + "'", con);
                itemCost = Convert.ToDouble(comm.ExecuteScalar());
                con.Close();
            //}
            /*catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if(other.CheckConnection())
                    {
                        setItemPrice(itemID);
                    }
                }
            }*/
        }

        private double getItemPrice()
        {
            return itemCost;
        }
        //GET AND SET Promotion////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setPromotion(string itemName)
        {
            //try
            //{
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
                con.Open();
                //SqlCommand comm = new SqlCommand(@"SELECT discount FROM Promotions WHERE item_name = '" + itemName + "' AND branch = '" + branch + "'", con);
                SqlCommand comm = new SqlCommand(@"SELECT discount FROM Promotions WHERE item_name = '" + itemName + "'", con);
                discount = Convert.ToDouble(comm.ExecuteScalar());
                con.Close();
            //}
            /*catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if(other.CheckConnection())
                    {
                        checkPromo(itemName);
                    }
                }
            }*/
        }
        private double getPromotion()
        {
            return discount;
        }
        //checkPromo////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkPromo(string itemName)
        {
            //try
            //{
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
                if (act == true && Q != 0)
                {
                    prom = true;
                }
                else
                {
                    prom = false;
                }
                con.Close();
            //}
            /*catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if(other.CheckConnection())
                    {
                        checkPromo(itemName);
                    }
                }
            }*/
        }
        private bool getcheckPromo()
        {
            return prom;
        }
//changeQuantityPLus////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void changeQuantityPlus(string itemName)
        {

            //try
            //{
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
            //}
            /*catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if(other.CheckConnection())
                    {
                        changeQuantityPlus(itemName);
                    }
                }
            }*/
        }
        //changeQuantityMin////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void changeQuantityMin(string itemName)
        {
            //try
            //{
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
            //}
            /*catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if(other.CheckConnection())
                    {
                        changeQuantityMin(itemName);
                    }
                }
            }*/
            
        }
        //GET AND SET Warranty////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void setWarranty(string itemID)
        {

            //try
            //{
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            //SqlCommand comm = new SqlCommand(@"SELECT warranty FROM Stock WHERE item_id = '" + itemID + "'  AND branch = '" + branch + "'", con);
            SqlCommand comm = new SqlCommand(@"SELECT warranty FROM Stock WHERE item_id = '" + itemID + "'", con);
            warranty = comm.ExecuteScalar().ToString();
            con.Close();
            //}
            /*catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if(other.CheckConnection())
                    {
                        setWarranty(itemID);
                    }
                }
            }*/
        }
        private string getWarranty()
        {
            return warranty;
        }
        //Generate Sale ID////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int GenerateSaleID()
        {
            //try
            //{
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
            //}
            /*catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if(other.CheckConnection())
                    {
                        GenerateSaleID();
                    }
                }
            }*/
        }

        //Check status of Stock////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkStockStatus(string itemID)
        {

            //try
            //{
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            con.Open();
            //SqlCommand comm = new SqlCommand(@"SELECT status FROM Stock WHERE item_id = '" + itemID + "' AND branch = '" + branch + "'", con);
            SqlCommand comm = new SqlCommand(@"SELECT status FROM Stock WHERE item_id = '" + itemID + "'", con);
            status = Convert.ToString(comm.ExecuteScalar());
            con.Close();
            //}
            /*catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if(other.CheckConnection())
                    {
                        setWarranty(itemID);
                    }
                }
            }*/


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
        public void testEmptyText(string textbox)
        {
            if(textbox == "")
            {
                MessageBox.Show("Please fill in all fields!");
            }
        }
    }
}
    

