using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Womb.Models;

namespace Womb.ViewModels
{
    public class CharacterViewModel
    {
        public CharacterViewModel(Character character)
        {
            this.Name = character.Name;
            this.Race = character.Race.Format();
            this.Subrace = character.Subrace;
            this.Class = character.Class.ToString();
            this.Subclass = character.Subclass;
            this.Background = "Lawyer";
            this.Stats = character.Stats.Select(kvp => KeyValuePair.Create(kvp.Key, kvp.Value + " (" + kvp.Value.GetModifierForValue() + ")"));
        }

        public string Name
        {
            get;
            set;
        }

        public string Class
        {
            get;
            set;
        }

        public string Race
        {
            get;
            set;
        }

        public string Subclass
        {
            get;
            set;
        }

        public string Subrace
        {
            get;
            set;
        }

        public String Background
        {
            get;
            set;
        }

        public IEnumerable<KeyValuePair<string, string>> Stats
        {
            get;
            set;
        }
    }
}
