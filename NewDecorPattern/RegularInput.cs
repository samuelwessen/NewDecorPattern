using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDecorPattern
{
    class RegularInput : IRegularInput
    {
        public string TextInput { get; set; }

        public RegularInput()
        {
            TextInput = "";
        }

        public string GetTextInput()
        {
            return TextInput;
        }

        public void SetUserInput()
        {
            bool validInput = false;
            while (!validInput)
            {
                string userInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    validInput = true;
                    TextInput = userInput;
                }
            }
        }
    }
}
