/*************************************************
 *   CS365 SP18 Project1
 *   Group 1D
 *       Austin Saporito
 *       G. Brent Hurst
 *       Kendall Nicley
 *
 *   Instruction.cs
 *
 *   Class for each Instruction.
 *   Inherits IInstruction.
 *
 ************************************************/


class Instruction : IInstruction
{
	string mStr;
	string Str
	{
		get { return mStr; }
		set { mStr = value; }
	}

	uint mEncoded;
	uint Encoded
	{
		get { return mEncoded; }
	}
}
