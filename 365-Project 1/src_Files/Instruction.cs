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


using System;
using _365_Project_1;

public class Instruction : IInstruction
{
	//the first word of an instruction line
	public string mCmd;
	public string Cmd
	{
		get { return mCmd; }
	}

	//the second word of an instruction line, else 0
	public uint mVal;
	public uint Val
	{
		get {return mVal;}
		set {mVal = value;}
	}

	//an instruction line
	public string mLine;
	public string Line
	{
		get { return mLine; }
		set
		{
			//the .asm file is case insensitive,
			//so change everything to lowercase
			mLine = value.ToLower();

			//set Cmd
			mLine.Trim();

			string[] delims = {" ","\t"};
			string[] words = mLine.Split(delims,StringSplitOptions.RemoveEmptyEntries);
			mCmd = words[0];

			//set Val
			mVal = 0;
			if(words.Length > 1)
			{
				string s = words[1];

				//number
				try
				{
					//hex
					if(s.Length>1 && s[0]=='0' && s[1]=='x')
						mVal = (uint) Int32.Parse(s.Substring(2,s.Length-2),System.Globalization.NumberStyles.HexNumber);
					//decimal
					else
						mVal = (uint) Int32.Parse(s);
				}
				//label, and Val will be set later
				catch
				{
					mVal = 0;
				}
			}
		}
	}

	//the bytecode to be output
	public uint mEncoded;
	public uint Encoded
	{
		get { return mEncoded; }
		set { mEncoded = value; }
	}
}
