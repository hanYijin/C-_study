using System;
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
    public partial class Form4 : Form, Obsever
    {
        Form2 frm2;
        Subject sub;

        public Form4(Subject sub, Form2 frm2)
        {
            this.sub = sub;
            this.frm2 = frm2;
            InitializeComponent();
        }

        public void update(string value)
        {
            //throw new NotImplementedException();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sub.register(frm2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sub.remove(frm2);
        }
    }
}
