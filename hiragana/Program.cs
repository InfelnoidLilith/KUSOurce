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
				/* �Ђ炪�ȓ��� */
				inputString = hiraganaIO.InputAColomn();

				if (inputString == "x" || inputString == "��")
				{
					Console.WriteLine("�����");
					break;
				}

				/* �Ђ炪�ȏo�� */
				hiraganaIO.OutputHiraganaRow();
			}
		}
	}
}