using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extends_Interface
{
    class Animal: Creature
    {
        public string name { get; set;}
        public int age { get; set; }

        public override void Born()
        {
            System.Windows.Forms.MessageBox.Show("응애응앵");

        }

        //오버라이딩이 가능하다 선언 virtual
        public virtual void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("ZZZ");
            //mbox tab 두번
        }
        //protected: Animal을 상속한 클래스만 호출 가능 
        protected void Eat()
        {
            System.Windows.Forms.MessageBox.Show("냠냠");
        }

    }
}
