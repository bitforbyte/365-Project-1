/**************************************************
 *   CS365 SP18 Project1
 *   Group 1D
 *       Austin Saporito
 *       G. Brent Hurst
 *       Kendall Nicley
 *
 *   bAssembler.cs
 *
 *   Partial Class for Brent's Functions
 *
 *************************************************/



using System;
using System.Collections.Generic;
using _365_Project_1;



//Brent: change everything to lowercase



partial class Assembler
{
	//Unconditionally goes to the PC + (PC relative offset).
	//PC relative offset is a signed integer that will be sign-extended in the VM.
	//0111 PCrelativeoffset
	void Goto(string line)
	{

	}

	void If_____(string line)
	{

	}

	void If__(string line)
	{

	}

	//Peeks x = *(sp+offset)
	//Pushes x
	//Last 2 bits are always zero, so offset is a multiple of 4
	//1100 StackTopRelOffset 00
	void Dup(string line)
	{

	}

	//Prints the very first value of the stack (or 0 if stack is empty)
	//Stack is left unchanged
	//1101 0000 0000 0000 0000 0000 0000 0000
	void Print(string line)
	{

	}

	//Prints every value in the stack
	//Stack is left unchanged
	//1110 0000 0000 0000 0000 0000 0000 0000
	void Dump(string line)
	{

	}

	//Pushes the value to the top of the stack
	//The value may be
	//  hex number (0xab, 0XAB, 0XaB)
	//  signed decimal number
	//  Memory label's value
	//  If no parameters are given, ValueToPush must be 0
	//1111 ValueToPush
	void Push(string line)
	{

	}
}
