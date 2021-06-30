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
    public partial class Form3 : Form, Obsever
    {
        public Form3(Subject sub)
        {
            sub.register(this);
            InitializeComponent();
        }

        public void update(string value)
        {
            ReadOnly_true.Text=value;
        }
    }
}
