using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
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
    class DBHelper_Oracle:DBHelper
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
                            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
                            "User Id=AI;Password=1234;";
        public  OracleCommand cmd = new OracleCommand();
        public  OracleConnection oraConn;
        public new OracleDataAdapter da;
        //public static DataSet ds;

        public override void ConnectDB()
        {
            oraConn = new OracleConnection(ORADB);
            oraConn.Open();
           
        }
        public override void Query_Select()
        {
            ConnectDB();
            string sql = "select * from tb_cust";
            da = new OracleDataAdapter();
            da.SelectCommand = new OracleCommand();
            da.SelectCommand.Connection = oraConn;
            da.SelectCommand.CommandText = sql;
            ds = new DataSet();
            da.Fill(ds, "tb_cust");
            oraConn.Close();

           
        }
        public override void Query_Insert(string cust_id, string birth_dt)
        {
            ConnectDB();
            string sqlcommand = $"insert into " +
                        $"TB_CUST(CUST_ID,BIRTH_DT)" +
                        $"values ('{cust_id}','{birth_dt}')";
            cmd.Connection = oraConn;
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            oraConn.Close();
        }

        public override void Query_Update(string cust_id, string birth_dt)
        {
            ConnectDB();
            string sqlcommand = $"update tb_cust set cust_id={cust_id},birth_dt={birth_dt}";
            cmd.Connection = oraConn;
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            oraConn.Close();
        }
        public override void Query_Delete()
        {
            ConnectDB();
            string sqlcommand = $"delete from tb_cust";
            cmd.Connection = oraConn;
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            oraConn.Close();
        }
    }
}
