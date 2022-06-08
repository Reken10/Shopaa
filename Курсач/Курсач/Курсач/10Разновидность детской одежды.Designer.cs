namespace Курсач
{
    partial class Form9
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
            this.разновидностиДетскойОдеждыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.разновидностиДетскойОдеждыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данныхDataSet = new Курсач.База_данныхDataSet();
            this.разновидности_детской_одеждыTableAdapter = new Курсач.База_данныхDataSetTableAdapters.Разновидности_детской_одеждыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.разновидностиДетскойОдеждыBindingSource)).BeginInit();
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
            this.разновидностиДетскойОдеждыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.разновидностиДетскойОдеждыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(199, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // разновидностиДетскойОдеждыDataGridViewTextBoxColumn
            // 
            this.разновидностиДетскойОдеждыDataGridViewTextBoxColumn.DataPropertyName = "Разновидности детской одежды";
            this.разновидностиДетскойОдеждыDataGridViewTextBoxColumn.HeaderText = "Разновидности детской одежды";
            this.разновидностиДетскойОдеждыDataGridViewTextBoxColumn.Name = "разновидностиДетскойОдеждыDataGridViewTextBoxColumn";
            this.разновидностиДетскойОдеждыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // разновидностиДетскойОдеждыBindingSource
            // 
            this.разновидностиДетскойОдеждыBindingSource.DataMember = "Разновидности детской одежды";
            this.разновидностиДетскойОдеждыBindingSource.DataSource = this.база_данныхDataSet;
            // 
            // база_данныхDataSet
            // 
            this.база_данныхDataSet.DataSetName = "База_данныхDataSet";
            this.база_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // разновидности_детской_одеждыTableAdapter
            // 
            this.разновидности_детской_одеждыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Разновидность детской одежды";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.разновидностиДетскойОдеждыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private База_данныхDataSet база_данныхDataSet;
        private System.Windows.Forms.BindingSource разновидностиДетскойОдеждыBindingSource;
        private База_данныхDataSetTableAdapters.Разновидности_детской_одеждыTableAdapter разновидности_детской_одеждыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn разновидностиДетскойОдеждыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}