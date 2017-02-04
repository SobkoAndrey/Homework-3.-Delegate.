using System;
using Gtk;
using System.Collections.Generic;

namespace DelegateGTK
{
	class MainClass
	{
		public static List<StringWork> methodsList = new List<StringWork>();

		public delegate string StringWork(string text);

		public static string ToUpperString(string text)
		{
			string upperString = text.ToUpper();
			return upperString;
		}

		public static string TurnString(string text)
		{
			string turnedString = string.Empty;

			for (int i = (text.Length - 1); i >= 0; i -= 1)
			{
				turnedString += text[i];
			}

			return turnedString;
		}

		public static string AddSpacesToString(string text)
		{
			string stringWithSpaces = string.Empty;

			for (int i = 0; i < text.Length; i += 1)
			{
				stringWithSpaces += $"{text[i]} ";
			}

			return stringWithSpaces;
		}

		public static string StringOperations(string text, List<StringWork> methodsList)
		{

			string newString = text;

			for (int i = 0; i < methodsList.Count; i += 1)
			{
				newString = methodsList[i](newString);
			}

			return newString;
		}

		public static bool IsEmpty(string text)
		{
			return text.Length == 0;
		}

		public static void Main(string[] args)
		{
			Application.Init();
			MainWindow win = new MainWindow();
			win.Show();
			Application.Run();

		}
	}
}
