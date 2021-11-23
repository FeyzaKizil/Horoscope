using Core.Entities;
using Core.WebApi;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Api myApi = new Api();
        private void MainForm_Load(object sender, EventArgs e)
        {
            fillData("today");
        }

        public string pullZodiac()
        {
            if (FindingHoroscope.zodiac == "")
            {
                return WriteYourSign.zodiac;
            }
            else
            {
                return FindingHoroscope.zodiac;
            }
        }

        public void fillData(string day)
        {
            string zodiac = pullZodiac();
            pictureBox1.Image = imageList1.Images[zodiac+".png"];
            JsonDataType data = myApi.pullData(zodiac, day);
            lbl_name.Text = zodiac.ToUpper();
            lbl_compatibility.Text = data.compatibility;
            lbl_luckyTime.Text = data.lucky_time;
            lbl_dateRange.Text = data.date_range;
            lbl_luckyNumber.Text = data.lucky_number;
            lbl_color.Text = data.color;
            lbl_mood.Text = data.mood;
            lbl_description.Text = data.description;
        }

        private void btn_yesterday_Click(object sender, EventArgs e)
        {
            fillData("yesterday");
            btn_yesterday.Visible = false;
        }

        private void btn_tomorrow_Click(object sender, EventArgs e)
        {
            fillData("tomorrow");
            btn_tomorrow.Visible = false;
        }
    }
}
