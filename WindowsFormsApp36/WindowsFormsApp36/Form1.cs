using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//красный цвет
        {
           if (checkBox1.Checked) { METODS.R = 255; } else { METODS.R = 0; }
            METODS.Zveta(this);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//зеленый цвет
        {
            if (checkBox2.Checked) { METODS.G = 255; } else { METODS.G = 0; }
            METODS.Zveta(this);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)//синий цвет
        {
            if (checkBox3.Checked) { METODS.B = 255; } else { METODS.B = 0; }
            METODS.Zveta(this);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//иконка формы
        {
            if (radioButton1.Checked) { METODS.D = 1; } else { METODS.D = 0; }
            METODS.ICON(this);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//иконка формы
        {
            if (radioButton2.Checked) { METODS.D = 2; } else { METODS.D = 0; }
            METODS.ICON(this);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//иконка формы
        {
            if (radioButton3.Checked) { METODS.D = 3; } else { METODS.D = 0; }
            METODS.ICON(this);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//цвета
        {
            if(listBox1.SelectedIndex == 0) { METODS.R = 255; METODS.G = 0; METODS.B = 0; }
            if (listBox1.SelectedIndex == 1) { METODS.R = 0; METODS.G = 255; METODS.B = 0; }
            if (listBox1.SelectedIndex == 2) { METODS.R = 0; METODS.G = 0; METODS.B = 255; }
            METODS.Zveta(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//название формы
        {
            if (comboBox1.Text == "Название") { METODS.D = 1; } else { METODS.D = 0; }
            METODS.TEXT(this);
            if (comboBox1.Text == "чтото") { METODS.D = 2; } else { METODS.D = 0; }
            METODS.TEXT(this);
            if (comboBox1.Text == "ято") { METODS.D = 3; } else { METODS.D = 0; }
            METODS.TEXT(this);

        }
    }
}
