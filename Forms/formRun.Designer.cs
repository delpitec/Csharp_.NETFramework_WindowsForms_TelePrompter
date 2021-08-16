
namespace TelePrompter
{
    partial class formRun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRun));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.keyEnterPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keyUpPanel = new System.Windows.Forms.Panel();
            this.keyDownPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.labelText);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 426);
            this.panel1.TabIndex = 0;
            // 
            // labelText
            // 
            this.labelText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelText.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelText.Location = new System.Drawing.Point(-3, 0);
            this.labelText.Margin = new System.Windows.Forms.Padding(3);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(707, 65535);
            this.labelText.TabIndex = 0;
            this.labelText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.keyEnterPanel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.keyUpPanel);
            this.panel2.Controls.Add(this.keyDownPanel);
            this.panel2.Location = new System.Drawing.Point(732, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 429);
            this.panel2.TabIndex = 1;
            // 
            // keyEnterPanel
            // 
            this.keyEnterPanel.BackgroundImage = global::TelePrompter.Properties.Resources.enter_icon__1_;
            this.keyEnterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.keyEnterPanel.Location = new System.Drawing.Point(6, 290);
            this.keyEnterPanel.Name = "keyEnterPanel";
            this.keyEnterPanel.Size = new System.Drawing.Size(102, 95);
            this.keyEnterPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Play/Pause";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Speed DOWN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Speed UP";
            // 
            // keyUpPanel
            // 
            this.keyUpPanel.BackgroundImage = global::TelePrompter.Properties.Resources.arrow_up_icon;
            this.keyUpPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.keyUpPanel.Location = new System.Drawing.Point(8, 25);
            this.keyUpPanel.Name = "keyUpPanel";
            this.keyUpPanel.Size = new System.Drawing.Size(100, 92);
            this.keyUpPanel.TabIndex = 4;
            // 
            // keyDownPanel
            // 
            this.keyDownPanel.BackgroundImage = global::TelePrompter.Properties.Resources.arrow_down_icon;
            this.keyDownPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.keyDownPanel.Location = new System.Drawing.Point(6, 122);
            this.keyDownPanel.Name = "keyDownPanel";
            this.keyDownPanel.Size = new System.Drawing.Size(102, 95);
            this.keyDownPanel.TabIndex = 3;
            // 
            // formRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 435);
            this.Name = "formRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teleprompter - Run";
            this.Load += new System.EventHandler(this.formRun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formRun_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel keyDownPanel;
        private System.Windows.Forms.Panel keyUpPanel;
        private System.Windows.Forms.Panel keyEnterPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}