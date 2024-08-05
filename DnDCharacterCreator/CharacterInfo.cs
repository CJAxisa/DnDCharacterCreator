using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DnDCharacterCreator
{
    public class CharacterInfo
    {
        public string Name {  get; set; }
        public int STR {  get; set; }
        public int INT { get; set; }
        public int WIS { get; set; }
        public int DEX { get; set; }
        public int CON {  get; set; }

        public int CHA { get; set; }

        public Race charRace { get; set; }

        public Class charClass { get; set; }

        public int HitPoints { get; set; }
        public int StartingGold { get; set; }

        public enum Race
        {
            Dwarf = 1,
            Elf = 2,
            Gnome = 3,
            Halfling = 4,
            Human = 5
        }

        public enum Class
        {
            Bard = 1,
            Cleric = 2,
            Druid = 3,
            Fighter = 4,
            Ranger = 5,
            Thief = 6,
            Wizard = 7
        }

        public CharacterInfo() { }

    }
}
