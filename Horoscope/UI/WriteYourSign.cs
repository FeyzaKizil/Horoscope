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
    public partial class WriteYourSign : Form
    {
        public static string zodiac = "";
        public WriteYourSign()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            zodiac = comboBox1.SelectedItem.ToString().ToLower();
            Form mainForm = new MainForm();
            mainForm.Show();
        }


    }
}
