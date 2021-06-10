namespace xmlReadWrite
{
    class Student
    {
        public Student(string name, int age, string hakbeon,
                        string hakgwa, string gender)
        {
            this.name = name;
            this.age = age;
            this.hakbeon = hakbeon;
            this.hakgwa = hakgwa;
            this.gender = gender;
        }

        //5개의 멤버변수
        //이름, 나이, 학번, 학과, 성별

        public string name { get; set; }
        public int age { get; set; }
        public string hakbeon { get; set; }
        public string hakgwa { get; set; }
        public string gender { get; set; }
    }
}