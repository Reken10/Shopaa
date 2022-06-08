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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet.Код_клиента". При необходимости она может быть перемещена или удалена.
            this.код_клиентаTableAdapter.Fill(this.база_данныхDataSet.Код_клиента);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
