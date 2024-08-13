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

        public int STR_Mod { get; set; }
        public int INT_Mod { get; set; }
        public int WIS_Mod { get; set; }
        public int DEX_Mod { get; set; }
        public int CON_Mod { get; set; }
        public int CHA_Mod { get; set; }

        public int CON_HP_MOD { get; set; }

        public Race charRace;
        public Class charClass;

        public RaceEnum charRaceEnum { get; set; }

        public ClassEnum charClassEnum { get; set; }

        public int HitPoints { get; set; }
        public int StartingGold { get; set; }


        //Enums for RaceEnum and class will allow light storage and easy conversions
        public enum RaceEnum
        {
            None = 0,
            Dwarf = 1,
            Elf = 2,
            Gnome = 3,
            Halfling = 4,
            Human = 5
        }

        public enum ClassEnum
        {
            None = 0,
            Bard = 1,
            Cleric = 2,
            Druid = 3,
            Fighter = 4,
            Ranger = 5,
            Thief = 6,
            Wizard = 7
        }

        public CharacterInfo() 
        {
            charRace = new Race();
            charClass = new Class();
        }


        //alt constructor for JSON data
        public CharacterInfo(string json)
        {
            FromJson(json);
        }


        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public void FromJson(string json)
        {
            CharacterInfo Jason = JsonSerializer.Deserialize<CharacterInfo>(json);
            
            Name = Jason.Name;

            STR = Jason.STR;
            INT = Jason.INT;
            WIS = Jason.WIS;
            DEX = Jason.DEX;
            CON = Jason.CON;
            CHA = Jason.CHA;

            STR_Mod = Jason.STR_Mod;
            INT_Mod = Jason.INT_Mod;
            WIS_Mod = Jason.WIS_Mod;
            DEX_Mod = Jason.DEX_Mod;
            CON_Mod = Jason.CON_Mod;
            CHA_Mod = Jason.CHA_Mod;

            CON_HP_MOD = Jason.CON_HP_MOD;

            HitPoints  = Jason.HitPoints;
            StartingGold = Jason.StartingGold;
            charRace = Jason.charRace;
            charClass = Jason.charClass;
        }
    }
}
