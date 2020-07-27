using System;

namespace LongestPalindromSubString
{ 

class Program
{

	public static void printSubStr(string str,int low, int high)
	{
		Console.WriteLine(str.Substring(low,(high + 1) - low));
	}
	public static int longestPalSubstr(string str)
	{
		int maxLength = 1; // The result length

		int start = 0;
		int len = str.Length;

		int low, high;

		for (int i = 1; i < len; ++i)
		{
			low = i - 1;
			high = i;
			while (low >= 0 && high < len && str[low] == str[high])
			{
				if (high - low + 1 > maxLength)
				{
					start = low;
					maxLength = high - low + 1;
				}
				--low;
				++high;
			}

			low = i - 1;
			high = i + 1;
			while (low >= 0 && high < len && str[low] == str[high])
			{
				if (high - low + 1 > maxLength)
				{
					start = low;
					maxLength = high - low + 1;
				}
				--low;
				++high;
			}
		}

		Console.Write("Longest palindrome substring is: ");
		printSubStr(str, start, start + maxLength - 1);

		return maxLength;
	}

	// Driver Code 
	public static void Main(string[] args)
	{
			Console.WriteLine("Enter Your String : ");
			bool flag = false;
		string str = Console.ReadLine();
			while(!flag)
			if (string.IsNullOrWhiteSpace(str)){
				flag = true;
				Console.WriteLine("Length is: " + longestPalSubstr(str));

			}
			else
			{
				flag = false;
					Console.WriteLine("Please Write");
			}
	}
}
}
