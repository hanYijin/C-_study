using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extends_Interface
{
    class Dog : Animal, IFight, IHwahae
    {
        public string hairColor { get; set; }
        public void AkSoo()
        {
            System.Windows.Forms.MessageBox.Show("ㅎㅎㅎ");
        }

        public void Fight()
        {
            System.Windows.Forms.MessageBox.Show("크르릉");
        }

        public void Hug()
        {
            System.Windows.Forms.MessageBox.Show("헤헤헤");
        }
    }
    
}
