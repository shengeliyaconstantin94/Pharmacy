namespace Apteka
{
    partial class EditForm
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
            System.Windows.Forms.Label prod_nameLabel;
            System.Windows.Forms.Label dozLabel;
            System.Windows.Forms.Label zak_priceLabel;
            System.Windows.Forms.Label rozn_priceLabel;
            System.Windows.Forms.Label gruppLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.dBDataSet = new Apteka.DBDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Apteka.DBDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Apteka.DBDataSetTableAdapters.TableAdapterManager();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.prod_nameTextBox = new System.Windows.Forms.TextBox();
            this.dozTextBox = new System.Windows.Forms.TextBox();
            this.zak_priceTextBox = new System.Windows.Forms.TextBox();
            this.rozn_priceTextBox = new System.Windows.Forms.TextBox();
            this.gruppComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            prod_nameLabel = new System.Windows.Forms.Label();
            dozLabel = new System.Windows.Forms.Label();
            zak_priceLabel = new System.Windows.Forms.Label();
            rozn_priceLabel = new System.Windows.Forms.Label();
            gruppLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Apteka.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(-1, 12);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(842, 104);
            this.productDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "articul_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "articul_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "prod_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "prod_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "doz";
            this.dataGridViewTextBoxColumn3.HeaderText = "doz";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "zak_price";
            this.dataGridViewTextBoxColumn4.HeaderText = "zak_price";
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "grupp";
            this.dataGridViewTextBoxColumn6.HeaderText = "grupp";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn7.HeaderText = "description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "img";
            this.dataGridViewImageColumn1.HeaderText = "img";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // prod_nameLabel
            // 
            prod_nameLabel.AutoSize = true;
            prod_nameLabel.Location = new System.Drawing.Point(559, 211);
            prod_nameLabel.Name = "prod_nameLabel";
            prod_nameLabel.Size = new System.Drawing.Size(83, 13);
            prod_nameLabel.TabIndex = 1;
            prod_nameLabel.Text = "Наименование";
            // 
            // prod_nameTextBox
            // 
            this.prod_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "prod_name", true));
            this.prod_nameTextBox.Location = new System.Drawing.Point(656, 208);
            this.prod_nameTextBox.Name = "prod_nameTextBox";
            this.prod_nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.prod_nameTextBox.TabIndex = 2;
            // 
            // dozLabel
            // 
            dozLabel.AutoSize = true;
            dozLabel.Location = new System.Drawing.Point(562, 237);
            dozLabel.Name = "dozLabel";
            dozLabel.Size = new System.Drawing.Size(64, 13);
            dozLabel.TabIndex = 3;
            dozLabel.Text = "Дозировка";
            // 
            // dozTextBox
            // 
            this.dozTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "doz", true));
            this.dozTextBox.Location = new System.Drawing.Point(656, 234);
            this.dozTextBox.Name = "dozTextBox";
            this.dozTextBox.Size = new System.Drawing.Size(121, 20);
            this.dozTextBox.TabIndex = 4;
            // 
            // zak_priceLabel
            // 
            zak_priceLabel.AutoSize = true;
            zak_priceLabel.Location = new System.Drawing.Point(549, 267);
            zak_priceLabel.Name = "zak_priceLabel";
            zak_priceLabel.Size = new System.Drawing.Size(93, 13);
            zak_priceLabel.TabIndex = 5;
            zak_priceLabel.Text = "Закупочная цена";
            // 
            // zak_priceTextBox
            // 
            this.zak_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "zak_price", true));
            this.zak_priceTextBox.Location = new System.Drawing.Point(656, 260);
            this.zak_priceTextBox.Name = "zak_priceTextBox";
            this.zak_priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.zak_priceTextBox.TabIndex = 6;
            // 
            // rozn_priceLabel
            // 
            rozn_priceLabel.AutoSize = true;
            rozn_priceLabel.Location = new System.Drawing.Point(549, 293);
            rozn_priceLabel.Name = "rozn_priceLabel";
            rozn_priceLabel.Size = new System.Drawing.Size(97, 13);
            rozn_priceLabel.TabIndex = 7;
            rozn_priceLabel.Text = "Розничная ценаe:";
            // 
            // rozn_priceTextBox
            // 
            this.rozn_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "rozn_price", true));
            this.rozn_priceTextBox.Location = new System.Drawing.Point(656, 286);
            this.rozn_priceTextBox.Name = "rozn_priceTextBox";
            this.rozn_priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.rozn_priceTextBox.TabIndex = 8;
            // 
            // gruppLabel
            // 
            gruppLabel.AutoSize = true;
            gruppLabel.Location = new System.Drawing.Point(584, 315);
            gruppLabel.Name = "gruppLabel";
            gruppLabel.Size = new System.Drawing.Size(42, 13);
            gruppLabel.TabIndex = 9;
            gruppLabel.Text = "Группа";
            // 
            // gruppComboBox
            // 
            this.gruppComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "grupp", true));
            this.gruppComboBox.FormattingEnabled = true;
            this.gruppComboBox.Items.AddRange(new object[] {
            "Рецептурное",
            "Безрецептурное"});
            this.gruppComboBox.Location = new System.Drawing.Point(656, 312);
            this.gruppComboBox.Name = "gruppComboBox";
            this.gruppComboBox.Size = new System.Drawing.Size(121, 21);
            this.gruppComboBox.TabIndex = 10;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(324, 215);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(57, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(408, 215);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(121, 118);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 166);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(847, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(587, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Добавить запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 419);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(prod_nameLabel);
            this.Controls.Add(this.prod_nameTextBox);
            this.Controls.Add(dozLabel);
            this.Controls.Add(this.dozTextBox);
            this.Controls.Add(zak_priceLabel);
            this.Controls.Add(this.zak_priceTextBox);
            this.Controls.Add(rozn_priceLabel);
            this.Controls.Add(this.rozn_priceTextBox);
            this.Controls.Add(gruppLabel);
            this.Controls.Add(this.gruppComboBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.productDataGridView);
            this.Name = "EditForm";
            this.Text = "Регистрация лекарственных средств";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox prod_nameTextBox;
        private System.Windows.Forms.TextBox dozTextBox;
        private System.Windows.Forms.TextBox zak_priceTextBox;
        private System.Windows.Forms.TextBox rozn_priceTextBox;
        private System.Windows.Forms.ComboBox gruppComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}