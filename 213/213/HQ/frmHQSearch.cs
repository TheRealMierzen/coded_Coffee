﻿using System;
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
    public partial class frmHQSearch : Form
    {
        private SqlConnection conn;

        public frmHQSearch()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string id, itemName, branch, manufacturer, warranty, manPrice, rePrice, type, cmdStr;

                id = txtID.Text;
                    
                if (id != "")
                {
                    using (conn)
                    {
                        
                        conn.Open();

                        cmdStr = "Select item_id from Stock where item_id = @id";

                        using (SqlCommand getItemID = new SqlCommand(cmdStr, conn))
                        {
                            getItemID.Parameters.AddWithValue("@id", id);                          
                            id = Convert.ToString(getItemID.ExecuteScalar());  
                        }

                        cmdStr = "Select item_name from Stock where item_id = @id";

                        using (SqlCommand getItemName = new SqlCommand(cmdStr, conn))
                        {
                            getItemName.Parameters.AddWithValue("@id", id);
                            itemName = Convert.ToString(getItemName.ExecuteScalar());
                        }

                        cmdStr = "Select branch from Stock where item_id = @id";

                        using (SqlCommand getBranch = new SqlCommand(cmdStr, conn))
                        {
                            getBranch.Parameters.AddWithValue("@id", id);
                            branch = Convert.ToString(getBranch.ExecuteScalar());
                        }

                        cmdStr = "Select manufacturer from Stock where item_id = @id";

                        using (SqlCommand getManufacturer = new SqlCommand(cmdStr, conn))
                        {
                            getManufacturer.Parameters.AddWithValue("@id", id);
                            manufacturer = Convert.ToString(getManufacturer.ExecuteScalar());
                        }

                        cmdStr = "Select warranty from Stock where item_id = @id";

                        using (SqlCommand getWarranty = new SqlCommand(cmdStr, conn))
                        {
                            getWarranty.Parameters.AddWithValue("@id", id);
                            warranty = Convert.ToString(getWarranty.ExecuteScalar());
                        }

                        cmdStr = "Select manufacturer_price from Stock where item_id = @id";

                        using (SqlCommand getManPrice = new SqlCommand(cmdStr, conn))
                        {
                            getManPrice.Parameters.AddWithValue("@id", id);
                            manPrice = Convert.ToString(getManPrice.ExecuteScalar());
                        }

                        cmdStr = "Select retail_price from Stock where item_id = @id";

                        using (SqlCommand getRePrice = new SqlCommand(cmdStr, conn))
                        {
                            getRePrice.Parameters.AddWithValue("@id", id);
                            rePrice = Convert.ToString(getRePrice.ExecuteScalar());
                        } 

                        cmdStr = "Select item_Type from Stock where item_id = @id";

                        using (SqlCommand getType = new SqlCommand(cmdStr, conn))
                        {
                            getType.Parameters.AddWithValue("@id", id);
                            type = Convert.ToString(getType.ExecuteScalar());
                        }

                        conn.Close();

                        btnAccept.Enabled = true;
                        frmHQ hq = new frmHQ(id, itemName, branch, manufacturer, manPrice, rePrice, type, warranty);
                        this.Hide();

                    }
                }
                else
                    btnAccept.Enabled = false;

            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnAccept.PerformClick();
                }
            }


        }

        private void frmHQSearch_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}