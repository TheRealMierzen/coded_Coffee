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
        private string addString = "";
        private int count;

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
                string cmdStr = "Delete from Stock where item_id = @id";

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    using (SqlCommand deleteStock = new SqlCommand(cmdStr, conn))
                    {
                        deleteStock.Parameters.AddWithValue("@id", txtItemID.Text);

                        conn.Open();
                        count = 0;
                        deleteStock.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("The stock has been removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtItemID.Clear();
                        txtName.Clear();
                        txtManName.Clear();
                        txtManPrice.Clear();
                        txtRetail.Clear();
                        txtItemType.Clear();
                        txtWarrant.Clear();
                    }
                }

                gebruik.addAction(user);

            }
            catch (SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnRemove.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Error connecting to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbmMainAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmMainAction.SelectedItem.ToString() == "Stock")
            {
                pnlStock.Visible = true;
                pnlStock.BringToFront();
                pnlStockButtons.Visible = true;
                pnlStockButtons.BringToFront();
                pnlOrder.Visible = false;
                pnlOrder.SendToBack();
                pnlOverview.Visible = false;
                pnlOverview.SendToBack();
            }
            else if (cbmMainAction.SelectedItem.ToString() == "Orders")
            {
                pnlOrder.Visible = true;
                pnlOrder.BringToFront();
                pnlOrdersActions.Visible = true;
                pnlOrdersActions.BringToFront();
                pnlStock.Visible = false;
                pnlStock.SendToBack();
                pnlOverview.Visible = false;
                pnlOverview.SendToBack();
            }
            else if (cbmMainAction.SelectedItem.ToString() == "Overview")
            {
                pnlOverview.Visible = true;
                pnlOverview.BringToFront();
                pnlOverviewActions.Visible = true;
                pnlOverviewActions.BringToFront();
                pnlStock.Visible = false;
                pnlStock.SendToBack();
                pnlOrder.Visible = false;
                pnlOrder.SendToBack();
            }

        }


        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            if(txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "" && txtWarranty.Text != "")
            {
                btnAccept.Enabled = true;
            }
            else
                btnAccept.Enabled = false;
        }

        private void txtManufacturerName_TextChanged(object sender, EventArgs e)
        {
            if (txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "" && txtWarranty.Text != "")
            {
                btnAccept.Enabled = true;
            }
            else
                btnAccept.Enabled = false;
        }

        private void txtManufacturerPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtManufacturerPrice.MaxLength = 10;

                if (txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "" && txtWarranty.Text != "")
                {
                    if (Convert.ToInt32(txtManufacturerPrice.Text) < 0)
                    {
                        txtManufacturerPrice.ForeColor = Color.Red;
                        btnAccept.Enabled = false;
                    }
                    else
                    {
                        btnAccept.Enabled = true;
                        txtManufacturerPrice.ForeColor = DefaultForeColor;
                    }
                }   
                else
                    btnAccept.Enabled = false;
            }
            catch(OverflowException)
            {
                MessageBox.Show("Invalid value was entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRetailPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtRetailPrice.MaxLength = 10;

                if (txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "" && txtWarranty.Text != "")
                {
                    if (Convert.ToInt32(txtRetailPrice.Text) < 0)
                    {
                        btnAccept.Enabled = false;
                        txtRetailPrice.ForeColor = Color.Red;
                    }
                    else
                    {
                        btnAccept.Enabled = true;
                        txtRetailPrice.ForeColor = DefaultForeColor;
                    }
                }
                else
                    btnAccept.Enabled = false;

            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid value was entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if (txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "" && txtWarranty.Text != "")
            {
                btnAccept.Enabled = true;
            }
            else
                btnAccept.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtManName.Text != "" && txtManPrice.Text != "" && txtRetail.Text != "" && txtItemType.Text != "")
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
            if (txtName.Text != "" && txtManName.Text != "" && txtManPrice.Text != "" && txtRetail.Text != "" && txtItemType.Text != "")
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
            try
            {

                txtManPrice.MaxLength = 10;

                if (txtName.Text != "" && txtManName.Text != "" && txtManPrice.Text != "" && txtRetail.Text != "" && txtItemType.Text != "")
                {
                    if (Convert.ToInt32(txtManPrice.Text) < 0)
                    {
                        btnUpdate.Enabled = false;
                        txtManPrice.ForeColor = Color.Red;
                    }
                    else
                    {
                        btnUpdate.Enabled = true;
                        txtManPrice.ForeColor = DefaultForeColor;
                    }
                }
                else
                {
                    btnUpdate.Enabled = false;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid value was entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRetail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtRetail.MaxLength = 10;

                if (txtName.Text != "" && txtManName.Text != "" && txtManPrice.Text != "" && txtRetail.Text != "" && txtItemType.Text != "")
                {
                    if (Convert.ToInt32(txtRetail.Text) < 0)
                    {
                        btnUpdate.Enabled = false;
                        txtRetail.ForeColor = Color.Red;
                    }
                    else
                    {
                        btnUpdate.Enabled = true;
                        txtRetail.ForeColor = DefaultForeColor;
                    }
                }
                else
                {
                    btnUpdate.Enabled = false;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid value was entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            pnlAddStock.Visible = false;
            pnlRevise.Visible = false;
            pnlTransfer.Visible = true;
            gebruik.fillBranches(cmbTo, cmbFrom);
            pnlTransfer.BringToFront();
        }


        private void comboBox1_SelectedindexChanged(object sender, EventArgs e)
        {

        }

        private void btnStockTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                string fBranch, tBranch, itemIDs, cmdStr;
                int temp;

                fBranch = cmbFrom.SelectedItem.ToString();
                tBranch = cmbTo.SelectedItem.ToString();
                itemIDs = txtItemIDs.Text + ",";

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    cmdStr = "Select Count(transfer_id) from Transfers";

                    using (SqlCommand icount = new SqlCommand(cmdStr, conn))
                    {
                        conn.Open();
                        count = 0;
                        temp = Convert.ToInt32(icount.ExecuteScalar());
                        conn.Close();
                    }

                    cmdStr = "Insert into Transfers Values(@id, @fBranch, @tBranch, @itemIDs, @sendDate, @eta)";

                    using (SqlCommand addTransfer = new SqlCommand(cmdStr, conn))
                    {
                        addTransfer.Parameters.AddWithValue("@id", Convert.ToString(temp + 1));
                        addTransfer.Parameters.AddWithValue("@fBranch", fBranch);
                        addTransfer.Parameters.AddWithValue("@tBranch", tBranch);
                        addTransfer.Parameters.AddWithValue("@itemIDs", txtItemIDs.Text);
                        addTransfer.Parameters.AddWithValue("@sendDate", Convert.ToString(DateTime.Today));
                        addTransfer.Parameters.AddWithValue("@eta", Convert.ToString(DateTime.Today.AddDays(9)));

                        conn.Open();
                        count = 0;
                        addTransfer.ExecuteNonQuery();
                        conn.Close();
                    }

                    while (itemIDs != "")
                    {
                        int pos = itemIDs.IndexOf(",");
                        string tempID = itemIDs.Substring(0, pos);
                        itemIDs = itemIDs.Remove(0, pos + 1);

                        cmdStr = "Update Stock set status = @status where item_id = @id";

                        using (SqlCommand updateTransfers = new SqlCommand(cmdStr, conn))
                        {
                            updateTransfers.Parameters.AddWithValue("@id", tempID);
                            updateTransfers.Parameters.AddWithValue("@status", "In Transit");

                            conn.Open();
                            count = 0;
                            updateTransfers.ExecuteNonQuery();
                            conn.Close();
                        }
                    }

                    MessageBox.Show("The stock has been transfered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItemIDs.Clear();

                    gebruik.addAction(user);
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnStockTransfer.PerformClick();
                    }

                    else
                    {
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Please enter all necessary fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            addString = "";
            pnlAddOrders.Visible = true;
            gebruik.fillBranches(cmbAddOrders);
            pnlAddOrders.BringToFront();
            pnlUpdateOrders.Visible = false;
            btnAddOrder.Enabled = false;
            txtQuantityAdd.Enabled = true;
            txtCustomerEmail.Enabled = false;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string items, quantity;

            items = txtItemsO.Text;
            quantity = txtQuantityAdd.Text;
            addString = addString + quantity + "X" + " " + items + ",";

            txtSuppliers.Clear();
            txtItemsO.Clear();
            txtTotalCost.Clear();
            txtQuantityAdd.Clear();
            txtItemsO.Focus();
        }

        private void btnUpdateOrders_Click(object sender, EventArgs e)
        {
            addString = "";
            pnlUpdateOrders.Visible = true;
            gebruik.fillBranches(cmbOrderUpdate);
            pnlUpdateOrders.BringToFront();
            pnlAddOrders.Visible = false;
            btnUpdateOrder.Enabled = false;
            txtEmailUp.Enabled = false;
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            string items, quantity;

            items = txtItemsUp.Text;
            quantity = txtQuantity.Text;
            addString = addString + quantity + "X" + " " + items + ",";


            txtSupplierUp.Clear();
            txtItemsUp.Clear();
            txtCostUp.Clear();
            txtEmailUp.Clear();
            txtQuantity.Clear();
            txtItemsUp.Focus();
        }

        private void btnRemoveOrders_Click(object sender, EventArgs e)
        {
            frmRemoveOrder remove = new frmRemoveOrder();
            remove.ShowDialog();
        }

        private void txtItemsO_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantityAdd.Text != "" && txtItemsO.Text != "" && txtSuppliers.Text != "" && txtTotalCost.Text != "")
            {
                btnAddOrder.Enabled = true;
                btnFinalizeAdd.Enabled = true;
            }
            else
            {
                btnAddOrder.Enabled = false;
                btnFinalizeAdd.Enabled = false;
            }
        }

        private void txtSuppliers_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantityAdd.Text != "" && txtItemsO.Text != "" && txtSuppliers.Text != "" && txtTotalCost.Text != "")
            {
                btnAddOrder.Enabled = true;
                btnFinalizeAdd.Enabled = true;
            }
            else
            {
                btnAddOrder.Enabled = false;
                btnFinalizeAdd.Enabled = false;
            }
        }

        private void txtTotalCost_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtQuantityAdd.Text != "" && txtItemsO.Text != "" && txtSuppliers.Text != "" && txtTotalCost.Text != "")
                {
                    if (Convert.ToInt32(txtTotalCost.Text) > 0)
                    {
                        btnAddOrder.Enabled = true;
                        btnFinalizeAdd.Enabled = true;
                        txtTotalCost.ForeColor = DefaultForeColor;
                    }
                    else
                    {
                        btnAddOrder.Enabled = false;
                        btnFinalizeAdd.Enabled = false;
                        txtTotalCost.ForeColor = Color.Red;
                    }
                }
                else
                {
                    btnAddOrder.Enabled = false;
                    btnFinalizeAdd.Enabled = false;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid value was entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text != "" && txtCostUp.Text != "" && txtOrderID.Text != "" && txtItemsUp.Text != "" && txtSupplierUp.Text != "")
            {
                btnUpdateOrder.Enabled = true;
                btnFinalizeUp.Enabled = true;
            }
            else
            {
                btnUpdateOrder.Enabled = false;
                btnFinalizeUp.Enabled = false;
            }
        }

        private void txtItemsUp_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && txtCostUp.Text != "" && txtOrderID.Text != "" && txtItemsUp.Text != "" && txtSupplierUp.Text != "")
            {
                btnUpdateOrder.Enabled = true;
                btnFinalizeUp.Enabled = true;
            }
            else
            {
                btnUpdateOrder.Enabled = false;
                btnFinalizeUp.Enabled = false;
            }
        }

        private void txtSupplierUp_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && txtCostUp.Text != "" && txtOrderID.Text != "" && txtItemsUp.Text != "" && txtSupplierUp.Text != "")
            {
                btnUpdateOrder.Enabled = true;
                btnFinalizeUp.Enabled = true;
            }
            else
            {
                btnUpdateOrder.Enabled = false;
                btnFinalizeUp.Enabled = false;
            }
        }

        private void txtCostUp_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtQuantity.Text != "" && txtCostUp.Text != "" && txtOrderID.Text != "" && txtItemsUp.Text != "" && txtSupplierUp.Text != "")
                {
                    if (Convert.ToInt32(txtCostUp.Text) > 0)
                    {
                        btnUpdateOrder.Enabled = true;
                        btnFinalizeUp.Enabled = true;
                        txtCostUp.ForeColor = DefaultForeColor;
                    }
                    else
                    {
                        btnUpdateOrder.Enabled = false;
                        btnFinalizeUp.Enabled = false;
                        txtCostUp.ForeColor = Color.Red;
                    }
                }
                else
                {
                    btnUpdateOrder.Enabled = false;
                    btnFinalizeUp.Enabled = false;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid value was entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxSpecialUp_CheckedChanged(object sender, EventArgs e)
        {
            txtEmailUp.Clear();

            if (cbxSpecialUp.Checked)
            {
                txtEmailUp.Enabled = true;
                txtEmailUp.Focus();
            }
            else
            {
                txtEmailUp.Enabled = false;
            }

        }

        private void cbxSpecial_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerEmail.Clear();

            if (cbxSpecial.Checked)
            {
                txtCustomerEmail.Enabled = true;
                txtCustomerEmail.Focus();
            }
            else
            {
                txtCustomerEmail.Enabled = false;
            }
        }

        private void btnStockOverview_Click(object sender, EventArgs e)
        {
            pnlStockFilter.Visible = true;
            gebruik.fillBranches(cmbBranch);
            cmbBranch.Enabled = false;
            txtTypeFilter.Enabled = false;
            txtManufacturerFilter.Enabled = false;
            txtRePrice.Enabled = false;
            pnlStockFilter.BringToFront();
            pnlOverviewActions.Visible = false;
        }

        private void chbBranch_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBranch.Checked)
                cmbBranch.Enabled = true;
            else
                cmbBranch.Enabled = false;

        }

        private void btnStockBack_Click(object sender, EventArgs e)
        {
            pnlOverviewActions.Visible = true;
            pnlOverviewActions.BringToFront();
            pnlStockFilter.Visible = false;
            chbBranch.Checked = false;
            txtManufacturerFilter.Clear();
            txtRePrice.Clear();
            txtTypeFilter.Clear();
            rdbManufacturer.Checked = false;
            rdbRePrice.Checked = false;
            rdbType.Checked = false;
        }

        private void btnStockFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, manufacturer, rePrice, type, cmdStr;

                if (chbBranch.Checked)
                    branch = cmbBranch.SelectedItem.ToString();
                else
                    branch = "None";


                manufacturer = txtManufacturerFilter.Text;
                rePrice = txtRePrice.Text;
                type = txtTypeFilter.Text;
                dgOverview.Rows.Clear();
                dgOverview.Columns.Clear();

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    conn.Open();
                    count = 0;

                    cmdStr = "Select * from Stock";

                    using (SqlCommand filter = new SqlCommand(cmdStr, conn))
                    {
                        if (chbBranch.Checked && rdbManufacturer.Checked && txtManufacturerFilter.Text != "")
                        {
                            filter.CommandText = "Select * from Stock where branch = @branch and manufacturer = @manufacturer";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@manufacturer", manufacturer);
                        }
                        else if (chbBranch.Checked && rdbRePrice.Checked && txtRePrice.Text != "")
                        {
                            filter.CommandText = "Select * from Stock where branch = @branch and retail_price = @price";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@price", rePrice);
                        }
                        else if (chbBranch.Checked && rdbType.Checked && txtTypeFilter.Text != "")
                        {
                            filter.CommandText = "Select * from Stock where branch = @branch and item_type = @type";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@type", type);
                        }
                        else if (chbBranch.Checked)
                        {
                            filter.CommandText = "Select * from Stock where branch = @branch";
                            filter.Parameters.AddWithValue("@branch", branch);
                        }
                        else if (rdbManufacturer.Checked && txtManufacturerFilter.Text != "")
                        {
                            filter.CommandText = "Select * from Stock where manufacturer = @manufacturer";
                            filter.Parameters.AddWithValue("@manufacturer", manufacturer);
                        }
                        else if (rdbRePrice.Checked && txtRePrice.Text != "")
                        {
                            filter.CommandText = "Select * from Stock where retail_price = @price";
                            filter.Parameters.AddWithValue("@price", rePrice);
                        }
                        else if (rdbType.Checked && txtTypeFilter.Text != "")
                        {
                            filter.CommandText = "Select * from Stock where item_type = @type";
                            filter.Parameters.AddWithValue("@type", type);
                        }


                        using (var reader = filter.ExecuteReader())
                        {
                            dgOverview.Columns.Add("branch", "Branch");
                            dgOverview.Columns.Add("item_id", "Item ID");
                            dgOverview.Columns.Add("item_name", "Item Name");
                            dgOverview.Columns.Add("manufacturer", "Manufacturer");
                            dgOverview.Columns.Add("warranty", "Warranty");
                            dgOverview.Columns.Add("last_updated", "Last Update");
                            dgOverview.Columns.Add("initial_add", "Initial Add");
                            dgOverview.Columns.Add("manufacturer_price", "Manufacturer Price");
                            dgOverview.Columns.Add("retail_price", "Retail Price");
                            dgOverview.Columns.Add("checked", "Checked");
                            dgOverview.Columns.Add("status", "Status");
                            dgOverview.Columns.Add("item_type", "Item Type");

                            while (reader.Read())
                            {
                                

                                dgOverview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), reader.GetDateTime(6), reader.GetString(7), reader.GetString(8), reader.GetBoolean(9), reader.GetString(10), reader.GetString(11));
                               

                            }

                        }

                    }

                    conn.Close();
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnStockFilter.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         


        private void rdbManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            txtManufacturerFilter.Clear();

            if (rdbManufacturer.Checked)
                txtManufacturerFilter.Enabled = true;
            else
                txtManufacturerFilter.Enabled = false;
        }

        private void rdbType_CheckedChanged(object sender, EventArgs e)
        {
            txtTypeFilter.Clear();

            if (rdbType.Checked)
                txtTypeFilter.Enabled = true;
            else
                txtTypeFilter.Enabled = false;
        }

        private void rdbRePrice_CheckedChanged(object sender, EventArgs e)
        {
            txtRePrice.Clear();

            if (rdbRePrice.Checked)
                txtRePrice.Enabled = true;
            else
                txtRePrice.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chbEmployeeBranch_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEmployeeBranch.Checked)
                cmbEmployeeBranch.Enabled = true;
            else
                cmbEmployeeBranch.Enabled = false;
        }

        private void btnEmployeeOverview_Click(object sender, EventArgs e)
        {
            pnlEmployeeOverview.Visible = true;
            gebruik.fillBranches(cmbEmployeeBranch);
            cmbEmployeeBranch.Enabled = false;
            pnlEmployeeOverview.BringToFront();
            pnlOverviewActions.Visible = false;
        }

        private void btnEmployeeBack_Click(object sender, EventArgs e)
        {
            pnlOverviewActions.Visible = true;
            pnlOverviewActions.BringToFront();
            pnlEmployeeOverview.Visible = false;
            chbEmployeeBranch.Checked = false;
            rdbTemp.Checked = false;
            rdbUser.Checked = false;
        }

        private void btnEmployeeFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, cmdStr;

                if (chbEmployeeBranch.Checked)
                    branch = cmbEmployeeBranch.SelectedItem.ToString();
                else
                    branch = "None";


                dgOverview.Rows.Clear();
                dgOverview.Columns.Clear();

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    conn.Open();
                    count = 0;

                    cmdStr = "Select * from Employees";

                    using (SqlCommand filter = new SqlCommand(cmdStr, conn))
                    {
                        if (chbEmployeeBranch.Checked && rdbUser.Checked)
                        {
                            filter.CommandText = "Select * from Employees where branch = @branch and is_user = @user";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@user", "1");
                        }
                        else if (chbEmployeeBranch.Checked && rdbTemp.Checked)
                        {
                            filter.CommandText = "Select * from Employees where branch = @branch and is_temp = @temp";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@temp", "1");
                        }
                        else if (chbBranch.Checked)
                        {
                            filter.CommandText = "Select * from Employees where branch = @branch";
                            filter.Parameters.AddWithValue("@branch", branch);
                        }
                        else if (rdbManufacturer.Checked)
                        {
                            filter.CommandText = "Select * from Employees where is_user = @user";
                            filter.Parameters.AddWithValue("@user", "1");
                        }
                        else if (rdbRePrice.Checked)
                        {
                            filter.CommandText = "Select * from Employees where is_temp = @temp";
                            filter.Parameters.AddWithValue("@temp", "1");
                        }

                        

                        using (var reader = filter.ExecuteReader())
                        {
                            dgOverview.Columns.Add("branch", "Branch");
                            dgOverview.Columns.Add("employee_id", "Employee ID");
                            dgOverview.Columns.Add("name", "Name");
                            dgOverview.Columns.Add("surname", "Surname");
                            dgOverview.Columns.Add("id_num", "ID Number");
                            dgOverview.Columns.Add("email_address", "Email");
                            dgOverview.Columns.Add("cell", "Cellphone Number");
                            dgOverview.Columns.Add("is_user", "System User");
                            dgOverview.Columns.Add("date_appointed", "Date Appointed");
                            dgOverview.Columns.Add("employed_until", "Empoyed Until");
                            dgOverview.Columns.Add("is_temp", "Temporary");

                            while (reader.Read())
                            {


                                dgOverview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetBoolean(7), reader.GetDateTime(8), reader.GetDateTime(9), reader.GetBoolean(10));


                            }

                        }

                        conn.Close();
                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnEmployeeFilter.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("There are no records containing these filter options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void chbOrderBranch_CheckedChanged(object sender, EventArgs e)
        {
            if(chbOrderBranch.Checked)
            {
                cmbOrderBranch.Enabled = true;
            }
            else
            {
                cmbOrderBranch.Enabled = false;
            }
        }

        private void rdbSupplier_CheckedChanged(object sender, EventArgs e)
        {
            txtSupplier.Clear();

            if (rdbSupplier.Checked)
            {
                txtSupplier.Enabled = true;
            }
            else
            {
                txtSupplier.Enabled = false;
            }
        }

        private void btnOrdersOverview_Click(object sender, EventArgs e)
        {
            pnlOrderOverview.Visible = true;
            gebruik.fillBranches(cmbOrderBranch);
            pnlOrderOverview.BringToFront();
            pnlOverviewActions.Visible = false;
            txtSupplier.Enabled = false;
            cmbOrderBranch.Enabled = false;
        }

        private void btnOrderBack_Click(object sender, EventArgs e)
        {
            pnlOverviewActions.Visible = true;
            pnlOverviewActions.BringToFront();
            pnlOrderOverview.Visible = false;
            txtSupplier.Enabled = false;
            rdbSupplier.Checked = false;
            rdbInvoiced.Checked = false;
            rdbRecieved.Checked = false;
            rdbSpecial.Checked = false;
        }



        private void btnOrderFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, supplier, cmdStr;

                if (chbOrderBranch.Checked)
                {
                    branch = cmbOrderBranch.SelectedItem.ToString();
                }
                else
                {
                    branch = "None";
                }

                supplier = txtSupplier.Text;
                dgOverview.Rows.Clear();
                dgOverview.Columns.Clear();

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    conn.Open();
                    count = 0;

                    cmdStr = "Select * from Orders";

                    using (SqlCommand filter = new SqlCommand(cmdStr, conn))
                    {
                        if (chbOrderBranch.Checked && rdbSupplier.Checked && txtSupplier.Text != "")
                        {
                            filter.CommandText = "Select * from Orders where branch = @branch and order_supplier = @supplier";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@supplier", supplier);
                        }
                        else if (chbOrderBranch.Checked && rdbInvoiced.Checked)
                        {
                            filter.CommandText = "Select * from Orders where branch = @branch and invoice_sent = @invoice";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@invoice", "1");
                        }
                        else if (chbOrderBranch.Checked && rdbRecieved.Checked)
                        {
                            filter.CommandText = "Select * from Orders where branch = @branch and received = @received";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@received", "1");
                        }
                        else if (chbOrderBranch.Checked && rdbSpecial.Checked)
                        {
                            filter.CommandText = "Select * from Orders where branch = @branch and special_order = @special";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@special", "1");
                        }
                        else if (chbBranch.Checked)
                        {
                            filter.CommandText = "Select * from Orders where branch = @branch";
                            filter.Parameters.AddWithValue("@branch", branch);
                        }
                        else if (rdbInvoiced.Checked)
                        {
                            filter.CommandText = "Select * from Orders where invoice_sent = @invoice";
                            filter.Parameters.AddWithValue("@invoice", "1");
                        }
                        else if (rdbRecieved.Checked)
                        {
                            filter.CommandText = "Select * from Orders where received = @received";
                            filter.Parameters.AddWithValue("@received", "1");
                        }
                        else if (rdbSpecial.Checked)
                        {
                            filter.CommandText = "Select * from Orders where special_order = @special";
                            filter.Parameters.AddWithValue("@special", "1");
                        }
                        else if(rdbSupplier.Checked && txtSupplier.Text != "")
                        {
                            filter.CommandText = "Select * from Orders where order_supplier = @supplier";
                            filter.Parameters.AddWithValue("@supplier", supplier);
                        }

                        using (var reader = filter.ExecuteReader())
                        {
                            dgOverview.Columns.Add("branch", "Branch");
                            dgOverview.Columns.Add("order_id", "Order ID");
                            dgOverview.Columns.Add("order_supplier", "Supplier Name");
                            dgOverview.Columns.Add("order_items", "Ordered Items");
                            dgOverview.Columns.Add("total_cost", "Total Cost");
                            dgOverview.Columns.Add("invoice_sent", "Invoiced");
                            dgOverview.Columns.Add("received", "Received");
                            dgOverview.Columns.Add("order_date", "Date Ordered");
                            dgOverview.Columns.Add("eta", "E.T.A");
                            dgOverview.Columns.Add("received_Date", "Date Received");
                            dgOverview.Columns.Add("special_order", "Special Order");
                            dgOverview.Columns.Add("cust_email", "Customer Email");

                            while (reader.Read())
                            {


                                dgOverview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5), reader.GetBoolean(6), reader.GetDateTime(7), reader.GetDateTime(8), reader.GetDateTime(9), reader.GetBoolean(10), reader.GetString(11));


                            }

                        }

                        conn.Close();
                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnOrderFilter.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("There are no records containing these filter options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalesOverview_Click(object sender, EventArgs e)
        {
            pnlSalesOverview.Visible = true;
            gebruik.fillBranches(cmbSalesBranch);
            cmbSalesBranch.Enabled = false;
            dtpSalesOverview.MaxDate = DateTime.Today.AddDays(-1);
            dtpSalesOverview.Enabled = false;
            pnlSalesOverview.BringToFront();
            pnlOverviewActions.Visible = false;
        }

        private void chbSalesBranch_CheckedChanged(object sender, EventArgs e)
        {
            if(chbSalesBranch.Checked)
            {
                cmbSalesBranch.Enabled = true;
            }
            else
            {
                cmbSalesBranch.Enabled = false;
            }
        }

        private void btnSalesBack_Click(object sender, EventArgs e)
        {
            pnlOverviewActions.Visible = true;
            pnlOverviewActions.BringToFront();
            pnlSalesOverview.Visible = false;
            chbSalesDate.Checked = false;
            chbSalesBranch.Checked = false;
        }

        private void btnSalesFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, cmdStr;
                DateTime picked;

                if (chbSalesBranch.Checked)
                {
                    branch = cmbSalesBranch.SelectedItem.ToString();
                }
                else
                {
                    branch = "None";
                }

                dtpSalesOverview.MaxDate = DateTime.Today.AddDays(-1);
                picked = dtpSalesOverview.Value;
                branch = cmbSalesBranch.SelectedItem.ToString();
                dgOverview.Rows.Clear();
                dgOverview.Columns.Clear();

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    conn.Open();
                    count = 0;
                    cmdStr = "Select * from Sales";

                    using (SqlCommand filter = new SqlCommand(cmdStr, conn))
                    {
                        if (chbSalesBranch.Checked && chbSalesDate.Checked)
                        {
                            filter.CommandText = "Select * from Sales where branch = @branch and sale_date = @date";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@date", picked);
                        }
                        else if (chbSalesDate.Checked)
                        {
                            filter.CommandText = "Select * from Sales where sale_date = @date";
                            filter.Parameters.AddWithValue("@date", picked);
                        }
                        else if (chbSalesBranch.Checked)
                        {
                            filter.CommandText = "Select * from Sales where branch = @branch";
                            filter.Parameters.AddWithValue("@branch", branch);
                        }

                        using (var reader = filter.ExecuteReader())
                        {
                            dgOverview.Columns.Add("sale_branch", "Branch");
                            dgOverview.Columns.Add("sale_id", "Sale ID");
                            dgOverview.Columns.Add("sale_date", "Sale Date");
                            dgOverview.Columns.Add("items", "Items");
                            dgOverview.Columns.Add("item_ids", "Item ID's");
                            dgOverview.Columns.Add("total_cost", "Amount Due");
                            dgOverview.Columns.Add("total_paid", "Amount Paid");
                            dgOverview.Columns.Add("payment_method", "Payment Method");
                            dgOverview.Columns.Add("promotion", "On Promotion");
                            dgOverview.Columns.Add("special_order", "Special Order");

                            while (reader.Read())
                            {


                                dgOverview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetBoolean(9), reader.GetBoolean(10));


                            }
                        }

                        conn.Close();
                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnOrderFilter.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("There are no records containing these filter options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbSalesDate_CheckedChanged(object sender, EventArgs e)
        {
            if(chbSalesDate.Checked)
            {
                dtpSalesOverview.Enabled = true;
            }
            else
            {
                dtpSalesOverview.Enabled = false;
            }
        }

        private void btnTechnicalOverview_Click(object sender, EventArgs e)
        {
            pnlTechnicalOverview.Visible = true;
            gebruik.fillBranches(cmbTechnicalBranch);
            cmbTechnicalBranch.Enabled = false;
            pnlTechnicalOverview.BringToFront();
            pnlOverviewActions.Visible = false;
        }

        private void chbTechnicalBranch_CheckedChanged(object sender, EventArgs e)
        {
            if(chbTechnicalBranch.Checked)
            {
                cmbTechnicalBranch.Enabled = true;
            }
            else
            {
                cmbTechnicalBranch.Enabled = false;
            }
        }

        private void btnFinalizeUp_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, supplier, items, cost, email, id, cmdStr, quantity;
                int invoice, special, received;
                DateTime receivedDate = DateTime.Today.AddDays(3);

                id = txtOrderID.Text;
                branch = cmbOrderUpdate.SelectedItem.ToString();
                supplier = txtSupplierUp.Text;
                items = txtItemsUp.Text;
                cost = txtCostUp.Text;
                email = txtEmailUp.Text;
                quantity = txtQuantity.Text;
                addString = addString + quantity + "X" + " " + items + ",";

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
                    received = 1;
                    receivedDate = DateTime.Today;
                }
                else
                    received = 0;

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    cmdStr = "Update Orders set branch = @branch, order_supplier = @supplier, order_items = @items, total_cost = @cost, invoice_sent = @invoice, received = @received, received_date = @receivedDate, special_order = @special, cust_email = @email where order_id = @id";

                    using (SqlCommand updateOrder = new SqlCommand(cmdStr, conn))
                    {
                        updateOrder.Parameters.AddWithValue("@branch", branch);
                        updateOrder.Parameters.AddWithValue("@id", id);
                        updateOrder.Parameters.AddWithValue("@supplier", supplier);
                        updateOrder.Parameters.AddWithValue("@items", addString);
                        updateOrder.Parameters.AddWithValue("@cost", cost);
                        updateOrder.Parameters.AddWithValue("@invoice", invoice);
                        updateOrder.Parameters.AddWithValue("@received", received);
                        updateOrder.Parameters.AddWithValue("@receivedDate", receivedDate);
                        updateOrder.Parameters.AddWithValue("@special", special);
                        updateOrder.Parameters.AddWithValue("@email", email);

                        conn.Open();
                        count = 0;
                        updateOrder.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("The order has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtOrderID.Clear();
                        txtSupplierUp.Clear();
                        txtItemsUp.Clear();
                        txtCostUp.Clear();
                        txtEmailUp.Clear();
                        txtQuantity.Clear();
                        cbxInvoiceUp.Checked = false;
                        cbxRecievedUp.Checked = false;
                        cbxSpecialUp.Checked = false;
                        addString = "";
                    }
                }

                gebruik.addAction(user);
            }
            catch (SqlException se)
            {        
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnUpdateOrder.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("There are no records containing these filter options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTechnicalFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, cmdStr;

                if (chbTechnicalBranch.Checked)
                {
                    branch = cmbTechnicalBranch.SelectedItem.ToString();
                }
                else
                {
                    branch = "None";
                }

                
                dgOverview.Rows.Clear();
                dgOverview.Columns.Clear();

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    conn.Open();
                    count = 0;
                    cmdStr = "Select * from cms";

                    using (SqlCommand filter = new SqlCommand(cmdStr, conn))
                    {
                        if (chbTechnicalBranch.Checked && chbCompleted.Checked)
                        {
                            filter.CommandText = "Select * from cms where branch = @branch and completed = @complete";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@complete", "1");
                        }
                        else if (chbSalesDate.Checked)
                        {
                            filter.CommandText = "Select * from cms where completed = @complete";
                            filter.Parameters.AddWithValue("@complete", "1");
                        }
                        else if (chbSalesBranch.Checked)
                        {
                            filter.CommandText = "Select * from Orders where branch = @branch";
                            filter.Parameters.AddWithValue("@branch", branch);
                        }

                        using (var reader = filter.ExecuteReader())
                        {
                            dgOverview.Columns.Add("cms_id", "Cms ID");
                            dgOverview.Columns.Add("cms_items", "Items");
                            dgOverview.Columns.Add("cms_order", "Ordered");
                            dgOverview.Columns.Add("cms_orderid", "Order ID");
                            dgOverview.Columns.Add("cms_email", "Email address");
                            dgOverview.Columns.Add("complete_date", "Date completed");
                            dgOverview.Columns.Add("completed", "Completed");
                            dgOverview.Columns.Add("branch", "Branch");

                            while (reader.Read())
                            {


                                dgOverview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), reader.GetBoolean(6), reader.GetString(7));


                            }
                        }

                        conn.Close();
                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnOrderFilter.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("There are no records containing these filter options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, supplier, items, cost, email, quantity, cmdStr;
                int invoice, special, temp;

                branch = cmbAddOrders.SelectedItem.ToString();
                supplier = txtSuppliers.Text;
                items = txtItemsO.Text;
                cost = txtTotalCost.Text;
                email = txtCustomerEmail.Text;
                quantity = txtQuantityAdd.Text;
                addString = addString + quantity + " X" + " " + items + ",";

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

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    cmdStr = "Select Count(order_id) from Orders";

                    using (SqlCommand icount = new SqlCommand(cmdStr, conn))
                    {
                        conn.Open();
                        count = 0;
                        temp = Convert.ToInt32(icount.ExecuteScalar());
                        conn.Close();
                    }

                    cmdStr = "Insert into Orders Values(@branch, @id, @supplier, @items, @cost, @invoice, @received, @orderDate, @eta, @receivedDate, @special, @email)";

                    using (SqlCommand addOrders = new SqlCommand(cmdStr, conn))
                    {
                        addOrders.Parameters.AddWithValue("@branch", branch);
                        addOrders.Parameters.AddWithValue("@id", Convert.ToString(temp + 1));
                        addOrders.Parameters.AddWithValue("@supplier", supplier);
                        addOrders.Parameters.AddWithValue("@items", addString);
                        addOrders.Parameters.AddWithValue("@cost", cost);
                        addOrders.Parameters.AddWithValue("@invoice", invoice);
                        addOrders.Parameters.AddWithValue("@received", "0");
                        addOrders.Parameters.AddWithValue("@orderDate", DateTime.Today);
                        addOrders.Parameters.AddWithValue("@eta", DateTime.Today.AddDays(3));
                        addOrders.Parameters.AddWithValue("@receivedDate", DateTime.Today.AddDays(3));
                        addOrders.Parameters.AddWithValue("@special", special);
                        addOrders.Parameters.AddWithValue("@email", email);

                        conn.Open();
                        count = 0;
                        addOrders.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("The order has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtSuppliers.Clear();
                        txtItemsO.Clear();
                        txtTotalCost.Clear();
                        txtCustomerEmail.Clear();
                        txtQuantityAdd.Clear();
                        cbxInvoice.Checked = false;
                        cbxSpecial.Checked = false;
                        addString = "";
                    }

                    gebruik.addAction(user);
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnAddOrder.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("There are no records containing this data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMainBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOverviewReport_Click(object sender, EventArgs e)
        {
            pnlReport.Visible = true;
            lblBranch.Visible = false;
            cmbDetailedBranch.Visible = false;
            gebruik.fillBranches(cmbDetailedBranch);
            btnOrderDetail.Visible = false;
            btnSalesDetail.Visible = false;
            btnStockDetail.Visible = false;
            btnTechnicalDetail.Visible = false;
            pnlReport.BringToFront();
            pnlOverviewActions.Visible = false;
            dtpReport.MaxDate = DateTime.Today.AddDays(-1);
        }

        private void btnReportBack_Click(object sender, EventArgs e)
        {
            pnlOverviewActions.Visible = true;
            pnlOverviewActions.BringToFront();
            pnlReport.Visible = false;
            btnDetailed.Visible = true;
            dtpReport.MaxDate = DateTime.Today.AddDays(-1);
            txtOutput.Clear();
        }

        private void btnDetailed_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            btnDetailed.Visible = false;
            lblDate.Visible = true;
            lblBranch.Visible = true;
            cmbDetailedBranch.Visible = true;
            btnOrderDetail.Visible = true;
            btnSalesDetail.Visible = true;
            btnStockDetail.Visible = true;
            btnTechnicalDetail.Visible = true;
            dtpReport.MaxDate = DateTime.Today.AddDays(-1);

            string date, branch, cmdStr;

            date = dtpReport.Value.ToShortDateString() + " 00:00:00";
            int icount = 0;
            branch = cmbDetailedBranch.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    conn.Open();
                    count = 0;
                    cmdStr = "Select Count(*) as temp from Stock where initial_add = @date";

                    using (SqlCommand stockAdd = new SqlCommand(cmdStr, conn))
                    {
                        stockAdd.Parameters.AddWithValue("@date", date);

                        using (var reader = stockAdd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                icount = reader.GetInt32(0);
                            }

                        }

                        txtOutput.AppendText("Stock");
                        txtOutput.AppendText("\r\n=========================================");
                        if (icount == 0)
                        {
                            txtOutput.AppendText("\r\nNo items added for the day: " + dtpReport.Value.ToShortDateString());
                            txtOutput.AppendText("\r\n=========================================");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nItems added for the day: " + dtpReport.Value.ToShortDateString() + "\r\n" + icount);
                            txtOutput.AppendText("\r\n=========================================");
                            icount = 0;
                        }
                    }

                    cmdStr = "Select Count(*) as count from Stock where last_updated = @date and status = @status";

                    using (SqlCommand stockTransfer = new SqlCommand(cmdStr, conn))
                    {
                        stockTransfer.Parameters.AddWithValue("@date", date);
                        stockTransfer.Parameters.AddWithValue("@status", "In Transit");

                        using (var reader = stockTransfer.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                icount = reader.GetInt32(0);
                            }

                        }

                        if (icount == 0)
                        {
                            txtOutput.AppendText("\r\nNo items transfered for the day: " + dtpReport.Value.ToShortDateString());
                            txtOutput.AppendText("\r\n=========================================");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nItems transfered for the day: " + dtpReport.Value.ToShortDateString() + "\r\n" + icount);
                            txtOutput.AppendText("\r\n=========================================");
                            icount = 0;
                        }
                    }


                    cmdStr = "Select Count(*) as count from Stock where last_updated = @date and status = @status";

                    using (SqlCommand stockSold = new SqlCommand(cmdStr, conn))
                    {
                        stockSold.Parameters.AddWithValue("@date", date);
                        stockSold.Parameters.AddWithValue("@status", "Sold");

                        using (var reader = stockSold.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                icount = reader.GetInt32(0);
                            }

                        }

                        if (icount == 0)
                        {
                            txtOutput.AppendText("\r\nNo items sold for the day: " + dtpReport.Value.ToShortDateString());
                            txtOutput.AppendText("\r\n=========================================");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nItems sold for the day: " + dtpReport.Value.ToShortDateString() + "\r\n" + icount);
                            txtOutput.AppendText("\r\n=========================================");
                            icount = 0;
                        }
                    }

                    cmdStr = "Select Count(*) as count from Sales where sale_date = @date";

                    using (SqlCommand numSales = new SqlCommand(cmdStr, conn))
                    {
                        numSales.Parameters.AddWithValue("@date", date);

                        using (var reader = numSales.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                icount = reader.GetInt32(0);
                            }

                        }

                        txtOutput.AppendText("\r\nSales");
                        txtOutput.AppendText("\r\n=========================================");
                        if (icount == 0)
                        {
                            txtOutput.AppendText("\r\nNo sales made for the day: " + dtpReport.Value.ToShortDateString());
                            txtOutput.AppendText("\r\n=========================================");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nSales made for the day: " + dtpReport.Value.ToShortDateString() + "\r\n" + icount);
                            txtOutput.AppendText("\r\n=========================================");
                            icount = 0;
                        }
                    }

                    cmdStr = "Select Count(*) as count from Orders where order_date = @order";

                    using (SqlCommand numOrders = new SqlCommand(cmdStr, conn))
                    {
                        numOrders.Parameters.AddWithValue("@order", date);

                        using (var reader = numOrders.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                icount = reader.GetInt32(0);
                            }

                        }

                        txtOutput.AppendText("\r\nOrders");
                        txtOutput.AppendText("\r\n=========================================");
                        if (icount == 0)
                        {
                            txtOutput.AppendText("\r\nNo orders placed for the day: " + dtpReport.Value.ToShortDateString());
                            txtOutput.AppendText("\r\n=========================================");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nOrders placed for the day: " + dtpReport.Value.ToShortDateString() + "\r\n" + icount);
                            txtOutput.AppendText("\r\n=========================================");
                            icount = 0;
                        }
                    }

                    cmdStr = "Select Count(*) as count from cms where complete_date = @date and completed = @complete";

                    using (SqlCommand ontimeCMS = new SqlCommand(cmdStr, conn))
                    {
                        ontimeCMS.Parameters.AddWithValue("@date", date);
                        ontimeCMS.Parameters.AddWithValue("@complete", "1");

                        txtOutput.AppendText("\r\nCustom Builds");
                        txtOutput.AppendText("\r\n=========================================");
                        using (var reader = ontimeCMS.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                icount = reader.GetInt32(0);
                            }

                        }

                        if (icount == 0)
                        {
                            txtOutput.AppendText("\r\nNo custom builds completed for the day: " + dtpReport.Value.ToShortDateString());
                            txtOutput.AppendText("\r\n=========================================");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nCustom builds completed for the day: " + dtpReport.Value.ToShortDateString() + "\r\n" + icount);
                            txtOutput.AppendText("\r\n=========================================");
                            icount = 0;
                        }
                    }

                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnAddOrder.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("There are no reports for the selected date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtItemType_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtManName.Text != "" && txtManPrice.Text != "" && txtRetail.Text != "" && txtItemType.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void pnlStockButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTechnicalOverview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtManufacturerFilter_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTypeFilter_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtRePrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pnlUpdateOrders_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlReport_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStockDetail_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Reports";
            string branch = cmbDetailedBranch.SelectedItem.ToString();
            string date = dtpReport.Value.ToString().Substring(0, 10);

            int pos = 0;
            txtOutput.Clear();

            while (date.Length > 8)
            {
                pos = date.IndexOf("/");
                date = date.Remove(pos,1);
            }

            path = path + @"\" + branch + @"\Stock\" + date + ".txt";

            try
            {
                if (File.Exists(path))
                {

                    txtOutput.AppendText(File.ReadAllText(path));
                    File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden | FileAttributes.ReadOnly);

                }
                else
                {

                    MessageBox.Show("Something went wrong and the report is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {

                MessageBox.Show("An error occurred while attempting to open the report. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Reports";
            string branch = cmbDetailedBranch.SelectedItem.ToString();
            string date = dtpReport.Value.ToString().Substring(0, 10);

            int pos = 0;
            txtOutput.Clear();

            while (date.Length > 8)
            {
                pos = date.IndexOf("/");
                date = date.Remove(pos, 1);
            }

            path = path + @"\" + branch + @"\Orders\" + date + ".txt";

            try
            {
                if (File.Exists(path))
                {

                    txtOutput.AppendText(File.ReadAllText(path));
                    File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden | FileAttributes.ReadOnly);

                }
                else
                {

                    MessageBox.Show("Something went wrong and the report is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {

                MessageBox.Show("An error occurred while attempting to open the report. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalesDetail_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Reports";
            string branch = cmbDetailedBranch.SelectedItem.ToString();
            string date = dtpReport.Value.ToString().Substring(0, 10);

            int pos = 0;
            txtOutput.Clear();

            while (date.Length > 8)
            {
                pos = date.IndexOf("/");
                date = date.Remove(pos, 1);
            }

            path = path + @"\" + branch + @"\Sales\" + date + ".txt";

            try
            {
                if (File.Exists(path))
                {

                    txtOutput.AppendText(File.ReadAllText(path));
                    File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden | FileAttributes.ReadOnly);

                }
                else
                {

                    MessageBox.Show("Something went wrong and the report is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {

                MessageBox.Show("An error occurred while attempting to open the report. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTechnicalDetail_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Reports";
            string branch = cmbDetailedBranch.SelectedItem.ToString();
            string date = dtpReport.Value.ToString().Substring(0, 10);

            int pos = 0;
            txtOutput.Clear();

            while (date.Length > 8)
            {
                pos = date.IndexOf("/");
                date = date.Remove(pos, 1);
            }

            path = path + @"\" + branch + @"\Technical\" + date + ".txt";

            try
            {
                if (File.Exists(path))
                {

                    txtOutput.AppendText(File.ReadAllText(path));
                    File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden | FileAttributes.ReadOnly);

                }
                else
                {

                    MessageBox.Show("Something went wrong and the report is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {

                MessageBox.Show("An error occurred while attempting to open the report. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtWarranty_TextChanged(object sender, EventArgs e)
        {
            if (txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "" && txtWarranty.Text != "")
            {
                btnAccept.Enabled = true;
            }
            else
                btnAccept.Enabled = false;
        }

        private void btnTechnicalBack_Click(object sender, EventArgs e)
        {
            pnlOverviewActions.Visible = true;
            pnlOverviewActions.BringToFront();
            pnlTechnicalOverview.Visible = false;
            chbTechnicalBranch.Checked = false;
            chbCompleted.Checked = false;
        }

        private void frmHQ_Load(object sender, EventArgs e)
        {

            int authLevel;
            cbmMainAction.SelectedItem = "Stock";
            

            authLevel =  this.getAuthLevel();

            if (authLevel >= 7)
            {
                pnlStock.Visible = true;
                pnlStockButtons.Visible = true;
                pnlAddStock.Visible = true;
                pnlStockButtons.BringToFront();
                pnlAddStock.BringToFront();
                btnAccept.Enabled = false;
            }
            else
            {
                cbmMainAction.Visible = false;
                pnlOverview.Visible = true;
                pnlOverview.BringToFront();
                btnOverviewReport.Enabled = false;
            }

        }

        private int getAuthLevel()
        {  
            try
            {
                string cmdStr;
                int authLevel;

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    cmdStr = "Select authLevel from Users where userName = @user";

                    using (SqlCommand getAuthLevel = new SqlCommand(cmdStr, conn))
                    {
                        getAuthLevel.Parameters.AddWithValue("@user", user);

                        conn.Open();
                        count = 0;
                        authLevel = Convert.ToInt16(getAuthLevel.ExecuteScalar());
                        conn.Close();
                    }

                }

                return authLevel;
            }
            catch (SqlException se)
            {
                if (se.Number == 207)
                    MessageBox.Show(se.Message);

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        getAuthLevel();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("There are no records containing this data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1; 
        }


        public frmHQ(string userName)
        {
            InitializeComponent();
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            user = userName;
        }

        public frmHQ(string itemID, string iName, string ibranch, string imanufacturer, string imanPrice, string irePrice, string itype, string iwarranty, string userName)
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
            user = userName;

            if (!pnlRevise.Visible)
            {
                pnlRevise.Visible = true;
                txtItemID.Text = id;
                txtItemID.Enabled = false;
                txtName.Text = name;
                txtManName.Text = itemManufacturer;
                txtManPrice.Text = itemManPrice;
                txtRetail.Text = itemRePrice;
                txtItemType.Text = itemType;
                cmbBranchUStock.SelectedItem = itemBranch;
                txtWarrant.Text = itemWarranty;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAddStock.Visible = true;
            gebruik.fillBranches(cmbBranchStockAdd);
            pnlAddStock.BringToFront();
            pnlRevise.Visible = false;
            btnAccept.Enabled = false;
            txtWarranty.MaxLength = 1;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, itemName, manufacturer, manPrice, rePrice, type, warranty, cmdStr;

                branch = cmbBranchStockAdd.SelectedItem.ToString();
                itemName = txtItemName.Text;
                manufacturer = txtManufacturerName.Text;
                manPrice = txtManufacturerPrice.Text;
                rePrice = txtRetailPrice.Text;
                type = txtType.Text;
                warranty = txtWarranty.Text + " Year(s)";

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    cmdStr = "Insert into Stock Values(@branch, @id, @itemName, @manufacturer, @warranty, @updated, @intial, @manPrice, @rePrice, @checked, @status, @type)";

                    using (SqlCommand addStock = new SqlCommand(cmdStr, conn))
                    {
                        addStock.Parameters.AddWithValue("@branch", branch);
                        addStock.Parameters.AddWithValue("@id",txtItemIDAdd.Text);
                        addStock.Parameters.AddWithValue("@itemName", itemName);
                        addStock.Parameters.AddWithValue("@manufacturer", manufacturer);
                        addStock.Parameters.AddWithValue("@warranty", warranty);
                        addStock.Parameters.AddWithValue("@updated", DateTime.Now);
                        addStock.Parameters.AddWithValue("@intial", DateTime.Today);
                        addStock.Parameters.AddWithValue("@manPrice", manPrice);
                        addStock.Parameters.AddWithValue("@rePrice", rePrice);
                        addStock.Parameters.AddWithValue("@checked", "0");
                        addStock.Parameters.AddWithValue("@status", "In Stock");
                        addStock.Parameters.AddWithValue("@type", type);

                        conn.Open();
                        count = 0;
                        addStock.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("The stock has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtManufacturerName.Clear();
                        txtItemIDAdd.Clear();
                        txtItemName.Clear();
                        txtManufacturerPrice.Clear();
                        txtRetailPrice.Clear();
                        txtType.Clear();
                        txtWarranty.Clear();
                    }
                
                    gebruik.addAction(user);

                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnAccept.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            frmHQSearch search = new frmHQSearch(user);
            search.ShowDialog();
            btnUpdate.Enabled = false;
            pnlRevise.Visible = true;
            gebruik.fillBranches(cmbBranchUStock);
            pnlRevise.BringToFront();
            pnlAddStock.Visible = false;
            txtWarrant.MaxLength = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdStr;

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    cmdStr = "Update Stock set branch = @branch, item_name = @itemName, manufacturer = @manufacturer, warranty = @warranty, last_updated = @updated, manufacturer_price = @manPrice, retail_price = @rePrice, item_Type = @type where item_id = @id";

                    using (SqlCommand updateStock = new SqlCommand(cmdStr, conn))
                    {
                        updateStock.Parameters.AddWithValue("@branch", cmbBranchUStock.SelectedItem.ToString());
                        updateStock.Parameters.AddWithValue("@id", txtItemID.Text);
                        updateStock.Parameters.AddWithValue("@itemName", txtName.Text);
                        updateStock.Parameters.AddWithValue("@manufacturer", txtManName.Text);
                        updateStock.Parameters.AddWithValue("@warranty", txtWarrant.Text + " Year(S)");
                        updateStock.Parameters.AddWithValue("@updated", DateTime.Now);
                        updateStock.Parameters.AddWithValue("@manPrice", txtManPrice.Text);
                        updateStock.Parameters.AddWithValue("@rePrice", txtRetail.Text);
                        updateStock.Parameters.AddWithValue("@type", txtItemType.Text);

                        conn.Open();
                        count = 0;
                        updateStock.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("The stock has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtItemID.Clear();                           
                        txtName.Clear();
                        txtManName.Clear();
                        txtManPrice.Clear();
                        txtRetail.Clear();
                        txtItemType.Clear();
                        txtWarrant.Clear();
                    }
                }

                gebruik.addAction(user);
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnUpdate.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("There are no records containing this data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
