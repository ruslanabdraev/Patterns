﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classic.PullModel
{
    public class ConcreteSubject: Subject
    {
        public string State { get; set; }
    }
}
