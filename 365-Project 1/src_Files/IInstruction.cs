/*************************************************
 *   CS365 SP18 Project1
 *   Group 1D
 *       Austin Saporito
 *       G. Brent Hurst
 *       Kendall Nicley
 *
 *   IInstruction.cs
 *
 *   Interface for each Instruction
 *
 ************************************************/

using _365_Project_1;

public interface IInstruction
{
	//the first word of an instruction line
	string Cmd {get;}

	//the second word of an instruction line, else 0
	uint Val {get; set;}

	//an instruction line
	string Line {get; set;}

	//the bytecode to be output
	uint Encoded {get; set;}

	//Address
	uint Address {get; set;}
}
