﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDecorPattern.Decorators
{
    public class Emphasized : TextDecorator, IEmphasized
    {
        public Emphasized(IText text) : base(text)
        {
            StartTag = "<em>";
            EndTag = "</em>";
        }
    }
}
