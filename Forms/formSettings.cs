using System;
using System.IO;
using System.Windows.Forms;
using Entities;
using Enums;

namespace TelePrompter
{
    public partial class formSettings : Form
    {
        public string[] FileText { set; get; }

        private Configurations Config = new Configurations();


        public formSettings()
        {
            InitializeComponent();

            comboBoxFontSize.DataSource = Config.FontSizeList;
            comboBoxFontSize.SelectedIndex = 8;

            Config = new Configurations(trackBarSpeed.Minimum, trackBarSpeed.Maximum, trackBarSpeed.Value, GetTextFirstPosition(),
                                        GetLetterAndBackGroundColor(), GetFontSize());

        }



        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            // Filter
            openFileDialog.Filter = "Bloco de notas|*.txt";

            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                textBoxFilePath.Text = openFileDialog.FileName;

                string[] LineTextFile = File.ReadAllLines(textBoxFilePath.Text);

                foreach (string line in LineTextFile)
                {
                    Console.WriteLine(line);
                }
            }

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            formRun _formRun = new formRun(Config);

            Config.SetDefaultSpeed(trackBarSpeed.Value);
            Config.SetTextFirstPosition(GetTextFirstPosition());
            Config.SetLetterAndBackColor(GetLetterAndBackGroundColor());
            Config.SetFontSize(GetFontSize());

            // Show dialog (formRun) and select behind Dialogo not permitted
            _formRun.ShowDialog();
        }

        private TextFirstPosition GetTextFirstPosition()
        {
            if (radioButtonTxtTop.Checked)
                return TextFirstPosition.Top;
            else if (radioButtonTxtMiddle.Checked)
                return TextFirstPosition.Middle;
            else
                return TextFirstPosition.Botton;
        }

        private LetterAndBackColorOption GetLetterAndBackGroundColor()
        {
            if (radioButtonWhiteBlack.Checked)
                return LetterAndBackColorOption.WhiteBlack;
            else if (radioBlackWhite.Checked)
                return LetterAndBackColorOption.BlackWhite;
            else
                return LetterAndBackColorOption.WhiteBlue;
        }

        private int GetFontSize()
        {
            return Convert.ToInt32(comboBoxFontSize.SelectedIndex);
        }
    }
}
