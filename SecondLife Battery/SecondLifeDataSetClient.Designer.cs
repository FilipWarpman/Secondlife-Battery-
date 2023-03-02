using System;

namespace SecondLife_Battery
{
    partial class SecondLifeDataSetClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondLifeDataSetClient));
            this.dataGridViewElectricityPrices = new System.Windows.Forms.DataGridView();
            this.dataGridViewWeather = new System.Windows.Forms.DataGridView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.ShowDataPanel = new System.Windows.Forms.Panel();
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.progressBarContinue = new System.Windows.Forms.ProgressBar();
            this.nextButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElectricityPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).BeginInit();
            this.ShowDataPanel.SuspendLayout();
            this.WelcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewElectricityPrices
            // 
            this.dataGridViewElectricityPrices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewElectricityPrices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewElectricityPrices.BackgroundColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewElectricityPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElectricityPrices.Location = new System.Drawing.Point(35, 111);
            this.dataGridViewElectricityPrices.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewElectricityPrices.Name = "dataGridViewElectricityPrices";
            this.dataGridViewElectricityPrices.RowHeadersWidth = 62;
            this.dataGridViewElectricityPrices.RowTemplate.Height = 28;
            this.dataGridViewElectricityPrices.Size = new System.Drawing.Size(317, 198);
            this.dataGridViewElectricityPrices.TabIndex = 0;
            this.dataGridViewElectricityPrices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewElectricityPrices);
            // 
            // dataGridViewWeather
            // 
            this.dataGridViewWeather.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewWeather.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewWeather.BackgroundColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeather.Location = new System.Drawing.Point(301, 111);
            this.dataGridViewWeather.Name = "dataGridViewWeather";
            this.dataGridViewWeather.RowHeadersWidth = 62;
            this.dataGridViewWeather.Size = new System.Drawing.Size(707, 196);
            this.dataGridViewWeather.TabIndex = 3;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.comboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "SE1",
            "SE2",
            "SE3",
            "SE4"});
            this.comboBox.Location = new System.Drawing.Point(869, 25);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(82, 21);
            this.comboBox.TabIndex = 4;
            this.comboBox.Text = "Area";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // ShowDataPanel
            // 
            this.ShowDataPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowDataPanel.BackgroundImage")));
            this.ShowDataPanel.Controls.Add(this.comboBox);
            this.ShowDataPanel.Controls.Add(this.dataGridViewWeather);
            this.ShowDataPanel.Controls.Add(this.dataGridViewElectricityPrices);
            this.ShowDataPanel.Location = new System.Drawing.Point(0, 0);
            this.ShowDataPanel.Name = "ShowDataPanel";
            this.ShowDataPanel.Size = new System.Drawing.Size(998, 463);
            this.ShowDataPanel.TabIndex = 6;
            this.ShowDataPanel.Hide();
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.SystemColors.Control;
            this.WelcomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WelcomePanel.BackgroundImage")));
            this.WelcomePanel.Controls.Add(this.progressBarContinue);
            this.WelcomePanel.Controls.Add(this.nextButton);
            this.WelcomePanel.Controls.Add(this.ShowDataPanel);
            this.WelcomePanel.Controls.Add(this.welcomeLabel);
            this.WelcomePanel.Location = new System.Drawing.Point(12, 12);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(1011, 485);
            this.WelcomePanel.TabIndex = 7;
            // 
            // progressBarContinue
            // 
            this.progressBarContinue.Location = new System.Drawing.Point(455, 264);
            this.progressBarContinue.Name = "progressBarContinue";
            this.progressBarContinue.Size = new System.Drawing.Size(94, 27);
            this.progressBarContinue.TabIndex = 0;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.nextButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextButton.Location = new System.Drawing.Point(455, 222);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(94, 27);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Continue";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcomeLabel.Location = new System.Drawing.Point(430, 160);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(157, 39);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to SecondLifeBattery!\r\n\r\nPress \"Continue\" to continue.\r\n";
            // 
            // SecondLifeDataSetClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 511);
            this.Controls.Add(this.WelcomePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SecondLifeDataSetClient";
            this.Text = "SecondLifeDataSetClient";
            this.Load += new System.EventHandler(this.SecondLifeDataSetClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElectricityPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).EndInit();
            this.ShowDataPanel.ResumeLayout(false);
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewElectricityPrices;
        private System.Windows.Forms.DataGridView dataGridViewWeather;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox errorMsgTextBox;
        private System.Windows.Forms.Panel ShowDataPanel;
        private System.Windows.Forms.Panel WelcomePanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ProgressBar progressBarContinue;
    }
}