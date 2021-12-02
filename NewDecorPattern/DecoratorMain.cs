using NewDecorPattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDecorPattern
{
    public class DecoratorMain
    {
        public static void DecRun()
        {
            Console.WriteLine("Decorator");
            Console.WriteLine("----------------------");                      
            Console.WriteLine("Selet an Tag-Style");
            Console.WriteLine("----------------------");
            Console.WriteLine("A: Show finished text");
            Console.WriteLine("B: Add Bold");
            Console.WriteLine("C: Add Deleted");
            Console.WriteLine("D: Add Emphasized");
            Console.WriteLine("E: Add Important");
            Console.WriteLine("F: Add Inserted");
            Console.WriteLine("G: Add Italic");
            Console.WriteLine("H: Add Marked");
            Console.WriteLine("I: Add Smaller");
            Console.WriteLine("J: Add SubScript");
            Console.WriteLine("K: Add SuperScript");
            Console.WriteLine("X: Quit Program");
            
            Console.WriteLine("Please enter your text");

            var inputText = Factory.CreateInputText();

            inputText.SetUserInput();

            var newInputText = inputText;

            while (true)
            {

                Console.WriteLine("Add a tag style or press A for finished: ");
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        Console.WriteLine($"Decorated text: {inputText.GetTextInput()}");
                        inputText = newInputText;
                        break;

                    case 'b' or 'B':
                        Console.WriteLine("Add Bold text");
                        inputText = new Bold(inputText);
                        break;

                    case 'c' or 'C':
                        Console.WriteLine("Add Deleted text");
                        inputText = new Deleted(inputText);
                        break;

                    case 'd' or 'D':
                        Console.WriteLine("Add Emphasized text");
                        inputText = new Emphasized(inputText);
                        break;

                    case 'e' or 'E':
                        Console.WriteLine("Add Important text");
                        inputText = new Important(inputText);
                        break;

                    case 'f' or 'F':
                        Console.WriteLine("Add Inserted text");
                        inputText = new Inserted(inputText);
                        break;

                    //case 'g' or 'G':
                    //    Console.WriteLine("Add Italic text");
                    //    inputText = new Italic(inputText);
                    //    break;

                    //case 'h' or 'H':
                    //    Console.WriteLine("Add Marked text");
                    //    decor = new Marked(decor);
                    //    break;
                    //case 'i' or 'I':
                    //    Console.WriteLine("Add Smaller text");
                    //    decor = new Smaller(decor);
                    //    break;
                    //case 'j' or 'J':
                    //    Console.WriteLine("Add SubScript text");
                    //    decor = new SubScript(decor);
                    //    break;

                    //case 'k' or 'K':
                    //    Console.WriteLine("Add SuperScript text");
                    //    decor = new SuperScript(decor);
                    //    break;

                    case 'x' or 'X':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }

        }
    }
}
