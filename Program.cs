using System;

namespace devsense_parser_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToParse = "<?php  $x = <<<EOTXT\n  \"closure\" => Closure {{$r}\n  }";
            Lexer lexer = new Lexer(new StringReader(stringToParse), Encoding.UTF8, null, LanguageFeatures.Php71Set);
            Tokens token;
            while ((token = lexer.GetNextToken()) != Tokens.EOF)
            {
                Console.WriteLine($"Type: {token.ToString()}");
            }        }
    }
}
