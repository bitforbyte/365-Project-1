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
	string mCmd;
	string Cmd
	{
		get { return mCmd; }
	}

	string mVal;
	string Val
	{
		get {return mVal; }
	}

	string mLine;
	string Line
	{
		get { return mStr; }
		set
		{
			mStr = value;
			//set Cmd
			//set Val
		}
	}

	uint mEncoded;
	uint Encoded
	{
		get { return mEncoded; }
		set { mEncoded = value; }
	}
}
