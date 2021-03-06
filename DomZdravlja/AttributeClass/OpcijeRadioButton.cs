﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomZdravlja.AttributeClass
{
    [AttributeUsage(AttributeTargets.Property)]
    public class OpcijeRadioButton : Attribute
    {
        public string Param1 { get; set; }
        public string Param2 { get; set; }

        public object Vrijednost1 { get; set; }
        public object Vrijednost2 { get; set; }

        public OpcijeRadioButton(string Param1, string Param2, object vrijednost1, object vrijednost2)
        {
            this.Param1 = Param1;
            this.Param2 = Param2;
            Vrijednost1 = vrijednost1;
            Vrijednost2 = vrijednost2;
        }
    }
}
