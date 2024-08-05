namespace DnDCharacterCreator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CHA_mod = new System.Windows.Forms.Label();
            this.lbl_CHA_roll = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_CON_mod = new System.Windows.Forms.Label();
            this.lbl_CON_roll = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_DEX_mod = new System.Windows.Forms.Label();
            this.lbl_DEX_roll = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_WIS_mod = new System.Windows.Forms.Label();
            this.lbl_WIS_roll = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_INT_mod = new System.Windows.Forms.Label();
            this.lbl_INT_roll = new System.Windows.Forms.Label();
            this.lbl_STR_mod = new System.Windows.Forms.Label();
            this.lbl_STR_roll = new System.Windows.Forms.Label();
            this.lbl_AbilityScores = new System.Windows.Forms.Label();
            this.lbl_RolledValue = new System.Windows.Forms.Label();
            this.lbl_ModifierValue = new System.Windows.Forms.Label();
            this.lbl_STR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_CharName = new System.Windows.Forms.Label();
            this.rchTxtBox_CharName = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label43 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Race = new System.Windows.Forms.ComboBox();
            this.btn_STR_Reroll = new System.Windows.Forms.Button();
            this.btn_INT_Reroll = new System.Windows.Forms.Button();
            this.btn_WIS_Reroll = new System.Windows.Forms.Button();
            this.btn_DEX_Reroll = new System.Windows.Forms.Button();
            this.btn_CON_Reroll = new System.Windows.Forms.Button();
            this.btn_CHA_Reroll = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox_Class = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lbl_TotalHP = new System.Windows.Forms.Label();
            this.lbl_HP_CON_Mod = new System.Windows.Forms.Label();
            this.lbl_HP_roll = new System.Windows.Forms.Label();
            this.btn_HP_Reroll = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_Start_Gold_value = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Gold_Reroll = new System.Windows.Forms.Button();
            this.lbl_Race_Minstat = new System.Windows.Forms.Label();
            this.lbl_Race_Modifier = new System.Windows.Forms.Label();
            this.lbl_Race_Ability = new System.Windows.Forms.Label();
            this.lbl_Race_Allowed_Classes = new System.Windows.Forms.Label();
            this.lbl_Class_hit_dice_value = new System.Windows.Forms.Label();
            this.lbl_Class_Prime_Stat_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(717, 724);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(141, 61);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save Character";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(717, 648);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(141, 61);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Load Character";
            this.btn_Load.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.92308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.07692F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Controls.Add(this.btn_CHA_Reroll, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_CON_Reroll, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_DEX_Reroll, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_WIS_Reroll, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_INT_Reroll, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_CHA_mod, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_CHA_roll, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_CON_mod, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_CON_roll, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_STR_Reroll, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_DEX_mod, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_DEX_roll, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_WIS_mod, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_WIS_roll, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_INT_mod, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_INT_roll, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_STR_mod, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_STR_roll, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_AbilityScores, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_RolledValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ModifierValue, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_STR, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 337);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_CHA_mod
            // 
            this.lbl_CHA_mod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CHA_mod.AutoSize = true;
            this.lbl_CHA_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_CHA_mod.Location = new System.Drawing.Point(410, 295);
            this.lbl_CHA_mod.Name = "lbl_CHA_mod";
            this.lbl_CHA_mod.Size = new System.Drawing.Size(18, 20);
            this.lbl_CHA_mod.TabIndex = 26;
            this.lbl_CHA_mod.Text = "0";
            // 
            // lbl_CHA_roll
            // 
            this.lbl_CHA_roll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CHA_roll.AutoSize = true;
            this.lbl_CHA_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_CHA_roll.Location = new System.Drawing.Point(236, 295);
            this.lbl_CHA_roll.Name = "lbl_CHA_roll";
            this.lbl_CHA_roll.Size = new System.Drawing.Size(27, 20);
            this.lbl_CHA_roll.TabIndex = 25;
            this.lbl_CHA_roll.Text = "12";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.Location = new System.Drawing.Point(6, 295);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 20);
            this.label22.TabIndex = 24;
            this.label22.Text = "Charisma (CHA)";
            // 
            // lbl_CON_mod
            // 
            this.lbl_CON_mod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CON_mod.AutoSize = true;
            this.lbl_CON_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_CON_mod.Location = new System.Drawing.Point(410, 255);
            this.lbl_CON_mod.Name = "lbl_CON_mod";
            this.lbl_CON_mod.Size = new System.Drawing.Size(18, 20);
            this.lbl_CON_mod.TabIndex = 22;
            this.lbl_CON_mod.Text = "0";
            // 
            // lbl_CON_roll
            // 
            this.lbl_CON_roll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CON_roll.AutoSize = true;
            this.lbl_CON_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_CON_roll.Location = new System.Drawing.Point(236, 255);
            this.lbl_CON_roll.Name = "lbl_CON_roll";
            this.lbl_CON_roll.Size = new System.Drawing.Size(27, 20);
            this.lbl_CON_roll.TabIndex = 21;
            this.lbl_CON_roll.Text = "12";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(6, 255);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "Constitution (CON)";
            // 
            // lbl_DEX_mod
            // 
            this.lbl_DEX_mod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DEX_mod.AutoSize = true;
            this.lbl_DEX_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_DEX_mod.Location = new System.Drawing.Point(410, 218);
            this.lbl_DEX_mod.Name = "lbl_DEX_mod";
            this.lbl_DEX_mod.Size = new System.Drawing.Size(18, 20);
            this.lbl_DEX_mod.TabIndex = 18;
            this.lbl_DEX_mod.Text = "0";
            // 
            // lbl_DEX_roll
            // 
            this.lbl_DEX_roll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DEX_roll.AutoSize = true;
            this.lbl_DEX_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_DEX_roll.Location = new System.Drawing.Point(236, 218);
            this.lbl_DEX_roll.Name = "lbl_DEX_roll";
            this.lbl_DEX_roll.Size = new System.Drawing.Size(27, 20);
            this.lbl_DEX_roll.TabIndex = 17;
            this.lbl_DEX_roll.Text = "12";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(6, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Dexterity (DEX)";
            // 
            // lbl_WIS_mod
            // 
            this.lbl_WIS_mod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_WIS_mod.AutoSize = true;
            this.lbl_WIS_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_WIS_mod.Location = new System.Drawing.Point(410, 166);
            this.lbl_WIS_mod.Name = "lbl_WIS_mod";
            this.lbl_WIS_mod.Size = new System.Drawing.Size(18, 20);
            this.lbl_WIS_mod.TabIndex = 14;
            this.lbl_WIS_mod.Text = "0";
            // 
            // lbl_WIS_roll
            // 
            this.lbl_WIS_roll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_WIS_roll.AutoSize = true;
            this.lbl_WIS_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_WIS_roll.Location = new System.Drawing.Point(236, 166);
            this.lbl_WIS_roll.Name = "lbl_WIS_roll";
            this.lbl_WIS_roll.Size = new System.Drawing.Size(27, 20);
            this.lbl_WIS_roll.TabIndex = 13;
            this.lbl_WIS_roll.Text = "12";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(6, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Wisdom (WIS)";
            // 
            // lbl_INT_mod
            // 
            this.lbl_INT_mod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_INT_mod.AutoSize = true;
            this.lbl_INT_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_INT_mod.Location = new System.Drawing.Point(410, 115);
            this.lbl_INT_mod.Name = "lbl_INT_mod";
            this.lbl_INT_mod.Size = new System.Drawing.Size(18, 20);
            this.lbl_INT_mod.TabIndex = 10;
            this.lbl_INT_mod.Text = "0";
            // 
            // lbl_INT_roll
            // 
            this.lbl_INT_roll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_INT_roll.AutoSize = true;
            this.lbl_INT_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_INT_roll.Location = new System.Drawing.Point(236, 115);
            this.lbl_INT_roll.Name = "lbl_INT_roll";
            this.lbl_INT_roll.Size = new System.Drawing.Size(27, 20);
            this.lbl_INT_roll.TabIndex = 9;
            this.lbl_INT_roll.Text = "12";
            // 
            // lbl_STR_mod
            // 
            this.lbl_STR_mod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_STR_mod.AutoSize = true;
            this.lbl_STR_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_STR_mod.Location = new System.Drawing.Point(410, 59);
            this.lbl_STR_mod.Name = "lbl_STR_mod";
            this.lbl_STR_mod.Size = new System.Drawing.Size(18, 20);
            this.lbl_STR_mod.TabIndex = 7;
            this.lbl_STR_mod.Text = "0";
            // 
            // lbl_STR_roll
            // 
            this.lbl_STR_roll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_STR_roll.AutoSize = true;
            this.lbl_STR_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_STR_roll.Location = new System.Drawing.Point(236, 59);
            this.lbl_STR_roll.Name = "lbl_STR_roll";
            this.lbl_STR_roll.Size = new System.Drawing.Size(27, 20);
            this.lbl_STR_roll.TabIndex = 6;
            this.lbl_STR_roll.Text = "12";
            // 
            // lbl_AbilityScores
            // 
            this.lbl_AbilityScores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_AbilityScores.AutoSize = true;
            this.lbl_AbilityScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_AbilityScores.Location = new System.Drawing.Point(28, 3);
            this.lbl_AbilityScores.Name = "lbl_AbilityScores";
            this.lbl_AbilityScores.Size = new System.Drawing.Size(118, 20);
            this.lbl_AbilityScores.TabIndex = 0;
            this.lbl_AbilityScores.Text = "Ability Scores";
            this.lbl_AbilityScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RolledValue
            // 
            this.lbl_RolledValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_RolledValue.AutoSize = true;
            this.lbl_RolledValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_RolledValue.Location = new System.Drawing.Point(194, 3);
            this.lbl_RolledValue.Name = "lbl_RolledValue";
            this.lbl_RolledValue.Size = new System.Drawing.Size(111, 20);
            this.lbl_RolledValue.TabIndex = 1;
            this.lbl_RolledValue.Text = "Rolled Value";
            this.lbl_RolledValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ModifierValue
            // 
            this.lbl_ModifierValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ModifierValue.AutoSize = true;
            this.lbl_ModifierValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_ModifierValue.Location = new System.Drawing.Point(382, 3);
            this.lbl_ModifierValue.Name = "lbl_ModifierValue";
            this.lbl_ModifierValue.Size = new System.Drawing.Size(73, 20);
            this.lbl_ModifierValue.TabIndex = 2;
            this.lbl_ModifierValue.Text = "Modifier";
            this.lbl_ModifierValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_STR
            // 
            this.lbl_STR.AutoSize = true;
            this.lbl_STR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_STR.Location = new System.Drawing.Point(6, 59);
            this.lbl_STR.Name = "lbl_STR";
            this.lbl_STR.Size = new System.Drawing.Size(117, 20);
            this.lbl_STR.TabIndex = 3;
            this.lbl_STR.Text = "Strength (STR)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Intelligence (INT)";
            // 
            // lbl_CharName
            // 
            this.lbl_CharName.AutoSize = true;
            this.lbl_CharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_CharName.Location = new System.Drawing.Point(69, 18);
            this.lbl_CharName.Name = "lbl_CharName";
            this.lbl_CharName.Size = new System.Drawing.Size(129, 20);
            this.lbl_CharName.TabIndex = 3;
            this.lbl_CharName.Text = "Character Name:";
            // 
            // rchTxtBox_CharName
            // 
            this.rchTxtBox_CharName.Location = new System.Drawing.Point(204, 18);
            this.rchTxtBox_CharName.Name = "rchTxtBox_CharName";
            this.rchTxtBox_CharName.Size = new System.Drawing.Size(275, 29);
            this.rchTxtBox_CharName.TabIndex = 4;
            this.rchTxtBox_CharName.Text = "";
            this.rchTxtBox_CharName.TextChanged += new System.EventHandler(this.rchTxtBox_CharName_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Race_Allowed_Classes, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Race_Ability, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Race_Modifier, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Race_Minstat, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label43, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_Race, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(33, 423);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(638, 86);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label43.Location = new System.Drawing.Point(6, 3);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(51, 20);
            this.label43.TabIndex = 47;
            this.label43.Text = "Race";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(110, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Min Stat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(230, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Modifier";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(313, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ability";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.Location = new System.Drawing.Point(431, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Allowed Classes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Race
            // 
            this.comboBox_Race.FormattingEnabled = true;
            this.comboBox_Race.Location = new System.Drawing.Point(6, 47);
            this.comboBox_Race.Name = "comboBox_Race";
            this.comboBox_Race.Size = new System.Drawing.Size(95, 21);
            this.comboBox_Race.TabIndex = 52;
            // 
            // btn_STR_Reroll
            // 
            this.btn_STR_Reroll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_STR_Reroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_STR_Reroll.Location = new System.Drawing.Point(538, 62);
            this.btn_STR_Reroll.Name = "btn_STR_Reroll";
            this.btn_STR_Reroll.Size = new System.Drawing.Size(96, 37);
            this.btn_STR_Reroll.TabIndex = 53;
            this.btn_STR_Reroll.Text = "Reroll";
            this.btn_STR_Reroll.UseVisualStyleBackColor = true;
            this.btn_STR_Reroll.Click += new System.EventHandler(this.btn_STR_Reroll_Click);
            // 
            // btn_INT_Reroll
            // 
            this.btn_INT_Reroll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_INT_Reroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_INT_Reroll.Location = new System.Drawing.Point(541, 118);
            this.btn_INT_Reroll.Name = "btn_INT_Reroll";
            this.btn_INT_Reroll.Size = new System.Drawing.Size(90, 37);
            this.btn_INT_Reroll.TabIndex = 55;
            this.btn_INT_Reroll.Text = "Reroll";
            this.btn_INT_Reroll.UseVisualStyleBackColor = true;
            this.btn_INT_Reroll.Click += new System.EventHandler(this.btn_INT_Reroll_Click);
            // 
            // btn_WIS_Reroll
            // 
            this.btn_WIS_Reroll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_WIS_Reroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_WIS_Reroll.Location = new System.Drawing.Point(541, 169);
            this.btn_WIS_Reroll.Name = "btn_WIS_Reroll";
            this.btn_WIS_Reroll.Size = new System.Drawing.Size(90, 37);
            this.btn_WIS_Reroll.TabIndex = 56;
            this.btn_WIS_Reroll.Text = "Reroll";
            this.btn_WIS_Reroll.UseVisualStyleBackColor = true;
            this.btn_WIS_Reroll.Click += new System.EventHandler(this.btn_WIS_Reroll_Click);
            // 
            // btn_DEX_Reroll
            // 
            this.btn_DEX_Reroll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_DEX_Reroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_DEX_Reroll.Location = new System.Drawing.Point(541, 221);
            this.btn_DEX_Reroll.Name = "btn_DEX_Reroll";
            this.btn_DEX_Reroll.Size = new System.Drawing.Size(90, 28);
            this.btn_DEX_Reroll.TabIndex = 57;
            this.btn_DEX_Reroll.Text = "Reroll";
            this.btn_DEX_Reroll.UseVisualStyleBackColor = true;
            this.btn_DEX_Reroll.Click += new System.EventHandler(this.btn_DEX_Reroll_Click);
            // 
            // btn_CON_Reroll
            // 
            this.btn_CON_Reroll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CON_Reroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CON_Reroll.Location = new System.Drawing.Point(541, 258);
            this.btn_CON_Reroll.Name = "btn_CON_Reroll";
            this.btn_CON_Reroll.Size = new System.Drawing.Size(90, 31);
            this.btn_CON_Reroll.TabIndex = 58;
            this.btn_CON_Reroll.Text = "Reroll";
            this.btn_CON_Reroll.UseVisualStyleBackColor = true;
            this.btn_CON_Reroll.Click += new System.EventHandler(this.btn_CON_Reroll_Click);
            // 
            // btn_CHA_Reroll
            // 
            this.btn_CHA_Reroll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CHA_Reroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CHA_Reroll.Location = new System.Drawing.Point(541, 298);
            this.btn_CHA_Reroll.Name = "btn_CHA_Reroll";
            this.btn_CHA_Reroll.Size = new System.Drawing.Size(90, 33);
            this.btn_CHA_Reroll.TabIndex = 59;
            this.btn_CHA_Reroll.Text = "Reroll";
            this.btn_CHA_Reroll.UseVisualStyleBackColor = true;
            this.btn_CHA_Reroll.Click += new System.EventHandler(this.btn_CHA_Reroll_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_Class_Prime_Stat_Value, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Class_hit_dice_value, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label17, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label21, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label25, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_Class, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(33, 524);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(453, 86);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label17.Location = new System.Drawing.Point(302, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 49;
            this.label17.Text = "Prime Stat";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label21.Location = new System.Drawing.Point(144, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 20);
            this.label21.TabIndex = 48;
            this.label21.Text = "Hit Dice";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label25.Location = new System.Drawing.Point(6, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 20);
            this.label25.TabIndex = 47;
            this.label25.Text = "Class";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Class
            // 
            this.comboBox_Class.FormattingEnabled = true;
            this.comboBox_Class.Location = new System.Drawing.Point(6, 47);
            this.comboBox_Class.Name = "comboBox_Class";
            this.comboBox_Class.Size = new System.Drawing.Size(95, 21);
            this.comboBox_Class.TabIndex = 52;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.04546F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.95454F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel4.Controls.Add(this.btn_HP_Reroll, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_HP_roll, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label28, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label30, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label29, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_TotalHP, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_HP_CON_Mod, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(33, 623);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(506, 86);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label28.Location = new System.Drawing.Point(270, 3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(111, 20);
            this.label28.TabIndex = 49;
            this.label28.Text = "Rolled Value";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label29.Location = new System.Drawing.Point(117, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(115, 20);
            this.label29.TabIndex = 48;
            this.label29.Text = "CON Modifier";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label30.Location = new System.Drawing.Point(6, 3);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(77, 38);
            this.label30.TabIndex = 47;
            this.label30.Text = "Total Hit Points";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TotalHP
            // 
            this.lbl_TotalHP.AutoSize = true;
            this.lbl_TotalHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_TotalHP.Location = new System.Drawing.Point(6, 44);
            this.lbl_TotalHP.Name = "lbl_TotalHP";
            this.lbl_TotalHP.Size = new System.Drawing.Size(27, 20);
            this.lbl_TotalHP.TabIndex = 50;
            this.lbl_TotalHP.Text = "12";
            // 
            // lbl_HP_CON_Mod
            // 
            this.lbl_HP_CON_Mod.AutoSize = true;
            this.lbl_HP_CON_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_HP_CON_Mod.Location = new System.Drawing.Point(117, 44);
            this.lbl_HP_CON_Mod.Name = "lbl_HP_CON_Mod";
            this.lbl_HP_CON_Mod.Size = new System.Drawing.Size(18, 20);
            this.lbl_HP_CON_Mod.TabIndex = 51;
            this.lbl_HP_CON_Mod.Text = "0";
            // 
            // lbl_HP_roll
            // 
            this.lbl_HP_roll.AutoSize = true;
            this.lbl_HP_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_HP_roll.Location = new System.Drawing.Point(270, 44);
            this.lbl_HP_roll.Name = "lbl_HP_roll";
            this.lbl_HP_roll.Size = new System.Drawing.Size(18, 20);
            this.lbl_HP_roll.TabIndex = 53;
            this.lbl_HP_roll.Text = "0";
            // 
            // btn_HP_Reroll
            // 
            this.btn_HP_Reroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_HP_Reroll.Location = new System.Drawing.Point(403, 47);
            this.btn_HP_Reroll.Name = "btn_HP_Reroll";
            this.btn_HP_Reroll.Size = new System.Drawing.Size(90, 28);
            this.btn_HP_Reroll.TabIndex = 59;
            this.btn_HP_Reroll.Text = "Reroll";
            this.btn_HP_Reroll.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(6, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Starting Gold: ";
            // 
            // lbl_Start_Gold_value
            // 
            this.lbl_Start_Gold_value.AutoSize = true;
            this.lbl_Start_Gold_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Start_Gold_value.Location = new System.Drawing.Point(173, 3);
            this.lbl_Start_Gold_value.Name = "lbl_Start_Gold_value";
            this.lbl_Start_Gold_value.Size = new System.Drawing.Size(27, 20);
            this.lbl_Start_Gold_value.TabIndex = 9;
            this.lbl_Start_Gold_value.Text = "12";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.15385F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.84615F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel5.Controls.Add(this.btn_Gold_Reroll, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_Start_Gold_value, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(33, 724);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(453, 45);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // btn_Gold_Reroll
            // 
            this.btn_Gold_Reroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Gold_Reroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Gold_Reroll.Location = new System.Drawing.Point(308, 8);
            this.btn_Gold_Reroll.Name = "btn_Gold_Reroll";
            this.btn_Gold_Reroll.Size = new System.Drawing.Size(90, 28);
            this.btn_Gold_Reroll.TabIndex = 60;
            this.btn_Gold_Reroll.Text = "Reroll";
            this.btn_Gold_Reroll.UseVisualStyleBackColor = true;
            // 
            // lbl_Race_Minstat
            // 
            this.lbl_Race_Minstat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Race_Minstat.AutoSize = true;
            this.lbl_Race_Minstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Race_Minstat.Location = new System.Drawing.Point(152, 44);
            this.lbl_Race_Minstat.Name = "lbl_Race_Minstat";
            this.lbl_Race_Minstat.Size = new System.Drawing.Size(27, 20);
            this.lbl_Race_Minstat.TabIndex = 53;
            this.lbl_Race_Minstat.Text = "12";
            // 
            // lbl_Race_Modifier
            // 
            this.lbl_Race_Modifier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Race_Modifier.AutoSize = true;
            this.lbl_Race_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Race_Modifier.Location = new System.Drawing.Point(253, 44);
            this.lbl_Race_Modifier.Name = "lbl_Race_Modifier";
            this.lbl_Race_Modifier.Size = new System.Drawing.Size(27, 20);
            this.lbl_Race_Modifier.TabIndex = 54;
            this.lbl_Race_Modifier.Text = "12";
            // 
            // lbl_Race_Ability
            // 
            this.lbl_Race_Ability.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Race_Ability.AutoSize = true;
            this.lbl_Race_Ability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Race_Ability.Location = new System.Drawing.Point(354, 44);
            this.lbl_Race_Ability.Name = "lbl_Race_Ability";
            this.lbl_Race_Ability.Size = new System.Drawing.Size(27, 20);
            this.lbl_Race_Ability.TabIndex = 55;
            this.lbl_Race_Ability.Text = "12";
            // 
            // lbl_Race_Allowed_Classes
            // 
            this.lbl_Race_Allowed_Classes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Race_Allowed_Classes.AutoSize = true;
            this.lbl_Race_Allowed_Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Race_Allowed_Classes.Location = new System.Drawing.Point(518, 44);
            this.lbl_Race_Allowed_Classes.Name = "lbl_Race_Allowed_Classes";
            this.lbl_Race_Allowed_Classes.Size = new System.Drawing.Size(27, 20);
            this.lbl_Race_Allowed_Classes.TabIndex = 56;
            this.lbl_Race_Allowed_Classes.Text = "12";
            // 
            // lbl_Class_hit_dice_value
            // 
            this.lbl_Class_hit_dice_value.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Class_hit_dice_value.AutoSize = true;
            this.lbl_Class_hit_dice_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Class_hit_dice_value.Location = new System.Drawing.Point(205, 44);
            this.lbl_Class_hit_dice_value.Name = "lbl_Class_hit_dice_value";
            this.lbl_Class_hit_dice_value.Size = new System.Drawing.Size(27, 20);
            this.lbl_Class_hit_dice_value.TabIndex = 53;
            this.lbl_Class_hit_dice_value.Text = "12";
            // 
            // lbl_Class_Prime_Stat_Value
            // 
            this.lbl_Class_Prime_Stat_Value.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Class_Prime_Stat_Value.AutoSize = true;
            this.lbl_Class_Prime_Stat_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Class_Prime_Stat_Value.Location = new System.Drawing.Point(361, 44);
            this.lbl_Class_Prime_Stat_Value.Name = "lbl_Class_Prime_Stat_Value";
            this.lbl_Class_Prime_Stat_Value.Size = new System.Drawing.Size(27, 20);
            this.lbl_Class_Prime_Stat_Value.TabIndex = 54;
            this.lbl_Class_Prime_Stat_Value.Text = "12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 797);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.rchTxtBox_CharName);
            this.Controls.Add(this.lbl_CharName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_CharName;
        private System.Windows.Forms.RichTextBox rchTxtBox_CharName;
        private System.Windows.Forms.Label lbl_AbilityScores;
        private System.Windows.Forms.Label lbl_CHA_mod;
        private System.Windows.Forms.Label lbl_CHA_roll;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl_CON_mod;
        private System.Windows.Forms.Label lbl_CON_roll;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_DEX_mod;
        private System.Windows.Forms.Label lbl_DEX_roll;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_WIS_mod;
        private System.Windows.Forms.Label lbl_WIS_roll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_INT_mod;
        private System.Windows.Forms.Label lbl_INT_roll;
        private System.Windows.Forms.Label lbl_STR_mod;
        private System.Windows.Forms.Label lbl_STR_roll;
        private System.Windows.Forms.Label lbl_RolledValue;
        private System.Windows.Forms.Label lbl_ModifierValue;
        private System.Windows.Forms.Label lbl_STR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_STR_Reroll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox comboBox_Race;
        private System.Windows.Forms.Button btn_CHA_Reroll;
        private System.Windows.Forms.Button btn_CON_Reroll;
        private System.Windows.Forms.Button btn_DEX_Reroll;
        private System.Windows.Forms.Button btn_WIS_Reroll;
        private System.Windows.Forms.Button btn_INT_Reroll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBox_Class;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btn_HP_Reroll;
        private System.Windows.Forms.Label lbl_HP_roll;
        private System.Windows.Forms.Label lbl_TotalHP;
        private System.Windows.Forms.Label lbl_HP_CON_Mod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_Start_Gold_value;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btn_Gold_Reroll;
        private System.Windows.Forms.Label lbl_Race_Allowed_Classes;
        private System.Windows.Forms.Label lbl_Race_Ability;
        private System.Windows.Forms.Label lbl_Race_Modifier;
        private System.Windows.Forms.Label lbl_Race_Minstat;
        private System.Windows.Forms.Label lbl_Class_Prime_Stat_Value;
        private System.Windows.Forms.Label lbl_Class_hit_dice_value;
    }
}

