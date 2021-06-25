using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extends_Interface
{
    class Cat :Animal, IFight
    {
        public string eyeColor { get; set; }
        public override void Born()
        {
            System.Windows.Forms.MessageBox.Show("냐옹냐온");
        }
        public override void Sleep()
        {
            //base.Sleep();
            System.Windows.Forms.MessageBox.Show("집사야 나 잔다냥~");
        }
        public void DailyLootin()
        {
            Eat();
            Sleep();
        }
        
        public void Fight()
        {
            System.Windows.Forms.MessageBox.Show("꺼져!!");
        }
    }
}
