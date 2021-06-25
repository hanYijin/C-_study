using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBwithClass
{
    class DataManager_MySql
    {
        public static List<TB_Cust> tb_custs = new List<TB_Cust>();
        public static void Load()
        {
            DBHelper_MySql.Query_Select();
            tb_custs.Clear();
            foreach(DataRow item in DBHelper_MySql.ds.Tables[0].Rows)
            {
                TB_Cust temp = new TB_Cust();
                temp.cust_id = item["CUST_ID"].ToString();
                temp.birth_dt = item["BIRTH_DT"].ToString();
                tb_custs.Add(temp);
            }
        }

        internal static void select()
        {
            DBHelper_MySql.Query_Select();
        }

        public static void save()
        {
            DBHelper_MySql.Query_Delete();

            foreach (TB_Cust item in tb_custs)
            {
                DBHelper_MySql.Query_Insert(item.cust_id, item.birth_dt);
            }
           
        }
    }
}
