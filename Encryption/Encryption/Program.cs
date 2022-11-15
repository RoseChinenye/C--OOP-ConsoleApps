using System;

namespace Encryption
{
    public class Encrypt
    {
        char letter;
        string? encryptedMessage;

        public string encryptMessage(string messages)
        {
            List<string> encrypted = new List<string>();
            foreach (char message in messages.ToString())
            {
                switch (message)
                {
                    case 'a':
                        letter = '£';
                        break;
                    case 'b':
                        letter = '*';
                        break;
                    case 'c':
                        letter = '%';
                        break;
                    case 'd':
                        letter = '&';
                        break;
                    case 'e':
                        letter = '>';
                        break;
                    case 'f':
                        letter = '<';
                        break;
                    case 'g':
                        letter = '!';
                        break;
                    case 'h':
                        letter = ')';
                        break;
                    case 'i':
                        letter = '@';
                        break;
                    case 'j':
                        letter = 'a';
                        break;
                    case 'k':
                        letter = 'b';
                        break;
                    case 'l':
                        letter = 'c';
                        break;
                    case 'm':
                        letter = 'd';
                        break;
                    case 'n':
                        letter = 'e';
                        break;
                    case 'o':
                        letter = 'f';
                        break;
                    case 'p':
                        letter = 'g';
                        break;
                    case 'q':
                        letter = 'h';
                        break;
                    case 'r':
                        letter = 'i';
                        break;
                    case 's':
                        letter = 'j';
                        break;
                    case 't':
                        letter = 'k';
                        break;
                    case 'u':
                        letter = 'l';
                        break;
                    case 'v':
                        letter = 'm';
                        break;
                    case 'w':
                        letter = 'n';
                        break;
                    case 'x':
                        letter = 'o';
                        break;
                    case 'y':
                        letter = 'p';
                        break;
                    case 'z':
                        letter = 'q';
                        break;
                    default:
                        letter = message;
                        break;
                }
                encrypted.Add(letter.ToString());
            }
            encryptedMessage = string.Join("", encrypted);
            return encryptedMessage;

        }
    }

    public class Decrypt
    {
        char letter;
        string? decryptedMessage;
        public string decryptMessage(string messages)
        {
            List<string> decrypted = new List<string>();
            foreach (char message in messages.ToString())
            {
                switch (message)
                {
                    case '£':
                        letter = 'a';
                        break;
                    case '*':
                        letter = 'b';
                        break;
                    case '%':
                        letter = 'c';
                        break;
                    case '&':
                        letter = 'd';
                        break;
                    case '>':
                        letter = 'e';
                        break;
                    case '<':
                        letter = 'f';
                        break;
                    case '!':
                        letter = 'g';
                        break;
                    case ')':
                        letter = 'h';
                        break;
                    case '@':
                        letter = 'i';
                        break;
                    case 'a':
                        letter = 'j';
                        break;
                    case 'b':
                        letter = 'k';
                        break;
                    case 'c':
                        letter = 'l';
                        break;
                    case 'd':
                        letter = 'm';
                        break;
                    case 'e':
                        letter = 'n';
                        break;
                    case 'f':
                        letter = 'o';
                        break;
                    case 'g':
                        letter = 'p';
                        break;
                    case 'h':
                        letter = 'q';
                        break;
                    case 'i':
                        letter = 'r';
                        break;
                    case 'j':
                        letter = 's';
                        break;
                    case 'k':
                        letter = 't';
                        break;
                    case 'l':
                        letter = 'u';
                        break;
                    case 'm':
                        letter = 'v';
                        break;
                    case 'n':
                        letter = 'w';
                        break;
                    case 'o':
                        letter = 'x';
                        break;
                    case 'p':
                        letter = 'y';
                        break;
                    case 'q':
                        letter = 'z';
                        break;
                    default:
                        letter = message;
                        break;
                }
                decrypted.Add(letter.ToString());
            }
            decryptedMessage = string.Join("", decrypted);
            return decryptedMessage;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string? messages;
                Console.WriteLine("Enter a Message to encrypt: ");
                messages = Console.ReadLine().ToLower();

                Encrypt Encrypt = new Encrypt();
                string result = Encrypt.encryptMessage(messages);
                Console.WriteLine("Encrypted Message is: {0}", result);

                Console.WriteLine("Press Enter to decrypt: ");
                Console.ReadKey(true);

                Decrypt Decrypt = new Decrypt();
                string decrypted = Decrypt.decryptMessage(result);
                Console.WriteLine("Decrypted Message is: {0}",decrypted);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}