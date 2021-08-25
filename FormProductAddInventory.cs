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
    public partial class FormProductAddInventory : Form
    {
        public FormProductAddInventory()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("data source = (local); initial catalog = InventoryManagementApplication; integrated security = true");
        SqlCommand command = new SqlCommand();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_a_scan_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            command = new SqlCommand();
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "SELECT * FROM AddTable WHERE AddCode=@A_CODE";
            command.Parameters.AddWithValue("@A_CODE", txt_a_code.Text);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }

            sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txt_i_code.Text = sqlDataReader["InventoryCode"].ToString();
                txt_i_name.Text = sqlDataReader["InventoryName"].ToString();
                txt_p_code.Text = sqlDataReader["ProductCode"].ToString();
                txt_p_name.Text = sqlDataReader["ProductName"].ToString();
                txt_p_serial.Text = sqlDataReader["ProductSerial"].ToString();
                txt_location.Text = sqlDataReader["AddLocation"].ToString();
                txt_entity.Text = sqlDataReader["AddEntity"].ToString();

            }
            else
            {
                MessageBox.Show(" برای کد وارد شده اطلاعاتی پیدا نشد");
                txt_a_code.Focus();
                txt_a_code.Text = "";
            }

            connection.Close();
        }

        private void btn_p_scan_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            command = new SqlCommand();
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "SELECT * FROM ProductsTable WHERE ProductCode=@P_CODE";
            command.Parameters.AddWithValue("@P_CODE", txt_p_code.Text);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }

            sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txt_p_code.Text = sqlDataReader["ProductCode"].ToString();
                txt_p_name.Text = sqlDataReader["ProductName"].ToString();
                txt_p_serial.Text = sqlDataReader["ProductSerial"].ToString();


            }
            else
            {
                MessageBox.Show(" برای کد وارد شده اطلاعاتی پیدا نشد");
                txt_p_code.Focus();
                txt_p_code.Text = "";
            }

            connection.Close();
        }

        private void btn_i_scan_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            command = new SqlCommand();
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "SELECT * FROM InventoriesTable WHERE InventoryCode=@I_CODE";
            command.Parameters.AddWithValue("@I_CODE", txt_i_code.Text);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }

            sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txt_i_code.Text = sqlDataReader["InventoryCode"].ToString();
                txt_i_name.Text = sqlDataReader["InventoryName"].ToString();
            }
            else
            {
                MessageBox.Show(" برای کد وارد شده اطلاعاتی پیدا نشد");
                txt_i_code.Focus();
                txt_i_code.Text = "";
            }

            connection.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "INSERT INTO AddTable(InventoryCode, InventoryName, ProductCode, ProductName, ProductSerial, AddLocation, AddEntity, AddImport, AddExport, AddExist) VALUES (@I_CODE, @I_NAME, @P_CODE, @P_NAME, @P_SERIAL, @A_LOCATION, @A_ENTITY, @A_IMPORT, @A_EXPORT, @A_EXIST)";
            //command.Parameters.AddWithValue("@P_CODE", txt_code.Text);
            command.Parameters.AddWithValue("@I_CODE", txt_i_code.Text);
            command.Parameters.AddWithValue("@I_NAME", txt_i_name.Text);
            command.Parameters.AddWithValue("@P_CODE", txt_p_code.Text);
            command.Parameters.AddWithValue("@P_NAME", txt_p_name.Text);
            command.Parameters.AddWithValue("@P_SERIAL", txt_p_serial.Text);
            command.Parameters.AddWithValue("@A_LOCATION", txt_location.Text);
            command.Parameters.AddWithValue("@A_ENTITY", txt_entity.Text);
            command.Parameters.AddWithValue("@A_IMPORT", 0);
            command.Parameters.AddWithValue("@A_EXPORT", 0);
            command.Parameters.AddWithValue("@A_EXIST", txt_exist.Text);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }

            txt_i_code.Text = txt_i_name.Text = txt_p_code.Text = txt_p_name.Text = txt_p_serial.Text = txt_location.Text = txt_entity.Text = "";

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("اطلاعات ذخیره شد");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "UPDATE AddTable SET InventoryCode='" + txt_i_code.Text + "',InventoryName='" + txt_i_name.Text + "',ProductCode='" + txt_p_code.Text + "',ProductName='" + txt_p_name.Text + "',ProductSerial='" + txt_p_serial.Text + "',AddLocation='" + txt_location.Text + "' WHERE AddCode=" + txt_a_code.Text;

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("اطلاعات ویرایش شد");
            txt_i_code.Text = txt_i_name.Text = txt_p_code.Text = txt_p_name.Text = txt_p_serial.Text = txt_location.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
