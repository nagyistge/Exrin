﻿using Exrin.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrin.Framework
{
    public class NavigationArgs: INavigationArgs
    {

        public object StackType { get; set; }

        public object Key { get; set; }

        public object Parameter { get; set; }

    }
}
