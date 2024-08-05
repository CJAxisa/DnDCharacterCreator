using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public void RollDefaultValues()
        {


        }

        public int RollDice(int numDice, int numSides)
        {
            int sum = 0;
            for (int i = 0; i < numDice; i++)
            {
                sum += RNG.Next(1, numSides + 1);
            }

            return sum;
        }

        #endregion



        #region Controls
        private void rchTxtBox_CharName_TextChanged(object sender, EventArgs e)
        {

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

        #endregion


    }
}
