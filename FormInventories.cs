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
    public partial class FormInventories : Form
    {
        public FormInventories()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("data source = (local); initial catalog = InventoryManagementApplication; integrated security = true");
        SqlCommand command = new SqlCommand();
        void ShowReports()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            //DataGridView dataGridView = new DataGridView();
            sqlDataAdapter.SelectCommand.Connection = connection;
            sqlDataAdapter.SelectCommand.CommandText = "SELECT * FROM InventoriesTable";
            sqlDataAdapter.Fill(dataSet, "InventoriesTable");

            dataGridView.DataSource = dataSet;
            dataGridView.DataMember = "InventoriesTable";
            dataGridView.Columns[0].HeaderText = "کد انبار";
            dataGridView.Columns[1].HeaderText = "نام انبار";
            dataGridView.Columns[2].HeaderText = "تلفن انبار";
            dataGridView.Columns[3].HeaderText = "آدرس انبار";
            dataGridView.Columns[3].Width = 300;
        }

        private void FormInventories_Load(object sender, EventArgs e)
        {
            ShowReports();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "INSERT INTO InventoriesTable(InventoryName, InventoryTelephone, InventoryAddress) VALUES (@I_NAME, @I_TELEPHONE, @I_ADDRESS)";
            //command.Parameters.AddWithValue("@P_CODE", txt_code.Text);
            command.Parameters.AddWithValue("@I_NAME", txt_name.Text);
            command.Parameters.AddWithValue("@I_TELEPHONE", txt_telephone.Text);
            command.Parameters.AddWithValue("@I_ADDRESS", txt_address.Text);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            ShowReports();
            txt_name.Text = txt_telephone.Text = txt_address.Text = "";
            MessageBox.Show("اطلاعات ذخیره شد");
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int I_CODE = int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "DELETE FROM InventoriesTable WHERE InventoryCode=@I_CODE";
            command.Parameters.AddWithValue("@I_CODE", I_CODE);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            ShowReports();
            MessageBox.Show("اطلاعات حذف شد");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "UPDATE InventoriesTable SET InventoryName='" + txt_name.Text + "',InventoryTelephone='" + txt_telephone.Text + "',InventoryAddress='" + txt_address.Text + "' WHERE InventoryCode=" +txt_code.Text;

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("اطلاعات ویرایش شد");
            txt_name.Text = txt_telephone.Text = txt_address.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_code.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_telephone.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txt_address.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
