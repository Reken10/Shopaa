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
    public partial class Form14 : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = База данных.mdb";
        private OleDbConnection myConnection;
        public Form14()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string Full_name = textBox2.Text;
            string Address = textBox3.Text;
            string Telephone = textBox4.Text;
            string Login = textBox5.Text;
            string Clothing_Code = textBox6.Text;
            string Type_of_clothing = textBox7.Text;
            string A_variety_of_children = textBox8.Text;
            string Composition = textBox9.Text;
            string Size = textBox10.Text;
            string query = "INSERT INTO [Магазин одежды для детей] ([Код клиента], ФИО, Адрес, Телефон, Логин, [Код одежды], [Вид одежды], [Разновидность детской одежды], Состав, Размеры) VALUES (" + kod + ",'" + Full_name + "','" + Address + "', '" + Telephone + "', '" + Login + "','" + Clothing_Code + "','" + Type_of_clothing + "','" + A_variety_of_children + "','" + Composition + "','" + Size + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Клиент добавлен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
