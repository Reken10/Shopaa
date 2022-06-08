using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Курсач
{
    public partial class Form12 : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = База данных.mdb";
        private OleDbConnection myConnection;
        public Form12()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet.Магазин_одежды_для_детей". При необходимости она может быть перемещена или удалена.
            this.магазин_одежды_для_детейTableAdapter.Fill(this.база_данныхDataSet.Магазин_одежды_для_детей);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Owner = this;
            f14.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM [Магазин одежды для детей] WHERE [Код клиента] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о клиенте были удалены");
            this.магазин_одежды_для_детейTableAdapter.Fill(this.база_данныхDataSet.Магазин_одежды_для_детей);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "UPDATE [Магазин одежды для детей] SET [Код одежды] =" + textBox3.Text + " WHERE [Код клиента] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о коде одежды у клиента изменены ");
            this.магазин_одежды_для_детейTableAdapter.Fill(this.база_данныхDataSet.Магазин_одежды_для_детей);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.магазин_одежды_для_детейTableAdapter.Fill(this.база_данныхDataSet.Магазин_одежды_для_детей);
        }

        private void кодДеждыПоКодуКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Owner = this;
            f16.Show();
        }

        private void фИОПоЛогинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Owner = this;
            f1.Show();
        }
    }
}
