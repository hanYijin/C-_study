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

namespace csvReadWrite
{
    public partial class Form1 : Form
    {     
        const int NAME= 0;
        const int AGE =1;
        const int HAKBEON = 2;
        const int HAKGWA = 3;
        const int GENDER =4;
        //열거형 코드 조각?
        enum Student_Data
        {
            NAME, AGE, HAKBEON, HAKGWA, GENDER
        }
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button_readCSV_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("test.csv", Encoding.GetEncoding("UTF-8"));
            //가장 첫번째 줄 데이터는 필요없음
            reader.ReadLine();// 가장 첫번쨰 줄 읽기

            List<Student> students = new List<Student>();
            while (!reader.EndOfStream)//EnfOfStream: 현재 스트림 위치가 끝이면 true, 아니면 false
                                       //!reader.EndOfStream는 스트림 끝이 아니면 true
            {
                string[] temp = reader.ReadLine().Split(',');
                //Student st = new Student(temp[NAME],
                //                    int.Parse(temp[AGE]),
                //                    temp[HAKBEON],
                //                    temp[HAKGWA],
                //                    temp[GENDER]);
                Student st = new Student(temp[(int)Student_Data.NAME], int.Parse(temp[(int)Student_Data.AGE]),
                                            temp[(int)Student_Data.HAKBEON], temp[(int)Student_Data.HAKGWA],
                                            temp[(int)Student_Data.GENDER]);
                students.Add(st);
            }
            dataGridView_students.DataSource = students;
            //개체에 사용되는 모든 리소스 해체
            reader.Dispose();
        }

        private void button_writeCSV_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("test.csv", true);
            writer.WriteLine($"{textBox_name.Text}," +
                $"{textBox_age.Text}," + $"{textBox_hakbeon.Text}," +
                $"{textBox_hakgwa.Text}," + $"{comboBox_gender.Text}");
            writer.Dispose(); //수동으로 메모리 해체
        }

        private void button_open_daegu_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();//인스턴스 바로 생성하고 띄우기 (1번)

            //2번
            //변수 선언하고 그 변수 띄우기
            //Form2 temp = new Form2();
            //temp.showDialog();
        }

        private void dataGridView_students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Student temp = dataGridView_students.CurrentRow.DataBoundItem as Student;
            textBox_name.Text = temp.name;
            textBox_age.Text = temp.age.ToString();
            textBox_hakbeon.Text = temp.hakbeon;
            textBox_hakgwa.Text = temp.hakgwa;
            comboBox_gender.Text = temp.gender;
        }
    }
}
