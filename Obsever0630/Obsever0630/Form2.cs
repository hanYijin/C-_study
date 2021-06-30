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
    public partial class Form2 : Form, Obsever
    {
        
        public Form2(Subject sub)
        {
            sub.register(this);
            InitializeComponent();
        }

        public void update(string value)
        {
            //throw new NotImplementedException();
            ReadOnly_true.Text = value;

        }
    }
}
