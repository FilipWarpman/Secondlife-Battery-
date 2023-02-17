using System;
using System.Collections;
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
        ArrayList receievedPrice = new ArrayList();
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
            TextBoxSuggestion.Clear();
            dataAccessLayer.ClearData();
            receievedPrice.Clear();
        }
        public void TextBoxSuggestion_TextChanged(object sender, EventArgs e)//namnet på textboxen
        {

        }
        public void ButtonGetResults_Click(object sender, EventArgs e)//namnet på knappen
        {
            DateTime date = DatePicker.Value;
            try
            {
                dataAccessLayer.ClearData();
                receievedPrice.Clear();
                TextBoxSuggestion.Clear();
                dataAccessLayer.SetDate(date);
                receievedPrice = dataAccessLayer.GetElectricityPrice();

                if (receievedPrice != null && receievedPrice.Count is 6)
                {
                    double price1 = (double)receievedPrice[0];
                    double price2 = (double)receievedPrice[1];
                    double price3 = (double)receievedPrice[2];
                    double price4 = (double)receievedPrice[3];
                    double price5 = (double)receievedPrice[4];
                    double price6 = (double)receievedPrice[5];
                    TextBoxSuggestion.Text = price1.ToString()+ " kr/MWh " + price2.ToString() + " kr/MWh " + price3.ToString() + " kr/MWh " + price4.ToString() + " kr/MWh " + price5.ToString() + " kr/MWh " + price6.ToString()+ " kr/MWh ";
                }
                else if(receievedPrice != null && receievedPrice.Count is 5)
                {
                    double price1 = (double)receievedPrice[0];
                    double price2 = (double)receievedPrice[1];
                    double price3 = (double)receievedPrice[2];
                    double price4 = (double)receievedPrice[3];
                    double price5 = (double)receievedPrice[4];
                    TextBoxSuggestion.Text = price1.ToString() + " kr/MWh " + price2.ToString() + " kr/MWh " + price3.ToString() + " kr/MWh " + price4.ToString() + " kr/MWh " + price5.ToString() + " kr/MWh ";
                }
                else if (receievedPrice != null && receievedPrice.Count is 4)
                {
                    double price1 = (double)receievedPrice[0];
                    double price2 = (double)receievedPrice[1];
                    double price3 = (double)receievedPrice[2];
                    double price4 = (double)receievedPrice[3];
                    TextBoxSuggestion.Text = price1.ToString() + " kr/MWh " + price2.ToString() + " kr/MWh " + price3.ToString() + " kr/MWh " + price4.ToString()+ " kr/MWh ";
                }
                else if (receievedPrice != null && receievedPrice.Count is 3)
                {
                    double price1 = (double)receievedPrice[0];
                    double price2 = (double)receievedPrice[1];
                    double price3 = (double)receievedPrice[2];
                    TextBoxSuggestion.Text = price1.ToString() + " kr/MWh " + price2.ToString() + " kr/MWh " + price3.ToString()+ " kr/MWh ";
                }
                else if (receievedPrice != null && receievedPrice.Count is 2)
                {
                    double price1 = (double)receievedPrice[0];
                    double price2 = (double)receievedPrice[1];
                    TextBoxSuggestion.Text = price1.ToString() + " kr/MWh " + price2.ToString() + " kr/MWh ";
                }
                else if (receievedPrice != null && receievedPrice.Count is 1)
                {
                    double price1 = (double)receievedPrice[0];
                    TextBoxSuggestion.Text = price1.ToString() + " kr/MWh ";
                }
                else 
                {
                    TextBoxSuggestion.Text = receievedPrice.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
