using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace TelePrompter
{
    public partial class formRun : Form
    {
        private Configurations configsBridge = new Configurations();

        public formRun(Configurations Configs)
        {
            configsBridge = Configs;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Move text down
            labelText.Top -= 1;
        }

        private void formRun_Load(object sender, EventArgs e)
        {
            // Speed text
            timer1.Interval = configsBridge.DefaultSpeed.Value;

            // Text First position
            labelText.Top = (int)configsBridge.TextFirstPosition;

            // Text letter color and background color
            labelText.ForeColor = configsBridge.Letter;
            labelText.BackColor = configsBridge.BackGround;
            panel1.BackColor = configsBridge.BackGround;

            //Font size
            labelText.Font = new Font(labelText.Font.FontFamily.Name, configsBridge.FontSize);

            Console.WriteLine(configsBridge);

        }

        private async void formRun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                try
                {
                    configsBridge.IncreaseDefaultSpeed();
                    keyUpPanel.BackColor = System.Drawing.Color.FromArgb(0, 64, 0);
                    await Task.Delay(90);
                    keyUpPanel.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
                }
                catch (Exception Ex)
                {
                    keyUpPanel.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    await Task.Delay(90);
                    keyUpPanel.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                try
                {
                    configsBridge.DecreaseDefaultSpeed();
                    keyDownPanel.BackColor = System.Drawing.Color.FromArgb(0, 64, 0);
                    await Task.Delay(90);
                    keyDownPanel.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
                }
                catch (Exception Ex)
                {
                    keyDownPanel.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    await Task.Delay(90);
                    keyDownPanel.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (timer1.Enabled)
                {
                    keyEnterPanel.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    await Task.Delay(90);
                    keyEnterPanel.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
                    timer1.Enabled = false;
                }
                else
                {
                    keyEnterPanel.BackColor = System.Drawing.Color.FromArgb(0, 64, 0);
                    await Task.Delay(90);
                    keyEnterPanel.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
                    timer1.Enabled = true;
                }

            }
            else if (e.KeyCode == Keys.I)
            {
                try
                {
                    configsBridge.IncreaseFontSize();
                }
                catch (Exception Ex)
                {
                    ;// Console.WriteLine(Ex.Message);
                }
                finally
                {
                    labelText.Font = new Font(labelText.Font.FontFamily.Name, configsBridge.FontSize);
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                try
                {
                    configsBridge.DecreaseFontSize();
                }
                catch (Exception Ex)
                {
                    ;// Console.WriteLine(Ex.Message);
                }
                finally
                {
                    labelText.Font = new Font(labelText.Font.FontFamily.Name, configsBridge.FontSize);
                }
            }
            else if (e.KeyCode == Keys.R)
            {
                // Text First position
                labelText.Top = (int)configsBridge.TextFirstPosition;
            }
            else
            {
                ;
            }

            // Speed text
            timer1.Interval = configsBridge.DefaultSpeed.Value;

            Console.WriteLine(configsBridge);

        }
    }
}

