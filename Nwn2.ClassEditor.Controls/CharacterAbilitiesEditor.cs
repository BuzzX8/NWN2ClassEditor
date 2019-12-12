using System;
using System.Windows.Forms;
using Dnd35.Class;

namespace NWN2.ClassEditor.Controls
{
    public partial class CharacterAbilitiesEditor : UserControl
    {
        private byte abilityPoints = 32;
        private byte strValue = 8;
        private byte dexValue = 8;
        private byte conValue = 8;
        private byte intValue = 8;
        private byte wisValue = 8;
        private byte chaValue = 8;
        private bool updating = false;

        public CharacterAbilitiesEditor()
        {
            InitializeComponent();
        }

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
        }

        internal CharacterAbilities Ability
        {
            get
            {
                return new CharacterAbilities
                {
                    AbilityPointsCount = abilityPoints,
                    Str = (byte)strengthNumericUpDown.Value,
                    Dex = (byte)dextertyNumericUpDown.Value,
                    Con = (byte)constitutionNumericUpDown.Value,
                    Int = (byte)intelegenceNumericUpDown.Value,
                    Wis = (byte)wisdomNumericUpDown.Value,
                    Cha = (byte)charismaNumericUpDown.Value
                };
            }
            set
            {
                updating = true;
                abilityPoints = value.AbilityPointsCount;
                strengthNumericUpDown.Value = value.Str;
                dextertyNumericUpDown.Value = value.Dex;
                constitutionNumericUpDown.Value = value.Con;
                intelegenceNumericUpDown.Value = value.Int;
                wisdomNumericUpDown.Value = value.Wis;
                charismaNumericUpDown.Value = value.Cha;
                abilityPointsLabel.Text = abilityPoints.ToString();
                updating = false;
            }
        }

        private void updateValue(ref byte prevValue, ref byte currentValue , NumericUpDown numeric)
        {
            sbyte pointsDelta = 0;

            if (updating) return;

            if (currentValue > prevValue)
            {
                //if (abilityPoints == 0) return;
                if (currentValue >= 8 && currentValue <= 14) pointsDelta = -1;
                if (currentValue > 14 && currentValue <= 16) pointsDelta = -2;
                if (currentValue > 16 && currentValue <= 18) pointsDelta = -3;
               
                if (abilityPoints + pointsDelta >= 0)
                {
                    abilityPoints += (byte)pointsDelta;
                    prevValue = currentValue;
                }
                else numeric.Value = prevValue;

                abilityPointsLabel.Text = abilityPoints.ToString();
            }

            if (currentValue < prevValue)
            {
                if (prevValue > 8 && prevValue <= 14) pointsDelta = 1;
                if (prevValue > 14 && prevValue <= 16) pointsDelta = 2;
                if (prevValue > 16 && prevValue <= 18) pointsDelta = 3;

                prevValue = currentValue;
                abilityPoints += (byte)pointsDelta;
                abilityPointsLabel.Text = abilityPoints.ToString();
            }
        }

        private void strengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            byte currentValue = (byte)strengthNumericUpDown.Value;

            updateValue(ref strValue, ref currentValue, strengthNumericUpDown);
        }

        private void dextertyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            byte currentValue = (byte)dextertyNumericUpDown.Value;

            updateValue(ref dexValue, ref currentValue, dextertyNumericUpDown);
        }

        private void constitutionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            byte currentValue = (byte)constitutionNumericUpDown.Value;

            updateValue(ref conValue, ref currentValue, constitutionNumericUpDown);
        }

        private void intelegenceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            byte currentValue = (byte)intelegenceNumericUpDown.Value;

            updateValue(ref intValue, ref currentValue, intelegenceNumericUpDown);
        }

        private void wisdomNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            byte currentValue = (byte)wisdomNumericUpDown.Value;

            updateValue(ref wisValue, ref currentValue, wisdomNumericUpDown);
        }

        private void charismaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            byte currentValue = (byte)charismaNumericUpDown.Value;

            updateValue(ref chaValue, ref currentValue, charismaNumericUpDown);
        }
    }
}
