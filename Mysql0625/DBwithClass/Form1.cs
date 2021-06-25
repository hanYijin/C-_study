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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public void DataLoad()
        {
            DataManager.Load();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager.tb_custs;

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
            DataManager.tb_custs.Add(temp);
            DataManager.save();
            DataLoad();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //singleton (useing lamba)
            try
            {
                TB_Cust temp = DataManager.tb_custs.Single((x) => x.cust_id.Trim().ToString() == textBox_ID.Text);
                //x는 객체
                //DataManager.tb_custs.Remove(temp);
                temp.birth_dt = textBox_Birth.Text;
                DataManager.save();
                DataLoad();

            }
            catch (Exception ex)
            {

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //singleton (useing lamba)
            try
            {
                TB_Cust temp = DataManager.tb_custs.Single((x) => x.cust_id.Trim().ToString() == textBox_ID.Text);
                //x는 객체
                DataManager.tb_custs.Remove(temp);
                DataManager.save();
                DataLoad();

            }catch(Exception ex)
            {
                
            }
        }

        private void button_Mysql_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button_Oracle_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}
