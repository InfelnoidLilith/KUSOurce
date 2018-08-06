using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50on.cs
{
	class HiraganaIO
	{
		private HiraganaMap hiraganaMap;
		private string inputString;

		public HiraganaIO()
		{
			hiraganaMap = new HiraganaMap();
		}

		/// <summary>
		/// あ段の入力処理
		/// </summary>
		public string InputAColomn()
		{
			Console.WriteLine("あ段を入力しろ、やめるならxおせ");

			while (true)
			{
				inputString = Console.ReadLine();

				if (hiraganaMap.ValidatAColumn(inputString) || inputString == "x" || inputString == "ｘ")
				{
					return (inputString);
				}
				Console.WriteLine("あ段じゃない再入力しろやめるならxおせ");
			}
		}

		/// <summary>
		/// ひらがなの行出力
		/// </summary>
		public void OutputHiraganaRow()
		{
			string hiraganaRow = hiraganaMap.GetTargetHiraganaRow(inputString);

			Console.WriteLine(hiraganaRow);
		}
	}
}
