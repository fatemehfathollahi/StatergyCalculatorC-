﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebCalculator.Helper
{
    public enum Operation
    {
        [Description("/")]
        Divide,
        [Description("-")]
        Minus ,
        [Description("*")]
        MultiPly,
        [Description("+")]
        Plus
    }
}