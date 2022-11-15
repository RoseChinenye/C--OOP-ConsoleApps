using System;

namespace CodeCracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {
                    Console.WriteLine("Enter Letter to encrypt: ");
                    string? encryptLetter = Console.ReadLine().ToLower();

                    switch (encryptLetter)
                    {
                        case "a":
                            Console.WriteLine("£");
                            break;
                        case "b":
                            Console.WriteLine("*");
                            break;
                        case "c":
                            Console.WriteLine("%");
                            break;
                        case "d":
                            Console.WriteLine("&");
                            break;
                        case "e":
                            Console.WriteLine(">");
                            break;
                        case "f":
                            Console.WriteLine("<");
                            break;
                        case "g":
                            Console.WriteLine("!");
                            break;
                        case "h":
                            Console.WriteLine(")");
                            break;
                        case "i":
                            Console.WriteLine("\"");
                            break;
                        case "j":
                            Console.WriteLine("(");
                            break;
                        case "k":
                            Console.WriteLine("@");
                            break;
                        case "l":
                            Console.WriteLine("a");
                            break;
                        case "m":
                            Console.WriteLine("b");
                            break;
                        case "n":
                            Console.WriteLine("c");
                            break;
                        case "o":
                            Console.WriteLine("d");
                            break;
                        case "p":
                            Console.WriteLine("e");
                            break;
                        case "q":
                            Console.WriteLine("f");
                            break;
                        case "r":
                            Console.WriteLine("g");
                            break;
                        case "s":
                            Console.WriteLine("h");
                            break;
                        case "t":
                            Console.WriteLine("i");
                            break;
                        case "u":
                            Console.WriteLine("j");
                            break;
                        case "v":
                            Console.WriteLine("k");
                            break;
                        case "w":
                            Console.WriteLine("l");
                            break;
                        case "x":
                            Console.WriteLine("m");
                            break;
                        case "y":
                            Console.WriteLine("n");
                            break;
                        case "z":
                            Console.WriteLine("o");
                            break;
                        default:
                            Console.WriteLine("Try again Later...");
                            break;

                    }
                    Console.WriteLine("Enter Letter to decrypt: ");
                    string? decryptLetter = Console.ReadLine();

                    switch (decryptLetter)
                    {
                        case "£":
                            Console.WriteLine("a");
                            break;
                        case "*":
                            Console.WriteLine("b");
                            break;
                        case "%":
                            Console.WriteLine("c");
                            break;
                        case "&":
                            Console.WriteLine("d");
                            break;
                        case ">":
                            Console.WriteLine("e");
                            break;
                        case "<":
                            Console.WriteLine("f");
                            break;
                        case "!":
                            Console.WriteLine("g");
                            break;
                        case ")":
                            Console.WriteLine("h");
                            break;
                        case "\"":
                            Console.WriteLine("i");
                            break;
                        case "(":
                            Console.WriteLine("j");
                            break;
                        case "@":
                            Console.WriteLine("k");
                            break;
                        case "a":
                            Console.WriteLine("l");
                            break;
                        case "b":
                            Console.WriteLine("m");
                            break;
                        case "c":
                            Console.WriteLine("n");
                            break;
                        case "d":
                            Console.WriteLine("o");
                            break;
                        case "e":
                            Console.WriteLine("p");
                            break;
                        case "f":
                            Console.WriteLine("q");
                            break;
                        case "g":
                            Console.WriteLine("r");
                            break;
                        case "h":
                            Console.WriteLine("s");
                            break;
                        case "i":
                            Console.WriteLine("t");
                            break;
                        case "j":
                            Console.WriteLine("u");
                            break;
                        case "k":
                            Console.WriteLine("v");
                            break;
                        case "l":
                            Console.WriteLine("w");
                            break;
                        case "m":
                            Console.WriteLine("x");
                            break;
                        case "n":
                            Console.WriteLine("y");
                            break;
                        case "o":
                            Console.WriteLine("z");
                            break;
                        default:
                            Console.WriteLine("Try again Later...");
                            break;
                         }
                    }

                }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
                    
            }


        }
    }
}