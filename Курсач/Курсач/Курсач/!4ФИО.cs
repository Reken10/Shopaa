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
    public partial class ФИО : Form
    {
        public ФИО()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet.ФИО". При необходимости она может быть перемещена или удалена.
            this.фИОTableAdapter.Fill(this.база_данныхDataSet.ФИО);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
