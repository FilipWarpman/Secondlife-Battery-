using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLife_Battery
{
    public partial class SecondLifeClient : Form
    {
        DAL dataAccessLayer = new DAL();
        public SecondLifeClient()
        {
            InitializeComponent();
        }

        private void SecondLifeClient_Load(object sender, EventArgs e)//namnet på forms
        {

        }
        public void DatePicker_ValueChanged(object sender, EventArgs e)//namnet på datepickern
        {
        }
        public void TextBoxSuggestion_TextChanged(object sender, EventArgs e)//namnet på textboxen
        {

        }
        public DateTime ButtonGetResults_Click(object sender, EventArgs e)//namnet på knappen
        {
            
            return DatePicker.Value;

            TextBoxSuggestion.AppendText();
        }
    }
}
