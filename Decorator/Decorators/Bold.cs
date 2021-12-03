﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    public class Bold : TextDecorator, IBold
    {
       
        public Bold (IText text ): base(text)
        {
            StartTag = "<b>";
            EndTag = "</b>";           
        }
    }
}
