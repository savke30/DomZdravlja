﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomZdravlja.AttributeClass
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Invisible:Attribute
    {

        public Use Use { get; set; }

        public Invisible(Use use)
        {
            Use = use;
        }
    }
}
