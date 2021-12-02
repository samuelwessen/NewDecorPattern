using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDecorPattern
{
    public class Factory
    {
        public static IText CreateInputText()
        {
            return new RegularInput();
        }
    }
}
