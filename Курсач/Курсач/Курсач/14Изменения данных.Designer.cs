namespace Курсач
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодОдеждыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видОдеждыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.разновидностьДетскойОдеждыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.составDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.магазинОдеждыДляДетейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данныхDataSet = new Курсач.База_данныхDataSet();
            this.магазин_одежды_для_детейTableAdapter = new Курсач.База_данныхDataSetTableAdapters.Магазин_одежды_для_детейTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кодДеждыПоКодуКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фИОПоЛогинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазинОдеждыДляДетейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.логинDataGridViewTextBoxColumn,
            this.кодОдеждыDataGridViewTextBoxColumn,
            this.видОдеждыDataGridViewTextBoxColumn,
            this.разновидностьДетскойОдеждыDataGridViewTextBoxColumn,
            this.составDataGridViewTextBoxColumn,
            this.размерыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.магазинОдеждыДляДетейBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            this.кодКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            this.логинDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодОдеждыDataGridViewTextBoxColumn
            // 
            this.кодОдеждыDataGridViewTextBoxColumn.DataPropertyName = "Код одежды";
            this.кодОдеждыDataGridViewTextBoxColumn.HeaderText = "Код одежды";
            this.кодОдеждыDataGridViewTextBoxColumn.Name = "кодОдеждыDataGridViewTextBoxColumn";
            this.кодОдеждыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видОдеждыDataGridViewTextBoxColumn
            // 
            this.видОдеждыDataGridViewTextBoxColumn.DataPropertyName = "Вид одежды";
            this.видОдеждыDataGridViewTextBoxColumn.HeaderText = "Вид одежды";
            this.видОдеждыDataGridViewTextBoxColumn.Name = "видОдеждыDataGridViewTextBoxColumn";
            this.видОдеждыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // разновидностьДетскойОдеждыDataGridViewTextBoxColumn
            // 
            this.разновидностьДетскойОдеждыDataGridViewTextBoxColumn.DataPropertyName = "Разновидность детской одежды";
            this.разновидностьДетскойОдеждыDataGridViewTextBoxColumn.HeaderText = "Разновидность детской одежды";
            this.разновидностьДетскойОдеждыDataGridViewTextBoxColumn.Name = "разновидностьДетскойОдеждыDataGridViewTextBoxColumn";
            this.разновидностьДетскойОдеждыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // составDataGridViewTextBoxColumn
            // 
            this.составDataGridViewTextBoxColumn.DataPropertyName = "Состав";
            this.составDataGridViewTextBoxColumn.HeaderText = "Состав";
            this.составDataGridViewTextBoxColumn.Name = "составDataGridViewTextBoxColumn";
            this.составDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // размерыDataGridViewTextBoxColumn
            // 
            this.размерыDataGridViewTextBoxColumn.DataPropertyName = "Размеры";
            this.размерыDataGridViewTextBoxColumn.HeaderText = "Размеры";
            this.размерыDataGridViewTextBoxColumn.Name = "размерыDataGridViewTextBoxColumn";
            this.размерыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // магазинОдеждыДляДетейBindingSource
            // 
            this.магазинОдеждыДляДетейBindingSource.DataMember = "Магазин одежды для детей";
            this.магазинОдеждыДляДетейBindingSource.DataSource = this.база_данныхDataSet;
            // 
            // база_данныхDataSet
            // 
            this.база_данныхDataSet.DataSetName = "База_данныхDataSet";
            this.база_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // магазин_одежды_для_детейTableAdapter
            // 
            this.магазин_одежды_для_детейTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите код клиента";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите код клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Укажите новый код одежды";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Удалить клиента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 509);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 509);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(544, 509);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 20);
            this.textBox3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(345, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1050, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 200);
            this.button3.TabIndex = 9;
            this.button3.Text = "Добавить клиента";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1050, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 92);
            this.button4.TabIndex = 10;
            this.button4.Text = "Обновить данные";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1050, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 119);
            this.button5.TabIndex = 11;
            this.button5.Text = "Закрыть";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кодДеждыПоКодуКлиентаToolStripMenuItem,
            this.фИОПоЛогинуToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // кодДеждыПоКодуКлиентаToolStripMenuItem
            // 
            this.кодДеждыПоКодуКлиентаToolStripMenuItem.Name = "кодДеждыПоКодуКлиентаToolStripMenuItem";
            this.кодДеждыПоКодуКлиентаToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.кодДеждыПоКодуКлиентаToolStripMenuItem.Text = "Адреса по ФИО";
            this.кодДеждыПоКодуКлиентаToolStripMenuItem.Click += new System.EventHandler(this.кодДеждыПоКодуКлиентаToolStripMenuItem_Click);
            // 
            // фИОПоЛогинуToolStripMenuItem
            // 
            this.фИОПоЛогинуToolStripMenuItem.Name = "фИОПоЛогинуToolStripMenuItem";
            this.фИОПоЛогинуToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.фИОПоЛогинуToolStripMenuItem.Text = "ФИО по виду одежды";
            this.фИОПоЛогинуToolStripMenuItem.Click += new System.EventHandler(this.фИОПоЛогинуToolStripMenuItem_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 579);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form12";
            this.Text = "Изменение данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form12_FormClosing);
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазинОдеждыДляДетейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private База_данныхDataSet база_данныхDataSet;
        private System.Windows.Forms.BindingSource магазинОдеждыДляДетейBindingSource;
        private База_данныхDataSetTableAdapters.Магазин_одежды_для_детейTableAdapter магазин_одежды_для_детейTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодОдеждыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видОдеждыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn разновидностьДетскойОдеждыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn составDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кодДеждыПоКодуКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фИОПоЛогинуToolStripMenuItem;
    }
}