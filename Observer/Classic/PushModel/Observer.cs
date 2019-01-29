using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classic.PushModel
{
    public abstract class Observer
    {
        public abstract void Update(string state);
    }
}
