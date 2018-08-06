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
				/* ひらがな入力 */
				inputString = hiraganaIO.InputAColomn();

				if (inputString == "x" || inputString == "ｘ")
				{
					Console.WriteLine("おわる");
					break;
				}

				/* ひらがな出力 */
				hiraganaIO.OutputHiraganaRow();
			}
		}
	}
}