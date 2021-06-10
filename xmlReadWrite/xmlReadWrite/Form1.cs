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
using System.Xml.Linq;

namespace xmlReadWrite
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_readXML_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> temp = new List<int>();
                temp.Add(10);
                temp.Add(5);
                temp.Add(500);

                foreach(int item in temp)
                {
                    Console.WriteLine(item);
                }

                //parse
                //문자열을 숫자 변환하는 방법
                //1.
                int num1 = int.Parse("123");
                //2. 
                int num2 = 0;
                int.TryParse("123", out num2);

                int.TryParse("123", out int num3);
                int result = num1 + num2;
                Console.WriteLine(result);
                //3. 1번 방법으로 하되, try catch로 감싼다.

                //xml 파일 읽기
                string xmlfile = File.ReadAllText("Student.xml");
                XElement student_xml = XElement.Parse(xmlfile);

                //읽기 누를때 마다 그리드뷰 늘어나는 이슈 수정
                students.Clear();
                //Descendants(XName):이 문서 또는 요소의 하위 요소가 문서순으로 들어 있는 필터링된 컬렉션을 반환합니다. 
                //일치하는 XName이 있는 요소만 컬렉션에 포함됩니다.
                foreach (var item in student_xml.Descendants("student"))
                {
                    string name = item.Element("name").Value;
                    int age = int.Parse(item.Element("age").Value); // 문자열을 숫자로 반환 int.Parse
                    string hakbeon = item.Element("hakbeon").Value;
                    string hakgwa = item.Element("hakgwa").Value;
                    string gender = item.Element("gender").Value;

                    students.Add(new Student(name, age, hakbeon, hakgwa, gender));

                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = students;
            }catch(Exception ee)
            {

            }
        }

        private void button_writeXML_Click(object sender, EventArgs e)
        {
            students.Add(new Student(textBox_name.Text, int.Parse(textBox_age.Text),textBox_hakbeon.Text,textBox_hakgwa.Text,
                comboBox_gender.Text));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;

            string input = "<students>\n";
            foreach(var item in students)
            {
                input += "  <student>" + Environment.NewLine;//이 환경에 대해 정의된 줄 바꿈 문자열
                input += $"     <name>{item.name}</name>{Environment.NewLine}";
                input += $"     <age>{item.age}</age>{Environment.NewLine}";
                input += $"     <hakbeon>{item.hakbeon}</hakbeon>{Environment.NewLine}";
                input += $"     <hakgwa>{item.hakgwa}</hakgwa>{Environment.NewLine}";
                input += $"     <gender>{item.gender}</gender>{Environment.NewLine}";
                input += "  </student>\n";
            }
            input += "</students>";
            File.WriteAllText("Student.xml", input);
        }
    }
}
