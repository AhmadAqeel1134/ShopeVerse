namespace Project
{
    partial class AdProductCategoryMgmt
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCat = new System.Windows.Forms.Button();
            this.SaveButtonCat = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelProductButton = new System.Windows.Forms.Button();
            this.SaveProductButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new Project.ProjectDataSet();
            this.StTxt = new System.Windows.Forms.TextBox();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.DescTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.projectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Project.ProjectDataSetTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new Project.ProjectDataSetTableAdapters.TableAdapterManager();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CancelButton1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.AddCat);
            this.tabPage1.Controls.Add(this.SaveButtonCat);
            this.tabPage1.Controls.Add(this.NameText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CategoryGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Category Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(629, 171);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(110, 35);
            this.CancelButton1.TabIndex = 19;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Category Management";
            // 
            // AddCat
            // 
            this.AddCat.Location = new System.Drawing.Point(55, 171);
            this.AddCat.Name = "AddCat";
            this.AddCat.Size = new System.Drawing.Size(110, 35);
            this.AddCat.TabIndex = 17;
            this.AddCat.Text = "Add";
            this.AddCat.UseVisualStyleBackColor = true;
            this.AddCat.Click += new System.EventHandler(this.AddCat_Click);
            // 
            // SaveButtonCat
            // 
            this.SaveButtonCat.Location = new System.Drawing.Point(346, 171);
            this.SaveButtonCat.Name = "SaveButtonCat";
            this.SaveButtonCat.Size = new System.Drawing.Size(110, 35);
            this.SaveButtonCat.TabIndex = 13;
            this.SaveButtonCat.Text = "Save";
            this.SaveButtonCat.UseVisualStyleBackColor = true;
            this.SaveButtonCat.Click += new System.EventHandler(this.SaveButtonCat_Click);
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(146, 102);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(160, 25);
            this.NameText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CategoryGridView.Location = new System.Drawing.Point(3, 212);
            this.CategoryGridView.Name = "CategoryGridView";
            this.CategoryGridView.Size = new System.Drawing.Size(786, 209);
            this.CategoryGridView.TabIndex = 0;
            this.CategoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_CellContentClick_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddButton);
            this.tabPage2.Controls.Add(this.CancelProductButton);
            this.tabPage2.Controls.Add(this.SaveProductButton);
            this.tabPage2.Controls.Add(this.CategoryComboBox);
            this.tabPage2.Controls.Add(this.StTxt);
            this.tabPage2.Controls.Add(this.PriceTxt);
            this.tabPage2.Controls.Add(this.DescTxt);
            this.tabPage2.Controls.Add(this.NameTxt);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.ProductGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Product Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(362, 178);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 35);
            this.AddButton.TabIndex = 34;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelProductButton
            // 
            this.CancelProductButton.Location = new System.Drawing.Point(659, 178);
            this.CancelProductButton.Name = "CancelProductButton";
            this.CancelProductButton.Size = new System.Drawing.Size(110, 35);
            this.CancelProductButton.TabIndex = 33;
            this.CancelProductButton.Text = "Cancel";
            this.CancelProductButton.UseVisualStyleBackColor = true;
            this.CancelProductButton.Click += new System.EventHandler(this.CancelProductButton_Click);
            // 
            // SaveProductButton
            // 
            this.SaveProductButton.Location = new System.Drawing.Point(514, 178);
            this.SaveProductButton.Name = "SaveProductButton";
            this.SaveProductButton.Size = new System.Drawing.Size(110, 35);
            this.SaveProductButton.TabIndex = 32;
            this.SaveProductButton.Text = "Save";
            this.SaveProductButton.UseVisualStyleBackColor = true;
            this.SaveProductButton.Click += new System.EventHandler(this.SaveProductButton_Click_1);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DataSource = this.categoryBindingSource;
            this.CategoryComboBox.DisplayMember = "Name";
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(141, 115);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 28;
            this.CategoryComboBox.ValueMember = "CategoryID";
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.projectDataSet;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StTxt
            // 
            this.StTxt.Location = new System.Drawing.Point(141, 186);
            this.StTxt.Name = "StTxt";
            this.StTxt.Size = new System.Drawing.Size(100, 20);
            this.StTxt.TabIndex = 27;
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(514, 115);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(100, 20);
            this.PriceTxt.TabIndex = 26;
            // 
            // DescTxt
            // 
            this.DescTxt.Location = new System.Drawing.Point(514, 29);
            this.DescTxt.Name = "DescTxt";
            this.DescTxt.Size = new System.Drawing.Size(100, 20);
            this.DescTxt.TabIndex = 25;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(138, 35);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 20);
            this.NameTxt.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(74, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Stock:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(431, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Price:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(71, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Category:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(431, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Description:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(71, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Name:";
            // 
            // ProductGridView
            // 
            this.ProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProductGridView.Location = new System.Drawing.Point(3, 237);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.Size = new System.Drawing.Size(786, 184);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick_1);
            // 
            // projectDataSetBindingSource
            // 
            this.projectDataSetBindingSource.DataSource = this.projectDataSet;
            this.projectDataSetBindingSource.Position = 0;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.ElectronicsTableAdapter = null;
            this.tableAdapterManager.FashionTableAdapter = null;
            this.tableAdapterManager.HomeAppliancesTableAdapter = null;
            this.tableAdapterManager.OrderItemTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ReportTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.SellerProductTableAdapter = null;
            this.tableAdapterManager.SellerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WishlistItemTableAdapter = null;
            // 
            // AdProductCategoryMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdProductCategoryMgmt";
            this.Text = "Product and Category Management";
            this.Load += new System.EventHandler(this.ProductCategoryAdMgmt_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button SaveButtonCat;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CategoryGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox StTxt;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.TextBox DescTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private ProjectDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button AddCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.Button CancelProductButton;
        private System.Windows.Forms.Button SaveProductButton;
        private System.Windows.Forms.Button AddButton;
    }
}