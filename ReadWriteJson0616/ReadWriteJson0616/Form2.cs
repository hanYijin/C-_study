using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteJson0616
{
    public partial class Form2 : Form
    {
        public List<Member> members = new List<Member>();
        public Form2()
        {
            InitializeComponent();
        }

        private void bnt_MemberWrite_Click(object sender, EventArgs e)
        {
            var jmemberArray = new JArray();
            var jmemberObject = new JObject();

            if (members.Count > 0)
            {
                foreach(var item in members)
                {
                    jmemberObject.Add("id", item.id);
                    jmemberObject.Add("name", item.name);
                    jmemberObject.Add("pw", item.pw);
                    jmemberObject.Add("tel", item.tel);
                    jmemberObject.Add("address", item.address);
                }
            }
            jmemberObject = new JObject();
            jmemberObject.Add("id", tb_id.Text);
            jmemberObject.Add("name", tb_name.Text);
            jmemberObject.Add("pw", tb_pw.Text);
            //jmemberObject.Add("tel", tb);
            //jmemberObject.Add("address", item.address);

        }
    }
}
