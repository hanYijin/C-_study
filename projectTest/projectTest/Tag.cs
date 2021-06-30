using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTest
{
    class Tag
    {
        public string title { get; set; }
        public string keywords { get; set; }

        public Tag(string title, string keywords)
        {
            this.title = title;
            this.keywords = keywords;
        }
    }
}
