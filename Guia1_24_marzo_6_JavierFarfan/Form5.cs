using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_24_marzo_6_JavierFarfan
{
    public partial class Form5 : Form
    {
        private int[,] m1;
        private int[,] m2;
        int multi;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m1 = new int[2, 3];
            m2 = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m1[i, j] = Convert.ToInt32(Interaction.InputBox("ingresa los numero: "));
                }

            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m2[i, j] = Convert.ToInt32(Interaction.InputBox("ingresa los numero: "));
                }

            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    multi = m1[i, j] * m2[i, j];
                    dataGridView1.Rows.Add(m1[i, j], m2[i, j], multi);
                }

            }
        }
    }
}
