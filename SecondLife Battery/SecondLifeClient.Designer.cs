namespace SecondLife_Battery
{
    partial class SecondLifeClient
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
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TextBoxSuggestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(255, 113);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 26);
            this.DatePicker.TabIndex = 0;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // TextBoxSuggestion
            // 
            this.TextBoxSuggestion.Location = new System.Drawing.Point(56, 365);
            this.TextBoxSuggestion.Name = "TextBoxSuggestion";
            this.TextBoxSuggestion.Size = new System.Drawing.Size(680, 26);
            this.TextBoxSuggestion.TabIndex = 1;
            this.TextBoxSuggestion.TextChanged += new System.EventHandler(this.TextBoxSuggestion_TextChanged);
            // 
            // SecondLifeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxSuggestion);
            this.Controls.Add(this.DatePicker);
            this.Name = "SecondLifeClient";
            this.Text = "SecondLifeClient";
            this.Load += new System.EventHandler(this.SecondLifeClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox TextBoxSuggestion;
    }
}

