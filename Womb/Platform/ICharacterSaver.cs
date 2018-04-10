using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Womb.Models;

namespace Womb.Platform
{
    public interface ICharacterSaver
    {
        Task Save(Character character, Guid creatorId);
    }
}
