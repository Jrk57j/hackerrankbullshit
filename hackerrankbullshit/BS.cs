﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankbullshit
{
	public class BS
	{
		public BS() { }

		public void OutputString(string funcName, string answerStr)
		{
			Console.WriteLine($"Solution for  {funcName}");
			Console.WriteLine("-------------------------------------");
			Console.WriteLine(answerStr);
			Console.WriteLine("-------------------------------------");
			Console.WriteLine();
		}

		public void OutputIntList(string funcName, List<int> arr)
		{
			Console.WriteLine($"Solution for {funcName}");
			Console.WriteLine("-------------------------------------");
			foreach(var item in arr)
			{
				Console.Write(item);
			}
			Console.WriteLine();
			Console.WriteLine("-------------------------------------");
			Console.WriteLine();
		}

		public void OutputIntArray(string funcName, int[] arr)
		{
			Console.WriteLine($"Solution for {funcName}");
			Console.WriteLine("-------------------------------------");
			foreach(var item in arr)
			{
				Console.Write(item);
			}
			Console.WriteLine();
			Console.WriteLine("-------------------------------------");
			Console.WriteLine();
		}

		public void OutputInt(string funcName, int val)
		{
			Console.WriteLine($"Solution for  {funcName}e");
			Console.WriteLine("-------------------------------------");
			Console.WriteLine(val);
			Console.WriteLine("-------------------------------------");
			Console.WriteLine();
		}
	}
}