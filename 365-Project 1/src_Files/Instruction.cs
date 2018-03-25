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
	public string mCmd;
	public string Cmd
	{
		get { return mCmd; }
	}

	public uint mVal;
	public uint Val
	{
		get {return mVal;}
		set {mVal = value;}
	}

	public string mLine;
	public string Line
	{
		get { return mLine; }
		set
		{
			mLine = value.ToLower();

			//set Cmd
		//	Console.WriteLine(mLine);
			mLine.Trim();
		//	Console.WriteLine(mLine);

			string[] delims = {" ","\t"};
			string[] words = mLine.Split(delims,StringSplitOptions.RemoveEmptyEntries);
		//	Console.WriteLine(words.Length);
			mCmd = words[0];

			//set Val
			mVal = 0;
			if(words.Length > 1)
			{
				string s = words[1];
				try
				{
					if(s.Length>1 && s[0]=='0' && s[1]=='x')
						mVal = (uint) Int32.Parse(s.Substring(2,s.Length-2),System.Globalization.NumberStyles.HexNumber);
					else
						mVal = (uint) Int32.Parse(s);
				}
				catch
				{
					mVal = 0;
				}
			}
		}
	}

	public uint mEncoded;
	public uint Encoded
	{
		get { return mEncoded; }
		set { mEncoded = value; }
	}
}
