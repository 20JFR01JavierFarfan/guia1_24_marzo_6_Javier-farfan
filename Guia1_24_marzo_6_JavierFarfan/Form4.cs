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
    public partial class Form4 : Form
    {
        public int[] vector1;
        public int[] vector2;
        int suma;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vector2 = new int[2];
            vector1 = new int[2];
            for (int i = 0; i < 2; i++)
            {
                {
                    vector1[i] = Convert.ToInt32(Interaction.InputBox("ingrese numero: "));
                }
            }
            for (int i = 0; i < 2; i++) 
            {
                vector2[i] = Convert.ToInt32(Interaction.InputBox("ingrese numero: "));
            }
            for(int i = 0;i < 2; i++)
            {
                suma = vector1[i] + vector2[i];
                dataGridView1.Rows.Add(vector1[i], vector2[i],suma);
            }
        }
    }
}
