using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readwriteCSV
{
    class Student
    {
        private string name;
        private int age;
        private string hakbeon;
        private string hakgwa;
        private string gender;

        public Student(string name, int age, string hakbeon,
                        string hakgwa, string gender)
        {
            this.name = name;
            this.age = age;
            this.hakbeon = hakbeon;
            this.hakgwa = hakgwa;
            this.gender = gender;
        }
        //c# 스타일
        //public string hakgwa
        //{
         //   get { return hakgwa; }
          //  set { hakgwa = value; }
        //}
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Hakbeon { get => hakbeon; set => hakbeon = value; }
        public string Hakgwa { get => hakgwa; set => hakgwa = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
