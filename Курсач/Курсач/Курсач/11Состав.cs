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
    public partial class Состав : Form
    {
        public Состав()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet.Состав". При необходимости она может быть перемещена или удалена.
            this.составTableAdapter.Fill(this.база_данныхDataSet.Состав);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
