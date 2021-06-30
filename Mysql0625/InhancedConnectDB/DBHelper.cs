﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InhancedConnectDB
{
    class DBHelper : ICrud
    {
        public SqlConnection conn = new SqlConnection();
        public SqlDataAdapter da;
        public DataSet ds;
        public DataTable dt;

        public DBHelper instance;
        public DBHelper getInstance(int num)
        {
            if(instance == null)
            {
                switch (num)
                {
                    case 1:
                        instance = new DBHelper_MySql();
                        break;
                    case 2:
                        instance = new DBHelper_Oracle();
                        break;
                    default:
                        instance = new DBHelper();
                        break;
                }
            }
            return instance;
        }
        public virtual void ConnectDB()
        {
            string connect = string.Format("Data Source=({0});" +
               "Initial Catalog ={1};" +
               "Integrated Security = {2};" +
               "Timeout = 3",
               "local", "MYDB1", "SSPI");
            conn = new SqlConnection(connect);
            conn.Open();
        }
        public virtual void Query_Select()
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

        public virtual void Query_Delete()
        {
            ConnectDB();
            string sql = "delete from TB_CUST";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public virtual void Query_Insert(string cust_id, string birth_dt)
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
     
        public virtual void Query_Update(string cust_id, string birth_dt)
        {
            ConnectDB();
            string sqlcommand = "update TB_CUST set CUST_ID = @p1, BIRTH_DT = @p2 where CUST_ID= @p3";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", cust_id);
            cmd.Parameters.AddWithValue("@p2", birth_dt);
/*            DataGridViewRow row = dataGridView.SelectedRows[0];
            string selectid = row.Cells[0].Value.ToString();*/
            cmd.Parameters.AddWithValue("@p3", cust_id);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery(); //쿼리 실행
            conn.Close();
        }
        

    }
}
