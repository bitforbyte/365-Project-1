using System;
using System.IO;
using System.Collections.Generic;
using _365_Project_1;

partial class Assembler
{
	//protected List<int> lLoc;

	//Delegate for each of the functions
	protected delegate void del(Instruction i);

	//Dictionary keyed on command string and value is the approiate funciton
	public Dictionary<string, Delegate> delDic;
	public Assembler()
	{
		//Assign the functions
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
			//{"goto", new del(Goto)},
			//{"ifeq", new del(Ifeq)},
			//{"ifne", new del(Ifne)},
			//{"iflt", new del(Iflt)},
			//{"ifgt", new del(Ifgt)},
			//{"ifle", new del(Ifle)},
			//{"ifge", new del(Ifge)},
			//{"ifez", new del(Ifez)},
			//{"ifnz", new del(Ifnz)},
			//{"ifmi", new del(Ifmi)},
			//{"ifpl", new del(Ifpl)},
			//{"dup", new del(Dup)},
			//{"print", new del(Print)},
			//{"dump", new del(Dump)},
			//{"push", new del(Push)},

		};
	}

	//Writer that will write to the file using a binary writer
	//by iterating thorugh a list of Interfaces that will contain the
	//value to be written
	public void Writer(List<Instruction> ins)
	{

		using (BinaryWriter bw = new BinaryWriter(File.Open("Output.asm", FileMode.Create)))
		{
			//TODO figure out which line needs to be used "because endian could switch the order"
			bw.Write(0xfeedbeef);
			//bw.Write(0xefbeedfe); Likely not needed

			//Iterate through the list of interfaces and write the encoded value
			foreach(Instruction item in ins)
			{bw.Write(item.Encoded);}
		}

	}

}
