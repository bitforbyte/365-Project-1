/**************************************************
 *   CS365 SP18 Project1
 *   Group 1D
 *       Austin Saporito
 *       G. Brent Hurst
 *       Kendall Nicley
 *
 *   aAssembler.cs
 *
 *   Partial Class for Austin's Functions:
 *   Add()
 *   Sub()
 *   Mul()
 *   Div()
 *   Rem()
 *   And()
 *   Or()
 *   Xor()
 *
 *************************************************/

using System;
using System.Collections.Generic;
using _365_Project_1;

partial class Assembler
{
	uint strbyte;

	//Pops left and right, adds them together, and pushes the sum
	//0010 0000 0000 0000 0000 0000 0000 0000
	void Add(Instruction i)
	{
		strbyte=2<<28;
		i.Encoded=strbyte;
		return;
	}

	//Pops left and right, subtracts right from left, and pushes the difference
	//0010 0001 0000 0000 0000 0000 0000 0000
	void Sub(Instruction i)
	{
		strbyte=33<<24;
		i.Encoded=strbyte;
		return;
	}

	//Pops left and right, multiplies them together, and pushes the product
	//0010 0010 0000 0000 0000 0000 0000 0000
	void Mul(Instruction i)
	{
		strbyte=34<<24;
		i.Encoded=strbyte;
		return;
	}

	//Pops left and right, divides left over right, and pushes the quotient
	//0010 0011 0000 0000 0000 0000 0000 0000
	void Div(Instruction i)
	{
		strbyte=35<<24;
		i.Encoded=strbyte;
		return;
	}

	//Pops left and right, divides left over right, and pushes the remainder
	//0010 0100 0000 0000 0000 0000 0000 0000
	void Rem(Instruction i)
	{
		strbyte=36<<24;
		i.Encoded=strbyte;
		return;
	}

	//Pops left and right, logical ANDs left and right, and pushes the result
	//0010 0101 0000 0000 0000 0000 0000 0000
	void And(Instruction i)
	{
		strbyte=37<<24;
		i.Encoded=strbyte;
		return;
	}

	//Pops left and right, logical ORs left and right, and pushes the result
	//0010 0110 0000 0000 0000 0000 0000 0000
	void Or(Instruction i)
	{
		strbyte=38<<24;
		i.Encoded=strbyte;
		return;
	}

	//Pops left and right, logical XORs left and right, and pushes the result
	//0010 0111 0000 0000 0000 0000 0000 0000
	void Xor(Instruction i)
	{
		strbyte=39<<24;
		i.Encoded=strbyte;
		return;
	}
}
