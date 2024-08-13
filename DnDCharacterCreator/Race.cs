using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator
{
    public class Race
    {

        public string name;
        public string ability;
        //public string modifierDisplay;
        public List<string> allowedClasses;

        public int STR_Mod = 0;
        public int INT_Mod = 0;
        public int WIS_Mod = 0;
        public int DEX_Mod = 0;
        public int CON_Mod = 0;
        public int CHA_Mod = 0;



        public int STR_Min = 0;
        public int INT_Min = 0;
        public int WIS_Min = 0;
        public int DEX_Min = 0;
        public int CON_Min = 0;
        public int CHA_Min = 0;

        public Race()
        {
            name = "";
        }

        public void OnSelected()
        {
            
        }

        public virtual void Validate(CharacterInfo CI)
        {
            Form1.ResolveRaceError();
        }


        /// <summary>
        /// Takes the bool result from Validate() and calls the corresponding form1 methods
        /// </summary>
        /// <param name="result"></param>
        public void HandleValidation(bool hasError)
        {
            if (hasError)
                Form1.instance.ThrowRaceError();
            else
                Form1.instance.ResolveRaceError();
        }
    }

    public class Dwarf : Race
    {
        public Dwarf()
        {
            name = "Dwarf";
            CHA_Mod = -1;
            CON_Mod = 1;
            CON_Min = 9;
            ability = "Infravision";

            allowedClasses.AddRange(new string[] { "Bard", "Cleric", "Fighter", "Thief" });
        }

        public override void Validate(CharacterInfo CI)
        {
            bool hasError = false;
            if (CI.CON < CON_Min)
            {
                hasError = true;
            }
            HandleValidation(hasError);

        }
    }



    public class Elf : Race
    {

        public Elf()
        {
            name = "Elf";


            INT_Min = 9;

            CON_Mod = -1;
            DEX_Mod = 1;
            ability = "Detect Secret Doors";
            allowedClasses.AddRange(new string[] { "Cleric", "Druid", "Fighter", "Ranger", "Thief", "Wizard" });

        }

        public override void Validate(CharacterInfo CI)
        {
            bool hasError = false;
            if (CI.INT < INT_Min)
            {
                hasError = true;
            }

            HandleValidation(hasError);

        }

    }

    public class Gnome : Race
    {

        public Gnome()
        {
            name = "Gnome";

            CON_Min = 9;
            INT_Min = 9;

            ability = "Defensive Bonus";

            allowedClasses.AddRange(new string[] { "Cleric", "Fighter", "Thief", "Wizard" });


        }

        public override void Validate(CharacterInfo CI)
        {
            bool hasError = false;

            if (CI.CON < CON_Min)
                hasError = true;

            if (CI.INT < INT_Min)
                hasError = true;

            HandleValidation(hasError);

        }

    }



    public class Halfling : Race
    {
        public Halfling()
        {
            name = "Halfling";


            CON_Min = 9;
            DEX_Min = 9;

            DEX_Mod = 1;

            ability = "Initiative Bonus";

            allowedClasses.AddRange(new string[] { "Bard", "Druid", "Fighter", "Thief" });

        }
        public override void Validate(CharacterInfo CI)
        {
            bool hasError = false;

            if (CI.CON < CON_Min)
                hasError = true;

            if (CI.DEX < DEX_Min)
                hasError = true;

            HandleValidation(hasError);

        }
    }

    public class Human: Race
    {
        public Human()
        {
            name = "Human";

            ability = "None";
            allowedClasses.AddRange(new string[] { "Bard","Cleric", "Druid", "Fighter", "Ranger", "Thief", "Wizard" });
        }

        //humans are different in that they have no stat minimums, so we will always resolve validation
        public override void Validate(CharacterInfo CI)
        {
            Form1.ResolveRaceError();
        }

    }
}
