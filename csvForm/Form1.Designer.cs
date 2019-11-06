namespace csvForm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_exportCSV = new System.Windows.Forms.TextBox();
            this.btn_importCSV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_importCSV = new System.Windows.Forms.TextBox();
            this.btn_exportCSV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_SQLCom = new System.Windows.Forms.TextBox();
            this.btn_SQLCom = new System.Windows.Forms.Button();
            this.btn_SQLSearch50 = new System.Windows.Forms.Button();
            this.btn_SQLClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SQLServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_SQLSelect = new System.Windows.Forms.ComboBox();
            this.txt_SQLDB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SQLConfirm = new System.Windows.Forms.Button();
            this.txt_SQLAccount = new System.Windows.Forms.TextBox();
            this.txt_SQLPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CSVtoSQL = new System.Windows.Forms.Button();
            this.btn_SQLtoCSV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SQLtoCSV);
            this.groupBox1.Controls.Add(this.txt_exportCSV);
            this.groupBox1.Controls.Add(this.btn_CSVtoSQL);
            this.groupBox1.Controls.Add(this.btn_importCSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_importCSV);
            this.groupBox1.Controls.Add(this.btn_exportCSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CSV Controller";
            // 
            // txt_exportCSV
            // 
            this.txt_exportCSV.Location = new System.Drawing.Point(82, 62);
            this.txt_exportCSV.Name = "txt_exportCSV";
            this.txt_exportCSV.Size = new System.Drawing.Size(185, 22);
            this.txt_exportCSV.TabIndex = 5;
            // 
            // btn_importCSV
            // 
            this.btn_importCSV.Location = new System.Drawing.Point(273, 19);
            this.btn_importCSV.Name = "btn_importCSV";
            this.btn_importCSV.Size = new System.Drawing.Size(25, 23);
            this.btn_importCSV.TabIndex = 4;
            this.btn_importCSV.Text = "...";
            this.btn_importCSV.UseVisualStyleBackColor = true;
            this.btn_importCSV.Click += new System.EventHandler(this.btn_importCSV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "匯出路徑:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "匯入CSV:";
            // 
            // txt_importCSV
            // 
            this.txt_importCSV.Location = new System.Drawing.Point(82, 21);
            this.txt_importCSV.Name = "txt_importCSV";
            this.txt_importCSV.Size = new System.Drawing.Size(185, 22);
            this.txt_importCSV.TabIndex = 1;
            // 
            // btn_exportCSV
            // 
            this.btn_exportCSV.Location = new System.Drawing.Point(273, 60);
            this.btn_exportCSV.Name = "btn_exportCSV";
            this.btn_exportCSV.Size = new System.Drawing.Size(25, 23);
            this.btn_exportCSV.TabIndex = 0;
            this.btn_exportCSV.Text = "...";
            this.btn_exportCSV.UseVisualStyleBackColor = true;
            this.btn_exportCSV.Click += new System.EventHandler(this.btn_exportCSV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txt_SQLCom);
            this.groupBox2.Controls.Add(this.btn_SQLCom);
            this.groupBox2.Controls.Add(this.btn_SQLSearch50);
            this.groupBox2.Controls.Add(this.btn_SQLClose);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_SQLServer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.combo_SQLSelect);
            this.groupBox2.Controls.Add(this.txt_SQLDB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_SQLConfirm);
            this.groupBox2.Controls.Add(this.txt_SQLAccount);
            this.groupBox2.Controls.Add(this.txt_SQLPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL Server Controller";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_SQLCom
            // 
            this.txt_SQLCom.Location = new System.Drawing.Point(179, 37);
            this.txt_SQLCom.Name = "txt_SQLCom";
            this.txt_SQLCom.Size = new System.Drawing.Size(190, 22);
            this.txt_SQLCom.TabIndex = 7;
            // 
            // btn_SQLCom
            // 
            this.btn_SQLCom.Enabled = false;
            this.btn_SQLCom.Location = new System.Drawing.Point(179, 70);
            this.btn_SQLCom.Name = "btn_SQLCom";
            this.btn_SQLCom.Size = new System.Drawing.Size(190, 23);
            this.btn_SQLCom.TabIndex = 18;
            this.btn_SQLCom.Text = "SQL語法搜尋";
            this.btn_SQLCom.UseVisualStyleBackColor = true;
            this.btn_SQLCom.Click += new System.EventHandler(this.btn_SQLCom_Click);
            // 
            // btn_SQLSearch50
            // 
            this.btn_SQLSearch50.Enabled = false;
            this.btn_SQLSearch50.Location = new System.Drawing.Point(179, 105);
            this.btn_SQLSearch50.Name = "btn_SQLSearch50";
            this.btn_SQLSearch50.Size = new System.Drawing.Size(190, 23);
            this.btn_SQLSearch50.TabIndex = 17;
            this.btn_SQLSearch50.Text = "搜尋前50筆資料";
            this.btn_SQLSearch50.UseVisualStyleBackColor = true;
            this.btn_SQLSearch50.Click += new System.EventHandler(this.btn_SQLSearch50_Click);
            // 
            // btn_SQLClose
            // 
            this.btn_SQLClose.Location = new System.Drawing.Point(23, 262);
            this.btn_SQLClose.Name = "btn_SQLClose";
            this.btn_SQLClose.Size = new System.Drawing.Size(150, 23);
            this.btn_SQLClose.TabIndex = 15;
            this.btn_SQLClose.Text = "中斷連接";
            this.btn_SQLClose.UseVisualStyleBackColor = true;
            this.btn_SQLClose.Click += new System.EventHandler(this.btn_SQLClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Server:";
            // 
            // txt_SQLServer
            // 
            this.txt_SQLServer.Location = new System.Drawing.Point(59, 107);
            this.txt_SQLServer.Name = "txt_SQLServer";
            this.txt_SQLServer.Size = new System.Drawing.Size(114, 22);
            this.txt_SQLServer.TabIndex = 13;
            this.txt_SQLServer.Text = "localhost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Table:";
            // 
            // combo_SQLSelect
            // 
            this.combo_SQLSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_SQLSelect.Enabled = false;
            this.combo_SQLSelect.FormattingEnabled = true;
            this.combo_SQLSelect.Location = new System.Drawing.Point(59, 177);
            this.combo_SQLSelect.Name = "combo_SQLSelect";
            this.combo_SQLSelect.Size = new System.Drawing.Size(114, 20);
            this.combo_SQLSelect.TabIndex = 11;
            this.combo_SQLSelect.SelectedIndexChanged += new System.EventHandler(this.combo_SQLSelect_SelectedIndexChanged);
            // 
            // txt_SQLDB
            // 
            this.txt_SQLDB.Location = new System.Drawing.Point(59, 142);
            this.txt_SQLDB.Name = "txt_SQLDB";
            this.txt_SQLDB.Size = new System.Drawing.Size(114, 22);
            this.txt_SQLDB.TabIndex = 10;
            this.txt_SQLDB.Text = "testDB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "DB:";
            // 
            // btn_SQLConfirm
            // 
            this.btn_SQLConfirm.Location = new System.Drawing.Point(23, 223);
            this.btn_SQLConfirm.Name = "btn_SQLConfirm";
            this.btn_SQLConfirm.Size = new System.Drawing.Size(150, 23);
            this.btn_SQLConfirm.TabIndex = 8;
            this.btn_SQLConfirm.Text = "連線驗證";
            this.btn_SQLConfirm.UseVisualStyleBackColor = true;
            this.btn_SQLConfirm.Click += new System.EventHandler(this.btn_SQLConfirm_Click);
            // 
            // txt_SQLAccount
            // 
            this.txt_SQLAccount.Location = new System.Drawing.Point(61, 37);
            this.txt_SQLAccount.Name = "txt_SQLAccount";
            this.txt_SQLAccount.Size = new System.Drawing.Size(112, 22);
            this.txt_SQLAccount.TabIndex = 6;
            this.txt_SQLAccount.Text = "sa";
            // 
            // txt_SQLPassword
            // 
            this.txt_SQLPassword.Location = new System.Drawing.Point(59, 72);
            this.txt_SQLPassword.Name = "txt_SQLPassword";
            this.txt_SQLPassword.PasswordChar = '*';
            this.txt_SQLPassword.Size = new System.Drawing.Size(114, 22);
            this.txt_SQLPassword.TabIndex = 7;
            this.txt_SQLPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SQLPassword_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "密碼:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "帳號:";
            // 
            // btn_CSVtoSQL
            // 
            this.btn_CSVtoSQL.Location = new System.Drawing.Point(308, 19);
            this.btn_CSVtoSQL.Name = "btn_CSVtoSQL";
            this.btn_CSVtoSQL.Size = new System.Drawing.Size(84, 22);
            this.btn_CSVtoSQL.TabIndex = 2;
            this.btn_CSVtoSQL.Text = "CSV -> SQL";
            this.btn_CSVtoSQL.UseVisualStyleBackColor = true;
            this.btn_CSVtoSQL.Click += new System.EventHandler(this.btn_CSVtoSQL_Click);
            // 
            // btn_SQLtoCSV
            // 
            this.btn_SQLtoCSV.Location = new System.Drawing.Point(308, 60);
            this.btn_SQLtoCSV.Name = "btn_SQLtoCSV";
            this.btn_SQLtoCSV.Size = new System.Drawing.Size(84, 22);
            this.btn_SQLtoCSV.TabIndex = 3;
            this.btn_SQLtoCSV.Text = "SQL -> CSV";
            this.btn_SQLtoCSV.UseVisualStyleBackColor = true;
            this.btn_SQLtoCSV.Click += new System.EventHandler(this.btn_SQLtoCSV_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 425);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_exportCSV;
        private System.Windows.Forms.Button btn_importCSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_importCSV;
        private System.Windows.Forms.Button btn_exportCSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_SQLSelect;
        private System.Windows.Forms.TextBox txt_SQLDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SQLConfirm;
        private System.Windows.Forms.TextBox txt_SQLAccount;
        private System.Windows.Forms.TextBox txt_SQLPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CSVtoSQL;
        private System.Windows.Forms.Button btn_SQLtoCSV;
        private System.Windows.Forms.TextBox txt_SQLServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_SQLClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_SQLSearch50;
        private System.Windows.Forms.TextBox txt_SQLCom;
        private System.Windows.Forms.Button btn_SQLCom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

