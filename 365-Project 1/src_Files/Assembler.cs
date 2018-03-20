using System;
using System.Collections.Generic;
using _365_Project_1;

partial class Assembler
{
	//protected List<int> lLoc;
	
	//Delegate for each of the functions
	protected delegate void del(string line);

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
			//{"add", new del(Add)},
			//{"sub", new del(Sub)},
			//{"mul", new del(Mul)},
			//{"div", new del(Div)},
			//{"rem", new del(Rem)},
			//{"and", new del(And)},
			//{"or", new del(Or)},
			//{"xor", new del(Xor)},
			{"neg", new del(Neg)},
			{"not", new del(Not)},
			//{"goto", new del(Goto)},
			//{"if1", new del(If1)},
			//{"if2", new del(If2)},
			//{"dup", new del(Dup)},
			//{"print", new del(Print)},
			//{"dump", new del(Dump)},
			//{"push", new del(Push)},
			
		};
	}

}