
namespace TelePrompter
{
    partial class formSettings
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupTxtBeginning = new System.Windows.Forms.GroupBox();
            this.radioButtonTxtTop = new System.Windows.Forms.RadioButton();
            this.radioButtonTxtBotton = new System.Windows.Forms.RadioButton();
            this.radioButtonTxtMiddle = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioWhiteBlue = new System.Windows.Forms.RadioButton();
            this.radioBlackWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonWhiteBlack = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupTxtBeginning.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOpenFile);
            this.groupBox1.Controls.Add(this.textBoxFilePath);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text File";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.LightGray;
            this.buttonOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonOpenFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Image = global::TelePrompter.Properties.Resources.openfile1;
            this.buttonOpenFile.Location = new System.Drawing.Point(238, 18);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(37, 37);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilePath.Location = new System.Drawing.Point(6, 22);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(227, 29);
            this.textBoxFilePath.TabIndex = 1;
            this.textBoxFilePath.Text = "(No file selected)";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 18;
            this.trackBarSpeed.Location = new System.Drawing.Point(6, 19);
            this.trackBarSpeed.Maximum = 19;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(181, 45);
            this.trackBarSpeed.TabIndex = 3;
            this.trackBarSpeed.Value = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.trackBarSpeed);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(99, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 72);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Default Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(152, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Slow";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fast";
            // 
            // groupTxtBeginning
            // 
            this.groupTxtBeginning.Controls.Add(this.radioButtonTxtTop);
            this.groupTxtBeginning.Controls.Add(this.radioButtonTxtBotton);
            this.groupTxtBeginning.Controls.Add(this.radioButtonTxtMiddle);
            this.groupTxtBeginning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupTxtBeginning.Location = new System.Drawing.Point(12, 19);
            this.groupTxtBeginning.Name = "groupTxtBeginning";
            this.groupTxtBeginning.Size = new System.Drawing.Size(136, 95);
            this.groupTxtBeginning.TabIndex = 6;
            this.groupTxtBeginning.TabStop = false;
            this.groupTxtBeginning.Text = "Text 1st position";
            // 
            // radioButtonTxtTop
            // 
            this.radioButtonTxtTop.AutoSize = true;
            this.radioButtonTxtTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTxtTop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonTxtTop.Location = new System.Drawing.Point(12, 19);
            this.radioButtonTxtTop.Name = "radioButtonTxtTop";
            this.radioButtonTxtTop.Size = new System.Drawing.Size(51, 20);
            this.radioButtonTxtTop.TabIndex = 8;
            this.radioButtonTxtTop.Text = "Top";
            this.radioButtonTxtTop.UseVisualStyleBackColor = true;
            // 
            // radioButtonTxtBotton
            // 
            this.radioButtonTxtBotton.AutoSize = true;
            this.radioButtonTxtBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTxtBotton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonTxtBotton.Location = new System.Drawing.Point(12, 69);
            this.radioButtonTxtBotton.Name = "radioButtonTxtBotton";
            this.radioButtonTxtBotton.Size = new System.Drawing.Size(64, 20);
            this.radioButtonTxtBotton.TabIndex = 7;
            this.radioButtonTxtBotton.Text = "Botton";
            this.radioButtonTxtBotton.UseVisualStyleBackColor = true;
            // 
            // radioButtonTxtMiddle
            // 
            this.radioButtonTxtMiddle.AutoSize = true;
            this.radioButtonTxtMiddle.Checked = true;
            this.radioButtonTxtMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTxtMiddle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonTxtMiddle.Location = new System.Drawing.Point(12, 44);
            this.radioButtonTxtMiddle.Name = "radioButtonTxtMiddle";
            this.radioButtonTxtMiddle.Size = new System.Drawing.Size(67, 20);
            this.radioButtonTxtMiddle.TabIndex = 6;
            this.radioButtonTxtMiddle.TabStop = true;
            this.radioButtonTxtMiddle.Text = "Middle";
            this.radioButtonTxtMiddle.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioWhiteBlue);
            this.groupBox4.Controls.Add(this.radioBlackWhite);
            this.groupBox4.Controls.Add(this.radioButtonWhiteBlack);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(154, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 95);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Letter/Back color";
            // 
            // radioWhiteBlue
            // 
            this.radioWhiteBlue.AutoSize = true;
            this.radioWhiteBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWhiteBlue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioWhiteBlue.Location = new System.Drawing.Point(12, 69);
            this.radioWhiteBlue.Name = "radioWhiteBlue";
            this.radioWhiteBlue.Size = new System.Drawing.Size(91, 20);
            this.radioWhiteBlue.TabIndex = 10;
            this.radioWhiteBlue.Text = "White/Blue";
            this.radioWhiteBlue.UseVisualStyleBackColor = true;
            // 
            // radioBlackWhite
            // 
            this.radioBlackWhite.AutoSize = true;
            this.radioBlackWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBlackWhite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioBlackWhite.Location = new System.Drawing.Point(12, 44);
            this.radioBlackWhite.Name = "radioBlackWhite";
            this.radioBlackWhite.Size = new System.Drawing.Size(98, 20);
            this.radioBlackWhite.TabIndex = 9;
            this.radioBlackWhite.Text = "Black/White";
            this.radioBlackWhite.UseVisualStyleBackColor = true;
            // 
            // radioButtonWhiteBlack
            // 
            this.radioButtonWhiteBlack.AutoSize = true;
            this.radioButtonWhiteBlack.Checked = true;
            this.radioButtonWhiteBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWhiteBlack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonWhiteBlack.Location = new System.Drawing.Point(12, 19);
            this.radioButtonWhiteBlack.Name = "radioButtonWhiteBlack";
            this.radioButtonWhiteBlack.Size = new System.Drawing.Size(98, 20);
            this.radioButtonWhiteBlack.TabIndex = 8;
            this.radioButtonWhiteBlack.TabStop = true;
            this.radioButtonWhiteBlack.Text = "White/Black";
            this.radioButtonWhiteBlack.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxFontSize);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(80, 72);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font Size";
            // 
            // comboBoxFontSize
            // 
            this.comboBoxFontSize.AutoCompleteCustomSource.AddRange(new string[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "20",
            "22",
            "24",
            "28",
            "32",
            "36",
            "38",
            "42",
            "54"});
            this.comboBoxFontSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxFontSize.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFontSize.DropDownHeight = 160;
            this.comboBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFontSize.FormattingEnabled = true;
            this.comboBoxFontSize.IntegralHeight = false;
            this.comboBoxFontSize.Location = new System.Drawing.Point(14, 26);
            this.comboBoxFontSize.MaxDropDownItems = 4;
            this.comboBoxFontSize.Name = "comboBoxFontSize";
            this.comboBoxFontSize.Size = new System.Drawing.Size(50, 26);
            this.comboBoxFontSize.TabIndex = 0;
            // 
            // buttonRun
            // 
            this.buttonRun.BackColor = System.Drawing.Color.LightGray;
            this.buttonRun.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonRun.FlatAppearance.BorderSize = 0;
            this.buttonRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Image = ((System.Drawing.Image)(resources.GetObject("buttonRun.Image")));
            this.buttonRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRun.Location = new System.Drawing.Point(111, 293);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(94, 37);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "     Run";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(306, 340);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupTxtBeginning);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teleprompter - Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupTxtBeginning.ResumeLayout(false);
            this.groupTxtBeginning.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupTxtBeginning;
        private System.Windows.Forms.RadioButton radioButtonTxtMiddle;
        private System.Windows.Forms.RadioButton radioButtonTxtBotton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioBlackWhite;
        private System.Windows.Forms.RadioButton radioButtonWhiteBlack;
        private System.Windows.Forms.RadioButton radioWhiteBlue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.RadioButton radioButtonTxtTop;
        private System.Windows.Forms.ComboBox comboBoxFontSize;
    }
}

