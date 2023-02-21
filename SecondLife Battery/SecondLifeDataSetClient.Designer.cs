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
            this.getResult = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.dataGridViewElectricityPrices.Location = new System.Drawing.Point(69, 188);
            this.dataGridViewElectricityPrices.Name = "dataGridViewElectricityPrices";
            this.dataGridViewElectricityPrices.RowHeadersWidth = 62;
            this.dataGridViewElectricityPrices.RowTemplate.Height = 28;
            this.dataGridViewElectricityPrices.Size = new System.Drawing.Size(534, 445);
            this.dataGridViewElectricityPrices.TabIndex = 0;
            this.dataGridViewElectricityPrices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewElectricityPrices);
            // 
            // getResult
            // 
            this.getResult.Location = new System.Drawing.Point(736, 60);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(238, 88);
            this.getResult.TabIndex = 1;
            this.getResult.Text = "GET RESULT";
            this.getResult.UseVisualStyleBackColor = true;
            this.getResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(222, 60);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value = new System.DateTime(2022, 2, 20, 13, 24, 43, 104);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // dataGridViewWeather
            // 
            this.dataGridViewWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeather.Location = new System.Drawing.Point(628, 188);
            this.dataGridViewWeather.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewWeather.Name = "dataGridViewWeather";
            this.dataGridViewWeather.RowHeadersWidth = 62;
            this.dataGridViewWeather.Size = new System.Drawing.Size(616, 445);
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
            this.comboBox.Location = new System.Drawing.Point(512, 91);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 28);
            this.comboBox.TabIndex = 4;
            // 
            // errorMsgTextBox
            // 
            this.errorMsgTextBox.Location = new System.Drawing.Point(69, 658);
            this.errorMsgTextBox.Name = "errorMsgTextBox";
            this.errorMsgTextBox.Size = new System.Drawing.Size(1175, 26);
            this.errorMsgTextBox.TabIndex = 5;
            // 
            // SecondLifeDataSetClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 770);
            this.Controls.Add(this.errorMsgTextBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dataGridViewWeather);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.getResult);
            this.Controls.Add(this.dataGridViewElectricityPrices);
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
        private System.Windows.Forms.Button getResult;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridViewWeather;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox errorMsgTextBox;
    }
}