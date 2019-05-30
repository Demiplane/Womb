using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Womb.Models;

namespace Womb.Characters
{
    public interface ICharacterBuilder
    {
        Character BuildCharacter();
    }
}
