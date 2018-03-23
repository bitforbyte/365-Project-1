/**************************************************
 *   CS365 SP18 Project1
 *   Group 1D
 *       Austin Saporito
 *       G. Brent Hurst
 *       Kendall Nicley
 *
 *   bAssembler.cs
 *
 *   Partial Class for Brent's Functions:
 *   GoTo()
 *   If()
 *   Dup()
 *   Print()
 *   Dump()
 *   Push()
 *
 *************************************************/

//HOW DO I FIND PC AND STACK RELATIVE OFFSET

using System;
using System.Collections.Generic;
using _365_Project_1;


partial class Assembler
{
	//Unconditionally goes to the PC + (PC relative offset).
	//PC relative offset is a signed integer that will be sign-extended in the VM.
	//0111 PCrelativeoffset
	void Goto(Instruction i)
	{
		//TODO
	}

	void Ifeq(Instruction i)
	{
		i.Encoded = (uint) 8 << 28;
		i.Encoded |= (uint) 0 << 24;
		i.Encoded |= i.Val;
	}

	void Ifne(Instruction i)
	{
		i.Encoded = (uint) 8 << 28;
		i.Encoded |= (uint) 1 << 24;
		//TODO
	}

	void Iflt(Instruction i)
	{
		i.Encoded = (uint) 8 << 28;
		i.Encoded |= (uint) 2 << 24;
		//TODO
	}

	void Ifgt(Instruction i)
	{
		i.Encoded = (uint) 8 << 28;
		i.Encoded |= (uint) 3 << 24;
		//TODO
	}

	void Ifle(Instruction i)
	{
		i.Encoded = (uint) 8 << 28;
		i.Encoded |= (uint) 4 << 24;
		//TODO
	}

	void Ifge(Instruction i)
	{
		i.Encoded = (uint) 8 << 28;
		i.Encoded |= (uint) 5 << 24;
		//TODO
	}

	void Ifez(Instruction i)
	{
		i.Encoded = (uint) 9 << 28;
		i.Encoded |= (uint) 0 << 24;
		//TODO
	}

	void Ifnz(Instruction i)
	{
		i.Encoded = (uint) 9 << 28;
		i.Encoded |= (uint) 1 << 24;
		//TODO
	}

	void Ifmi(Instruction i)
	{
		i.Encoded = (uint) 9 << 28;
		i.Encoded |= (uint) 2 << 24;
		//TODO
	}

	void Ifpl(Instruction i)
	{
		i.Encoded = (uint) 9 << 28;
		i.Encoded |= (uint) 3 << 24;
		//TODO
	}



	//Peeks x = *(sp+offset)
	//Pushes x
	//Last 2 bits are always zero, so offset is a multiple of 4
	//1100 StackTopRelOffset 00
	void Dup(Instruction i)
	{
		//TODO
	}

	//Prints the very first value of the stack (or 0 if stack is empty)
	//Stack is left unchanged
	//1101 0000 0000 0000 0000 0000 0000 0000
	void Print(Instruction i)
	{
		i.Encoded = (uint) 13 << 28;
	}

	//Prints every value in the stack
	//Stack is left unchanged
	//1110 0000 0000 0000 0000 0000 0000 0000
	void Dump(Instruction i)
	{
		i.Encoded = (uint) 14 << 28;
	}

	//Pushes the value to the top of the stack
	//The value may be
	//  hex number (0xab, 0XAB, 0XaB)
	//  signed decimal number
	//  Memory label's value
	//  If no parameters are given, ValueToPush must be 0
	//1111 ValueToPush
	void Push(Instruction i)
	{
		i.Encoded = (uint) 15 << 28;
		i.Encoded |= i.Val;
	}
}
