/*
In C#, Split() is a string class method. The Split() method returns an array of strings generated by splitting of original string separated by the delimiters passed as a parameter in Split() method. The delimiters can be a character or an array of characters or an array of strings. Or you can also say that it returns a string array which contains the substrings in the current instance that are delimited by elements of a specified string or Unicode character array.
*/
// Split(String[], Int32, StringSplitOptions)
// Method
using System;
class Progrm
{
	public static void Main(string[] args)
	{
		string line = "Write, a C# Sharp, Program to display the following pattern";
		int n=3;
		foreach(var s in line.Split(','))
		{
			Console.WriteLine(s);
		}
		Console.Read();
	}
}