//Partial Class for Kendall's Functions
using System;
using System.Collections.Generic;
using _365_Project_1;

partial class Assembler
{
	//Byte code that will be send to the file writer
	uint byteVal;

	//Exit will terminate the virtual machine
	//The 8-bit exit code will be returned to the operating system
	//If no exit code is specified, 0 is assumed
	void Exit(string line)
	{
		byteVal = 0;
		//TODO get exit code from line

		//TODO send bytecode to binary writer: WriteCode(byteCode);

		return;
	}

	//Swap will swap the topmest value on the stack with the second topmost value
	//If there is stack is empty it will do nothing
	//If there is onle one value on the stack, swap is similar to push 0
	void Swap(string line)
	{
		byteVal = 1 << 56;
		Console.WriteLine(line + " byteval: " + Convert.ToString(byteVal, 2).PadLeft(32, '0'));
		
		//TODO send bytecode to binary writer: WriteCode(byteCode);
		return;
	}

	//Inputs number from console and pushes the value onto the stack
	//TODO Fix the name type (need to also fix name in Assemble.cs)
	void Input(string line)
	{
		byteVal = 2 << 56;
		Console.WriteLine(line + " byteval:  " + Convert.ToString(byteVal, 2).PadLeft(32, '0'));

		//TODO send bytecode to binary writer: WriteCode(byteCode);
		return;
	}

	//Nop is a "no operation" instruction and does nothing but move the program counter
	void Nop(string line)
	{
		byteVal = 3 << 56;
		Console.WriteLine(line + " byteval:  " + Convert.ToString(byteVal, 2).PadLeft(32, '0'));
		//TODO send bytecode to binary writer: WriteCode(byteCode);
		return;
	}

	//Pop will move the stack pointer down(to higher memory address)
	void Pop(string line)
	{
		byteVal = 1 << 60;
		Console.WriteLine(line + " byteval:  " + Convert.ToString(byteVal, 2).PadLeft(32, '0'));

		//TODO send bytecode to binary writer: WriteCode(byteCode);
		return;
	}

	//Pops a value, negates it, and pushes the result
	void Neg(string line)
	{
		byteVal = 3 << 60;
		Console.WriteLine(line + " byteval:  " + Convert.ToString(byteVal, 2).PadLeft(32, '0'));
		//TODO send bytecode to binary writer: WriteCode(byteCode);
		return;
	}

	//Not function that will pop value, logically nots it, and pushes the result
	void Not(string line)
	{
		byteVal = 49 << 56;
		Console.WriteLine(line + " byteval:  " + Convert.ToString(byteVal, 2).PadLeft(32, '0'));
		//TODO send bytecode to binary writer: WriteCode(byteCode);
		return;
	}
}
