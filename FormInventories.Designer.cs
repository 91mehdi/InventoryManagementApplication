
namespace InventoryManagementApplication
{
    partial class FormInventories
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_telephone);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_name);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txt_code);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(584, 39);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(216, 13);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(112, 23);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام انبار";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(389, 12);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(112, 23);
            this.txt_code.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "کد انبار";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView);
            this.groupBox3.Location = new System.Drawing.Point(0, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 105);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(578, 83);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseUp);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(497, 162);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(175, 162);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 33);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "حذف";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 162);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 33);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "ذخیره";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_telephone
            // 
            this.txt_telephone.Location = new System.Drawing.Point(22, 13);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(123, 23);
            this.txt_telephone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "تلفن انبار";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(83, 41);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(479, 23);
            this.txt_address.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "آدرس انبار";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(93, 162);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 33);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "ویرایش";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // FormInventories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 201);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInventories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف انبار";
            this.Load += new System.EventHandler(this.FormInventories_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_edit;
    }
}