using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsever0630
{
    public interface Obsever //옵저버 패턴 인터페이스는 구현을 명령(규칙)
    {
        void update(string value);
    }
}
