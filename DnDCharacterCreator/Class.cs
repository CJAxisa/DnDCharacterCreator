using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator
{

    //It's so messed up to have a class named class, but I must.....
    public class Class
    {
        public string name;
        public int numDice;
        public int numDiceFaces;

        public string primeStat;

        public Class()
        {
            numDice = 1;
            numDiceFaces = 6;
            primeStat = "A";
        }

        public virtual void Validate(CharacterInfo CI)
        {
            bool hasError = true;
            foreach (string allowedClass in CI.charRace.allowedClasses)
            {
                if(allowedClass.Equals(name))
                    hasError = false;
            }

            HandleValidation(hasError);
        }

        public void HandleValidation(bool HasError)
        {
            if (HasError)
                Form1.instance.ThrowClassError();
            else
                Form1.instance.ResolveClassError();
        }
    }


    public class Bard : Class
    {

        public Bard()
        {
            name = "Bard";
            numDice = 1;
            numDiceFaces = 6;
            primeStat = "CHA";

        }
    }

    public class Cleric : Class
    {

        public Cleric()
        {
            name = "Cleric";
            numDice = 1;
            numDiceFaces = 6;
            primeStat = "WIS";
        }
    }

    public class Druid : Class
    {

        public Druid()
        {
            name = "Druid";
            numDice = 1;
            numDiceFaces = 6;
            primeStat = "WIS";
        }
    }

    public class Fighter : Class
    {

        public Fighter()
        {
            name = "Fighter";
            numDice = 1;
            numDiceFaces = 8;
            primeStat = "STR";
        }
    }

    public class Ranger : Class
    {

        public Ranger()
        {
            name = "Ranger";
            numDice = 1;
            numDiceFaces = 8;
            primeStat = "STR";
        }
    }

    public class Thief : Class
    {

        public Thief()
        {
            name = "Thief";
            numDice = 1;
            numDiceFaces = 4;
            primeStat = "DEX";
        }
    }


    public class Wizard : Class
    {

        public Wizard()
        {
            name = "Wizard";
            numDice = 1;
            numDiceFaces = 4;
            primeStat = "INT";
        }
    }


}
