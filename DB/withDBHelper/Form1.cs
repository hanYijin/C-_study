using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace withDBHelper
{
    public partial class Form1 : Form
    {
        //DBhelper dh;
        public Form1()
        {
            InitializeComponent();
            //dh = new DBhelper().getInstance();
            //DBhelper dh = new DBhelper();
            //dh.ex1 = 100;
            //dh.ex2 = 200;
            //dh.example();
        }
        public void DBSelect()
        {
            DBhelper.Query_Select();
            dataGridView1.DataSource = DBhelper.ds;
            dataGridView1.DataMember = "TB_CUST";
        }
        private void DBinsert()
        {
            DBhelper.Query_Insert(textBox_ID.Text, textBox_Birth.Text);
        }
        private void DBupdate()
        {
            DBhelper.Query_Update(textBox_ID.Text, textBox_Birth.Text, dataGridView1);
        }
        private void DBdelete()
        {
            DBhelper.Query_Delete(dataGridView1);
        }
        private void button_select_Click(object sender, EventArgs e)
        {

            DBSelect();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            DBinsert();
            DBSelect();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            DBupdate();
            DBSelect();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DBdelete();
            DBSelect();

        }

        
    }
}
