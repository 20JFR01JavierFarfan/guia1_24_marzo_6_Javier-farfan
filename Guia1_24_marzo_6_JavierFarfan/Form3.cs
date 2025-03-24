using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Guia1_24_marzo_6_JavierFarfan
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont3 = 1;
            int num1 = int.Parse(textBox1.Text);

            do
            {
                int multi;
                multi = num1 * cont3;
                dataGridView1.Rows.Add(num1, cont3, multi);
                cont3++;
            } while (cont3 < 11);
        }
    }
}
