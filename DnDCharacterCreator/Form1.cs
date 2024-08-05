﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCharacterCreator
{
    public partial class Form1 : Form
    {
        Random RNG;

        CharacterInfo currentCharacter;
        public Form1()
        {
            InitializeComponent();
            RNG = new Random();
            currentCharacter = new CharacterInfo();
        }

        #region Utility

        /// <summary>
        /// Used to get default ability scores when app is initially opened
        /// </summary>
        public void RollDefaultValues()
        {


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


        }

        #endregion



        #region Controls

        private void rchTxtBox_CharName_TextChanged(object sender, EventArgs e)
        {
            currentCharacter.Name = rchTxtBox_CharName.Text;
        }
        private void btn_STR_Reroll_Click(object sender, EventArgs e)
        {
            currentCharacter.STR = RollDice(3, 6);
            lbl_STR_roll.Text = currentCharacter.STR.ToString(); ;
        }

        private void btn_INT_Reroll_Click(object sender, EventArgs e)
        {
            currentCharacter.INT = RollDice(3, 6);
            lbl_INT_roll.Text = currentCharacter.INT.ToString(); ;
        }

        private void btn_WIS_Reroll_Click(object sender, EventArgs e)
        {
            currentCharacter.WIS = RollDice(3, 6);
            lbl_WIS_roll.Text = currentCharacter.WIS.ToString(); ;
        }

        private void btn_DEX_Reroll_Click(object sender, EventArgs e)
        {
            currentCharacter.DEX = RollDice(3, 6);
            lbl_DEX_roll.Text = currentCharacter.DEX.ToString(); ;
        }

        private void btn_CON_Reroll_Click(object sender, EventArgs e)
        {
            currentCharacter.CON = RollDice(3, 6);
            lbl_CON_roll.Text = currentCharacter.CON.ToString(); ;
        }

        private void btn_CHA_Reroll_Click(object sender, EventArgs e)
        {
            currentCharacter.CHA = RollDice(3, 6);
            lbl_CHA_roll.Text = currentCharacter.CHA.ToString(); ;
        }

        private void btn_HP_Reroll_Click(object sender, EventArgs e)
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
        }

        private void btn_Gold_Reroll_Click(object sender, EventArgs e)
        {
            currentCharacter.StartingGold = RollDice(3, 6) * 100;
            lbl_Start_Gold_value.Text = currentCharacter.StartingGold.ToString();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
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
                    StreamReader myReader = new StreamReader(myStream);
                    currentCharacter = new CharacterInfo();
                    currentCharacter.FromJson(myReader.ReadToEnd());
                    myReader.Close();
                    Console.WriteLine(currentCharacter.ToString());
                }
            }
        }

        #endregion


    }
}
