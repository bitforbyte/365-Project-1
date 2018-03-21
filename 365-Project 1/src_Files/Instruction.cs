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

using _365_Project_1;

public class Instruction : IInstruction
{
	public string mCmd;
	public string Cmd
	{
		get { return mCmd; }
	}

	public string mVal;
	public string Val
	{
		get {return mVal; }
	}

	public string mLine;
	public string Line
	{
		get { return mLine; }
		set
		{
			mLine = value;
			//set Cmd
			//set Val
		}
	}

	public uint mEncoded;
	public uint Encoded
	{
		get { return mEncoded; }
		set { mEncoded = value; }
	}
}
