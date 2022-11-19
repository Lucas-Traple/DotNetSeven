using System;
using static System.String;
using static System.Console;

namespace DotNet7.Features;

public static class InterpolatedChain
{
	public static void InterpolatedChainMethod()
	{
		List<int> lista = new()
		{
			3,5,4,2,7,
		}; 
		var text = $"Minha lista {lista
									.Order()
									.FirstOrDefault()}";

		var text1 = """
					ververv
						erverv
					aerqer
					aervervwerv
					ervwervvr
					""";

		var latitude = 0;
        var text2 = $"""
					ververv
						erverv
					aerqer
					{latitude}
					ervwervvr
					""";

        var text3 = $$"""
					ververv
						erverv
					aerqer
					{{{latitude}}}
					ervwervvr
					""";

        WriteLine(text);
        WriteLine();
        WriteLine(text1);
        WriteLine();
        WriteLine(text2);
        WriteLine();
        WriteLine(text3);
    }
}