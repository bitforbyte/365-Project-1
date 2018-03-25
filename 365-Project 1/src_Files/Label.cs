/*************************************************
 *   CS365 SP18 Project1
 *   Group 1D
 *       Austin Saporito
 *       G. Brent Hurst
 *       Kendall Nicley
 *
 *   Label.cs
 *
 *   Class for each Label.
 *   Inherits ILabel.
 *
 ************************************************/

using System;
using _365_Project_1;

//self-explanatory
public class Label : Ilabel
{
	public string mlabel;
	public string labelName{
		get{ return mlabel; }
		set{ mlabel=value; }

	}

	public uint maddr;
	public uint Addr{
		get{ return maddr; }
		set{ maddr = value; }
	}
}
