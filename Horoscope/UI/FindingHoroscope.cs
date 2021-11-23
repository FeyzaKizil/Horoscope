using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FindingHoroscope : Form
    {
        public FindingHoroscope()
        {
            InitializeComponent();
        }
        public static string zodiac = "";

        private void btn_continue_Click(object sender, EventArgs e)
        {
            
            zodiac = zodiacSign(dateTimePicker1.Value.Day, dateTimePicker1.Value.Month);
            MessageBox.Show("Your zodiac sign : " + zodiac, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Hide();
            Form mainForm = new MainForm();
            mainForm.Show();
        }

        public string zodiacSign(int day, int month)
        {
            string astro_sign = "";
            if (month == 12)
            {

                if (day < 22)
                    astro_sign = "sagittarius";
                else
                    astro_sign = "capricorn";
            }

            else if (month == 1)
            {
                if (day < 20)
                    astro_sign = "capricorn";
                else
                    astro_sign = "aquarius";
            }

            else if (month == 2)
            {
                if (day < 19)
                    astro_sign = "aquarius";
                else
                    astro_sign = "pisces";
            }

            else if (month == 3)
            {
                if (day < 21)
                    astro_sign = "pisces";
                else
                    astro_sign = "aries";
            }
            else if (month == 4)
            {
                if (day < 20)
                    astro_sign = "aries";
                else
                    astro_sign = "taurus";
            }

            else if (month == 5)
            {
                if (day < 21)
                    astro_sign = "taurus";
                else
                    astro_sign = "gemini";
            }

            else if (month == 6)
            {
                if (day < 21)
                    astro_sign = "gemini";
                else
                    astro_sign = "cancer";
            }

            else if (month == 7)
            {
                if (day < 23)
                    astro_sign = "cancer";
                else
                    astro_sign = "leo";
            }

            else if (month == 8)
            {
                if (day < 23)
                    astro_sign = "leo";
                else
                    astro_sign = "virgo";
            }

            else if (month == 9)
            {
                if (day < 23)
                    astro_sign = "virgo";
                else
                    astro_sign = "libra";
            }

            else if (month == 10)
            {
                if (day < 23)
                    astro_sign = "libra";
                else
                    astro_sign = "scorpio";
            }

            else if (month == 11)
            {
                if (day < 22)
                    astro_sign = "scorpio";
                else
                    astro_sign = "sagittarius";
            }
            return astro_sign;
        }
    }
}
