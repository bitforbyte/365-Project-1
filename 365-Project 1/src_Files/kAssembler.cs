/**************************************************
 *   CS365 SP18 Project1
 *   Group 1D
 *       Austin Saporito
 *       G. Brent Hurst
 *       Kendall Nicley
 *
 *   kAssembler.cs
 *
 *   Partial Class for Brent's Functions:
 *   Exit()
 *   Swap()
 *   Inpt()
 *   Nop()
 *   Pop()
 *   Neg()
 *   Not()
 *
 *************************************************/

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
	void Exit(Instruction i)
	{
		byte exCode;
		byteVal = 0;

		//Get the exit code with error checking
		try
		{
			exCode = Convert.ToByte(i.Val);
			i.Encoded = (byteVal | exCode);
		}
		catch
		{ Console.WriteLine("Exit Code Bad Format: '{0}'", i.Val); }


		return;
	}

	//Swap will swap the topmest value on the stack with the second topmost value
	//If there is stack is empty it will do nothing
	//If there is onle one value on the stack, swap is similar to push 0
	void Swap(Instruction i)
	{
		byteVal = 1 << 24;

		i.Encoded = byteVal;
		return;
	}

	//Inputs number from console and pushes the value onto the stack
	void Inpt(Instruction i)
	{
		byteVal = 2 << 24;

		i.Encoded = byteVal;
		return;
	}

	//Nop is a "no operation" instruction and does nothing but move the program counter
	void Nop(Instruction i)
	{
		byteVal = 3 << 24;
		i.Encoded = byteVal;
		return;
	}

	//Pop will move the stack pointer down(to higher memory address)
	void Pop(Instruction i)
	{
		byteVal = 1 << 28;
		i.Encoded = byteVal;

		return;
	}

	//Pops a value, negates it, and pushes the result
	void Neg(Instruction i)
	{
		byteVal = 3 << 28;
		i.Encoded = byteVal;
		return;
	}

	//Not function that will pop value, logically nots it, and pushes the result
	void Not(Instruction i)
	{
		byteVal = 49 << 24;
		i.Encoded = byteVal;
		return;
	}
}
