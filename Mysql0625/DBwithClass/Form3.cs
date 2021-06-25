using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBwithClass
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void DataLoad()
        {
            DataManager_Oracle.Load();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager_Oracle.tb_custs;

        }
        private void button_select_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            TB_Cust temp = new TB_Cust();
            temp.cust_id = textBox_ID.Text;
            temp.birth_dt = textBox_Birth.Text;
            DataManager_Oracle.tb_custs.Add(temp);
            DataManager_Oracle.save();
            DataLoad();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                TB_Cust temp = DataManager_Oracle.tb_custs.Single((x) => x.cust_id.Trim().ToString() == textBox_ID.Text);
                //x는 객체
                //DataManager.tb_custs.Remove(temp);
                temp.birth_dt = textBox_Birth.Text;
                DataManager_Oracle.save();
                DataLoad();

            }
            catch (Exception ex)
            {

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                TB_Cust temp = DataManager_Oracle.tb_custs.Single((x) => x.cust_id.Trim().ToString() == textBox_ID.Text);
                //x는 객체
                DataManager_Oracle.tb_custs.Remove(temp);
                DataManager_Oracle.save();
                DataLoad();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
