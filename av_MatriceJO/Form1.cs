using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace av_MatriceJO
{
    public partial class Form1 : Form
    {
        int[,] a;
        int[,] b;

        public Form1()
        {
            InitializeComponent();
        }

        void load()
        {
            TextReader dataLoad = new StreamReader(@"..\..\Data.in");
            string buffer = dataLoad.ReadLine();
            // "4 5"
            int n = int.Parse(buffer.Split(' ')[0]);
            int m = int.Parse(buffer.Split(' ')[1]);
            a = new int[n, m];
            for (int i = 0; i<n; i++)
            {
                buffer = dataLoad.ReadLine();
                string[] local = buffer.Split(' ');

                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(local[j]);
                }
            }
            dataLoad.Close();
        }

        void view()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                string buffer = "";
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    buffer += T[i, j] + " ";
                }
                listBox1.Items.Add(buffer);
            }
        }

        void doMath()
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            b = new int[2*n - 1, 2*m -1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    b[i * 2, j * 2] = a[i, j];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
            doMath();
            view();
            view();
        }
    }
}
