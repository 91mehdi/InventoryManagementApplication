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
    public partial class FormGroups : Form
    {
        public FormGroups()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("data source = (local); initial catalog = InventoryManagementApplication; integrated security = true");
        SqlCommand command = new SqlCommand();
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        void ShowReports()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            //DataGridView dataGridView = new DataGridView();
            sqlDataAdapter.SelectCommand.Connection = connection;
            sqlDataAdapter.SelectCommand.CommandText = "SELECT * FROM GroupsTable";
            sqlDataAdapter.Fill(dataSet, "GroupsTable");

            dataGridView.DataSource = dataSet;
            dataGridView.DataMember = "GroupsTable";
            dataGridView.Columns[0].HeaderText = "کد";
            dataGridView.Columns[1].HeaderText = "نام گروه";
            dataGridView.Columns[1].Width = 100;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "INSERT INTO GroupsTable(GroupName) VALUES (@G_NAME)";
            command.Parameters.AddWithValue("@G_NAME", txt_name.Text);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            ShowReports();
            MessageBox.Show("اطلاعات ذخیره شد");

        }



        private void btn_remove_Click(object sender, EventArgs e)
        {
            int G_CODE = int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "DELETE FROM GroupsTable WHERE GroupCode=@G_CODE";
            command.Parameters.AddWithValue("@G_CODE", G_CODE);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            ShowReports();
            MessageBox.Show("اطلاعات حذف شد");

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGroups_Load(object sender, EventArgs e)
        {
            ShowReports();
        }

        private void txt_name_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
