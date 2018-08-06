using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50on.cs
{
	class Program
	{
		static void Main(string[] args)
		{
			HiraganaIO hiraganaIO = new HiraganaIO();
			string inputString;

			while (true)
			{
				/* ‚Ğ‚ç‚ª‚È“ü—Í */
				inputString = hiraganaIO.InputAColomn();

				if (inputString == "x" || inputString == "‚˜")
				{
					Console.WriteLine("‚¨‚í‚é");
					break;
				}

				/* ‚Ğ‚ç‚ª‚Èo—Í */
				hiraganaIO.OutputHiraganaRow();
			}
		}
	}
}