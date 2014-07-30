using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRunDisc
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process.Start(@"F:\autorun.inf");
        }
    }
}
