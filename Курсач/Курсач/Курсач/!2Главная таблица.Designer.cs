namespace Курсач
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазинОдеждыДляДетейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 566);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1093, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Магазин одежды для детей";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазинОдеждыДляДетейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
    }
}