using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readwriteCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_readcsv_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("test.csv", Encoding.GetEncoding("UTF-8"));

            label_contents.Text = reader.ReadLine() + Environment.NewLine;
            List<Student> students = new List<Student>();
            List<Student_Gridview> student_Gridviews = new List<Student_Gridview>();

            while(!reader.EndOfStream)//아무것도 없을 때까지 읽음
            {
                string[] temp = reader.ReadLine().Split(',');
                string name = temp[0];
                int age = int.Parse(temp[1]);
                string hakbeon = temp[2];
                string hakgwa = temp[3];
                string gender = temp[4];
                Student st = new Student(name, age, hakbeon, hakgwa, gender);
                students.Add(st);
                student_Gridviews.Add(new Student_Gridview(name, age, hakbeon, hakgwa, gender));
            }

            for(int i=0; i < students.Count; i++)
            {
                label_contents.Text += students[i].Name + " " + students[i].Age + " " + students[i].Hakbeon
                    + " " + students[i].Hakgwa + " " + students[i].Gender + Environment.NewLine;
            }
            reader.Dispose();//개체에 사용되는 리소스 모두 해체
            dataGridView1.DataSource = student_Gridviews;
        }

        private void button_writeCSV_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter("test.csv", true);
            write.WriteLine($"{textBox_name.Text},{textBox_age.Text},{textBox_hakbeon.Text},{textBox_hakgwa.Text},{textBox_gender.Text}");
            write.Dispose();
        }
    }
}
