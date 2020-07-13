namespace Apteka
{
    partial class Kassa
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
            System.Windows.Forms.Label oper_dateLabel;
            System.Windows.Forms.Label articul_idLabel;
            System.Windows.Forms.Label prod_nameLabel;
            System.Windows.Forms.Label rozn_priceLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label summLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kassa));
            this.dBDataSet = new Apteka.DBDataSet();
            this.kassaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kassaTableAdapter = new Apteka.DBDataSetTableAdapters.KassaTableAdapter();
            this.tableAdapterManager = new Apteka.DBDataSetTableAdapters.TableAdapterManager();
            this.kassaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oper_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.articul_idTextBox = new System.Windows.Forms.TextBox();
            this.prod_nameTextBox = new System.Windows.Forms.TextBox();
            this.rozn_priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.summTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            oper_dateLabel = new System.Windows.Forms.Label();
            articul_idLabel = new System.Windows.Forms.Label();
            prod_nameLabel = new System.Windows.Forms.Label();
            rozn_priceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            summLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kassaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kassaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kassaBindingSource
            // 
            this.kassaBindingSource.DataMember = "Kassa";
            this.kassaBindingSource.DataSource = this.dBDataSet;
            // 
            // kassaTableAdapter
            // 
            this.kassaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KassaTableAdapter = this.kassaTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PostavkiTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Apteka.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kassaDataGridView
            // 
            this.kassaDataGridView.AutoGenerateColumns = false;
            this.kassaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kassaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.kassaDataGridView.DataSource = this.kassaBindingSource;
            this.kassaDataGridView.Location = new System.Drawing.Point(12, 2);
            this.kassaDataGridView.Name = "kassaDataGridView";
            this.kassaDataGridView.Size = new System.Drawing.Size(742, 220);
            this.kassaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "operation_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "operation_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "oper_date";
            this.dataGridViewTextBoxColumn2.HeaderText = "oper_date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "articul_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "articul_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "prod_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "prod_name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rozn_price";
            this.dataGridViewTextBoxColumn5.HeaderText = "rozn_price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "summ";
            this.dataGridViewTextBoxColumn7.HeaderText = "summ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // oper_dateLabel
            // 
            oper_dateLabel.AutoSize = true;
            oper_dateLabel.Location = new System.Drawing.Point(35, 272);
            oper_dateLabel.Name = "oper_dateLabel";
            oper_dateLabel.Size = new System.Drawing.Size(84, 13);
            oper_dateLabel.TabIndex = 1;
            oper_dateLabel.Text = "Дата операции";
            // 
            // oper_dateDateTimePicker
            // 
            this.oper_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kassaBindingSource, "oper_date", true));
            this.oper_dateDateTimePicker.Location = new System.Drawing.Point(138, 266);
            this.oper_dateDateTimePicker.Name = "oper_dateDateTimePicker";
            this.oper_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.oper_dateDateTimePicker.TabIndex = 2;
            // 
            // articul_idLabel
            // 
            articul_idLabel.AutoSize = true;
            articul_idLabel.Location = new System.Drawing.Point(33, 299);
            articul_idLabel.Name = "articul_idLabel";
            articul_idLabel.Size = new System.Drawing.Size(86, 13);
            articul_idLabel.TabIndex = 3;
            articul_idLabel.Text = "Артикул товара";
            // 
            // articul_idTextBox
            // 
            this.articul_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kassaBindingSource, "articul_id", true));
            this.articul_idTextBox.Location = new System.Drawing.Point(138, 292);
            this.articul_idTextBox.Name = "articul_idTextBox";
            this.articul_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.articul_idTextBox.TabIndex = 4;
            // 
            // prod_nameLabel
            // 
            prod_nameLabel.AutoSize = true;
            prod_nameLabel.Location = new System.Drawing.Point(12, 325);
            prod_nameLabel.Name = "prod_nameLabel";
            prod_nameLabel.Size = new System.Drawing.Size(121, 13);
            prod_nameLabel.TabIndex = 5;
            prod_nameLabel.Text = "Наименование товара";
            // 
            // prod_nameTextBox
            // 
            this.prod_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kassaBindingSource, "prod_name", true));
            this.prod_nameTextBox.Location = new System.Drawing.Point(138, 318);
            this.prod_nameTextBox.Name = "prod_nameTextBox";
            this.prod_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.prod_nameTextBox.TabIndex = 6;
            // 
            // rozn_priceLabel
            // 
            rozn_priceLabel.AutoSize = true;
            rozn_priceLabel.Location = new System.Drawing.Point(21, 351);
            rozn_priceLabel.Name = "rozn_priceLabel";
            rozn_priceLabel.Size = new System.Drawing.Size(88, 13);
            rozn_priceLabel.TabIndex = 7;
            rozn_priceLabel.Text = "Розничная цена";
            // 
            // rozn_priceTextBox
            // 
            this.rozn_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kassaBindingSource, "rozn_price", true));
            this.rozn_priceTextBox.Location = new System.Drawing.Point(138, 344);
            this.rozn_priceTextBox.Name = "rozn_priceTextBox";
            this.rozn_priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.rozn_priceTextBox.TabIndex = 8;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(53, 373);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(66, 13);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "Количество";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kassaBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(138, 370);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantityTextBox.TabIndex = 10;
            // 
            // summLabel
            // 
            summLabel.AutoSize = true;
            summLabel.Location = new System.Drawing.Point(72, 399);
            summLabel.Name = "summLabel";
            summLabel.Size = new System.Drawing.Size(41, 13);
            summLabel.TabIndex = 11;
            summLabel.Text = "Сумма";
            // 
            // summTextBox
            // 
            this.summTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kassaBindingSource, "summ", true));
            this.summTextBox.Enabled = false;
            this.summTextBox.Location = new System.Drawing.Point(138, 396);
            this.summTextBox.Name = "summTextBox";
            this.summTextBox.Size = new System.Drawing.Size(200, 20);
            this.summTextBox.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(728, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(oper_dateLabel);
            this.Controls.Add(this.oper_dateDateTimePicker);
            this.Controls.Add(articul_idLabel);
            this.Controls.Add(this.articul_idTextBox);
            this.Controls.Add(prod_nameLabel);
            this.Controls.Add(this.prod_nameTextBox);
            this.Controls.Add(rozn_priceLabel);
            this.Controls.Add(this.rozn_priceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(summLabel);
            this.Controls.Add(this.summTextBox);
            this.Controls.Add(this.kassaDataGridView);
            this.Name = "Kassa";
            this.Text = "Kassa";
            this.Load += new System.EventHandler(this.Kassa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kassaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kassaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource kassaBindingSource;
        private DBDataSetTableAdapters.KassaTableAdapter kassaTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kassaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DateTimePicker oper_dateDateTimePicker;
        private System.Windows.Forms.TextBox articul_idTextBox;
        private System.Windows.Forms.TextBox prod_nameTextBox;
        private System.Windows.Forms.TextBox rozn_priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox summTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}