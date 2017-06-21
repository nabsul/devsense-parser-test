using System;
using System.IO;
using System.Text;
using Devsense.PHP.Syntax;

namespace devsense_parser_test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFile();
        }

        static void TestFile()
        {
            var fileName = "CliDumperTest.php";
            Lexer lexer = new Lexer(new StreamReader(File.OpenRead(fileName)), Encoding.UTF8, null, LanguageFeatures.Php71Set);
            Tokens token;
            while ((token = lexer.GetNextToken()) != Tokens.EOF)
            {
                Console.WriteLine($"Type: {token.ToString()}");
            }                    
        }

        static void TestString() 
        {
            string stringToParse = "<?php  $x = <<<EOTXT\n  \"closure\" => Closure {{$r}\n  }";
            Lexer lexer = new Lexer(new StringReader(stringToParse), Encoding.UTF8, null, LanguageFeatures.Php71Set);
            Tokens token;
            while ((token = lexer.GetNextToken()) != Tokens.EOF)
            {
                Console.WriteLine($"Type: {token.ToString()}");
            }        
        }
    }
}
