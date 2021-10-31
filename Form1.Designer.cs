namespace UseAdventureWorks
{
    partial class Form1
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
            this.adventureWorks2016CTP3DataSet = new UseAdventureWorks.AdventureWorks2016CTP3DataSet();
            this.countryRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryRegionTableAdapter = new UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionTableAdapter();
            this.countryRegionCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2016CTP3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryRegionCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.countryRegionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(103, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            
            // 
            // adventureWorks2016CTP3DataSet
            // 
            this.adventureWorks2016CTP3DataSet.DataSetName = "AdventureWorks2016CTP3DataSet";
            this.adventureWorks2016CTP3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryRegionBindingSource
            // 
            this.countryRegionBindingSource.DataMember = "CountryRegion";
            this.countryRegionBindingSource.DataSource = this.adventureWorks2016CTP3DataSet;
            // 
            // countryRegionTableAdapter
            // 
            this.countryRegionTableAdapter.ClearBeforeFill = true;
            // 
            // countryRegionCodeDataGridViewTextBoxColumn
            // 
            this.countryRegionCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryRegionCode";
            this.countryRegionCodeDataGridViewTextBoxColumn.HeaderText = "CountryRegionCode";
            this.countryRegionCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryRegionCodeDataGridViewTextBoxColumn.Name = "countryRegionCodeDataGridViewTextBoxColumn";
            this.countryRegionCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryRegionCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(229, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Munt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2016CTP3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AdventureWorks2016CTP3DataSet adventureWorks2016CTP3DataSet;
        private System.Windows.Forms.BindingSource countryRegionBindingSource;
        private AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionTableAdapter countryRegionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryRegionCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

