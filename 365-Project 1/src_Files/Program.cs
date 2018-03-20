//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _365_Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
			Assembler assem = new Assembler();
			string cmd = "swap";
			string test = "swap info";

			assem.delDic[cmd].DynamicInvoke(test);


        }
    }
}
