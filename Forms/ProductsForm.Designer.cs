namespace EnglishStore.Forms
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishStoreDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishStoreDataSet1 = new EnglishStore.EnglishStoreDataSet();
            this.productTableAdapter = new EnglishStore.EnglishStoreDataSetTableAdapters.ProductTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sortByNameGroupBox = new System.Windows.Forms.GroupBox();
            this.ascRadioButton = new System.Windows.Forms.RadioButton();
            this.descRatioButton = new System.Windows.Forms.RadioButton();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtrationGroupBox = new System.Windows.Forms.GroupBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.filtrationButton = new System.Windows.Forms.Button();
            this.filtrationComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editPostButton = new System.Windows.Forms.Button();
            this.addPostButton = new System.Windows.Forms.Button();
            this.deletePostButton = new System.Windows.Forms.Button();
            this.backToMainForm = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.manufacturerTableAdapter = new EnglishStore.EnglishStoreDataSetTableAdapters.ManufacturerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishStoreDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishStoreDataSet1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.sortByNameGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.filtrationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AutoGenerateColumns = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.manufacturerIDDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewProduct.DataSource = this.productBindingSource;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(653, 500);
            this.dataGridViewProduct.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Код товара";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Фотография";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // manufacturerIDDataGridViewTextBoxColumn
            // 
            this.manufacturerIDDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn.HeaderText = "Код производителя";
            this.manufacturerIDDataGridViewTextBoxColumn.Name = "manufacturerIDDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "Активно";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.englishStoreDataSet1BindingSource;
            // 
            // englishStoreDataSet1BindingSource
            // 
            this.englishStoreDataSet1BindingSource.DataSource = this.englishStoreDataSet1;
            this.englishStoreDataSet1BindingSource.Position = 0;
            // 
            // englishStoreDataSet1
            // 
            this.englishStoreDataSet1.DataSetName = "EnglishStoreDataSet";
            this.englishStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(922, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // sortByNameGroupBox
            // 
            this.sortByNameGroupBox.Controls.Add(this.ascRadioButton);
            this.sortByNameGroupBox.Controls.Add(this.descRatioButton);
            this.sortByNameGroupBox.Location = new System.Drawing.Point(700, 12);
            this.sortByNameGroupBox.Name = "sortByNameGroupBox";
            this.sortByNameGroupBox.Size = new System.Drawing.Size(202, 70);
            this.sortByNameGroupBox.TabIndex = 2;
            this.sortByNameGroupBox.TabStop = false;
            this.sortByNameGroupBox.Text = "Sorting by name";
            // 
            // ascRadioButton
            // 
            this.ascRadioButton.AutoSize = true;
            this.ascRadioButton.Location = new System.Drawing.Point(6, 42);
            this.ascRadioButton.Name = "ascRadioButton";
            this.ascRadioButton.Size = new System.Drawing.Size(75, 17);
            this.ascRadioButton.TabIndex = 3;
            this.ascRadioButton.Text = "Ascending";
            this.ascRadioButton.UseVisualStyleBackColor = true;
            this.ascRadioButton.CheckedChanged += new System.EventHandler(this.ascRadioButton_CheckedChanged);
            // 
            // descRatioButton
            // 
            this.descRatioButton.AutoSize = true;
            this.descRatioButton.Checked = true;
            this.descRatioButton.Location = new System.Drawing.Point(6, 19);
            this.descRatioButton.Name = "descRatioButton";
            this.descRatioButton.Size = new System.Drawing.Size(82, 17);
            this.descRatioButton.TabIndex = 0;
            this.descRatioButton.TabStop = true;
            this.descRatioButton.Text = "Descending";
            this.descRatioButton.UseVisualStyleBackColor = true;
            this.descRatioButton.CheckedChanged += new System.EventHandler(this.descRatioButton_CheckedChanged);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Location = new System.Drawing.Point(700, 88);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(202, 70);
            this.searchGroupBox.TabIndex = 3;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(9, 32);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter product name";
            // 
            // filtrationGroupBox
            // 
            this.filtrationGroupBox.Controls.Add(this.showAllButton);
            this.filtrationGroupBox.Controls.Add(this.filtrationButton);
            this.filtrationGroupBox.Controls.Add(this.filtrationComboBox);
            this.filtrationGroupBox.Location = new System.Drawing.Point(700, 164);
            this.filtrationGroupBox.Name = "filtrationGroupBox";
            this.filtrationGroupBox.Size = new System.Drawing.Size(202, 99);
            this.filtrationGroupBox.TabIndex = 4;
            this.filtrationGroupBox.TabStop = false;
            this.filtrationGroupBox.Text = "Filtration";
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(114, 58);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(82, 23);
            this.showAllButton.TabIndex = 2;
            this.showAllButton.Text = "Show all";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // filtrationButton
            // 
            this.filtrationButton.Location = new System.Drawing.Point(6, 58);
            this.filtrationButton.Name = "filtrationButton";
            this.filtrationButton.Size = new System.Drawing.Size(82, 23);
            this.filtrationButton.TabIndex = 1;
            this.filtrationButton.Text = "Filtration";
            this.filtrationButton.UseVisualStyleBackColor = true;
            this.filtrationButton.Click += new System.EventHandler(this.filtrationButton_Click);
            // 
            // filtrationComboBox
            // 
            this.filtrationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ManufacturerID", true));
            this.filtrationComboBox.DataSource = this.manufacturerBindingSource;
            this.filtrationComboBox.DisplayMember = "Name";
            this.filtrationComboBox.FormattingEnabled = true;
            this.filtrationComboBox.Location = new System.Drawing.Point(6, 19);
            this.filtrationComboBox.Name = "filtrationComboBox";
            this.filtrationComboBox.Size = new System.Drawing.Size(190, 21);
            this.filtrationComboBox.TabIndex = 0;
            this.filtrationComboBox.ValueMember = "ID";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.englishStoreDataSet1BindingSource;
            // 
            // editPostButton
            // 
            this.editPostButton.Location = new System.Drawing.Point(700, 283);
            this.editPostButton.Name = "editPostButton";
            this.editPostButton.Size = new System.Drawing.Size(202, 41);
            this.editPostButton.TabIndex = 5;
            this.editPostButton.Text = "EditPost";
            this.editPostButton.UseVisualStyleBackColor = true;
            this.editPostButton.Click += new System.EventHandler(this.editPostButton_Click);
            // 
            // addPostButton
            // 
            this.addPostButton.Location = new System.Drawing.Point(700, 330);
            this.addPostButton.Name = "addPostButton";
            this.addPostButton.Size = new System.Drawing.Size(202, 41);
            this.addPostButton.TabIndex = 6;
            this.addPostButton.Text = "Add post";
            this.addPostButton.UseVisualStyleBackColor = true;
            this.addPostButton.Click += new System.EventHandler(this.addPostButton_Click);
            // 
            // deletePostButton
            // 
            this.deletePostButton.Location = new System.Drawing.Point(700, 377);
            this.deletePostButton.Name = "deletePostButton";
            this.deletePostButton.Size = new System.Drawing.Size(202, 41);
            this.deletePostButton.TabIndex = 7;
            this.deletePostButton.Text = "Delete post";
            this.deletePostButton.UseVisualStyleBackColor = true;
            this.deletePostButton.Click += new System.EventHandler(this.deletePostButton_Click);
            // 
            // backToMainForm
            // 
            this.backToMainForm.Location = new System.Drawing.Point(700, 471);
            this.backToMainForm.Name = "backToMainForm";
            this.backToMainForm.Size = new System.Drawing.Size(202, 41);
            this.backToMainForm.TabIndex = 9;
            this.backToMainForm.Text = "Back to main form";
            this.backToMainForm.UseVisualStyleBackColor = true;
            this.backToMainForm.Click += new System.EventHandler(this.backToMainForm_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(700, 424);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(202, 41);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 554);
            this.Controls.Add(this.backToMainForm);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deletePostButton);
            this.Controls.Add(this.addPostButton);
            this.Controls.Add(this.editPostButton);
            this.Controls.Add(this.filtrationGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.sortByNameGroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishStoreDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishStoreDataSet1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.sortByNameGroupBox.ResumeLayout(false);
            this.sortByNameGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.filtrationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private EnglishStoreDataSet englishStoreDataSet1;
        private System.Windows.Forms.BindingSource englishStoreDataSet1BindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private EnglishStoreDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox sortByNameGroupBox;
        private System.Windows.Forms.RadioButton ascRadioButton;
        private System.Windows.Forms.RadioButton descRatioButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox filtrationGroupBox;
        private System.Windows.Forms.ComboBox filtrationComboBox;
        private System.Windows.Forms.Button editPostButton;
        private System.Windows.Forms.Button addPostButton;
        private System.Windows.Forms.Button deletePostButton;
        private System.Windows.Forms.Button backToMainForm;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private EnglishStoreDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.Button filtrationButton;
        private System.Windows.Forms.Button showAllButton;
    }
}