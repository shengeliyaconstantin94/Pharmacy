namespace Apteka
{
    partial class Postavk
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
            System.Windows.Forms.Label naimenovanieLabel;
            System.Windows.Forms.Label date_postevkiLabel;
            System.Windows.Forms.Label postavshikLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label price_per_unitLabel;
            System.Windows.Forms.Label summLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postavk));
            this.dBDataSet = new Apteka.DBDataSet();
            this.postavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavkiTableAdapter = new Apteka.DBDataSetTableAdapters.PostavkiTableAdapter();
            this.tableAdapterManager = new Apteka.DBDataSetTableAdapters.TableAdapterManager();
            this.postavkiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieTextBox = new System.Windows.Forms.TextBox();
            this.date_postevkiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postavshikTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.price_per_unitTextBox = new System.Windows.Forms.TextBox();
            this.summTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            naimenovanieLabel = new System.Windows.Forms.Label();
            date_postevkiLabel = new System.Windows.Forms.Label();
            postavshikLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            price_per_unitLabel = new System.Windows.Forms.Label();
            summLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavkiBindingSource
            // 
            this.postavkiBindingSource.DataMember = "Postavki";
            this.postavkiBindingSource.DataSource = this.dBDataSet;
            // 
            // postavkiTableAdapter
            // 
            this.postavkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PostavkiTableAdapter = this.postavkiTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Apteka.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // postavkiDataGridView
            // 
            this.postavkiDataGridView.AutoGenerateColumns = false;
            this.postavkiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postavkiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.postavkiDataGridView.DataSource = this.postavkiBindingSource;
            this.postavkiDataGridView.Location = new System.Drawing.Point(0, 28);
            this.postavkiDataGridView.Name = "postavkiDataGridView";
            this.postavkiDataGridView.Size = new System.Drawing.Size(748, 220);
            this.postavkiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_postavki";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_postavki";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "naimenovanie";
            this.dataGridViewTextBoxColumn2.HeaderText = "naimenovanie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date_postevki";
            this.dataGridViewTextBoxColumn3.HeaderText = "date_postevki";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "postavshik";
            this.dataGridViewTextBoxColumn4.HeaderText = "postavshik";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "price_per_unit";
            this.dataGridViewTextBoxColumn6.HeaderText = "price_per_unit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "summ";
            this.dataGridViewTextBoxColumn7.HeaderText = "summ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // naimenovanieLabel
            // 
            naimenovanieLabel.AutoSize = true;
            naimenovanieLabel.Location = new System.Drawing.Point(35, 318);
            naimenovanieLabel.Name = "naimenovanieLabel";
            naimenovanieLabel.Size = new System.Drawing.Size(95, 13);
            naimenovanieLabel.TabIndex = 4;
            naimenovanieLabel.Text = "Название товара";
            // 
            // naimenovanieTextBox
            // 
            this.naimenovanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavkiBindingSource, "naimenovanie", true));
            this.naimenovanieTextBox.Location = new System.Drawing.Point(141, 315);
            this.naimenovanieTextBox.Name = "naimenovanieTextBox";
            this.naimenovanieTextBox.Size = new System.Drawing.Size(200, 20);
            this.naimenovanieTextBox.TabIndex = 5;
            // 
            // date_postevkiLabel
            // 
            date_postevkiLabel.AutoSize = true;
            date_postevkiLabel.Location = new System.Drawing.Point(59, 345);
            date_postevkiLabel.Name = "date_postevkiLabel";
            date_postevkiLabel.Size = new System.Drawing.Size(83, 13);
            date_postevkiLabel.TabIndex = 6;
            date_postevkiLabel.Text = "Дата поставки";
            // 
            // date_postevkiDateTimePicker
            // 
            this.date_postevkiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postavkiBindingSource, "date_postevki", true));
            this.date_postevkiDateTimePicker.Location = new System.Drawing.Point(141, 341);
            this.date_postevkiDateTimePicker.Name = "date_postevkiDateTimePicker";
            this.date_postevkiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_postevkiDateTimePicker.TabIndex = 7;
            // 
            // postavshikLabel
            // 
            postavshikLabel.AutoSize = true;
            postavshikLabel.Location = new System.Drawing.Point(59, 370);
            postavshikLabel.Name = "postavshikLabel";
            postavshikLabel.Size = new System.Drawing.Size(65, 13);
            postavshikLabel.TabIndex = 8;
            postavshikLabel.Text = "Поставщик";
            // 
            // postavshikTextBox
            // 
            this.postavshikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavkiBindingSource, "postavshik", true));
            this.postavshikTextBox.Location = new System.Drawing.Point(141, 367);
            this.postavshikTextBox.Name = "postavshikTextBox";
            this.postavshikTextBox.Size = new System.Drawing.Size(200, 20);
            this.postavshikTextBox.TabIndex = 9;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(59, 396);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(66, 13);
            quantityLabel.TabIndex = 10;
            quantityLabel.Text = "Количество";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavkiBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(141, 393);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantityTextBox.TabIndex = 11;
            // 
            // price_per_unitLabel
            // 
            price_per_unitLabel.AutoSize = true;
            price_per_unitLabel.Location = new System.Drawing.Point(43, 422);
            price_per_unitLabel.Name = "price_per_unitLabel";
            price_per_unitLabel.Size = new System.Drawing.Size(92, 13);
            price_per_unitLabel.TabIndex = 12;
            price_per_unitLabel.Text = "Цена за единицу";
            // 
            // price_per_unitTextBox
            // 
            this.price_per_unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavkiBindingSource, "price_per_unit", true));
            this.price_per_unitTextBox.Location = new System.Drawing.Point(141, 419);
            this.price_per_unitTextBox.Name = "price_per_unitTextBox";
            this.price_per_unitTextBox.Size = new System.Drawing.Size(200, 20);
            this.price_per_unitTextBox.TabIndex = 13;
            // 
            // summLabel
            // 
            summLabel.AutoSize = true;
            summLabel.Location = new System.Drawing.Point(59, 448);
            summLabel.Name = "summLabel";
            summLabel.Size = new System.Drawing.Size(41, 13);
            summLabel.TabIndex = 14;
            summLabel.Text = "Сумма";
            // 
            // summTextBox
            // 
            this.summTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavkiBindingSource, "summ", true));
            this.summTextBox.Location = new System.Drawing.Point(141, 445);
            this.summTextBox.Name = "summTextBox";
            this.summTextBox.Size = new System.Drawing.Size(200, 20);
            this.summTextBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(754, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Postavk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 508);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(naimenovanieLabel);
            this.Controls.Add(this.naimenovanieTextBox);
            this.Controls.Add(date_postevkiLabel);
            this.Controls.Add(this.date_postevkiDateTimePicker);
            this.Controls.Add(postavshikLabel);
            this.Controls.Add(this.postavshikTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(price_per_unitLabel);
            this.Controls.Add(this.price_per_unitTextBox);
            this.Controls.Add(summLabel);
            this.Controls.Add(this.summTextBox);
            this.Controls.Add(this.postavkiDataGridView);
            this.Name = "Postavk";
            this.Text = "Postavk";
            this.Load += new System.EventHandler(this.Postavk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource postavkiBindingSource;
        private DBDataSetTableAdapters.PostavkiTableAdapter postavkiTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView postavkiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox naimenovanieTextBox;
        private System.Windows.Forms.DateTimePicker date_postevkiDateTimePicker;
        private System.Windows.Forms.TextBox postavshikTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox price_per_unitTextBox;
        private System.Windows.Forms.TextBox summTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}