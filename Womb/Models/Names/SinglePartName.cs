using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Models.Names
{
    public sealed class SinglePartName : Name
    {
        public string Name
        {
            get;
            set;
        }

        public override string Format()
        {
            return this.Name;
        }
    }
}
