namespace Курсач
{
    partial class Form8
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
            this.видОдеждыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видОдеждыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данныхDataSet = new Курсач.База_данныхDataSet();
            this.вид_одеждыTableAdapter = new Курсач.База_данныхDataSetTableAdapters.Вид_одеждыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видОдеждыBindingSource)).BeginInit();
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
            this.видОдеждыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.видОдеждыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(402, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // видОдеждыDataGridViewTextBoxColumn
            // 
            this.видОдеждыDataGridViewTextBoxColumn.DataPropertyName = "Вид одежды";
            this.видОдеждыDataGridViewTextBoxColumn.HeaderText = "Вид одежды";
            this.видОдеждыDataGridViewTextBoxColumn.Name = "видОдеждыDataGridViewTextBoxColumn";
            this.видОдеждыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видОдеждыBindingSource
            // 
            this.видОдеждыBindingSource.DataMember = "Вид одежды";
            this.видОдеждыBindingSource.DataSource = this.база_данныхDataSet;
            // 
            // база_данныхDataSet
            // 
            this.база_данныхDataSet.DataSetName = "База_данныхDataSet";
            this.база_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вид_одеждыTableAdapter
            // 
            this.вид_одеждыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Вид одежды";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видОдеждыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private База_данныхDataSet база_данныхDataSet;
        private System.Windows.Forms.BindingSource видОдеждыBindingSource;
        private База_данныхDataSetTableAdapters.Вид_одеждыTableAdapter вид_одеждыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn видОдеждыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}