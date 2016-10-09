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
        private SqlConnection conn;
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
                string cmdStr = "Delete from Stock where item_id = @id'";

                using (conn)
                {
                    using (SqlCommand deleteStock = new SqlCommand(cmdStr, conn))
                    {
                        deleteStock.Parameters.AddWithValue("@id", txtItemID.Text);

                        conn.Open();
                        count = 0;
                        deleteStock.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                gebruik.addAction(user);

            }
            catch (SqlException se)
            {
                if(se.Number == 53 && count < 4)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnRemove.PerformClick();
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
                pnlOverview.Visible = false;
            }
            else if (cbmMainAction.SelectedItem.ToString() == "Orders")
            {
                pnlOrder.Visible = true;
                pnlOrder.BringToFront();
                pnlOrdersActions.Visible = true;
                pnlOrdersActions.BringToFront();
                pnlStock.Visible = false;
                pnlOverview.Visible = false;
            }
            else if (cbmMainAction.SelectedItem.ToString() == "Overview")
            {
                pnlOverview.Visible = true;
                pnlOverview.BringToFront();
                pnlOverviewActions.Visible = true;
                pnlOverviewActions.BringToFront();
                pnlStock.Visible = false;
                pnlOrder.Visible = false;
            }

        }


        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            if(txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "")
            {
                btnAccept.Enabled = true;
            }
            else
                btnAccept.Enabled = false;
        }

        private void txtManufacturerName_TextChanged(object sender, EventArgs e)
        {
            if (txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "")
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

                if (txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "")
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
        }

        private void txtRetailPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtRetailPrice.MaxLength = 10;

                if (txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "")
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
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if (txtItemName.Text != "" && txtManufacturerName.Text != "" && txtManufacturerPrice.Text != "" && txtRetailPrice.Text != "" && txtType.Text != "")
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
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            pnlAddStock.Visible = false;
            pnlRevise.Visible = false;
            pnlTransfer.Visible = true;
            gebruik.fillBranches(cmbTo, cmbTo);
            pnlTransfer.BringToFront();
            btnStockTransfer.Enabled = false;
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
                        addTransfer.Parameters.AddWithValue("@eta", DateTime.Today.AddDays(9));

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
                if (se.Number == 53 && count < 4)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnStockTransfer.PerformClick();

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
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            pnlAddOrders.Visible = true;
            gebruik.fillBranches(cmbAddOrders);
            pnlAddOrders.BringToFront();
            pnlUpdateOrders.Visible = false;
            btnAddOrder.Enabled = false;
            txtCustomerEmail.Enabled = false;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string items, quantity;

            items = txtItemsO.Text;
            quantity = txtQuantityAdd.Text;
            addString = addString + quantity + "X" + " " + items + ",";

            txtItemsO.Clear();
            txtQuantityAdd.Clear();
            txtItemsO.Focus();
        }

        private void btnUpdateOrders_Click(object sender, EventArgs e)
        {
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

            txtItemsUp.Clear();
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
            cmbBranch.Enabled = true;
        }

        private void btnStockBack_Click(object sender, EventArgs e)
        {
            pnlOverviewActions.Visible = true;
            pnlOverviewActions.BringToFront();
            pnlStockFilter.Visible = false;
        }

        private void btnStockFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, manufacturer, rePrice, type, cmdStr;

                branch = cmbBranch.SelectedItem.ToString();
                manufacturer = txtManufacturerFilter.Text;
                rePrice = txtRePrice.Text;
                type = txtTypeFilter.Text;

                using (conn)
                {
                    conn.Open();
                    count = 0;

                    cmdStr = "Select * from Stock";

                    using (SqlCommand filter = new SqlCommand(cmdStr, conn))
                    {
                        if (chbBranch.Checked && rdbManufacturer.Checked)
                        {
                            cmdStr = "Select * from Stock where branch = @branch and manufacturer = @man";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@man", manufacturer);
                        }
                        else if (chbBranch.Checked && rdbRePrice.Checked)
                        {
                            cmdStr = "Select * from Stock where branch = @branch and retail_price = @price";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@price", rePrice);
                        }
                        else if (chbBranch.Checked && rdbType.Checked)
                        {
                            cmdStr = "Select * from Stock where branch = @branch and item_type = @type";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@type", type);
                        }
                        else if(chbBranch.Checked)
                        {
                            cmdStr = "Select * from Stock where branch = @branch";
                            filter.Parameters.AddWithValue("@branch", branch);
                        }
                        else if(rdbManufacturer.Checked)
                        {
                            cmdStr = "Select * from Stock where manufacturer = @manufacturer";
                            filter.Parameters.AddWithValue("@man", manufacturer);
                        }
                        else if(rdbRePrice.Checked)
                        {
                            cmdStr = "Select * from Stock where retail_price = @price";
                            filter.Parameters.AddWithValue("@price", rePrice);
                        }
                        else if(rdbType.Checked)
                        {
                            cmdStr = "Select * from Stock where item_type = @type";
                            filter.Parameters.AddWithValue("@type", type);
                        }

                        using (var reader = filter.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                dgOverview.Rows.Add(reader.GetString(0), reader.GetString(1));

                            }

                        }

                        conn.Close();

                        for (int i = 0; i < dgOverview.Rows.Count; i++)
                        {
                            DataGridViewRowHeaderCell cell = dgOverview.Rows[i].HeaderCell;
                            cell.Value = (i + 1).ToString();
                            dgOverview.Rows[i].HeaderCell = cell;
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53 && count < 4)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnStockFilter.PerformClick();
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
        }
         


        private void rdbManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbManufacturer.Checked)
                txtManufacturerFilter.Enabled = true;
            else
                txtManufacturerFilter.Enabled = false;
        }

        private void rdbType_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbType.Checked)
                txtTypeFilter.Enabled = true;
            else
                txtTypeFilter.Enabled = false; 
            
        }

        private void rdbRePrice_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRePrice.Checked)
                txtRePrice.Enabled = true;
            else
                txtRePrice.Enabled = false;        }

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
        }

        private void btnEmployeeFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, cmdStr;

                branch = cmbEmployeeBranch.SelectedItem.ToString();

                using (conn)
                {
                    conn.Open();
                    count = 0;

                    cmdStr = "Select * from Employee";

                    using (SqlCommand filter = new SqlCommand(cmdStr, conn))
                    {
                        if (chbEmployeeBranch.Checked && rdbUser.Checked)
                        {
                            cmdStr = "Select * from Employee where branch = @branch and is_user = @user";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@user", "1");
                        }
                        else if (chbEmployeeBranch.Checked && rdbTemp.Checked)
                        {
                            cmdStr = "Select * from Employee where branch = @branch and is_temp = @temp";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@temp", "1");
                        }
                        else if (chbBranch.Checked)
                        {
                            cmdStr = "Select * from Employee where branch = @branch";
                            filter.Parameters.AddWithValue("@branch", branch);
                        }
                        else if (rdbManufacturer.Checked)
                        {
                            cmdStr = "Select * from Employee where is_user = @user";
                            filter.Parameters.AddWithValue("@user", "1");
                        }
                        else if (rdbRePrice.Checked)
                        {
                            cmdStr = "Select * from Employee where is_temp = @temp";
                            filter.Parameters.AddWithValue("@temp", "1");
                        }

                        using (var reader = filter.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                dgOverview.Rows.Add(reader.GetString(0), reader.GetString(1));

                            }

                        }

                        conn.Close();

                        for (int i = 0; i < dgOverview.Rows.Count; i++)
                        {
                            DataGridViewRowHeaderCell cell = dgOverview.Rows[i].HeaderCell;
                            cell.Value = (i + 1).ToString();
                            dgOverview.Rows[i].HeaderCell = cell;
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53 && count < 4)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnEmployeeFilter.PerformClick();
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
        }


        private void chbOrderBranch_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOrderBranch.Checked)
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
            if(rdbSupplier.Checked)
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
            cmbOrderBranch.Enabled = false;
            pnlOrderOverview.BringToFront();
            pnlOverviewActions.Visible = false;
        }

        private void btnOrderBack_Click(object sender, EventArgs e)
        {
            pnlOverviewActions.Visible = true;
            pnlOverviewActions.BringToFront();
            pnlOrderOverview.Visible = false;
        }

        private void btnOrderFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, supplier, cmdStr;

                branch = cmbEmployeeBranch.SelectedItem.ToString();
                supplier = txtSupplier.Text;

                using (conn)
                {
                    conn.Open();
                    count = 0;

                    cmdStr = "Select * from Orders";

                    using (SqlCommand filter = new SqlCommand(cmdStr, conn))
                    {
                        if (chbOrderBranch.Checked && rdbSupplier.Checked)
                        {
                            cmdStr = "Select * from Orders where branch = @branch and order_supplier = @supplier";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@supplier", supplier);
                        }
                        else if (chbOrderBranch.Checked && rdbInvoiced.Checked)
                        {
                            cmdStr = "Select * from Orders where branch = @branch and invoice_sent = @invoice";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@invoice", "1");
                        }
                        else if (chbOrderBranch.Checked && rdbRecieved.Checked)
                        {
                            cmdStr = "Select * from Orders where branch = @branch and received = @received";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@received", "1");
                        }
                        else if (chbOrderBranch.Checked && rdbInvoiced.Checked)
                        {
                            cmdStr = "Select * from Orders where branch = @branch and special_order = @special";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@special", "1");
                        }
                        else if (chbBranch.Checked)
                        {
                            cmdStr = "Select * from Orders where branch = @branch";
                            filter.Parameters.AddWithValue("@branch", branch);
                        }
                        else if (rdbInvoiced.Checked)
                        {
                            cmdStr = "Select * from Orders where invoice_sent = @invoice";
                            filter.Parameters.AddWithValue("@invoice", "1");
                        }
                        else if (rdbRecieved.Checked)
                        {
                            cmdStr = "Select * from Orders where received = @received";
                            filter.Parameters.AddWithValue("@received", "1");
                        }
                        else if (rdbInvoiced.Checked)
                        {
                            cmdStr = "Select * from Orders where special_order = @special";
                            filter.Parameters.AddWithValue("@special", "1");
                        }

                        using (var reader = filter.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                dgOverview.Rows.Add(reader.GetString(0), reader.GetString(1));

                            }

                        }

                        conn.Close();

                        for (int i = 0; i < dgOverview.Rows.Count; i++)
                        {
                            DataGridViewRowHeaderCell cell = dgOverview.Rows[i].HeaderCell;
                            cell.Value = (i + 1).ToString();
                            dgOverview.Rows[i].HeaderCell = cell;
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53 && count < 4)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnOrderFilter.PerformClick();
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
        }

        private void btnSalesOverview_Click(object sender, EventArgs e)
        {
            pnlSalesOverview.Visible = true;
            gebruik.fillBranches(cmbSalesBranch);
            cmbSalesBranch.Enabled = false;
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
        }

        private void btnSalesFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, cmdStr;
                DateTime picked;

                dtpSalesOverview.MaxDate = DateTime.Today.AddDays(-1);
                picked = dtpSalesOverview.Value;
                branch = cmbSalesBranch.SelectedItem.ToString();

                using (conn)
                {
                    conn.Open();
                    count = 0;
                    cmdStr = "Select * from Sales";

                    using (SqlCommand filter = new SqlCommand(cmdStr, conn))
                    {
                        if (chbSalesBranch.Checked && chbSalesDate.Checked)
                        {
                            cmdStr = "Select * from Sales where branch = @branch and sale_date = @date";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@date", picked);
                        }
                        else if (chbSalesDate.Checked)
                        {
                            cmdStr = "Select * from Sales where sale_date = @date";
                            filter.Parameters.AddWithValue("@date", picked);
                        }
                        else if (chbSalesBranch.Checked)
                        {
                            cmdStr = "Select * from Orders where branch = @branch";
                            filter.Parameters.AddWithValue("@branch", branch);
                        }

                        using (var reader = filter.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                dgOverview.Rows.Add(reader.GetString(0), reader.GetString(1));

                            }

                        }

                        conn.Close();

                        for (int i = 0; i < dgOverview.Rows.Count; i++)
                        {
                            DataGridViewRowHeaderCell cell = dgOverview.Rows[i].HeaderCell;
                            cell.Value = (i + 1).ToString();
                            dgOverview.Rows[i].HeaderCell = cell;
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnOrderFilter.PerformClick();
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

                using (conn)
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
                    }
                }

                gebruik.addAction(user);
            }
            catch (SqlException se)
            {
                if (se.Number == 53 && count < 4)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnUpdateOrder.PerformClick();
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
        }

        private void btnTechnicalFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, cmdStr;

                branch = cmbSalesBranch.SelectedItem.ToString();

                using (conn)
                {
                    conn.Open();
                    count = 0;
                    cmdStr = "Select * from cms";

                    using (SqlCommand filter = new SqlCommand(cmdStr, conn))
                    {
                        if (chbTechnicalBranch.Checked && chbCompleted.Checked)
                        {
                            cmdStr = "Select * from cms where branch = @branch and completed = @complete";
                            filter.Parameters.AddWithValue("@branch", branch);
                            filter.Parameters.AddWithValue("@complete", "1");
                        }
                        else if (chbSalesDate.Checked)
                        {
                            cmdStr = "Select * from cms where completed = @complete";
                            filter.Parameters.AddWithValue("@complete", "1");
                        }
                        else if (chbSalesBranch.Checked)
                        {
                            cmdStr = "Select * from Orders where branch = @branch";
                            filter.Parameters.AddWithValue("@branch", branch);
                        }

                        using (var reader = filter.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                dgOverview.Rows.Add(reader.GetString(0), reader.GetString(1));

                            }

                        }

                        conn.Close();

                        for (int i = 0; i < dgOverview.Rows.Count; i++)
                        {
                            DataGridViewRowHeaderCell cell = dgOverview.Rows[i].HeaderCell;
                            cell.Value = (i + 1).ToString();
                            dgOverview.Rows[i].HeaderCell = cell;
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    while (count < 4)
                    {
                        gebruik other = new gebruik();
                        if (other.CheckConnection())
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
                quantity = txtQuantity.Text;
                addString = addString + quantity + "X" + " " + items + ",";

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
                        addOrders.ExecuteNonQuery();
                        conn.Close();

                    }

                    gebruik.addAction(user);
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53 && count < 4)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnAddOrder.PerformClick();
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
        }

        private void btnMainBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
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
        }

        private void btnReportBack_Click(object sender, EventArgs e)
        {
            pnlOverviewActions.Visible = true;
            pnlOverviewActions.BringToFront();
            pnlReport.Visible = false;
        }

        private void btnDetailed_Click(object sender, EventArgs e)
        {
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

            date = dtpReport.Value.ToString();
            date = date.Substring(0, 10);
            int count = 0;
            branch = cmbDetailedBranch.SelectedItem.ToString();

            try
            {
                using (conn)
                {
                    conn.Open();
                    count = 0;
                    cmdStr = "Select Distinct Count(*) from Stock where initial_add = @date";

                    using (SqlCommand stockAdd = new SqlCommand(cmdStr, conn))
                    {
                        stockAdd.Parameters.AddWithValue("@date", date);
                        count = (Int16)stockAdd.ExecuteScalar();
                        if(count == 0)
                        {
                            txtOutput.AppendText("\r\nNo items added Yesterday");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nItems added Yesterday: " + count);
                            count = 0;
                        }
                    }

                    cmdStr = "Select Distinct Count(*) from Stock where last_updated = @date and status = @status";

                    using (SqlCommand stockTransfer = new SqlCommand(cmdStr, conn))
                    {
                        stockTransfer.Parameters.AddWithValue("@date", date);
                        stockTransfer.Parameters.AddWithValue("@status", "In Transit");
                        count = (Int16)stockTransfer.ExecuteScalar();
                        if (count == 0)
                        {
                            txtOutput.AppendText("\r\nNo items transfered Yesterday");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nItems transfered Yesterday: " + count);
                            count = 0;
                        }
                    }


                    cmdStr = "Select Distinct Count(*) from Stock where last_updated = @date and status = @status";

                    using (SqlCommand stockSold = new SqlCommand(cmdStr, conn))
                    {
                        stockSold.Parameters.AddWithValue("@date", date);
                        stockSold.Parameters.AddWithValue("@status", "Sold");
                        count = (Int16)stockSold.ExecuteScalar();
                        if (count == 0)
                        {
                            txtOutput.AppendText("\r\nNo items sold Yesterday");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nItems sold Yesterday: " + count);
                            count = 0;
                        }
                    }

                    cmdStr = "Select Distinct Count(*) from Sales where sale_date = @date";

                    using (SqlCommand numSales = new SqlCommand(cmdStr, conn))
                    {
                        numSales.Parameters.AddWithValue("@date", dtpReport.Value.ToString());
                        count = (Int16)numSales.ExecuteScalar();
                        if (count == 0)
                        {
                            txtOutput.AppendText("\r\nNo items sold Yesterday");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nItems sold Yesterday: " + count);
                            count = 0;
                        }
                    }

                    cmdStr = "Select  Distinct Count(*) from Orders where order_date = @order";

                    using (SqlCommand numOrders = new SqlCommand(cmdStr, conn))
                    {
                        numOrders.Parameters.AddWithValue("@order", date);
                        count = (Int16)numOrders.ExecuteScalar();
                        if (count == 0)
                        {
                            txtOutput.AppendText("\r\nNo orders made Yesterday");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nOrders made Yesterday: " + count);
                            count = 0;
                        }
                    }

                    cmdStr = "Select Distinct Count(*) from cms where complete_date = @date and completed = @complete";

                    using (SqlCommand ontimeCMS = new SqlCommand(cmdStr, conn))
                    {
                        ontimeCMS.Parameters.AddWithValue("@date", date);
                        ontimeCMS.Parameters.AddWithValue("@complete", "1");
                        count = (Int16)ontimeCMS.ExecuteScalar();
                        if (count == 0)
                        {
                            txtOutput.AppendText("\r\nNo custom builds completed Yesterday");
                        }
                        else
                        {
                            txtOutput.AppendText("\r\nCustom buids completed Yesterday: " + count);
                            count = 0;
                        }
                    }

                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53 && count < 4)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnAddOrder.PerformClick();
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

        private void frmHQ_Load(object sender, EventArgs e)
        {

            int authLevel;
            cbmMainAction.SelectedItem = "Stock";
            conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");

            authLevel =  this.getAuthLevel();

            if (authLevel >= 7)
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
                btnOverviewReport.Enabled = false;
            }

        }

        private int getAuthLevel()
        {  
            try
            {
                string cmdStr;
                int authLevel;

                using (conn)
                {
                    cmdStr = "Select authLevel from Stock where userName = @user";

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
                if (se.Number == 53 && count < 4)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        getAuthLevel();
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
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string branch, itemName, manufacturer, manPrice, rePrice, type, warranty, cmdStr;
                int temp;

                branch = cmbBranchStockAdd.SelectedItem.ToString();
                itemName = txtItemName.Text;
                manufacturer = txtManufacturerName.Text;
                manPrice = txtManufacturerPrice.Text;
                rePrice = txtRetailPrice.Text;
                type = txtType.Text;
                warranty = txtWarranty.Text + " Years";

                using (conn)
                {

                    cmdStr = "Select Count(item_id) from Stock";

                    using (SqlCommand icount = new SqlCommand(cmdStr, conn))
                    {
                        conn.Open();
                        count = 0;
                        temp = Convert.ToInt32(icount.ExecuteScalar());
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
                if (se.Number == 53 && count < 4)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnAccept.PerformClick();
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
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            frmHQSearch search = new frmHQSearch();
            search.ShowDialog();
            btnUpdate.Enabled = false;
            pnlRevise.Visible = true;
            gebruik.fillBranches(cmbBranchUStock);
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
                        updateStock.Parameters.AddWithValue("@branch", cmbBranchUStock.SelectedItem.ToString());
                        updateStock.Parameters.AddWithValue("@id", txtItemID.Text);
                        updateStock.Parameters.AddWithValue("@itemName", txtName.Text);
                        updateStock.Parameters.AddWithValue("@manufacturer", txtManName.Text);
                        updateStock.Parameters.AddWithValue("@warranty", txtWarrant.Text);
                        updateStock.Parameters.AddWithValue("@updated", DateTime.Now);
                        updateStock.Parameters.AddWithValue("@manPrice", txtManPrice.Text);
                        updateStock.Parameters.AddWithValue("@rePrice", txtRetail.Text);
                        updateStock.Parameters.AddWithValue("@type", txtItemType.Text);

                        conn.Open();
                        count = 0;
                        updateStock.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                gebruik.addAction(user);
            }
            catch (SqlException se)
            {
                if (se.Number == 53 && count < 4)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnUpdate.PerformClick();
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
        }
    }
}
