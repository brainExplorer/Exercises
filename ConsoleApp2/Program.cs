using ConsoleApp2;
using System;
using System.Text.RegularExpressions;
using ConsoleApp2.Design_Patterns;
class Test
{
    public static void Main()
    {
       Number number = new Number();
        List<int> numb = new List<int>();
        
        string i="";
        string choice=String.Empty;           
        numb.Clear();

        Console.WriteLine("Please choice process\nAdditing => a \tDivision => d \tMultiplying => m \tSubtracting => s");
        choice = Console.ReadLine().ToLower();
        if (choice == "d")
        {
            Console.WriteLine("Enter 2 numbers");
            for (int k = 0; k < 2; k++)
            {
                numb.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine($"Rsult is {number.get2Number(numb.First(), numb.Last())}");
        }

        else
        {
            Console.WriteLine("You can typing your values.\nIf you wanna pass the next value you press Enter key.\nPlease enter 'e' or 'E' if it done.");
            while (i != "e")
            {
                i = Console.ReadLine();

                if (i.ToLower() == "e")
                {
                    i = "e";
                    break;
                }
                numb.Add(Int32.Parse(i));

            }

            Console.WriteLine($"Result is {number.getNumbers(numb.ToArray(), choice)}");
        }

          
       
    }


    private static void RegularExp()
    {
        string text = "The next morning we travelled through time rather than space, arriving just just before sunrise at the 7,500 7,500-year-old stone circle of of Almendres Cromlech," +
    " another landmark on the Dark Sky Route, located near the Unesco World Heritage city city of Évora." +
    " The biggest prehistoric monument on the the Iberian Peninsula isn't gated and " +
    "can be visited by day or by night – it looks especially awe-inspiring under the pale glow of the moon. (BBC News)";

        string[] numbers = { "45", text, "-8", "7ıytd2", "51", "design", "-6894", "1743", "58966820", "home" };

        catchTheSameWord(text);
        catchTheNumbers(numbers);
    }
    private static void catchTheSameWord(string text)
    {
        
        string pattern = @"\b(?<word>\w+)\s+(\k<word>)\b";
        //define a reg. exp. for repeated words
        Regex regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline);

        MatchCollection matchCollection = regex.Matches(text);

        // We didn't assigned as a 'var' type. If we did it, we couldn't call the Groups extension.
        foreach (Match item in matchCollection)
        {
            // It keeps a collection of single match.
            GroupCollection groupCollection = item.Groups;

            // 'word' referenced twice or multiple same words.
            Console.WriteLine($"'{groupCollection["word"].Value}'s positions are {groupCollection[0].Index} and {groupCollection[1].Index}.");
        }
    }

    private static void catchTheNumbers(string[] numbers)
    {
        string pattern = @"^-?[0-9][0-9,\.]+$";
        Regex rgx = new Regex(pattern);        
        Console.WriteLine("\nMatched items : ");
        foreach (string? item in numbers)
        {
            if (rgx.IsMatch(item))
            {
                Console.WriteLine($"{item}");
            }
        }
    }

}

/*
 \b : match boundary words like in \b\w+\s\w+\b pattern.
  ? : the previous element zero or one time
 \k< word > :  Matches the value of a word expression.
 \s+ : Matches one or more white-space character(s).
 () : it uses to subexpressions.
 */

/* Reference address : https://docs.microsoft.com/tr-tr/dotnet/api/system.text.regularexpressions.regex?view=net-6.0 */