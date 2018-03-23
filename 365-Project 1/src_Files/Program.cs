//
using System;
using System.IO;
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
			Program pro=new Program();
			pro.reader(args[0]);
			foreach(var item in assem.delDic)
			{
				assem.delDic[item.Key].DynamicInvoke(item.Key);
			}

		}
		public int reader(string file){
			 string line;

        if(File.Exists(file)){
            using (var read=new StreamReader(File.OpenRead(file))){
                while((line=read.ReadLine())!=null){
                    if(line.StartsWith("//")||line==string.Empty||line.StartsWith("#")){
                        //skip
                    }else{
                      // Console.WriteLine(line);
						Instruction inter= new Instruction();
						inter.Line=line;


                    }

                }
            }
        }
        return 1;
		}



	}
}
