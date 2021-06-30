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
    class DBHelper_MySql:DBHelper
    {
        public MySqlConnection MyConn = new MySqlConnection();
        public new MySqlDataAdapter da;
        //public static DataSet ds;

        public override void ConnectDB()
        {
            try
            {

                string pwd = "dlwls2955";
                string dbName = "MYDB";
                string strConn = "Server=localhost;" + "Database=" + dbName + ";" +
                    "Uid=root;" + "pwd=" + pwd + ";" + "Charset=utf8";
                MyConn = new MySqlConnection(strConn);
                MyConn.Open();
            }
            catch (Exception)
            {

            }
        }
        public override void Query_Select()
        {
            ConnectDB();
            string sql = " select * from tb_cust";
            da = new MySqlDataAdapter();
            MySqlCommand cmd = MyConn.CreateCommand();
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            ds = new DataSet();
            da.Fill(ds, "tb_cust");
            MyConn.Close();
        }
        public override void Query_Insert(string cust_id, string birth_dt)
        {
            ConnectDB();
            string sqlcommand = $"insert into " +
                        $"TB_CUST(CUST_ID,BIRTH_DT)" +
                        $"values ('{cust_id}','{birth_dt}')";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, MyConn);
            cmd.ExecuteNonQuery();
            MyConn.Close();
        }
        public override void Query_Update(string cust_id, string birth_dt)
        {
            ConnectDB();
            string sqlcommand = $"update tb_cust set cust_id={cust_id},birth_dt={birth_dt}";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, MyConn);
            cmd.ExecuteNonQuery();
            MyConn.Close();
        }
        public override void Query_Delete()
        {
            ConnectDB();
            string sqlcommand = $"delete from tb_cust";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, MyConn);
            cmd.ExecuteNonQuery();
            MyConn.Close();
        }
       
    }
}
