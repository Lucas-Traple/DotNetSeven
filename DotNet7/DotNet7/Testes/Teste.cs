using System;
using static System.String;
using static System.Console;
using DotNet7.Features;

namespace DotNet7.Testes;

public class Teste
{
    private const char EMPTY = ' ';

    public static void LetterCounter()
    {
        var word = "Lucas Traple";
        var counter = word
                        .ToUpper()
                        .Where(letter => letter != EMPTY)
                        .GroupBy(letter => letter)
                        .Select(letter => new
                        {
                            Letter = letter.Key,
                            Count = letter.Count()
                        }).ToList();

        WriteLine(word);
        counter.ForEach(letter =>
                    WriteLine($"""{nameof(letter.Letter)}: {letter.Letter} - {nameof(letter.Count)} {letter.Count}"""));
    }   

}

