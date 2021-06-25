using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extends_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_animal_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.name = "hanyijin";
            animal.age = 26;
            animal.Sleep();
            //animal.Eat();
        }

        private void button_cat_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat();
            cat.name = "냥냥이";
            cat.age = 2;
            cat.eyeColor = "오드아이";
            cat.Sleep();
            cat.DailyLootin();
        }

        private void button_dog_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog();
            dog.name = "멍멍이";
            dog.age = 3;
            dog.hairColor = "검은색";
            dog.Sleep();
        }

        private void button_animals_Click(object sender, EventArgs e)
        {
            //다형성
            Animal a = new Cat();
            Animal b = new Dog();
            a.age = 1;
            a.name = "길냥이";
            
            if(a is Cat)
            {
                //형변환
                ((Cat)a).eyeColor = "딥그린";
                (a as Cat).eyeColor = "치즈";
                (a as Cat).DailyLootin();
                (a as Cat).Sleep();
                a.Sleep();
            }
            var temp = a as Cat;
            if (temp != null)
                temp.DailyLootin();
            b.age = 1;
            b.name = "dogu";

            Animal c = new Cat();
            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            animals.Add(b);
            animals.Add(c);

            foreach(var item in animals)
            {
                if (item is Cat)
                {
                    (item as Cat).DailyLootin();
                }
                else
                    item.Sleep();
            }
        }

        private void button_Exinterface_Click(object sender, EventArgs e)
        {
            Fight(new Dog());
            Fight(new Cat());
        }
        private void Fight(IFight f)
        {
            f.Fight();
        }

        //인터페이스를 몰랐더라면...
        private void Fight(Animal f)
        {
            if (f is Cat)
                (f as Cat).Fight();
            if (f is Dog)
                (f as Dog).Fight();
        }
        private void Fight(Dog f)
        {
            f.Fight();
        }

        private void Fight(Cat f)
        {
            f.Fight();
        }

        private void Fight(IFight f)
        {
            f.Fight();
        }
    }
}
