using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to start the program!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                //pplication.Exit();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pay_Page pay_Page = new Pay_Page();
            pay_Page.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtName.Text = null;
            txtCustomerType.Text = null;
            txtMember.Text = null;
            txtLastWaterMonth.Text = null;
            txtThisWaterMonth.Text = null;
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string customerType = txtCustomerType.Text.Trim().ToLower();
            string member = txtMember.Text.Trim();
            string lastWater = txtLastWaterMonth.Text.Trim();
            string thisWater = txtThisWaterMonth.Text.Trim();
            double waterUsed = 0;
            double cost = 0;
            double VAT = 0;
            double totalCostWater = 0;
            bool Next = false;
            if (name != null && checkName(name))
            {
                if (customerType != null)
                {
                    if (customerType.Equals("household customer"))
                    {
                        if (member != null && int.TryParse(member, out int memberValue))
                        {
                            if (memberValue > 0)
                            {
                                if (int.TryParse(lastWater, out int lastWaterValue) && int.TryParse(thisWater, out int thisWaterValue) && lastWater != null && thisWater != null)
                                {
                                    if (lastWaterValue >= 0 && thisWaterValue >= 0)
                                    {

                                        if (thisWaterValue >= lastWaterValue)
                                        {
                                            btnPay.Enabled = true;
                                            waterUsed = thisWaterValue - lastWaterValue;
                                            double averagePerCapita = waterUsed / memberValue;
                                            if (averagePerCapita >= 0 && averagePerCapita < 10)
                                            {
                                                cost = waterUsed * 5973;
                                            }
                                            else if (averagePerCapita >= 10 && averagePerCapita < 20)
                                            {
                                                cost = waterUsed * 7052;
                                            }
                                            else if (averagePerCapita >= 20 && averagePerCapita < 30)
                                            {
                                                cost = waterUsed * 8699;
                                            }
                                            else if (averagePerCapita > 30)
                                            {
                                                cost = waterUsed * 15929;
                                            }
                                            VAT = cost * 1.1;
                                            totalCostWater = cost + VAT;
                                            Next = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Last month's water number must be less than or equal to this month's water number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("The quantity of water must be greater than zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else if (thisWater == null && lastWater == null)
                                {
                                    MessageBox.Show("Please do not leave the water quantity blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("The quantity of water must be an integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("The number of family members must be greater than zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (member == null)
                        {
                            MessageBox.Show("Please enter the number of family members!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Please the number of family members must be an integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (customerType.Equals("administrative agency"))
                    {
                        if (int.TryParse(lastWater, out int lastWaterValue) && int.TryParse(thisWater, out int thisWaterValue) && lastWater != null && thisWater != null)
                        {
                            if (lastWaterValue >= 0 && thisWaterValue >= 0)
                            {

                                if (thisWaterValue >= lastWaterValue)
                                {
                                    waterUsed = thisWaterValue - lastWaterValue;
                                    cost = waterUsed * 9955;
                                    VAT = cost * 1.1;
                                    totalCostWater = cost + VAT;
                                    btnPay.Enabled = true;
                                    Next = true;
                                }
                                else
                                {
                                    MessageBox.Show("Last month's water number must be less than or equal to this month's water number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("The quantity of water must be greater than zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (thisWater == null && lastWater == null)
                        {
                            MessageBox.Show("Please do not leave the water quantity blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("The quantity of water must be an integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (customerType.Equals("production units"))
                    {
                        if (int.TryParse(lastWater, out int lastWaterValue) && int.TryParse(thisWater, out int thisWaterValue) && lastWater != null && thisWater != null)
                        {
                            if (lastWaterValue >= 0 && thisWaterValue >= 0)
                            {

                                if (thisWaterValue >= lastWaterValue)
                                {
                                    waterUsed = thisWaterValue - lastWaterValue;
                                    cost = waterUsed * 11615;
                                    VAT = cost * 1.1;
                                    totalCostWater = cost + VAT;
                                    btnPay.Enabled = true;
                                    Next = true;
                                }
                                else
                                {
                                    MessageBox.Show("Last month's water number must be less than or equal to this month's water number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("The quantity of water must be greater than zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (thisWater == null && lastWater == null)
                        {
                            MessageBox.Show("Please do not leave the water quantity blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("The quantity of water must be an integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (customerType.Equals("business services"))
                    {
                        if (int.TryParse(lastWater, out int lastWaterValue) && int.TryParse(thisWater, out int thisWaterValue) && lastWater != null && thisWater != null)
                        {
                            if (lastWaterValue >= 0 && thisWaterValue >= 0)
                            {

                                if (thisWaterValue >= lastWaterValue)
                                {
                                    waterUsed = thisWaterValue - lastWaterValue;
                                    cost = waterUsed * 22068;
                                    VAT = cost * 1.1;
                                    totalCostWater = cost + VAT;
                                    btnPay.Enabled = true;
                                    Next = true;
                                }
                                else
                                {
                                    MessageBox.Show("Last month's water number must be less than or equal to this month's water number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("The quantity of water must be greater than zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (thisWater == null && lastWater == null)
                        {
                            MessageBox.Show("Please do not leave the water quantity blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("The quantity of water must be an integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select the correct customer type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please do not leave the customer type blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (name == null)
            {
                MessageBox.Show("Please enter customer name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Invalid name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Next == true)
            {
                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add(customerType);
                item.SubItems.Add(member);
                item.SubItems.Add(lastWater);
                item.SubItems.Add(thisWater);
                item.SubItems.Add(waterUsed.ToString());
                item.SubItems.Add(totalCostWater.ToString());
                lsvBill.Items.Add(item);
            }
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            lsvBill.View = View.Details;
            lsvBill.Columns.Add("Customer name", 150);
            lsvBill.Columns.Add("Type", 150);
            lsvBill.Columns.Add("Member", 80);
            lsvBill.Columns.Add("Water last month", 150);
            lsvBill.Columns.Add("Water this month", 150);
            lsvBill.Columns.Add("Water number", 150);
            lsvBill.Columns.Add("Money", 150);
        }

        private void txtCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = txtCustomerType.Text.Trim().ToLower();
            if (customerType.Equals("household customer, administrative agency, production units, business services"))
            {
                txtMember.Enabled = true;
            }
            else
            {
                txtMember.Enabled = false;
                txtMember.Text = null;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Do you want to delete it or not", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    lsvBill.Items.Remove(lsvBill.SelectedItems[0]);

                }
                else
                {
                    MessageBox.Show("Please select data to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }


        private void lsvBill_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }
        static bool checkName(string name)
        {
            return Regex.IsMatch(name, @"[a-zA-Z]");

        }
    }
}
