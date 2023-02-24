using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWin_Mariyana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1Otpechatvane_Click(object sender, EventArgs e)
        {

            string ime = " ";
            string avtor = " ";
            string janr = " ";
            string korica = " ";
            string izdatelstvo = " ";
            if (ckb1.Checked)
            {
                MessageBox.Show("da");
            }
            else
            {
                MessageBox.Show("Ne");
            }
            MessageBox.Show($"Вие въведохте{ime}с автор{avtor} и {janr} литература, {korica} корица от издателство {izdatelstvo}");
        }
    }
}
