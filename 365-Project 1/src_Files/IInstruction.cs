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


interface IInstruction
{
	//"pop" or "add", etc
	//includes "set" so Brent can change to lowercase
	string Str {get; set;}

	//the ByteCode to be output for this instruction
	uint Encoded {get;}
}
