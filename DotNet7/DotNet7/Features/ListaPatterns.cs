using System;
using static System.Console;

namespace DotNet7.Features;

public static class ListaPatterns
{
	public static void ListaPatternsMethod()
	{
		int[] arr1 = { 1, 2, 10 };
		int[] arr2 = { 1, 2, 5, 10 };
		int[] arr3 = { 1, 2, 5, 6, 7, 8, 9, 10 };

        WriteLine(CheckSwitch(arr1));
        WriteLine(CheckSwitch(arr2));
        WriteLine(CheckSwitch(arr3));
	}

	private static int CheckSwitch(int[] values) =>
		values switch
		{
			[1, 2, .., 10] => 1,
			[1, 2] => 2,
			[1, _] => 3,
			[1, ..] => 4,
			[..] => 50
		};
		
}

