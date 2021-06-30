using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obsever0630
{
    public partial class Form1 : Form,Subject
    {
        Form2 frm2 = null;
        Form3 frm3 = null;
        Form4 frm4 = null;
        
        IList observers = new ArrayList(); //IList는 interface
        //List<Obsever> obs = new List<Obsever>();

        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2(this);
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm2);
            frm2.Show();

            frm3 = new Form3(this);
            frm3.TopLevel = false;
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.Dock = DockStyle.Fill;
            panel2.Controls.Add(frm3);
            frm3.Show();

            frm4 = new Form4(this,frm2);
            frm4.TopLevel = false;
            frm4.FormBorderStyle = FormBorderStyle.None;
            frm4.Dock = DockStyle.Fill;
            panel3.Controls.Add(frm4);
            frm4.Show();
        }

        public void notifyObservers()
        {
            //throw new NotImplementedException();
            foreach(Obsever item in observers)
            {
                item.update(textBox1.Text);
            }
        }

        public void register(Obsever o)
        {
            observers.Add(o);
        }

        public void remove(Obsever o)
        {
            observers.Remove(o);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                notifyObservers();
            }
        }
    }
}
