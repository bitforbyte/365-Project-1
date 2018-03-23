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
			List<Instruction>Ilist;
			Assembler assem = new Assembler();
			string cmd = "swap";
			string test = "swap info";
			Program pro=new Program();
			Ilist=pro.reader(args[0]);
			foreach(var item in assem.delDic)
			{
				assem.delDic[item.Key].DynamicInvoke(item.Key);
			}

		}
		public List<Instruction> reader(string file){
			string line,label;
			uint addr=0;
			List<Instruction>Ilist=new List<Instruction>();
			Dictionary<Instruction,string> dic;

		if(File.Exists(file)){
            using (var read=new StreamReader(File.OpenRead(file))){
                while((line=read.ReadLine())!=null){
                    if(line.StartsWith("//")||line==string.Empty||line.StartsWith("#")){
                        //skip
                    }else if(line.EndsWith(":")&&addr!=0){
						addr+=4;
						Label la=new Label();
						la.labelName=line;
						la.Addr=addr;
						dic.Add(la,line);
					}else{
						addr+=4;
				}
			}
		}
		}
        if(File.Exists(file)){
            using (var read=new StreamReader(File.OpenRead(file))){
                while((line=read.ReadLine())!=null){
                    if(line.StartsWith("//")||line==string.Empty||line.StartsWith("#")){
                        //skip
                    }else{
						Instruction inter= new Instruction();
						inter.Line=line;
						Ilist.Add(inter);
						Console.WriteLine(inter.Val);
                    }

                }
            }
        }
        return Ilist;
		}



	}
}
