using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace withDBHelper
{
    class DBhelper
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public int ex1;
        public int ex2;

        public void example()
        {
            System.Windows.Forms.MessageBox.Show(ex1 + " " + ex2);
        }
       /* public DBhelper instance;
        public DBhelper getInstance()
        {
            if (instance == null)
                instance = new DBhelper();
            return instance;
        }*/
        public static void ConnectDB()
        {
            string connect = string.Format("Data Source=({0});" +
               "Initial Catalog ={1};" +
               "Integrated Security = {2};" +
               "Timeout = 3",
               "local", "MYDB1", "SSPI");
            conn = new SqlConnection(connect);
            conn.Open();
        }
        public static void Query_Select()
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn; // DB접속 정보 추가
            //쿼리 추가
            cmd.CommandText = "select * from TB_CUST";
            //DB 접속해서 쿼리 날려서 결과값으로 받은 테이블 관련 정보
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "TB_CUST");//da를 통해서 ds에 테이블 데이터를 넣은다

            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "TB_CUST";

            conn.Close();
        }

        internal static void Query_Delete(DataGridView dataGridView1)
        {
            ConnectDB();
            string sql = "delete from TB_CUST WHERE CUST_ID = @p1";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string selectid = row.Cells[0].Value.ToString();

            cmd.Parameters.AddWithValue("@p1", selectid);

            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void Query_Insert(string cust_id, string birth_dt)
        {
            ConnectDB();
            string sqlcommand = "insert into TB_CUST(CUST_ID,BIRTH_DT) values (@parameter1,@parameter2)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@parameter1", cust_id);
            cmd.Parameters.AddWithValue("@parameter2", birth_dt);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery(); //쿼리 실행
            conn.Close();
        }
/*        public static void Query_Delete(string cust_id, string birth_dt, DataGridViewRow view)
        {
            ConnectDB();
            string sql = "delete from TB_CUST WHERE CUST_ID = @p1";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            string selectid = view.Cells[0].Value.ToString();
            //string selectid = row.Cells[0].Value.ToString();

            cmd.Parameters.AddWithValue("@p1", selectid);

            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }*/
        public static void Query_Update(string cust_id, string birth_dt,DataGridView dataGridView)
        {
            ConnectDB();
            string sqlcommand = "update TB_CUST set CUST_ID = @p1, BIRTH_DT = @p2 where CUST_ID= @p3";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", cust_id);
            cmd.Parameters.AddWithValue("@p2", birth_dt);
            DataGridViewRow row = dataGridView.SelectedRows[0];
            string selectid = row.Cells[0].Value.ToString();
            cmd.Parameters.AddWithValue("@p3", selectid);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery(); //쿼리 실행
            conn.Close();
        }
    }
}
