using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementApplication
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();
            lbl_date.Text = persianCalendar.GetYear(DateTime.Now).ToString();
            lbl_date.Text += "/";
            lbl_date.Text += persianCalendar.GetMonth(DateTime.Now).ToString("0#");
            lbl_date.Text += "/";
            lbl_date.Text += persianCalendar.GetDayOfMonth(DateTime.Now).ToString("0#");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.Hour.ToString("0#");
            lbl_time.Text += ":";
            lbl_time.Text += DateTime.Now.Minute.ToString("0#");
            lbl_time.Text += ":";
            lbl_time.Text += DateTime.Now.Second.ToString("0#");

        }

        private void btn_company_info_Click(object sender, EventArgs e)
        {
            new FormCompanies().ShowDialog();
        }

        private void btn_customers_info_Click(object sender, EventArgs e)
        {
            new FormPersons().ShowDialog();

        }

        private void btn_customers_report_Click(object sender, EventArgs e)
        {
            new FormPersonsReport().ShowDialog();
        }

        private void btn_groups_info_Click(object sender, EventArgs e)
        {
            new FormGroups().ShowDialog();
        }

        private void btn_products_info_Click(object sender, EventArgs e)
        {
            new FormProducts().ShowDialog();
        }

        private void btn_products_report_Click(object sender, EventArgs e)
        {
            new FormProductsReport().ShowDialog();
        }

        private void btn_inventory_info_Click(object sender, EventArgs e)
        {
            new FormInventories().ShowDialog();
        }

        private void btn_add_products_inventory_Click(object sender, EventArgs e)
        {
            new FormProductAddInventory().ShowDialog();
        }

        private void btn_initial_inventory_report_Click(object sender, EventArgs e)
        {
            new FormInitialInventory().ShowDialog();
        }
    }
}
