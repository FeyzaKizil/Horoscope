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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form writeYourSign = new WriteYourSign();
            writeYourSign.Show();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form findingHoroscope = new FindingHoroscope();
            findingHoroscope.Show();
            
        }
    }
}
