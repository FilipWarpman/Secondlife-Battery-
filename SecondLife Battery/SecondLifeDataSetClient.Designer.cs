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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElectricityPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewElectricityPrices
            // 
            this.dataGridViewElectricityPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElectricityPrices.Location = new System.Drawing.Point(124, 184);
            this.dataGridViewElectricityPrices.Name = "dataGridViewElectricityPrices";
            this.dataGridViewElectricityPrices.RowHeadersWidth = 62;
            this.dataGridViewElectricityPrices.RowTemplate.Height = 28;
            this.dataGridViewElectricityPrices.Size = new System.Drawing.Size(877, 473);
            this.dataGridViewElectricityPrices.TabIndex = 0;
            this.dataGridViewElectricityPrices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewElectricityPrices);
            // 
            // getResult
            // 
            this.getResult.Location = new System.Drawing.Point(581, 49);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(238, 87);
            this.getResult.TabIndex = 1;
            this.getResult.Text = "GET RESULT";
            this.getResult.UseVisualStyleBackColor = true;
            this.getResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // dateTimePicker
            // 
            DateTime currentDate = DateTime.Now;
            DateTime tempDate = currentDate.AddYears(-1);
            this.dateTimePicker.Location = new System.Drawing.Point(222, 60);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value= tempDate;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // SecondLifeDataSetClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 716);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.getResult);
            this.Controls.Add(this.dataGridViewElectricityPrices);
            this.Name = "SecondLifeDataSetClient";
            this.Text = "SecondLifeDataSetClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElectricityPrices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewElectricityPrices;
        private System.Windows.Forms.Button getResult;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}