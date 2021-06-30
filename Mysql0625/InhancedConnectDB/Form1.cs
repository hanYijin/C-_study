using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InhancedConnectDB
{
    public partial class Form1 : Form
    {
        //괄호 안에 숫자를 1=mySql 2= oracle
        //입력하지 않으면 mssql
        DataManager instance = new DataManager();
        public Form1()
        {
            InitializeComponent();
        }
        private void DataLoad()
        {
            instance.Load();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = instance.tb_custs;

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
            instance.tb_custs.Add(temp);
            instance.save();
            DataLoad();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                TB_Cust temp = instance.tb_custs.Single((x) => x.cust_id.Trim().ToString() == textBox_ID.Text);
                //x는 객체
                //DataManager.tb_custs.Remove(temp);
                temp.birth_dt = textBox_Birth.Text;
                instance.save();
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
                TB_Cust temp = instance.tb_custs.Single((x) => x.cust_id.Trim().ToString() == textBox_ID.Text);
                //x는 객체
                instance.tb_custs.Remove(temp);
                instance.save();
                DataLoad();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
