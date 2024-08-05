using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCharacterCreator
{
    public partial class Form1 : Form
    {

        #region Variables

        Random RNG;

        CharacterInfo currentCharacter;

        private bool hasRaceError;
        private bool hasClassError;
        private bool hasHPBeenRolled = false;

        #endregion
        public Form1()
        {
            InitializeComponent();
            RNG = new Random();
            currentCharacter = new CharacterInfo();
            RollDefaultValues();
        }

        #region Utility

        /// <summary>
        /// Used to get default ability scores when app is initially opened
        /// </summary>
        public void RollDefaultValues()
        {
            STR_Reroll();
            INT_Reroll();
            WIS_Reroll();
            DEX_Reroll();
            CON_Reroll();
            CHA_Reroll();
            CHA_Reroll();
            GoldRoll();

            //Commented out for now, user should use SOME input other than default values
            //IMO Rolling for character health is part of the DnD char creation experience. can be reworked if need be
            //HP_Roll();
        }

        /// <summary>
        /// quick Utility for rolling x amount of Y sided dice and getting sum
        /// </summary>
        /// <param name="numDice"></param>
        /// <param name="numSides"></param>
        /// <returns></returns>
        public int RollDice(int numDice, int numSides)
        {
            int sum = 0;
            for (int i = 0; i < numDice; i++)
            {
                sum += RNG.Next(1, numSides + 1);
            }
            
            return sum;
        }


        /// <summary>
        /// This should take a character info and have all info on the app update to match the given char
        /// </summary>
        /// <param name="characterInfo"></param>
        public void UpdateFromCharacterInfo(CharacterInfo characterInfo)
        {
            currentCharacter = characterInfo;

            rchTxtBox_CharName.Text = characterInfo.Name;

            lbl_STR_mod.Text = characterInfo.STR_Mod.ToString();
            lbl_INT_mod.Text = characterInfo.INT_Mod.ToString();
            lbl_WIS_mod.Text = characterInfo.WIS_Mod.ToString();
            lbl_DEX_mod.Text = characterInfo.DEX_Mod.ToString();
            lbl_CON_mod.Text = characterInfo.CON_Mod.ToString();
            lbl_CHA_mod.Text = characterInfo.CHA_Mod.ToString();

            lbl_STR_roll.Text = characterInfo.STR.ToString();
            lbl_INT_roll.Text = characterInfo.INT.ToString();
            lbl_WIS_roll.Text = characterInfo.WIS.ToString();
            lbl_DEX_roll.Text = characterInfo.DEX.ToString();
            lbl_CON_roll.Text = characterInfo.CON.ToString();
            lbl_CHA_roll.Text = characterInfo.CHA.ToString();

            comboBox_Race.SelectedIndex = (int)characterInfo.charRace-1;
            comboBox_Race.Refresh();
            SelectNewRace(characterInfo.charRace);

            comboBox_Class.SelectedIndex = (int)characterInfo.charClass-1;
            comboBox_Class.Refresh();
            SelectNewClass(characterInfo.charClass);

            lbl_Total_HP.Text = currentCharacter.HitPoints.ToString();
            lbl_HP_CON_Mod.Text = currentCharacter.CON_HP_MOD.ToString();
            lbl_HP_roll.Text = (currentCharacter.HitPoints - currentCharacter.CON_HP_MOD).ToString();


            lbl_Start_Gold_value.Text = characterInfo.StartingGold.ToString();

        }


        /// <summary>
        /// Check if newRace minimum stat condition is met. If not, flag the newRace error bool and make the warning visible
        /// </summary>
        /// <param name="newRace"></param>
        public void CheckForRaceError(CharacterInfo.Race newRace)
        {
            switch (newRace)
            {
                case CharacterInfo.Race.None:
                    break;
                case CharacterInfo.Race.Dwarf:
                    if(currentCharacter.CON + currentCharacter.CON_Mod<9)
                        hasRaceError = true;
                    else
                        hasRaceError = false;
                    break;
                case CharacterInfo.Race.Elf:
                    if(currentCharacter.INT + currentCharacter.INT_Mod<9)
                        hasRaceError = true;
                    else
                        hasRaceError = false;
                    break;
                case CharacterInfo.Race.Gnome:
                    if (currentCharacter.CON + currentCharacter.CON_Mod < 9 ||
                        currentCharacter.INT + currentCharacter.INT_Mod < 9)
                        hasRaceError = true;
                    else
                        hasRaceError = false;
                    break;
                case CharacterInfo.Race.Halfling:
                    if (currentCharacter.CON + currentCharacter.CON_Mod < 9 ||
                        currentCharacter.DEX + currentCharacter.DEX_Mod < 9)
                        hasRaceError = true;
                    else
                        hasRaceError = false;
                    break;
                case CharacterInfo.Race.Human:
                    //no stat min for humans, so they wont ever cause newRace error
                    hasRaceError = false;
                    break;
                default:
                    break;
            }

            lbl_Race_Error.Visible = hasRaceError;

        }


        /// <summary>
        /// Make sure character race is allowed to use given class
        /// </summary>
        /// <param name="newClass"></param>
        public void CheckForClassError(CharacterInfo.Class newClass)
        {
            switch (currentCharacter.charRace)
            {
                case CharacterInfo.Race.None:
                    hasClassError = false;
                    break;
                case CharacterInfo.Race.Dwarf:
                    if (newClass == CharacterInfo.Class.Druid ||
                        newClass == CharacterInfo.Class.Ranger ||
                        newClass == CharacterInfo.Class.Wizard)
                        hasClassError = true;
                    else
                        hasClassError = false;
                    break;
                case CharacterInfo.Race.Elf:
                    if (newClass == CharacterInfo.Class.Bard)
                        hasClassError = true;
                    else
                        hasClassError = false;
                    break;
                case CharacterInfo.Race.Gnome:
                    if (newClass == CharacterInfo.Class.Bard ||
                        newClass == CharacterInfo.Class.Druid ||
                        newClass == CharacterInfo.Class.Ranger)
                        hasClassError = true;
                    else
                        hasClassError = false;
                    break;
                case CharacterInfo.Race.Halfling:
                    if (newClass == CharacterInfo.Class.Cleric ||
                        newClass == CharacterInfo.Class.Ranger ||
                        newClass == CharacterInfo.Class.Wizard)
                        hasClassError = true;
                    else
                        hasClassError = false;
                    break;
                case CharacterInfo.Race.Human:
                    hasClassError = false;
                    break;
                default:
                    break;
            }

            lbl_Class_Error.Visible = hasClassError;
        }


        public void ResetHP()
        {
            currentCharacter.HitPoints = 0;
            lbl_HP_roll.Text = "0";
            lbl_Total_HP.Text = "0";
            btn_HP_Reroll.Text = "Roll";
            hasHPBeenRolled= false;
        }



        private void STR_Reroll()
        {
            currentCharacter.STR = RollDice(3, 6);
            lbl_STR_roll.Text = currentCharacter.STR.ToString();
            CheckForRaceError(currentCharacter.charRace);
        }

        private void INT_Reroll()
        {
            currentCharacter.INT = RollDice(3, 6);
            lbl_INT_roll.Text = currentCharacter.INT.ToString();
            CheckForRaceError(currentCharacter.charRace);
        }

        private void WIS_Reroll()
        {
            currentCharacter.WIS = RollDice(3, 6);
            lbl_WIS_roll.Text = currentCharacter.WIS.ToString();
            CheckForRaceError(currentCharacter.charRace);
        }

        private void DEX_Reroll()
        {
            currentCharacter.DEX = RollDice(3, 6);
            lbl_DEX_roll.Text = currentCharacter.DEX.ToString();
            CheckForRaceError(currentCharacter.charRace);
        }

        private void CON_Reroll()
        {
            currentCharacter.CON = RollDice(3, 6);
            lbl_CON_roll.Text = currentCharacter.CON.ToString();
            CheckForRaceError(currentCharacter.charRace);

            //now we must handle the Constitution modifier as it relates to calculating HP
            if (currentCharacter.CON <= 3)
                currentCharacter.CON_HP_MOD = -3;
            else if (currentCharacter.CON <= 5)
                currentCharacter.CON_HP_MOD = -2;
            else if (currentCharacter.CON <= 8)
                currentCharacter.CON_HP_MOD = -1;
            else if (currentCharacter.CON <= 12)
                currentCharacter.CON_HP_MOD = 0;
            else if (currentCharacter.CON <= 15)
                currentCharacter.CON_HP_MOD = 1;
            else if (currentCharacter.CON <= 17)
                currentCharacter.CON_HP_MOD = 2;
            else if (currentCharacter.CON <= 20)
                currentCharacter.CON_HP_MOD = 3;

            lbl_HP_CON_Mod.Text = currentCharacter.CON_HP_MOD.ToString();

            //since CON MOD afects how HP is determined, user will need to reroll HP
            ResetHP();
        }

        private void CHA_Reroll()
        {
            currentCharacter.CHA = RollDice(3, 6);
            lbl_CHA_roll.Text = currentCharacter.CHA.ToString();
            CheckForRaceError(currentCharacter.charRace);
        }


        private void HP_Roll()
        {
            //Depending on what class we are, we need to roll different dice
            if (lbl_Class_hit_dice_value.Text.Equals("1d6"))
            {
                currentCharacter.HitPoints = RollDice(1, 6);
            }
            if (lbl_Class_hit_dice_value.Text.Equals("1d8"))
            {
                currentCharacter.HitPoints = RollDice(1, 8);
            }
            if (lbl_Class_hit_dice_value.Text.Equals("1d4"))
            {
                currentCharacter.HitPoints = RollDice(1, 4);
            }

            //Assign value to rolled value label before adding CON modifier
            lbl_HP_roll.Text = currentCharacter.HitPoints.ToString();

            //Add CON mod and update total HP label
            currentCharacter.HitPoints += int.Parse(lbl_HP_CON_Mod.Text);
            lbl_Total_HP.Text = currentCharacter.HitPoints.ToString();


            btn_HP_Reroll.Text = "Reroll";
            hasHPBeenRolled = true;

        }


        private void GoldRoll()
        {
            currentCharacter.StartingGold = RollDice(3, 6) * 100;
            lbl_Start_Gold_value.Text = currentCharacter.StartingGold.ToString();
        }



        private void SelectNewRace(CharacterInfo.Race newRace)
        {

            //if Race is the same as old newRace, no update needed
            if (newRace == currentCharacter.charRace)
                return;


            //there may be a better a way to refactor this, but im out of time, so oh well
            switch (newRace)
            {
                case CharacterInfo.Race.Dwarf:
                    lbl_Race_Minstat.Text = "CON 9";
                    lbl_Race_Modifier.Text = "-1 CHA, +1 CON";
                    lbl_Race_Ability.Text = "Infravision";
                    lbl_Race_Allowed_Classes.Text = "Bard, Cleric, Fighter, Thief";
                    currentCharacter.STR_Mod = 0;
                    currentCharacter.INT_Mod = 0;
                    currentCharacter.WIS_Mod = 0;
                    currentCharacter.DEX_Mod = 0;
                    currentCharacter.CON_Mod = 1;
                    currentCharacter.CHA_Mod = -1;
                    lbl_STR_mod.Text = "0";
                    lbl_INT_mod.Text = "0";
                    lbl_WIS_mod.Text = "0";
                    lbl_DEX_mod.Text = "0";
                    lbl_CON_mod.Text = "+1";
                    lbl_CHA_mod.Text = "-1";


                    break;
                case CharacterInfo.Race.Elf:
                    lbl_Race_Minstat.Text = "INT 9";
                    lbl_Race_Modifier.Text = "-1 CON, +1 DEX";
                    lbl_Race_Ability.Text = "Detect Secret Doors";
                    lbl_Race_Allowed_Classes.Text = "Cleric, Druid, Fighter, Ranger, Thief, Wizard";
                    currentCharacter.STR_Mod = 0;
                    currentCharacter.INT_Mod = 0;
                    currentCharacter.WIS_Mod = 0;
                    currentCharacter.DEX_Mod = 1;
                    currentCharacter.CON_Mod = -1;
                    currentCharacter.CHA_Mod = 0;
                    lbl_STR_mod.Text = "0";
                    lbl_INT_mod.Text = "0";
                    lbl_WIS_mod.Text = "0";
                    lbl_DEX_mod.Text = "+1";
                    lbl_CON_mod.Text = "-1";
                    lbl_CHA_mod.Text = "0";
                    break;
                case CharacterInfo.Race.Gnome:
                    lbl_Race_Minstat.Text = "CON 9, INT 9";
                    lbl_Race_Modifier.Text = "None";
                    lbl_Race_Ability.Text = "Defensive Bonus";
                    lbl_Race_Allowed_Classes.Text = "Cleric, Fighter, Thief, Wizard";
                    currentCharacter.STR_Mod = 0;
                    currentCharacter.INT_Mod = 0;
                    currentCharacter.WIS_Mod = 0;
                    currentCharacter.DEX_Mod = 0;
                    currentCharacter.CON_Mod = 0;
                    currentCharacter.CHA_Mod = 0;
                    lbl_STR_mod.Text = "0";
                    lbl_INT_mod.Text = "0";
                    lbl_WIS_mod.Text = "0";
                    lbl_DEX_mod.Text = "0";
                    lbl_CON_mod.Text = "0";
                    lbl_CHA_mod.Text = "0";
                    break;
                case CharacterInfo.Race.Halfling:
                    lbl_Race_Minstat.Text = "CON 9, DEX 9";
                    lbl_Race_Modifier.Text = "+1 DEX, -1 STR";
                    lbl_Race_Ability.Text = "Initiative Bonus";
                    lbl_Race_Allowed_Classes.Text = "Bard, Druid, Fighter, Thief";
                    currentCharacter.STR_Mod = -1;
                    currentCharacter.INT_Mod = 0;
                    currentCharacter.WIS_Mod = 0;
                    currentCharacter.DEX_Mod = 1;
                    currentCharacter.CON_Mod = 0;
                    currentCharacter.CHA_Mod = 0;
                    lbl_STR_mod.Text = "-1";
                    lbl_INT_mod.Text = "0";
                    lbl_WIS_mod.Text = "0";
                    lbl_DEX_mod.Text = "+1";
                    lbl_CON_mod.Text = "0";
                    lbl_CHA_mod.Text = "0";
                    break;
                case CharacterInfo.Race.Human:
                    lbl_Race_Minstat.Text = "None";
                    lbl_Race_Modifier.Text = "None";
                    lbl_Race_Ability.Text = "None";
                    lbl_Race_Allowed_Classes.Text = "Bard, Cleric, Druid, Fighter, Ranger, Thief, Wizard";
                    currentCharacter.STR_Mod = 0;
                    currentCharacter.INT_Mod = 0;
                    currentCharacter.WIS_Mod = 0;
                    currentCharacter.DEX_Mod = 0;
                    currentCharacter.CON_Mod = 0;
                    currentCharacter.CHA_Mod = 0;
                    lbl_STR_mod.Text = "0";
                    lbl_INT_mod.Text = "0";
                    lbl_WIS_mod.Text = "0";
                    lbl_DEX_mod.Text = "0";
                    lbl_CON_mod.Text = "0";
                    lbl_CHA_mod.Text = "0";
                    break;
                default:
                    break;
            }

            //check for race error after modifiers are added to give user more leeway in char creation
            CheckForRaceError(newRace);
            currentCharacter.charRace = newRace;
            CheckForClassError(currentCharacter.charClass);     //must check class after race value is assigned
        }


        private void SelectNewClass(CharacterInfo.Class newClass)
        {

            // For each class, update text and check if we need to reset HP due to a new HitDice
            switch (newClass)
            {
                case CharacterInfo.Class.None:
                    break;
                case CharacterInfo.Class.Bard:
                    if (lbl_Class_hit_dice_value.Text != "1d6")
                    {
                        lbl_Class_hit_dice_value.Text = "1d6";
                        ResetHP();
                    }
                    lbl_Class_Prime_Stat_Value.Text = "CHA";
                    break;
                case CharacterInfo.Class.Cleric:
                    if (lbl_Class_hit_dice_value.Text != "1d6")
                    {
                        lbl_Class_hit_dice_value.Text = "1d6";
                        ResetHP();
                    }
                    lbl_Class_Prime_Stat_Value.Text = "WIS";
                    break;
                case CharacterInfo.Class.Druid:
                    if (lbl_Class_hit_dice_value.Text != "1d6")
                    {
                        lbl_Class_hit_dice_value.Text = "1d6";
                        ResetHP();
                    }
                    lbl_Class_Prime_Stat_Value.Text = "WIS";
                    break;
                case CharacterInfo.Class.Fighter:
                    if (lbl_Class_hit_dice_value.Text != "1d8")
                    {
                        lbl_Class_hit_dice_value.Text = "1d8";
                        ResetHP();
                    }
                    lbl_Class_Prime_Stat_Value.Text = "STR";
                    break;
                case CharacterInfo.Class.Ranger:
                    if (lbl_Class_hit_dice_value.Text != "1d8")
                    {
                        lbl_Class_hit_dice_value.Text = "1d8";
                        ResetHP();
                    }
                    lbl_Class_Prime_Stat_Value.Text = "STR";
                    break;
                case CharacterInfo.Class.Thief:
                    if (lbl_Class_hit_dice_value.Text != "1d4")
                    {
                        lbl_Class_hit_dice_value.Text = "1d4";
                        ResetHP();
                    }
                    lbl_Class_Prime_Stat_Value.Text = "DEX";
                    break;
                case CharacterInfo.Class.Wizard:
                    if (lbl_Class_hit_dice_value.Text != "1d4")
                    {
                        lbl_Class_hit_dice_value.Text = "1d4";
                        ResetHP();
                    }
                    lbl_Class_Prime_Stat_Value.Text = "INT";
                    break;
                default:
                    break;
            }

            currentCharacter.charClass = newClass;
            CheckForClassError(newClass);
        }




        #endregion



        #region Controls

        private void rchTxtBox_CharName_TextChanged(object sender, EventArgs e)
        {
            currentCharacter.Name = rchTxtBox_CharName.Text;
        }
        private void btn_STR_Reroll_Click(object sender, EventArgs e)
        {
            STR_Reroll();
        }


        private void btn_INT_Reroll_Click(object sender, EventArgs e)
        {
            INT_Reroll();
        }

        private void btn_WIS_Reroll_Click(object sender, EventArgs e)
        {
            WIS_Reroll();
        }

        private void btn_DEX_Reroll_Click(object sender, EventArgs e)
        {
            DEX_Reroll();
        }


        private void btn_CON_Reroll_Click(object sender, EventArgs e)
        {
            CON_Reroll();
        }


        private void btn_CHA_Reroll_Click(object sender, EventArgs e)
        {
            CHA_Reroll();
        }


        private void btn_HP_Reroll_Click(object sender, EventArgs e)
        {
            HP_Roll();
        }


        private void btn_Gold_Reroll_Click(object sender, EventArgs e)
        {
            GoldRoll();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {

            //check for invalid character
            if(hasRaceError)
            {
                MessageBox.Show("Please Resolve your character's Race Error before saving");
                return;
            }

            if(hasClassError)
            {
                MessageBox.Show("Please Resolve your character's Class Error before saving");
                return;
            }

            if(!hasHPBeenRolled)
            {
                MessageBox.Show("Roll for Hit points before saving your character! We can't adventure with 0 HP!");
                return;
            }

            if(currentCharacter.charRace == CharacterInfo.Race.None)
            {
                MessageBox.Show("Please select character race before saving");
                return;
            }

            if(currentCharacter.charClass == CharacterInfo.Class.None)
            {
                MessageBox.Show("Please select character class before saving");
                return;
            }

            //since char is valid, proceed to save

            Stream myStream;
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.AddExtension = true;
            SFD.FileName = currentCharacter.Name;
            SFD.DefaultExt = ".txt";
            SFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (SFD.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = SFD.OpenFile()) != null)
                {
                    StreamWriter myWriter = new StreamWriter(myStream);
                    myWriter.Write(currentCharacter.ToJson());
                    myWriter.Flush();
                    myWriter.Close();
                    myStream.Close();
                }
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.DefaultExt = ".txt";
            OFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if(OFD.ShowDialog() == DialogResult.OK)
            {
                if((myStream = OFD.OpenFile()) != null)
                {
                    //load JSON data in from file then create character based on that
                    StreamReader myReader = new StreamReader(myStream);
                    currentCharacter = new CharacterInfo();
                    currentCharacter.FromJson(myReader.ReadToEnd());

                    //update forum with new character info then close reader
                    UpdateFromCharacterInfo(currentCharacter);
                    myReader.Close();
                    myStream.Close();
                    
                }
            }
        }


        private void comboBox_Race_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterInfo.Race newRace = (CharacterInfo.Race)comboBox_Race.SelectedIndex + 1;
            SelectNewRace(newRace);

        }



        private void comboBox_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterInfo.Class newClass = (CharacterInfo.Class)comboBox_Class.SelectedIndex + 1;

            SelectNewClass(newClass);

        }

        #endregion
    }
}
