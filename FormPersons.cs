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
    public partial class FormPersons : Form
    {
        public FormPersons()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("data source = (local); initial catalog = InventoryManagementApplication; integrated security = true");
        SqlCommand command = new SqlCommand();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormPersons_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "INSERT INTO PersonsTable(PersonCode, PersonName, PersonType, PersonTelephone, PersonMobile, PersonAddress) VALUES(@P_CODE, @P_NAME, @P_TYPE, @P_TELEPHONE, @P_MOBILE, @P_ADDRESS)";
            command.Parameters.AddWithValue("@P_CODE", txt_code.Text);
            command.Parameters.AddWithValue("@P_NAME", txt_name.Text);
            command.Parameters.AddWithValue("@P_TYPE", cmb_type.Text);
            command.Parameters.AddWithValue("@P_TELEPHONE", txt_telephone.Text);
            command.Parameters.AddWithValue("@P_MOBILE", txt_mobile.Text);
            command.Parameters.AddWithValue("@P_ADDRESS", txt_address.Text);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("اطلاعات ذخیره شد");
            txt_address.Text = txt_code.Text = txt_mobile.Text = txt_name.Text = txt_telephone.Text = "";



        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            command = new SqlCommand();
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "SELECT * FROM PersonsTable WHERE PersonCode=@P_CODE";
            command.Parameters.AddWithValue("@P_CODE", txt_code.Text);
            
            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            
            sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txt_code.Text = sqlDataReader["PersonCode"].ToString();
                txt_name.Text = sqlDataReader["PersonName"].ToString();
                cmb_type.Text = sqlDataReader["PersonType"].ToString();
                txt_telephone.Text = sqlDataReader["PersonTelephone"].ToString();
                txt_mobile.Text = sqlDataReader["PersonMobile"].ToString();
                txt_address.Text = sqlDataReader["PersonAddress"].ToString();

            }
            else
            {
                MessageBox.Show(" برای کد وارد شده اطلاعاتی پیدا نشد");
                txt_code.Focus();
                txt_code.Text = "";
            }

            connection.Close();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "UPDATE PersonsTable SET PersonName=N'" + txt_name.Text + "',PersonType=N'" + cmb_type.Text + "',PersonTelephone='" + txt_telephone.Text + "',PersonMobile='" + txt_mobile.Text + "',PersonAddress='" + txt_address.Text + "' WHERE PersonCode=" + txt_code.Text;

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("اطلاعات ویرایش شد");
            txt_address.Text = txt_code.Text = txt_mobile.Text = txt_name.Text = txt_telephone.Text = "";


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
