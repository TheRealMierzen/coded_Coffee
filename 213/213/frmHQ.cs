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
    public partial class frmHQ : Form
    {
        private string user, name, id, itemManufacturer, itemBranch, itemManPrice, itemRePrice, itemType, itemWarranty;     
        private SqlConnection conn;

        public frmHQ()
        {
            InitializeComponent();
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdStr = "Delete from Stock where item_id = @id'";

                using (conn)
                {
                    using (SqlCommand deleteStock = new SqlCommand(cmdStr, conn))
                    {
                        deleteStock.Parameters.AddWithValue("@id", txtItemID.Text);

                        conn.Open();
                        deleteStock.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                gebruik.addAction(user);

            }catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnRemove_Click();
                }
            }

        }

        private void cbmMainAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmMainAction.SelectedItem == "Stock")
            {
                pnlStock.Visible = true;
                pnlStock.BringToFront();
                pnlStockButtons.Visible = true;
                pnlStockButtons.BringToFront();
                pnlOrder.Visible = false;
            }
            else if (cbmMainAction.SelectedItem == "Orders")
            {
                pnlOrder.Visible = true;
                pnlOrder.BringToFront();
                pnlOrdersActions.Visible = true;
                pnlOrdersActions.BringToFront();
                pnlStock.Visible = false;
            }

        }

        private void txtBranch_TextChanged(object sender, EventArgs e)
        {
            if (txtBranch.Text != "" && txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "")
            {
                btnAccept.Enabled = true;
            }
            else
                btnAccept.Enabled = false;
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            if(txtBranch.Text != "" && txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "")
            {
                btnAccept.Enabled = true;
            }
            else
                btnAccept.Enabled = false;
        }

        private void txtManufacturerName_TextChanged(object sender, EventArgs e)
        {
            if (txtBranch.Text != "" && txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "")
            {
                btnAccept.Enabled = true;
            }
            else
                btnAccept.Enabled = false;
        }

        private void txtManufacturerPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtBranch.Text != "" && txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "")
            {
                btnAccept.Enabled = true;
            }
            else
                btnAccept.Enabled = false;
        }

        private void txtRetailPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtBranch.Text != "" && txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "")
            {
                btnAccept.Enabled = true;
            }
            else
                btnAccept.Enabled = false;
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if (txtBranch.Text != "" && txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "")
            {
                btnAccept.Enabled = true;
            }
            else
                btnAccept.Enabled = false;
        }

        private void txtItembranch_TextChanged(object sender, EventArgs e)
        {
            if (txtItembranch.Text != "" && txtName.Text != "" && txtManName.Text != "" && txtManPrice.Text != "" && txtRetail.Text != "" && txtItemType.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            { 
                btnUpdate.Enabled = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtItembranch.Text != "" && txtName.Text != "" && txtManName.Text != "" && txtManPrice.Text != "" && txtRetail.Text != "" && txtItemType.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void txtManName_TextChanged(object sender, EventArgs e)
        {
            if (txtItembranch.Text != "" && txtName.Text != "" && txtManName.Text != "" && txtManPrice.Text != "" && txtRetail.Text != "" && txtItemType.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void txtManPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtItembranch.Text != "" && txtName.Text != "" && txtManName.Text != "" && txtManPrice.Text != "" && txtRetail.Text != "" && txtItemType.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void txtRetail_TextChanged(object sender, EventArgs e)
        {
            if (txtItembranch.Text != "" && txtName.Text != "" && txtManName.Text != "" && txtManPrice.Text != "" && txtRetail.Text != "" && txtItemType.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            pnlAddStock.Visible = false;
            pnlRevise.Visible = false;
            pnlTransfer.Visible = true;
            pnlTransfer.BringToFront();
            btnStockTransfer.Enabled = false;
        }

        private void btnStockTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                string fBranch, tBranch, itemIDs, cmdStr;
                int temp;

                fBranch = txtFrom.Text;
                tBranch = txtTo.Text;
                itemIDs = txtItemIDs.Text;

                using (conn)
                {
                    cmdStr = "Select Count(transfer_id) from Transfers";

                    using (SqlCommand count = new SqlCommand(cmdStr, conn))
                    {
                        conn.Open();
                        temp = Convert.ToInt32(count.ExecuteScalar());
                        conn.Close();
                    }

                    cmdStr = "Insert into Transfers Values(@id, @fBranch, @tBranch, @itemIDs, @sendDate, @eta)";

                    using (SqlCommand addTransfer = new SqlCommand(cmdStr, conn))
                    {
                        addTransfer.Parameters.AddWithValue("@id", Convert.ToString(temp + 1));
                        addTransfer.Parameters.AddWithValue("@fBranch", fBranch);
                        addTransfer.Parameters.AddWithValue("@tBranch", tBranch);
                        addTransfer.Parameters.AddWithValue("@itemIDs", txtItemIDs);
                        addTransfer.Parameters.AddWithValue("@sendDate", DateTime.Today);
                        addTransfer.Parameters.AddWithValue("@eta", DateTime.Today.AddDays(3));

                        conn.Open();
                        addTransfer.ExecuteNonQuery();
                        conn.Close();
                    }

                    while (itemIDs != "")
                    {
                        int pos = itemIDs.IndexOf(",");
                        string tempID = itemIDs.Substring(1, pos - 1);
                        itemIDs.Remove(0, pos);

                        cmdStr = "Update Stock set status = 'In Transit' where item_id = @id";

                        using (SqlCommand updateTransfers = new SqlCommand(cmdStr, conn)) 
                        {
                            updateTransfers.Parameters.AddWithValue("@id", tempID);

                            conn.Open();
                            updateTransfers.ExecuteNonQuery();
                            conn.Close();
                        }
                    }

                    gebruik.addAction(user);
                }
            }
            catch (SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnStockTransfer_Click();
                }
            }

        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            if (txtFrom.Text != "" && txtTo.Text != "" && txtItemIDs.Text != "")
            {
                btnStockTransfer.Enabled = true;
            }
            else
                btnStockTransfer.Enabled = false;
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            pnlAddOrders.Visible = true;
            pnlAddOrders.BringToFront();
            pnlUpdateOrders.Visible = false;
            btnAddOrder.Enabled = false;
            txtCustomerEmail.Enabled = false;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            { 
                string branch, supplier, items, cost, email, cmdStr;
                int invoice, special, temp;

                branch = txtBranchO.Text;
                supplier = txtSuppliers.Text;
                items = txtItemsO.Text;
                cost = txtTotalCost.Text;
                email = txtCustomerEmail.Text;

                if (cbxInvoice.Checked)
                    invoice = 1;
                else
                    invoice = 0;

                if (cbxSpecial.Checked)
                {
                    special = 1;
                }
                else
                    special = 0;

                using (conn)
                {
                    cmdStr = "Select Count(order_id) from Orders";

                    using (SqlCommand count = new SqlCommand(cmdStr, conn))
                    {
                        conn.Open();              
                        temp = Convert.ToInt32(count.ExecuteScalar());
                        conn.Close();
                    }

                    cmdStr = "Insert into Orders Values(@branch, @id, @supplier, @items, @cost, @invoice, @recieved, @orderDate, @eta, @recievedDate, @special, @email)";

                    using (SqlCommand addOrders = new SqlCommand(cmdStr, conn))
                    {
                        addOrders.Parameters.AddWithValue("@branch",branch);
                        addOrders.Parameters.AddWithValue("@id", Convert.ToString(temp + 1));
                        addOrders.Parameters.AddWithValue("@supplier", supplier);
                        addOrders.Parameters.AddWithValue("@items", items);
                        addOrders.Parameters.AddWithValue("@cost", cost);
                        addOrders.Parameters.AddWithValue("@invoice", invoice);
                        addOrders.Parameters.AddWithValue("@recieved", "0");
                        addOrders.Parameters.AddWithValue("@orderDate", DateTime.Today);
                        addOrders.Parameters.AddWithValue("@eta", DateTime.Today.AddDays(3));
                        addOrders.Parameters.AddWithValue("@recievedDate", DateTime.Today.AddDays(3));
                        addOrders.Parameters.AddWithValue("@special", special);
                        addOrders.Parameters.AddWithValue("@email", email);

                        conn.Open();
                        addOrders.ExecuteNonQuery();
                        conn.Close();

                    }

                    gebruik.addAction(user);
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnAddOrder_Click();
                }
            }


        }

        private void btnUpdateOrders_Click(object sender, EventArgs e)
        {
            pnlUpdateOrders.Visible = true;
            pnlUpdateOrders.BringToFront();
            pnlAddOrders.Visible = false;
            btnUpdateOrder.Enabled = false;
            txtEmailUp.Enabled = false;
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, supplier, items, cost, email, id, cmdStr;
                int invoice, special, recieved;
                DateTime recievedDate = DateTime.Today.AddDays(3);

                id = txtOrderID.Text;
                branch = txtBranchO.Text;
                supplier = txtSupplierUp.Text;
                items = txtItemsUp.Text;
                cost = txtCostUp.Text;
                email = txtEmailUp.Text;

                if (cbxInvoiceUp.Checked)
                    invoice = 1;
                else
                    invoice = 0;

                if (cbxSpecialUp.Checked)
                {
                    special = 1;
                    txtCustomerEmail.Enabled = true;
                    txtCustomerEmail.Focus();
                }
                else
                    special = 0;

                if (cbxRecievedUp.Checked)
                {
                    recieved = 1;
                    recievedDate = DateTime.Today; 
                }
                else
                    recieved = 0;

                using (conn)
                {

                    cmdStr = "Update Orders set branch = @branch, order_supplier = @supplier, order_items = @items, total_cost = @cost, invoice_sent = @invoice, recieved = @recieved, recieved_date = @recievedDate, special_order = @special, cust_email = @email where order_id = @id";

                    using (SqlCommand updateOrder = new SqlCommand(cmdStr, conn))
                    {
                        updateOrder.Parameters.AddWithValue("@branch", branch);
                        updateOrder.Parameters.AddWithValue("@id", id);
                        updateOrder.Parameters.AddWithValue("@supplier", supplier);
                        updateOrder.Parameters.AddWithValue("@items", items);
                        updateOrder.Parameters.AddWithValue("@cost", cost);
                        updateOrder.Parameters.AddWithValue("@invoice", invoice);
                        updateOrder.Parameters.AddWithValue("@recieved", recieved);
                        updateOrder.Parameters.AddWithValue("@recievedDate", recievedDate);
                        updateOrder.Parameters.AddWithValue("@special", special);
                        updateOrder.Parameters.AddWithValue("@email", email);

                        conn.Open();
                        updateOrder.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                
                gebruik.addAction(user);
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnUpdateOrder_Click();
                }
            }

        }

        private void btnRemoveOrders_Click(object sender, EventArgs e)
        {
            frmRemoveOrder remove = new frmRemoveOrder();
            remove.Show();
        }

        private void txtBranchO_TextChanged(object sender, EventArgs e)
        {
            if(txtBranchO.Text != "" && txtItemsO.Text != "" && txtSuppliers.Text != "" && txtTotalCost.Text != "")
            {
                btnAddOrder.Enabled = true;
            }
            else
            {
                btnAddOrder.Enabled = false;
            }
        }

        private void txtItemsO_TextChanged(object sender, EventArgs e)
        {
            if (txtBranchO.Text != "" && txtItemsO.Text != "" && txtSuppliers.Text != "" && txtTotalCost.Text != "")
            {
                btnAddOrder.Enabled = true;
            }
            else
            {
                btnAddOrder.Enabled = false;
            }
        }

        private void txtSuppliers_TextChanged(object sender, EventArgs e)
        {
            if (txtBranchO.Text != "" && txtItemsO.Text != "" && txtSuppliers.Text != "" && txtTotalCost.Text != "")
            {
                btnAddOrder.Enabled = true;
            }
            else
            {
                btnAddOrder.Enabled = false;
            }
        }

        private void txtTotalCost_TextChanged(object sender, EventArgs e)
        {
            if (txtBranchO.Text != "" && txtItemsO.Text != "" && txtSuppliers.Text != "" && txtTotalCost.Text != "")
            {
                btnAddOrder.Enabled = true;
            }
            else
            {
                btnAddOrder.Enabled = false;
            }
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            if(txtBranchUp.Text != "" && txtCostUp.Text != "" && txtOrderID.Text != "" && txtItemsUp.Text != "" && txtSupplierUp.Text != "")
            {
                btnUpdateOrder.Enabled = true;
            }
            else
            {
                btnUpdateOrder.Enabled = false;
            }
        }

        private void txtBranchUp_TextChanged(object sender, EventArgs e)
        {
            if (txtBranchUp.Text != "" && txtCostUp.Text != "" && txtOrderID.Text != "" && txtItemsUp.Text != "" && txtSupplierUp.Text != "")
            {
                btnUpdateOrder.Enabled = true;
            }
            else
            {
                btnUpdateOrder.Enabled = false;
            }
        }

        private void txtItemsUp_TextChanged(object sender, EventArgs e)
        {
            if (txtBranchUp.Text != "" && txtCostUp.Text != "" && txtOrderID.Text != "" && txtItemsUp.Text != "" && txtSupplierUp.Text != "")
            {
                btnUpdateOrder.Enabled = true;
            }
            else
            {
                btnUpdateOrder.Enabled = false;
            }
        }

        private void txtSupplierUp_TextChanged(object sender, EventArgs e)
        {
            if (txtBranchUp.Text != "" && txtCostUp.Text != "" && txtOrderID.Text != "" && txtItemsUp.Text != "" && txtSupplierUp.Text != "")
            {
                btnUpdateOrder.Enabled = true;
            }
            else
            {
                btnUpdateOrder.Enabled = false;
            }
        }

        private void txtCostUp_TextChanged(object sender, EventArgs e)
        {
            if (txtBranchUp.Text != "" && txtCostUp.Text != "" && txtOrderID.Text != "" && txtItemsUp.Text != "" && txtSupplierUp.Text != "")
            {
                btnUpdateOrder.Enabled = true;
            }
            else
            {
                btnUpdateOrder.Enabled = false;
            }
        }

        private void cbxSpecialUp_CheckedChanged(object sender, EventArgs e)
        {
            txtEmailUp.Enabled = true;
            txtEmailUp.Focus();
        }

        private void cbxSpecial_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerEmail.Enabled = true;
            txtCustomerEmail.Focus();
        }

        private void txtItemType_TextChanged(object sender, EventArgs e)
        {
            if (txtItembranch.Text != "" && txtName.Text != "" && txtManName.Text != "" && txtManPrice.Text != "" && txtRetail.Text != "" && txtItemType.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void frmHQ_Load(object sender, EventArgs e)
        {
            string cmdStr;
            int authLevel;
            cbmMainAction.SelectedItem = "Stock";
            conn  = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");

            /*using (conn)
            {
                cmdStr = "Select authLevel from Stock where userName = @user";

                using (SqlCommand getAuthLevel = new SqlCommand(cmdStr, conn))
                {
                    getAuthLevel.Parameters.AddWithValue("@user", user);

                    conn.Open(); 
                    authLevel = Convert.ToInt16(getAuthLevel.ExecuteScalar());
                    conn.Close();
                }
            }


            if(authLevel >= 7)
            {
                pnlStock.Visible = true;
                pnlStockButtons.Visible = true;
                pnlAddStock.Visible = true;
                pnlStockButtons.BringToFront();
                pnlAddStock.BringToFront();
            }
            else
            {
                cbmMainAction.Visible = false;
                pnlOverview.Visible = true;
                pnlOverview.BringToFront();
            }*/

        }

        public frmHQ(string userName)
        {
            InitializeComponent();
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            user = userName;
        }

        public frmHQ(string itemID, string iName, string ibranch, string imanufacturer, string imanPrice, string irePrice, string itype, string iwarranty)
        {
            InitializeComponent();
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            name = iName;
            id = itemID;
            itemBranch = ibranch;
            itemManufacturer = imanufacturer;
            itemManPrice = imanPrice;
            itemRePrice = irePrice;
            itemType = itype;
            itemWarranty = iwarranty;

            if (pnlRevise.Visible)
            {
                txtItemID.Text = id;
                txtItemID.Enabled = false;
                txtName.Text = name;
                txtManName.Text = itemManufacturer;
                txtManPrice.Text = itemManPrice;
                txtRetail.Text = itemRePrice;
                txtItemType.Text = itemType;
                txtItembranch.Text = itemBranch;
                txtWarrant.Text = itemWarranty;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAddStock.Visible = true;
            pnlAddStock.BringToFront();
            pnlRevise.Visible = false;
            btnAccept.Enabled = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, itemName, manufacturer, manPrice, rePrice, type, warranty, cmdStr;
                int temp;

                branch = txtBranch.Text;
                itemName = txtItemName.Text;
                manufacturer = txtManufacturerName.Text;
                manPrice = txtManufacturerPrice.Text;
                rePrice = txtRetailPrice.Text;
                type = txtType.Text;
                warranty = txtWarranty.Text + " Years";

                using (conn)
                {

                    cmdStr = "Select Count(item_id) from Stock";

                    using (SqlCommand count = new SqlCommand(cmdStr, conn))
                    {
                        conn.Open();
                        temp = Convert.ToInt32(count.ExecuteScalar());
                        conn.Close();
                    }

                    cmdStr = "Insert into Stock Values(@branch, @id, @itemName, @manufacturer, @warranty, @updated, @intial, @manPrice, @rePrice, @checked, @status, @type)";

                    using (SqlCommand addStock = new SqlCommand(cmdStr, conn))
                    {
                        addStock.Parameters.AddWithValue("@branch", branch);
                        addStock.Parameters.AddWithValue("@id", Convert.ToString(temp + 1));
                        addStock.Parameters.AddWithValue("@itemName", itemName);
                        addStock.Parameters.AddWithValue("@manufacturer", manufacturer);
                        addStock.Parameters.AddWithValue("@warranty", warranty);
                        addStock.Parameters.AddWithValue("@updated", DateTime.Now);
                        addStock.Parameters.AddWithValue("@initial", DateTime.Today);
                        addStock.Parameters.AddWithValue("@manPrice", manPrice);
                        addStock.Parameters.AddWithValue("@rePrice", rePrice);
                        addStock.Parameters.AddWithValue("@checked", "1");
                        addStock.Parameters.AddWithValue("@status", "In Stock");
                        addStock.Parameters.AddWithValue("@type", type);

                        conn.Open();
                        addStock.ExecuteNonQuery();
                        conn.Close();
                    }
                
                    gebruik.addAction(user);

                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnAccept_Click();
                }
            }

        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            frmHQSearch search = new frmHQSearch();
            search.Show();
            btnUpdate.Enabled = false;
            pnlRevise.Visible = true;
            pnlRevise.BringToFront();
            pnlAddStock.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string cmdStr;

                using (conn)
                {

                    cmdStr = "Update Stock set branch = @branch, item_name = @itemName, manufacturer = @manufacturer, warranty = @warranty, last_updated = @updated, manufacturer_price = @manPrice, retail_price = @rePrice, item_Type = @type where item_id = @id";

                    using (SqlCommand updateStock = new SqlCommand(cmdStr, conn))
                    {
                        updateStock.Parameters.AddWithValue("@branch", txtItembranch.Text);
                        updateStock.Parameters.AddWithValue("@id", txtItemID.Text);
                        updateStock.Parameters.AddWithValue("@itemName", txtName.Text);
                        updateStock.Parameters.AddWithValue("@manufacturer", txtManName.Text);
                        updateStock.Parameters.AddWithValue("@warranty", txtWarrant.Text);
                        updateStock.Parameters.AddWithValue("@updated", DateTime.Now);
                        updateStock.Parameters.AddWithValue("@manPrice", txtManPrice.Text);
                        updateStock.Parameters.AddWithValue("@rePrice", txtRetail.Text);
                        updateStock.Parameters.AddWithValue("@type", txtItemType.Text);

                        conn.Open();
                        updateStock.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                gebruik.addAction(user);
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnUpdate_Click();
                }
            }

        }
    }
}
