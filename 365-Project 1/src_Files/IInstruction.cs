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


public interface IInstruction
{
	string Cmd {get;}
	string Val {get;}
	string Line {get; set;}
	uint Encoded {get; set;}
}
