using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : Component
    {
        private ArrayList _nodes = new ArrayList();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            _nodes.Add(component);
        }

        public override Component GetChild(int index)
        {
            return _nodes[index] as Component;
        }

        public override void Operation()
        {
            Console.WriteLine(name);

            foreach (Component node in _nodes)
            {
                node.Operation();
            }
        }

        public override void Remove(Component component)
        {
            _nodes.Remove(component);
        }
    }
}
