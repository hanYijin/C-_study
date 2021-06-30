using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhancedConnectDB
{
    class DataManager
    {
        public List<TB_Cust> tb_custs = new List<TB_Cust>();
        public DBHelper instance; //singleton patton
        public DataManager(int db=0)
        {
            instance = new DBHelper().getInstance(db);
        }
        public void Load()
        {
            instance.Query_Select();
            tb_custs.Clear();
            foreach(DataRow item in instance.ds.Tables[0].Rows)
            {
                TB_Cust temp = new TB_Cust();
                temp.cust_id = item["CUST_ID"].ToString();
                temp.birth_dt = item["BIRTH_DT"].ToString();
                tb_custs.Add(temp);
            }
        }

        internal void select()
        {
            instance.Query_Select();
        }

        public void save()
        {
            instance.Query_Delete();
           
            foreach(TB_Cust item in tb_custs)
            {
                instance.Query_Insert(item.cust_id, item.birth_dt);
            }
            /*TB_Cust tB_Cust = new TB_Cust();
            tB_Cust.cust_id = t1;
            tB_Cust.birth_dt = t2;
            tb_custs.Add(tB_Cust);

            foreach(var item in tb_custs)
            {
                DBHelper.Query_Insert(item.cust_id, item.birth_dt);
            }*/
        }
    }
}
