/**************************************************
 *   CS365 SP18 Project1
 *   Group 1D
 *       Austin Saporito
 *       G. Brent Hurst
 *       Kendall Nicley
 *
 *   Assembler.cs
 *
 *   Partial Class that creates a dictionary of
 *   our functions and writes out the bytecode.
 *
 *************************************************/

using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using _365_Project_1;

partial class Assembler
{

	//Delegate for each of the functions
	protected delegate void del(Instruction i);

	//Dictionary keyed on command string and value is the approiate funciton
	public Dictionary<string, Delegate> delDic;
	public Assembler()
	{
		//Assign the functions to the dictionary
		delDic = new Dictionary<string, Delegate>()
		{
			{"exit", new del(Exit)},
			{"swap", new del(Swap)},
			{"nop", new del(Nop)},
			{"pop", new del(Pop)},
			{"inpt", new del(Inpt)},
			{"add", new del(Add)},
			{"sub", new del(Sub)},
			{"mul", new del(Mul)},
			{"div", new del(Div)},
			{"rem", new del(Rem)},
			{"and", new del(And)},
			{"or", new del(Or)},
			{"xor", new del(Xor)},
			{"neg", new del(Neg)},
			{"not", new del(Not)},
			{"goto", new del(Goto)},
			{"ifeq", new del(Ifeq)},
			{"ifne", new del(Ifne)},
			{"iflt", new del(Iflt)},
			{"ifgt", new del(Ifgt)},
			{"ifle", new del(Ifle)},
			{"ifge", new del(Ifge)},
			{"ifez", new del(Ifez)},
			{"ifnz", new del(Ifnz)},
			{"ifmi", new del(Ifmi)},
			{"ifpl", new del(Ifpl)},
			{"dup", new del(Dup)},
			{"print", new del(Print)},
			{"dump", new del(Dump)},
			{"push", new del(Push)},

		};
	}


	//Assembler
	public void Assemble(string filename)
	{	
		List<Instruction>Ilist;
		Assembler assem = new Assembler();

		//Read the file and put the instructions in Ilist
		Ilist= reader(filename);

		//set i.Encoded for each i in Ilist
		foreach(var i in Ilist)
		{
			try
			{
				//Call the approiate function that will encode the value
				assem.delDic[i.Cmd].DynamicInvoke(i);

			}
			catch
			{
				Console.WriteLine("'{0}' is not an instruction Exiting...", i.Cmd);
			}

		}

		//Write to the writer to make the file and write the instructions to it
		assem.Writer(filename, Ilist);
	}

	//Reader
	//method for reading the file into a list of instructions
	public List<Instruction> reader(string file)
	{
		string line,line1,lab;
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

						//Check to make sure there are no inline comments
						if (line.Contains("//") || line.Contains("/*") || line.Contains("#"))
							line = inCRemover(line);

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

	//Removes inline comments from the given string (if there are any)
	protected string inCRemover(string line)
	{
		//To remove block comments
		var blockComments = @"/\*(.*?)\*/"; //pattern for block comments
		var cLineComments = @"(?-s)//(.*)"; //pattern for c style comments
		var pLineComments = @"(?-s)#(.*)"; //pattern for python style comments

		//Remove // comments at the end of the line
		if (line.Contains("//"))
			line = Regex.Replace(line, cLineComments, "");
		
		//Remove # comments from the end of the line
		if (line.Contains("#"))
			line = Regex.Replace(line, pLineComments, "");	
			
		//Remove the inline /* */ comments
		if (line.Contains("/*"))
			line = Regex.Replace(line, blockComments, "");

		return line;
	}

	//Writer that will write to the file using a binary writer
	//by iterating thorugh a list of Interfaces that will contain the
	//value to be written
	public void Writer(string file, List<Instruction> ins)
	{
		//Change the path name of the file to be .bin
		var fileName = Path.ChangeExtension(file, ".bin");
		
		//if (Test.RegularExpressions.Regex.IsMatch(fileName, "\\."))
		using (BinaryWriter bw = new BinaryWriter(File.Open(fileName,FileMode.Create)))
		{
			uint val;

			//Write the header for the .bin file (required for every .bin file)
			bw.Write(0xefbeedfe); //for the virtual machine

			//Iterate through the list of interfaces and write the encoded value
			foreach(Instruction item in ins)
			{
				//This gives the encoded value for the virtual machine
				bw.Write(item.Encoded);
			}
		}

		Console.WriteLine("File '{0}' Assembled Successfully",fileName);

	}

}
