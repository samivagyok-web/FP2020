using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataRoman
{
    public partial class Form : System.Windows.Forms.Form
    {

        string convert(int i, string A, string B, string C)
        {
            string tor = "";
            switch (i)
            {
                case 1: tor += A; break;
                case 2: tor += A + A; break;
                case 3: tor += A + A + A; break;
                case 4: tor += A + B; break;
                case 5: 
                case 6:
                case 7:
                case 8:
                case 9:
                default:
                    break;
            }
        }
        int dd = -1;
        int mm = -1;
        int yy = -1;

        public Form()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                mm = int.Parse(textBox1.Text);
            }
            catch
            { }
            try
            {
                dd = int.Parse(textBox3.Text);
            }
            catch { }
            try
            {
                yy = int.Parse(textBox2.Text);
            }
            catch { }

            if (dd == -1 && mm == -1 && yy == -1)
            {
                listBox1.Items.Add("Answer");
                listBox1.Items.Add("Enter at least one value for month, day or year");
            }
            else
            {
                bool ddok = false;
                bool mmok = false;
                bool yyok = false;

                if (dd >= 1 && dd <= 31)
                    ddok = true;
                if (mm >= 1 && mm <= 12)
                    mmok = true;
                if (yy >= 1 && yy <= 3999)
                    yyok = true;

                if (ddok && mmok & yyok)
                {
                    
                }
                else
                {
                    if (!mmok)
                        listBox1.Items.Add("Enter a valid month.");
                    if (!ddok)
                        listBox1.Items.Add("Enter a valid day.");
                    if (!yyok)
                        listBox1.Items.Add("Enter a valid year.");
                }
            }    

            listBox1.Items.Add(mm + " " + dd + " " + yy);
        }
    }
}
