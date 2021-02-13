using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMaker
{
    class Class1
    {
        public int id { get; set; }
        public string character { get; set; }
        public string statement { get; set; }
        public string answer { get; set; }
        public bool mayPass { get; set; }
        public Class1(int id, string character, string statement, string answer, bool mayPass)
        {
            this.id = id;
            this.character = character;
            this.statement = statement;
            this.answer = answer;
            this.mayPass = mayPass;
        }
    }
}
