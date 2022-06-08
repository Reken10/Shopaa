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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet.Код_одежды". При необходимости она может быть перемещена или удалена.
            this.код_одеждыTableAdapter.Fill(this.база_данныхDataSet.Код_одежды);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
