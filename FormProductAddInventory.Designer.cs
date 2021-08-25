
namespace InventoryManagementApplication
{
    partial class FormProductAddInventory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_exist = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_entity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_a_scan = new System.Windows.Forms.Button();
            this.txt_a_code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_i_scan = new System.Windows.Forms.Button();
            this.btn_p_scan = new System.Windows.Forms.Button();
            this.txt_p_serial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_p_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_p_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_i_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_i_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_exist);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_entity);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_location);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_a_scan);
            this.groupBox1.Controls.Add(this.txt_a_code);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_i_scan);
            this.groupBox1.Controls.Add(this.btn_p_scan);
            this.groupBox1.Controls.Add(this.txt_p_serial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_p_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_p_code);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_i_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_i_code);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_exist
            // 
            this.txt_exist.Location = new System.Drawing.Point(35, 93);
            this.txt_exist.Name = "txt_exist";
            this.txt_exist.ReadOnly = true;
            this.txt_exist.Size = new System.Drawing.Size(109, 23);
            this.txt_exist.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "اولیه فعلی";
            // 
            // txt_entity
            // 
            this.txt_entity.Location = new System.Drawing.Point(221, 93);
            this.txt_entity.Name = "txt_entity";
            this.txt_entity.Size = new System.Drawing.Size(112, 23);
            this.txt_entity.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "موجودی اولیه";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(426, 93);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(95, 23);
            this.txt_location.TabIndex = 8;
            this.txt_location.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "قفسه";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_a_scan
            // 
            this.btn_a_scan.Location = new System.Drawing.Point(394, 12);
            this.btn_a_scan.Name = "btn_a_scan";
            this.btn_a_scan.Size = new System.Drawing.Size(23, 23);
            this.btn_a_scan.TabIndex = 21;
            this.btn_a_scan.Text = "+";
            this.btn_a_scan.UseVisualStyleBackColor = true;
            this.btn_a_scan.Click += new System.EventHandler(this.btn_a_scan_Click);
            // 
            // txt_a_code
            // 
            this.txt_a_code.Location = new System.Drawing.Point(426, 12);
            this.txt_a_code.Name = "txt_a_code";
            this.txt_a_code.Size = new System.Drawing.Size(95, 23);
            this.txt_a_code.TabIndex = 0;
            this.txt_a_code.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "کد";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_i_scan
            // 
            this.btn_i_scan.Location = new System.Drawing.Point(6, 12);
            this.btn_i_scan.Name = "btn_i_scan";
            this.btn_i_scan.Size = new System.Drawing.Size(23, 23);
            this.btn_i_scan.TabIndex = 3;
            this.btn_i_scan.Text = "+";
            this.btn_i_scan.UseVisualStyleBackColor = true;
            this.btn_i_scan.Click += new System.EventHandler(this.btn_i_scan_Click);
            // 
            // btn_p_scan
            // 
            this.btn_p_scan.Location = new System.Drawing.Point(6, 53);
            this.btn_p_scan.Name = "btn_p_scan";
            this.btn_p_scan.Size = new System.Drawing.Size(23, 23);
            this.btn_p_scan.TabIndex = 7;
            this.btn_p_scan.Text = "+";
            this.btn_p_scan.UseVisualStyleBackColor = true;
            this.btn_p_scan.Click += new System.EventHandler(this.btn_p_scan_Click);
            // 
            // txt_p_serial
            // 
            this.txt_p_serial.Location = new System.Drawing.Point(35, 53);
            this.txt_p_serial.Name = "txt_p_serial";
            this.txt_p_serial.Size = new System.Drawing.Size(110, 23);
            this.txt_p_serial.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "سریال کالا";
            // 
            // txt_p_name
            // 
            this.txt_p_name.Location = new System.Drawing.Point(221, 53);
            this.txt_p_name.Name = "txt_p_name";
            this.txt_p_name.Size = new System.Drawing.Size(147, 23);
            this.txt_p_name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "نام کالا";
            // 
            // txt_p_code
            // 
            this.txt_p_code.Location = new System.Drawing.Point(426, 53);
            this.txt_p_code.Name = "txt_p_code";
            this.txt_p_code.Size = new System.Drawing.Size(95, 23);
            this.txt_p_code.TabIndex = 4;
            this.txt_p_code.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "کد کالا";
            // 
            // txt_i_name
            // 
            this.txt_i_name.Location = new System.Drawing.Point(35, 12);
            this.txt_i_name.Name = "txt_i_name";
            this.txt_i_name.Size = new System.Drawing.Size(112, 23);
            this.txt_i_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "نام انبار";
            // 
            // txt_i_code
            // 
            this.txt_i_code.Location = new System.Drawing.Point(221, 12);
            this.txt_i_code.Name = "txt_i_code";
            this.txt_i_code.Size = new System.Drawing.Size(95, 23);
            this.txt_i_code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "کد انبار";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_back);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 57);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(413, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 33);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "ویرایش";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(497, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 33);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "ذخیره";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // FormProductAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 201);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProductAddInventory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "افزودن کالا به انبار";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_i_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_i_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_p_scan;
        private System.Windows.Forms.TextBox txt_p_serial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_p_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_p_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_a_code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_i_scan;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_a_scan;
        private System.Windows.Forms.TextBox txt_entity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_exist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
    }
}