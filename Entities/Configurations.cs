using System;
using System.Collections.Generic;
using System.Drawing;
using Enums;

namespace Entities
{
    public class Configurations
    {

        public string TeleprompterText { get; private set; }
        public DefaultSpeed DefaultSpeed { get; private set; }
        public TextFirstPosition TextFirstPosition { get; private set; }
        public Color BackGround { get; private set; }
        public Color Letter { get; private set; }
        public int FontSize { get; private set; }

        public List<int> FontSizeList = new List<int>()  {
            8,10,12,14,16,20,22,24,28,32,36,38,42,54
        };

        public Configurations()
        {
            ;
        }

        public Configurations(int trackBarSpeedMin, int trackBarSpeedMax, int trackBarSpeedValue,
                              TextFirstPosition textFirsPosition, LetterAndBackColorOption option, int fontSize)
        {
            SetTeleprompterText(null);
            DefaultSpeed = new DefaultSpeed(trackBarSpeedMin, trackBarSpeedMax, trackBarSpeedValue);
            SetTextFirstPosition(textFirsPosition);
            SetLetterAndBackColor(option);
            SetFontSize(fontSize);
        }

        public void SetTeleprompterText(string teleprompterText)
        {
            TeleprompterText = teleprompterText;
        }

        public void SetDefaultSpeed(int trackBarSpeedValue)
        {
            DefaultSpeed.SetValue(trackBarSpeedValue);
        }

        public void DecreaseDefaultSpeed()
        {
            if (DefaultSpeed.Value == DefaultSpeed.MinValuePermitted)
                throw new ArgumentOutOfRangeException("DefaultSpeed.Value", "Min Value");
            else
                DefaultSpeed.IncreaseValue();
        }

        public void IncreaseDefaultSpeed()
        {
            if (DefaultSpeed.Value == DefaultSpeed.MaxValuePermitted)
                throw new ArgumentOutOfRangeException("DefaultSpeed.Value", "Max Value");
            else
                DefaultSpeed.DecreaseValue();
        }


        public void SetTextFirstPosition(TextFirstPosition textFirstPosition)
        {
            TextFirstPosition = textFirstPosition;
        }

        public void SetLetterAndBackColor(LetterAndBackColorOption option)
        {
            if (option == LetterAndBackColorOption.WhiteBlack)
            {
                BackGround = SystemColors.ActiveCaptionText;
                Letter = SystemColors.ButtonHighlight;
            }
            else if (option == LetterAndBackColorOption.BlackWhite)
            {
                BackGround = SystemColors.ButtonHighlight;
                Letter = SystemColors.ActiveCaptionText;
            }
            else
            {
                BackGround = Color.FromArgb(0, 0, 64);
                Letter = SystemColors.ButtonHighlight;
            }
        }

        public void SetFontSize(int fontSize)
        {
            FontSize = FontSizeList[fontSize];
        }

        public void IncreaseFontSize()
        {
            if (FontSize == FontSizeList[FontSizeList.Count - 1])
            {
                throw new ArgumentOutOfRangeException("FontSize", "Max Value");
            }
            else
            {
                SetFontSize(FontSizeList.IndexOf(FontSize) + 1);
            }
        }

        public void DecreaseFontSize()
        {
            if (FontSize == FontSizeList[0])
            {
                throw new ArgumentOutOfRangeException("FontSize", "Min Value");
            }
            else
            {
                SetFontSize(FontSizeList.IndexOf(FontSize) - 1);
            }
        }

        public override string ToString()
        {
            return " Default Speed    : " + DefaultSpeed.Value.ToString() + "\n" +
                   " TextFirstPosition: " + TextFirstPosition.ToString() + "\n" +
                   " Background color : " + BackGround.ToString() + "\n" +
                   " Letter color     : " + Letter.ToString() + "\n" +
                   " Font Size        : " + FontSize.ToString() + "\n" +
                   " Min Speed Permitted: " + DefaultSpeed.MinValuePermitted.ToString() + "\n" +
                   " Max Speed Permitted: " + DefaultSpeed.MaxValuePermitted.ToString() + "\n";
        }
    }
}
