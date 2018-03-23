//Partial Class for Austin's Functions
using System;
using System.Collections.Generic;
using _365_Project_1;

partial class Assembler
{
	uint strbyte;

	void Add(Instruction i)
	{
		strbyte=2<<28;
		i.Encoded=strbyte;
		return;
	}
	void Sub(Instruction i)
	{
		strbyte=33<<24;
		i.Encoded=strbyte;
		return;
	}

	void Mul(Instruction i){

		strbyte=34<<24;
		i.Encoded=strbyte;
		return;

	}
	void Div(Instruction i)
	{
		strbyte=35<<24;
		i.Encoded=strbyte;
		return;
	}
	void Rem(Instruction i)
	{
		strbyte=36<<24;
		i.Encoded=strbyte;
		return;
	}
	void And(Instruction i)
	{
		strbyte=37<<24;
		i.Encoded=strbyte;
		return;
	}
	void Or(Instruction i)
	{
		strbyte=38<<24;
		i.Encoded=strbyte;
		return;
	}
	void Xor(Instruction i)
	{
		strbyte=39<<24;
		i.Encoded=strbyte;
		return;
	}
}
