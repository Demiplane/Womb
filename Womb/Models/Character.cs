using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Models
{
    public class Character
    {
        public string Name
        {
            get;
            set;
        }

        public Class Class
        {
            get;
            set;
        }

        public Race Race
        {
            get;
            set;
        }

        public string Subrace
        {
            get;
            set;
        }

        public string Subclass
        {
            get;
            set;
        }
        

        public IDictionary<string, int> Stats
        {
            get;
            set;
        } = new Dictionary<string, int>();
    }
}
