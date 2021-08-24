
namespace InventoryManagementApplication
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_basic_info = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_company_info = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_inventory_info = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_groups_info = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_products_info = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_customers_info = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_users_info = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_import_export = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_products_import = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_products_export = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_add_products_inventory = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_inventory_exchange = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_set_inventory_exchange = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_reports = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_customers_report = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_inventories_report = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_products_report = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_groups_report = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_initial_inventory_report = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_import_report = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_export_report = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_exchange_report = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_database_management = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(584, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_time);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl_date);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_user);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(381, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(38, 109);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(42, 16);
            this.lbl_time.TabIndex = 5;
            this.lbl_time.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "ساعت";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(38, 72);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(42, 16);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "label3";
            this.lbl_date.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "تاریخ";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(38, 35);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(42, 16);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "label2";
            this.lbl_user.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "خوش آمدید";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_basic_info,
            this.btn_import_export,
            this.btn_inventory_exchange,
            this.btn_reports,
            this.btn_database_management,
            this.btn_exit});
            this.menuStrip1.Location = new System.Drawing.Point(3, 20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btn_basic_info
            // 
            this.btn_basic_info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_company_info,
            this.btn_inventory_info,
            this.btn_groups_info,
            this.btn_products_info,
            this.btn_customers_info,
            this.btn_users_info});
            this.btn_basic_info.Name = "btn_basic_info";
            this.btn_basic_info.Size = new System.Drawing.Size(80, 20);
            this.btn_basic_info.Text = "اطلاعات پایه";
            // 
            // btn_company_info
            // 
            this.btn_company_info.Name = "btn_company_info";
            this.btn_company_info.Size = new System.Drawing.Size(180, 22);
            this.btn_company_info.Text = "تعریف شرکت";
            this.btn_company_info.Click += new System.EventHandler(this.btn_company_info_Click);
            // 
            // btn_inventory_info
            // 
            this.btn_inventory_info.Name = "btn_inventory_info";
            this.btn_inventory_info.Size = new System.Drawing.Size(180, 22);
            this.btn_inventory_info.Text = "تعریف انبار";
            this.btn_inventory_info.Click += new System.EventHandler(this.btn_inventory_info_Click);
            // 
            // btn_groups_info
            // 
            this.btn_groups_info.Name = "btn_groups_info";
            this.btn_groups_info.Size = new System.Drawing.Size(180, 22);
            this.btn_groups_info.Text = "تعریف گروه کالا";
            this.btn_groups_info.Click += new System.EventHandler(this.btn_groups_info_Click);
            // 
            // btn_products_info
            // 
            this.btn_products_info.Name = "btn_products_info";
            this.btn_products_info.Size = new System.Drawing.Size(180, 22);
            this.btn_products_info.Text = "تعریف کالا";
            this.btn_products_info.Click += new System.EventHandler(this.btn_products_info_Click);
            // 
            // btn_customers_info
            // 
            this.btn_customers_info.Name = "btn_customers_info";
            this.btn_customers_info.Size = new System.Drawing.Size(180, 22);
            this.btn_customers_info.Text = "تعریف اشخاص";
            this.btn_customers_info.Click += new System.EventHandler(this.btn_customers_info_Click);
            // 
            // btn_users_info
            // 
            this.btn_users_info.Name = "btn_users_info";
            this.btn_users_info.Size = new System.Drawing.Size(180, 22);
            this.btn_users_info.Text = "تعریف کاربر";
            // 
            // btn_import_export
            // 
            this.btn_import_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_products_import,
            this.btn_products_export,
            this.btn_add_products_inventory});
            this.btn_import_export.Name = "btn_import_export";
            this.btn_import_export.Size = new System.Drawing.Size(97, 20);
            this.btn_import_export.Text = "ورود و خروج کالا";
            // 
            // btn_products_import
            // 
            this.btn_products_import.Name = "btn_products_import";
            this.btn_products_import.Size = new System.Drawing.Size(161, 22);
            this.btn_products_import.Text = "ورود کالا";
            // 
            // btn_products_export
            // 
            this.btn_products_export.Name = "btn_products_export";
            this.btn_products_export.Size = new System.Drawing.Size(161, 22);
            this.btn_products_export.Text = "خروج کالا";
            // 
            // btn_add_products_inventory
            // 
            this.btn_add_products_inventory.Name = "btn_add_products_inventory";
            this.btn_add_products_inventory.Size = new System.Drawing.Size(161, 22);
            this.btn_add_products_inventory.Text = "افزودن کالا به انبار";
            // 
            // btn_inventory_exchange
            // 
            this.btn_inventory_exchange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_set_inventory_exchange});
            this.btn_inventory_exchange.Name = "btn_inventory_exchange";
            this.btn_inventory_exchange.Size = new System.Drawing.Size(88, 20);
            this.btn_inventory_exchange.Text = "جابه جایی انبار";
            // 
            // btn_set_inventory_exchange
            // 
            this.btn_set_inventory_exchange.Name = "btn_set_inventory_exchange";
            this.btn_set_inventory_exchange.Size = new System.Drawing.Size(143, 22);
            this.btn_set_inventory_exchange.Text = "ثبت جابه جایی";
            // 
            // btn_reports
            // 
            this.btn_reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_customers_report,
            this.btn_inventories_report,
            this.btn_products_report,
            this.btn_groups_report,
            this.btn_initial_inventory_report,
            this.btn_import_report,
            this.btn_export_report,
            this.bt_exchange_report});
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(60, 20);
            this.btn_reports.Text = "گزارشات";
            // 
            // btn_customers_report
            // 
            this.btn_customers_report.Name = "btn_customers_report";
            this.btn_customers_report.Size = new System.Drawing.Size(180, 22);
            this.btn_customers_report.Text = "گزارش اشخاص";
            this.btn_customers_report.Click += new System.EventHandler(this.btn_customers_report_Click);
            // 
            // btn_inventories_report
            // 
            this.btn_inventories_report.Name = "btn_inventories_report";
            this.btn_inventories_report.Size = new System.Drawing.Size(180, 22);
            this.btn_inventories_report.Text = "گزارش انبار";
            // 
            // btn_products_report
            // 
            this.btn_products_report.Name = "btn_products_report";
            this.btn_products_report.Size = new System.Drawing.Size(180, 22);
            this.btn_products_report.Text = "گزارش کالا";
            this.btn_products_report.Click += new System.EventHandler(this.btn_products_report_Click);
            // 
            // btn_groups_report
            // 
            this.btn_groups_report.Name = "btn_groups_report";
            this.btn_groups_report.Size = new System.Drawing.Size(180, 22);
            this.btn_groups_report.Text = "گزارش گروه کالا";
            // 
            // btn_initial_inventory_report
            // 
            this.btn_initial_inventory_report.Name = "btn_initial_inventory_report";
            this.btn_initial_inventory_report.Size = new System.Drawing.Size(180, 22);
            this.btn_initial_inventory_report.Text = "گزارش موجودی انبار";
            // 
            // btn_import_report
            // 
            this.btn_import_report.Name = "btn_import_report";
            this.btn_import_report.Size = new System.Drawing.Size(180, 22);
            this.btn_import_report.Text = "گزارش ورود کالا";
            // 
            // btn_export_report
            // 
            this.btn_export_report.Name = "btn_export_report";
            this.btn_export_report.Size = new System.Drawing.Size(180, 22);
            this.btn_export_report.Text = "گزارش خروج کالا";
            // 
            // bt_exchange_report
            // 
            this.bt_exchange_report.Name = "bt_exchange_report";
            this.bt_exchange_report.Size = new System.Drawing.Size(180, 22);
            this.bt_exchange_report.Text = "گزارش جابه جایی انبار";
            // 
            // btn_database_management
            // 
            this.btn_database_management.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_backup,
            this.btn_restore});
            this.btn_database_management.Name = "btn_database_management";
            this.btn_database_management.Size = new System.Drawing.Size(129, 20);
            this.btn_database_management.Text = "مدیریت بانک اطلاعاتی";
            // 
            // btn_backup
            // 
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(148, 22);
            this.btn_backup.Text = "پشتیبان گیری";
            // 
            // btn_restore
            // 
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(148, 22);
            this.btn_restore.Text = "بازیابی پشتیبان";
            // 
            // btn_exit
            // 
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(44, 20);
            this.btn_exit.Text = "خروج";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 201);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 240);
            this.MinimumSize = new System.Drawing.Size(600, 240);
            this.Name = "FormMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار انبارداری";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_basic_info;
        private System.Windows.Forms.ToolStripMenuItem btn_company_info;
        private System.Windows.Forms.ToolStripMenuItem btn_inventory_info;
        private System.Windows.Forms.ToolStripMenuItem btn_groups_info;
        private System.Windows.Forms.ToolStripMenuItem btn_products_info;
        private System.Windows.Forms.ToolStripMenuItem btn_customers_info;
        private System.Windows.Forms.ToolStripMenuItem btn_import_export;
        private System.Windows.Forms.ToolStripMenuItem btn_products_import;
        private System.Windows.Forms.ToolStripMenuItem btn_products_export;
        private System.Windows.Forms.ToolStripMenuItem btn_add_products_inventory;
        private System.Windows.Forms.ToolStripMenuItem btn_inventory_exchange;
        private System.Windows.Forms.ToolStripMenuItem btn_set_inventory_exchange;
        private System.Windows.Forms.ToolStripMenuItem btn_reports;
        private System.Windows.Forms.ToolStripMenuItem btn_customers_report;
        private System.Windows.Forms.ToolStripMenuItem btn_inventories_report;
        private System.Windows.Forms.ToolStripMenuItem btn_products_report;
        private System.Windows.Forms.ToolStripMenuItem btn_groups_report;
        private System.Windows.Forms.ToolStripMenuItem btn_initial_inventory_report;
        private System.Windows.Forms.ToolStripMenuItem btn_import_report;
        private System.Windows.Forms.ToolStripMenuItem btn_export_report;
        private System.Windows.Forms.ToolStripMenuItem bt_exchange_report;
        private System.Windows.Forms.ToolStripMenuItem btn_database_management;
        private System.Windows.Forms.ToolStripMenuItem btn_backup;
        private System.Windows.Forms.ToolStripMenuItem btn_restore;
        private System.Windows.Forms.ToolStripMenuItem btn_exit;
        private System.Windows.Forms.ToolStripMenuItem btn_users_info;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

