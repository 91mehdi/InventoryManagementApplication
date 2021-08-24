using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementApplication
{
    public partial class FormCompanies : Form
    {
        public FormCompanies()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        SqlConnection connection = new SqlConnection("data source = (local); initial catalog = InventoryManagementApplication; integrated security = true");
        SqlCommand SqlCommand = new SqlCommand();

        private void frm_company_info_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand.Connection = connection;
            SqlCommand.Parameters.Clear();
            SqlCommand.CommandText = "INSERT INTO CompanyTable(CompanyCode, CompanyName, CompanyOwner, CompanyTelephone, CompanyFax, CompanyAddress) VALUES(@C_CODE, @C_NAME, @C_OWNER, @C_TELEPHONE, @C_FAX, @C_ADDRESS)";
            SqlCommand.Parameters.AddWithValue("@C_CODE", txt_code.Text);
            SqlCommand.Parameters.AddWithValue("@C_NAME", txt_company_name.Text);
            SqlCommand.Parameters.AddWithValue("@C_OWNER", txt_company_owner.Text);
            SqlCommand.Parameters.AddWithValue("@C_TELEPHONE", txt_telephone.Text);
            SqlCommand.Parameters.AddWithValue("@C_FAX", txt_fax.Text);
            SqlCommand.Parameters.AddWithValue("@C_ADDRESS", txt_company_address.Text);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }

            SqlCommand.ExecuteNonQuery();
            SqlCommand.Parameters.Clear();
            connection.Close();
            MessageBox.Show("اطلاعات با موفقیت ثبت شد");
            txt_code.Text = txt_company_address.Text = txt_company_name.Text = txt_company_owner.Text = txt_fax.Text = txt_telephone.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand.Connection = connection;
            SqlCommand.Parameters.Clear();
            SqlCommand.CommandText = "UPDATE CompanyTable SET CompanyName='" + txt_company_name.Text + "', CompanyOwner='" + txt_company_owner.Text + "', CompanyTelephone='" + txt_telephone.Text + "', CompanyFax= '" + txt_fax.Text + "', CompanyAddress='" + txt_company_address.Text + "' WHERE CompanyCode=" + txt_code.Text;

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }

            SqlCommand.ExecuteNonQuery();
            SqlCommand.Parameters.Clear();
            connection.Close();
            MessageBox.Show("اطلاعات با موفقیت ویرایش شد");
            txt_code.Text = txt_company_address.Text = txt_company_name.Text = txt_company_owner.Text = txt_fax.Text = txt_telephone.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            SqlCommand = new SqlCommand();
            SqlCommand.Connection = connection;
            SqlCommand.Parameters.Clear();
            SqlCommand.CommandText = "SELECT * FROM CompanyTable WHERE CompanyCode=@C_CODE";
            SqlCommand.Parameters.AddWithValue("@C_CODE", txt_code.Text);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }

            sqlDataReader = SqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txt_code.Text = sqlDataReader["CompanyCode"].ToString();
                txt_company_name.Text = sqlDataReader["CompanyName"].ToString();
                txt_company_owner.Text = sqlDataReader["CompanyOwner"].ToString();
                txt_telephone.Text = sqlDataReader["CompanyTelephone"].ToString();
                txt_fax.Text = sqlDataReader["CompanyFax"].ToString();
                txt_company_address.Text = sqlDataReader["CompanyAddress"].ToString();
            }
            else
            {
                MessageBox.Show("برای کد اقتصادی وارد شده اطلاعاتی یافت نشد");
                txt_code.Focus();
                txt_code.Text = "";
            }

            SqlCommand.Parameters.Clear();
            connection.Close();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void txt_company_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_fax_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_company_owner_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
