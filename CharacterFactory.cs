using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public partial class Character
    {
        public static class CharacterFactory
        {
            private static Dictionary<string, Character> _characterCache = new Dictionary<string, Character>();
            public static Character GetCharacter(string name, string type, string image)
            {
                string key = name + type;
                if (_characterCache.ContainsKey(key))
                {
                    return _characterCache[key];
                }
                else
                {
                    Character newCharacter = new Character(name, type, image);
                    _characterCache[key] = newCharacter;
                    return newCharacter;
                }
            }
        }
    }
}
