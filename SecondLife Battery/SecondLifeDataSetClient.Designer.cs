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
            this.dataGridViewElectricityPrices = new System.Windows.Forms.DataGridView();
            this.dataGridViewWeather = new System.Windows.Forms.DataGridView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.errorMsgTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElectricityPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewElectricityPrices
            // 
            this.dataGridViewElectricityPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElectricityPrices.Location = new System.Drawing.Point(46, 122);
            this.dataGridViewElectricityPrices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewElectricityPrices.Name = "dataGridViewElectricityPrices";
            this.dataGridViewElectricityPrices.RowHeadersWidth = 62;
            this.dataGridViewElectricityPrices.RowTemplate.Height = 28;
            this.dataGridViewElectricityPrices.Size = new System.Drawing.Size(356, 289);
            this.dataGridViewElectricityPrices.TabIndex = 0;
            this.dataGridViewElectricityPrices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewElectricityPrices);
            // 
            // dataGridViewWeather
            // 
            this.dataGridViewWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeather.Location = new System.Drawing.Point(419, 122);
            this.dataGridViewWeather.Name = "dataGridViewWeather";
            this.dataGridViewWeather.RowHeadersWidth = 62;
            this.dataGridViewWeather.Size = new System.Drawing.Size(589, 289);
            this.dataGridViewWeather.TabIndex = 3;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "SE1",
            "SE2",
            "SE3",
            "SE4"});
            this.comboBox.Location = new System.Drawing.Point(179, 53);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(198, 21);
            this.comboBox.TabIndex = 4;
            this.comboBox.Text = "Area";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // errorMsgTextBox
            // 
            this.errorMsgTextBox.Location = new System.Drawing.Point(46, 428);
            this.errorMsgTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errorMsgTextBox.Name = "errorMsgTextBox";
            this.errorMsgTextBox.Size = new System.Drawing.Size(963, 20);
            this.errorMsgTextBox.TabIndex = 5;
            // 
            // SecondLifeDataSetClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 500);
            this.Controls.Add(this.errorMsgTextBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dataGridViewWeather);
            this.Controls.Add(this.dataGridViewElectricityPrices);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SecondLifeDataSetClient";
            this.Text = "SecondLifeDataSetClient";
            this.Load += new System.EventHandler(this.SecondLifeDataSetClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElectricityPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewElectricityPrices;
        private System.Windows.Forms.DataGridView dataGridViewWeather;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox errorMsgTextBox;
    }
}