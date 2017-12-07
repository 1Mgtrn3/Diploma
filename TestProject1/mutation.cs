using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
   public class mutation
    {
       public string pos { get; set; }
       public string start { get; set;}
       public string end { get; set; }
       public string count { get; set; }

       public mutation(string Pos, string Start, string End, string Count)
       {
           this.pos = Pos;
           this.start = Start;
           this.end = End;
           this.count = Count;

       }

    }
}
