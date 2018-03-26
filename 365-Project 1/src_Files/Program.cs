/**************************************************
 *   CS365 SP18 Project1
 *   Group 1D
 *       Austin Saporito
 *       G. Brent Hurst
 *       Kendall Nicley
 *
 *   Program.cs
 *
 *   DESCRIPTION
 *
 *************************************************/

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
		//Entry point
		public static void Main(string[] args)
		{
			List<Instruction>Ilist;
			Assembler assem = new Assembler();
			Program pro=new Program();

			if(args.Length<1)
			{
				Console.WriteLine("Give file and a file name to write to as an arg");
				return;
			}

			//Read the file and put the instructions in Ilist
			Ilist=pro.reader(args[0]);

			//set i.Encoded for each i in Ilist
			foreach(var i in Ilist)
			{
				assem.delDic[i.Cmd].DynamicInvoke(i);
			}

			//Write to the writer to make the file and write the instructions to it
			assem.Writer(args[0], Ilist);


		}

		//method for reading the file into a list of instructions
		public List<Instruction> reader(string file){
			string line,label,line1,lab;
			uint addr=0;
			string[] delims = {" ","\t"};
			List<Instruction>Ilist=new List<Instruction>();
			Dictionary<string,Label> dic=new Dictionary<string,Label>();;

			//first pass through the file
			//find all labels and their addresses and fill dic
			if(File.Exists(file)){
				using (var read1=new StreamReader(File.OpenRead(file))){
					while((line1=read1.ReadLine())!=null){
						if(line1.StartsWith("//")||line1==string.Empty||line1.StartsWith("#")){
							//skip; ignore python and c-style commenting
						}else if(line1.EndsWith(":")){
							Label la=new Label();
							la.labelName=line1;
							la.Addr=addr;
							dic.Add(line1,la);
						}else{
							addr+=4;
						}
					}
				}
			}

			//second pass through the file
			//get all instructions
			addr=0;
			if(File.Exists(file)){
				using (var read=new StreamReader(File.OpenRead(file))){
					while((line=read.ReadLine())!=null){
						if(line.StartsWith("//")||line==string.Empty||line.StartsWith("#") || line.EndsWith(":")){
							//skip; ignore python and c-style commenting
						}else{
							Instruction inter= new Instruction();
							inter.Line=line;
							inter.Address = addr;

							//check to see if the second arg is a label
							//if it is, set inter.Val accordingly
							string[] words = line.Split(delims,StringSplitOptions.RemoveEmptyEntries);
							lab="";
							if(words.Length>1){
								lab=words[1];
								lab+=":";
							}
							if(dic.ContainsKey(lab)){
								inter.Val=dic[lab].Addr;
							}

							if(!line.EndsWith(":"))
								addr+=4;

							Ilist.Add(inter);
						}
					}
				}
			}
			return Ilist;
		}
	}
}
