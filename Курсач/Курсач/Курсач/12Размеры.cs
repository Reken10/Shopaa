﻿using System;
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
    public partial class Размеры : Form
    {
        public Размеры()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet.Размеры". При необходимости она может быть перемещена или удалена.
            this.размерыTableAdapter.Fill(this.база_данныхDataSet.Размеры);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
