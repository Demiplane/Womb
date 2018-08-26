﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Womb.Models;
using Womb.Models.Names;

namespace Womb.ViewModels
{
    public class CharacterViewModel
    {
        public Character Character
        {
            get;
            set;
        }

        public CharacterViewModel(Character character)
        {
            this.Character = character;
            this.Name = character.Name.Format();
            this.Race = character.Race.Name.Format();
            this.Subrace = character.Subrace;
            this.Class = character.Class.ToString();
            this.Subclass = character.Subclass;
            this.Background = character.Background.Format();
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
