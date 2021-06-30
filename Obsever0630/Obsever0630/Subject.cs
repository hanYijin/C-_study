using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsever0630
{
    public interface Subject
    {
        //register or subscribe
        //객체추가
        void register(Obsever o);
        //register ir dissubscribe
        //객체제거
        void remove(Obsever o);

        void notifyObservers();
    }
}
