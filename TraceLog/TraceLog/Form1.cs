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

namespace TraceLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Linq 문법
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var even = from item in input where item % 2 == 0 select item;
            string test = "";
            foreach(var item in even)
            {
                test += item + "    ";
            }
            Console.WriteLine(test);
            button3.Click += Button3_Click;
            button4.Click += (sender, e) => { MessageBox.Show("람다식으로 이벤트 추가"); };

            button3.Click += button1_Click;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이벤트 추가시 이미 델리게이트 사용함");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*//특정 폴더 여부 체크 없다면 생성하기
            DirectoryInfo di = new DirectoryInfo("History");
            if(di.Exists == false)
            {
                di.Create();//히스토리 폴더를 만든다.
            }
            //해당 폴더가 있을 경우 그 파일 안에 파일을 적는다
            //해당 폴더에 파일을 적는다
            using(StreamWriter writer = new StreamWriter("History\\History.txt", true)) //true 덮어쓰기 하지 않음
            {
                writer.WriteLine("현재 시각 : "+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
            }
            //텍스트파일에 적은 내용을 listbox에도 표시*/
            printLog("현재 시각 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
            displayLog("현재 시각 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printLog("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")+"]"+textBox1.Text);
            displayLog("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "]" + textBox1.Text);
        }

        private void displayLog(string text)
        {
            //recent history first
            listBox1.Items.Insert(0, text);//해당 인덱스에 작성
            //listBox1.Items.Add(text);
        }

        private void printLog(string text)
        {
            //특정 폴더 여부 체크 없다면 생성하기
            DirectoryInfo di = new DirectoryInfo("History");
            if (di.Exists == false)
            {
                di.Create();//히스토리 폴더를 만든다.
            }
            //해당 폴더가 있을 경우 그 파일 안에 파일을 적는다
            //해당 폴더에 파일을 적는다
            using (StreamWriter writer = new StreamWriter("History\\History.txt", true)) //true 덮어쓰기 하지 않음
            {
                writer.WriteLine(text);
            }
            //텍스트파일에 적은 내용을 listbox에도 표시
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //1초 단위 동작
            toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
        //콜백함수 델리게이트
        public delegate void voidFunction();
        private void button_study_Delegate_Click(object sender, EventArgs e)
        {
#if DEBUG
//디버그 일때 실행
#else
            if (false)
            {
                voidFunction v = temp;
                v();
                useDelegate(v);
            }
#endif
            voidFunction v2 = delegate () { MessageBox.Show("익명 델리게이트 사용"); };
            useDelegate(v2);

            //람다식
            voidFunction lamda = () => { MessageBox.Show("람다 사용"); };
            lamda();
            useDelegate(lamda);
        }
        public void temp()
        {
            MessageBox.Show("매개변수와 반환값이 없는 함수");
        }
        public void useDelegate(voidFunction v)
        {
            for(int i=0; i<3; i++)
            {
                v();
            }
        }
    }
}
