/**************************************************
 *   CS365 SP18 Project1
 *   Group 1D
 *       Austin Saporito
 *       G. Brent Hurst
 *       Kendall Nicley
 *
 *   Program.cs
 *
 *	 This project is to work as a basic assembler
 *	 by taking a .asm file and generate binary code
 *	 .bin file that will work on virtual machines
 *
 *************************************************/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _365_Project_1
{
	class Driver
	{
		//Entry point
		public static void Main(string[] args)
		{
			//Create the Assembler
			Assembler asm = new Assembler();

			//Check the args to make sure file is given
			if(args.Length<1)
			{
				Console.WriteLine("Give file and a file name to write to as an arg");
				return;
			}
			
			//Call Assembler to assemble the .bin file
			asm.Assemble(args[0]);


		}
	}
}
