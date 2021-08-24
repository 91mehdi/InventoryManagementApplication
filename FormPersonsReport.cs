using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Stimulsoft.Report;

namespace InventoryManagementApplication
{
    public partial class FormPersonsReport : Form
    {
        public FormPersonsReport()
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
            sqlDataAdapter.SelectCommand.CommandText = "SELECT * FROM PersonsTable";
            sqlDataAdapter.Fill(dataSet, "PersonsTable");

            dataGridView.DataSource = dataSet;
            dataGridView.DataMember = "PersonsTable";
            dataGridView.Columns[0].HeaderText = "کد";
            dataGridView.Columns[1].HeaderText = "نام شخص";
            dataGridView.Columns[2].HeaderText = "نوع شخص";
            dataGridView.Columns[3].HeaderText = "تلفن ثابت";
            dataGridView.Columns[4].HeaderText = "تلفن همراه";
            dataGridView.Columns[5].HeaderText = "آدرس";
            dataGridView.Columns[5].Width = 300;
        }

        private void FormPersonsReport_Load(object sender, EventArgs e)
        {
            ShowReports();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int P_CODE = int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());
            command.Connection = connection;
            command.Parameters.Clear();
            command.CommandText = "DELETE FROM PersonsTable WHERE PersonCode=@P_CODE";
            command.Parameters.AddWithValue("@P_CODE", P_CODE);

            if (!(connection.State == ConnectionState.Open))
            {
                connection.Open();
            }
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("اطلاعات حذف شد");

        }
    }
}
