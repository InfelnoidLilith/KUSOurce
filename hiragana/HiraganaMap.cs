using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50on.cs
{
	class HiraganaMap
	{
		private Dictionary<string, string> hiraganaArr;
		public Dictionary<string, string> HiraganaArr
		{
			get
			{
				return (hiraganaArr);
			}
		}
		
		public HiraganaMap()
		{
			hiraganaArr = new Dictionary<string, string>()
			{
				{ "あ","あいうえお" },
				{ "か", "かきくけこ" },
				{ "さ", "さしすせそ" },
				{ "た", "たちつてと" },
				{ "な", "なにぬねの" },
				{ "は", "はひふへほ" },
				{ "ま", "まみむめも" },
				{ "や", "やゆよ" },
				{ "ら", "らりるれろ" },
				{ "わ", "わをん" },
			};
		}

		/// <summary>
		///  あ段か判定する処理
		/// </summary>
		/// <param name="targetString">判定対象の文字列</param>
		/// <returns>あ段であれば真、あ段でなければ偽を返す</returns>
		public bool ValidatAColumn(string targetString)
		{
			if (hiraganaArr.ContainsKey(targetString))
			{
				return (true);
			}
			return (false);
		}

		/// <summary>
		/// あ段に対応する行を返す
		/// </summary>
		/// <param name="targetHiragana">あ段</param>
		/// <returns>引数のあ段に対応する行</returns>
		public string GetTargetHiraganaRow(string targetHiragana)
		{
			string matchHiraganaRow;

			matchHiraganaRow = hiraganaArr[targetHiragana];

			return (matchHiraganaRow);
		}
	}
}
