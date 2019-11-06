using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //參考SQL

namespace csvForm
{
    public partial class Form1 : Form
    {
        SqlConnection cnn;
        string connetionString;
        string cnnTable;
        DataTable csvFile = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_importCSV_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                ofd.Title = "Open a CSV File";
                if (ofd.ShowDialog(this) == DialogResult.Cancel) return;
                txt_importCSV.Text = ofd.FileName;
                //讀取中...
                csvFile = ReadCSV(txt_importCSV.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "讀取失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_exportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                saveFileDialog1.Title = "Save a CSV File";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    txt_exportCSV.Text = saveFileDialog1.FileName;
                    //存檔中...
                    //SaveCSV(csvFile,txt_exportCSV.Text);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "存檔失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ReadCSV(string filePath)
        {
            DataTable dt = new DataTable();
            FileStream fs = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string strLine = "";
            string[] aryLine = null;
            string[] tableHead = null;
            bool IsFirst = true;    //是否讀取第一行 (CSV第一列 有機會會是表格名稱)
            while ((strLine = sr.ReadLine()) != null)
            {
                if (IsFirst == true)
                {
                    tableHead = strLine.Split(',');
                    IsFirst = false;
                    //創建列
                    for (int i = 0; i < tableHead.Length; i++)
                    {
                        tableHead[i] = tableHead[i].Replace("\"", "");
                        DataColumn dc = new DataColumn(tableHead[i]);
                        dt.Columns.Add(dc);
                    }
                }
                else
                {
                    aryLine = strLine.Split(',');
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < tableHead.Length; j++)
                    {
                        dr[j] = aryLine[j].Replace("\"", "");
                    }
                    dt.Rows.Add(dr);
                }
            }

            if (aryLine != null && aryLine.Length > 0)
            {
                dt.DefaultView.Sort = tableHead[2] + " " + "DESC";
            }
            sr.Close();
            fs.Close();

            return dt;
        }
        public static bool SaveCSV(DataTable dt, string fullPath)
        {
            try
            {   
                // 檢查是否已經有檔案存在，沒有則新增
                FileInfo fi = new FileInfo(fullPath);
                if (!fi.Directory.Exists)
                {
                    fi.Directory.Create();
                }
                FileStream fs = new FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                //StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
                string data = "";
                //寫出列名稱
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data += "\"" + dt.Columns[i].ColumnName.ToString() + "\"";
                    if (i < dt.Columns.Count - 1)
                    {
                        data += ",";
                    }
                }
                sw.WriteLine(data);
                //寫出各行數據
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    data = "";
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        string str = dt.Rows[i][j].ToString();
                        str = string.Format("\"{0}\"", str);
                        data += str;
                        if (j < dt.Columns.Count - 1)
                        {
                            data += ",";
                        }
                    }
                    sw.WriteLine(data); //將stream寫入CSV
                }
                sw.Close();
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "存檔失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        public static SqlConnection OpenSqlConn(string Server, string Database, string dbuid, string dbpwd)
        {
            string cnstr = string.Format("server={0};database={1};uid={2};pwd={3};Connect Timeout = 180", Server, Database, dbuid, dbpwd);
            SqlConnection icn = new SqlConnection();
            icn.ConnectionString = cnstr;
            if (icn.State == ConnectionState.Open) icn.Close();
            icn.Open();
            return icn;
        }

        public static DataTable GetSqlDataTable(string Server, string Database, string dbuid, string dbpwd, string SqlString)
        {
            DataTable myDataTable = new DataTable();
            SqlConnection icn = null;
            icn = OpenSqlConn(Server, Database, dbuid, dbpwd);
            SqlCommand isc = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(isc);
            isc.Connection = icn;
            isc.CommandText = SqlString;
            isc.CommandTimeout = 600;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            myDataTable = ds.Tables[0];
            if (icn.State == ConnectionState.Open) icn.Close();
            return myDataTable;
        }

        public static void SqlInsertUpdateDelete(string Server, string Database, string dbuid, string dbpwd, string SqlSelectString)
        {
            SqlConnection icn = OpenSqlConn(Server, Database, dbuid, dbpwd);
            SqlCommand cmd = new SqlCommand(SqlSelectString, icn);
            SqlTransaction mySqlTransaction = icn.BeginTransaction();
            try
            {
                cmd.Transaction = mySqlTransaction;
                cmd.ExecuteNonQuery();
                mySqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                mySqlTransaction.Rollback();
                throw (ex);
            }
            if (icn.State == ConnectionState.Open) icn.Close();
        }
        private void btn_SQLConfirm_Click(object sender, EventArgs e)
        {
            
            connetionString = "server=" + txt_SQLServer.Text + ";database=" + txt_SQLDB.Text + ";UID=" + txt_SQLAccount.Text + ";PWD=" + txt_SQLPassword.Text;
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("驗證成功!", "連線訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Text = "SQL連線中...";

                btn_SQLCom.Enabled = true;
                btn_SQLSearch50.Enabled = true;
                dateTimePicker1.Enabled = true;
                //下拉清單，顯示所有table
                combo_SQLSelect.Enabled = true;
                DataTable tableNames = cnn.GetSchema("Tables");
                foreach (DataRow row in tableNames.Rows)
                {
                    string tablename = (string)row[2];
                    combo_SQLSelect.Items.Add(tablename);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"帳戶驗證失敗",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Text = "From 1";
            }
        }


        private void combo_SQLSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnnTable = combo_SQLSelect.Text;
            SqlCommand cmd = new SqlCommand("SELECT * From " + cnnTable, cnn);
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            da.Dispose();
            dataGridView1.DataSource = dataTable;
            csvFile = dataTable;
   
        }
        private void btn_SQLSearch50_Click(object sender, EventArgs e)
        {
            cnnTable = combo_SQLSelect.Text;
            // SqlCommand cmd = new SqlCommand("SELECT TOP 50 * From " + cnnTable, cnn);
            txt_SQLCom.Text = "SELECT TOP 50 * From " + cnnTable;
        }

        private void btn_SQLCom_Click(object sender, EventArgs e)
        {
            try
            {
                cnnTable = combo_SQLSelect.Text;
                SqlCommand cmd = new SqlCommand(txt_SQLCom.Text, cnn);
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                da.Dispose();
                dataGridView1.DataSource = dataTable;
                csvFile = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // dateTimePicker1.Value.AddDays(1).ToShortDateString();  //加1天
            cnnTable = combo_SQLSelect.Text;
            txt_SQLCom.Text = "SELECT * " +
                              "From " + cnnTable + " WHERE CDATETIME BETWEEN "  +
                              "'" + dateTimePicker1.Value.ToShortDateString() + "'" +" AND " + "'" + dateTimePicker1.Value.AddDays(1).ToShortDateString() + "' " +
                              "ORDER BY CDATETIME";

        }
        private void btn_SQLClose_Click(object sender, EventArgs e)
        {
            cnn.Close();
            this.Text = "From 1";
            combo_SQLSelect.Items.Clear();
            btn_SQLCom.Enabled = false;
            btn_SQLSearch50.Enabled = false;
            dateTimePicker1.Enabled = false;
            combo_SQLSelect.Enabled = false;
            txt_SQLCom.Text = "";
            dataGridView1.DataSource = null;  

            MessageBox.Show("SQL中斷連線!", "連線訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_CSVtoSQL_Click(object sender, EventArgs e)
        {

        }

        private void btn_SQLtoCSV_Click(object sender, EventArgs e)
        {
            try
            {
                SaveCSV(csvFile, txt_exportCSV.Text);
                MessageBox.Show("存檔完成", "檔案訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
               
        }


        private void txt_SQLPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SQLConfirm.PerformClick(); //執行btn_SQLConfirm   
            }
        }

    }
}
