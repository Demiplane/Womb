using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Models.Names
{
    public sealed class TwoPartName : Name
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public override string Format()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
