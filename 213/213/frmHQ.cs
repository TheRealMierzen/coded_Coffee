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
                using (conn)
                {
                    conn.Open();

                    SqlCommand deleteStock = new SqlCommand("Delete from Stock where item_id ='" + txtItemID.Text + "'", conn);
                    deleteStock.ExecuteNonQuery();

                    conn.Close();
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
                string fBranch, tBranch, itemIDs;

                fBranch = txtFrom.Text;
                tBranch = txtTo.Text;
                itemIDs = txtItemIDs.Text;

                using (conn)
                {
                    conn.Open();
                    SqlCommand count = new SqlCommand("Select Count(transfer_id) from Transfers", conn);
                    int temp = Convert.ToInt32(count.ExecuteScalar());

                    SqlCommand addTransfer = new SqlCommand("Insert into Transfers Values('" + Convert.ToString(temp + 1) + "','" + fBranch + "','" + tBranch + "','" + itemIDs + "','" + DateTime.Today + "','" + DateTime.Today.AddDays(3) + "')", conn);
                    addTransfer.ExecuteNonQuery();

                    while (itemIDs != "")
                    {
                        int pos = itemIDs.IndexOf(",");
                        string tempID = itemIDs.Substring(1, pos - 1);
                        itemIDs.Remove(0, pos);

                        SqlCommand updateTransfers = new SqlCommand("Update Stock set status = 'In Transit' where item_id = '" + tempID + "'", conn);
                        updateTransfers.ExecuteNonQuery();
                    }

                    conn.Close();
                    gebruik.addAction(user);
                }
            }catch(SqlException se)
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
                string branch, supplier, items, cost, email;
                int invoice, special;

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

                conn.Open();

                SqlCommand count = new SqlCommand("Select Count(order_id) from Orders", conn);
                int temp = Convert.ToInt32(count.ExecuteScalar());

                SqlCommand addOrders = new SqlCommand("Insert into Orders Values('" + branch + "','" + Convert.ToString(temp + 1) + "','" + supplier + "','" + items + "','" + cost + "','" + invoice + "','0'," + DateTime.Today + "','" + DateTime.Today.AddDays(3) + "','" + DateTime.Today.AddDays(3) + "','" + special + "','" + email + "')", conn);
                addOrders.ExecuteNonQuery();

                conn.Close();
                gebruik.addAction(user);
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
                string branch, supplier, items, cost, email, id;
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


                conn.Open();

                SqlCommand addOrders = new SqlCommand("Update Orders set branch ='" + branch + "', order_supplier ='" + supplier + "', order_items ='" + items + "', total_cost ='" + cost + "', invoice_sent ='" + invoice + "', recieved ='" + recieved + "', recieved_date ='" + recievedDate + "', special_order ='" + special + "', cust_email ='" + email + "' where order_id ='" + id + "'", conn);
                addOrders.ExecuteNonQuery();

                conn.Close();
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
            cbmMainAction.SelectedItem = "Stock";

            conn  = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");

            /*conn.Open();

            SqlCommand getAuthLevel = new SqlCommand("Select authLevel from Stock where userName = '" + user + "'", conn);
            int authLevel = Convert.ToInt16(getAuthLevel.ExecuteScalar());

            conn.Close();


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
                string branch, itemName, manufacturer, manPrice, rePrice, type, warranty;

                branch = txtBranch.Text;
                itemName = txtItemName.Text;
                manufacturer = txtManufacturerName.Text;
                manPrice = txtManufacturerPrice.Text;
                rePrice = txtRetailPrice.Text;
                type = txtType.Text;
                warranty = txtWarranty.Text + " Years";

                using (conn)
                { 
                    conn.Open();
                    SqlCommand count = new SqlCommand("Select Count(item_id) from Stock", conn);
                    int temp = Convert.ToInt32(count.ExecuteScalar());

                    /*SqlCommand getID = new SqlCommand("Select Max(item_id) from Stock", conn);
                    int tempID = getID.ExecuteNonQuery();*/

                    SqlCommand addStock = new SqlCommand("Insert into Stock Values('" + branch + "','" + Convert.ToString(temp + 1) + "','" + itemName + "','" + manufacturer + "','" + warranty + "','" + DateTime.Now + "','" + DateTime.Today + "','" + manPrice + "','" + rePrice + "','1','" + "In Stock','" + type + "')", conn);
                    addStock.ExecuteNonQuery();
                    conn.Close();

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
                using (conn)
                {
                    conn.Open();

                    SqlCommand updateStock = new SqlCommand("Update Stock set branch ='" + txtItembranch.Text + "', item_name ='"  + txtName.Text + "', manufacturer ='" + txtManName.Text + "', warranty ='" + txtWarrant.Text + "', last_updated ='" + DateTime.Now + "', manufacturer_price ='" + txtManPrice.Text + "', retail_price ='" + txtRetail.Text + "', item_Type ='" + txtItemType.Text + "' where item_id ='" + txtItemID.Text + "'", conn);
                    updateStock.ExecuteNonQuery();

                    conn.Close();
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
