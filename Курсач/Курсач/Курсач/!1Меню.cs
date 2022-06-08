using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ФИО f3 = new ФИО();
            f3.Owner = this;
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Адрес f4 = new Адрес();
            f4.Owner = this;
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Логин f6 = new Логин();
            f6.Owner = this;
            f6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Owner = this;
            f7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Owner = this;
            f8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Owner = this;
            f9.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Состав f10 = new Состав();
            f10.Owner = this;
            f10.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Размеры f11 = new Размеры();
            f11.Owner = this;
            f11.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Owner = this;
            f12.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Owner = this;
            f13.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Owner = this;
            f15.Show();
        }
    }
}
