namespace FinanceManager.PresentationLayer.TransactionItemViews
{
    partial class TransactionItemListForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beolvasásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésMáskéntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.transactionItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemLastValueTextBox = new System.Windows.Forms.TextBox();
            this.itemSaveButtom = new System.Windows.Forms.Button();
            this.expenseFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.incomeFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.typeToggleSwitch = new JCS.ToggleSwitch();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionItemListViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionItemListViewModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(764, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beolvasásToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.mentésMáskéntToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // beolvasásToolStripMenuItem
            // 
            this.beolvasásToolStripMenuItem.Name = "beolvasásToolStripMenuItem";
            this.beolvasásToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.beolvasásToolStripMenuItem.Text = "Beolvasás";
            this.beolvasásToolStripMenuItem.Click += new System.EventHandler(this.beolvasásToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            // 
            // mentésMáskéntToolStripMenuItem
            // 
            this.mentésMáskéntToolStripMenuItem.Name = "mentésMáskéntToolStripMenuItem";
            this.mentésMáskéntToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mentésMáskéntToolStripMenuItem.Text = "Mentés másként";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.lastValueDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.transactionItemsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(740, 471);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.TabStop = false;
            // 
            // transactionItemsBindingSource
            // 
            this.transactionItemsBindingSource.DataMember = "TransactionItems";
            this.transactionItemsBindingSource.DataSource = this.transactionItemListViewModelBindingSource1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Új tétel:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tétel neve:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itemNameTextBox.Location = new System.Drawing.Point(76, 529);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(166, 20);
            this.itemNameTextBox.TabIndex = 1;
            this.itemNameTextBox.TextChanged += new System.EventHandler(this.itemNameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategória:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryTextBox.Location = new System.Drawing.Point(309, 529);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(150, 20);
            this.categoryTextBox.TabIndex = 2;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.categoryTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tétel érték:";
            // 
            // itemLastValueTextBox
            // 
            this.itemLastValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itemLastValueTextBox.Location = new System.Drawing.Point(532, 529);
            this.itemLastValueTextBox.Name = "itemLastValueTextBox";
            this.itemLastValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemLastValueTextBox.TabIndex = 3;
            this.itemLastValueTextBox.TextChanged += new System.EventHandler(this.itemLastValueTextBox_TextChanged);
            this.itemLastValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemLastValueTextBox_KeyPress);
            // 
            // itemSaveButtom
            // 
            this.itemSaveButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itemSaveButtom.Location = new System.Drawing.Point(638, 527);
            this.itemSaveButtom.Name = "itemSaveButtom";
            this.itemSaveButtom.Size = new System.Drawing.Size(114, 23);
            this.itemSaveButtom.TabIndex = 4;
            this.itemSaveButtom.Text = "Rögzítés";
            this.itemSaveButtom.UseVisualStyleBackColor = true;
            this.itemSaveButtom.Click += new System.EventHandler(this.itemSaveButtom_Click);
            // 
            // expenseFilterCheckBox
            // 
            this.expenseFilterCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseFilterCheckBox.AutoSize = true;
            this.expenseFilterCheckBox.Checked = true;
            this.expenseFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.expenseFilterCheckBox.Location = new System.Drawing.Point(657, 7);
            this.expenseFilterCheckBox.Name = "expenseFilterCheckBox";
            this.expenseFilterCheckBox.Size = new System.Drawing.Size(95, 17);
            this.expenseFilterCheckBox.TabIndex = 11;
            this.expenseFilterCheckBox.TabStop = false;
            this.expenseFilterCheckBox.Text = "Kiadási tételek";
            this.expenseFilterCheckBox.UseVisualStyleBackColor = true;
            this.expenseFilterCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckChanged);
            // 
            // incomeFilterCheckBox
            // 
            this.incomeFilterCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.incomeFilterCheckBox.AutoSize = true;
            this.incomeFilterCheckBox.Checked = true;
            this.incomeFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.incomeFilterCheckBox.Location = new System.Drawing.Point(552, 7);
            this.incomeFilterCheckBox.Name = "incomeFilterCheckBox";
            this.incomeFilterCheckBox.Size = new System.Drawing.Size(99, 17);
            this.incomeFilterCheckBox.TabIndex = 12;
            this.incomeFilterCheckBox.TabStop = false;
            this.incomeFilterCheckBox.Text = "Bevételi tételek";
            this.incomeFilterCheckBox.UseVisualStyleBackColor = true;
            this.incomeFilterCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckChanged);
            // 
            // typeToggleSwitch
            // 
            this.typeToggleSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.typeToggleSwitch.Checked = true;
            this.typeToggleSwitch.Location = new System.Drawing.Point(76, 504);
            this.typeToggleSwitch.Name = "typeToggleSwitch";
            this.typeToggleSwitch.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeToggleSwitch.OffForeColor = System.Drawing.Color.White;
            this.typeToggleSwitch.OffText = "Kiadási tétel";
            this.typeToggleSwitch.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeToggleSwitch.OnForeColor = System.Drawing.Color.White;
            this.typeToggleSwitch.OnText = "Bevételi tétel";
            this.typeToggleSwitch.Size = new System.Drawing.Size(166, 19);
            this.typeToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy;
            this.typeToggleSwitch.TabIndex = 9;
            this.typeToggleSwitch.TabStop = false;
            this.typeToggleSwitch.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.typeToggleSwitch_CheckedChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tétel név";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Kategória";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastValueDataGridViewTextBoxColumn
            // 
            this.lastValueDataGridViewTextBoxColumn.DataPropertyName = "LastValue";
            this.lastValueDataGridViewTextBoxColumn.HeaderText = "Utoljára megadott érték";
            this.lastValueDataGridViewTextBoxColumn.Name = "lastValueDataGridViewTextBoxColumn";
            this.lastValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "TypeString";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Típus";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionItemListViewModelBindingSource1
            // 
            this.transactionItemListViewModelBindingSource1.DataSource = typeof(FinanceManager.PresentationLayer.TransactionItemViews.TransactionItemListViewModel);
            // 
            // TransactionItemListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 565);
            this.Controls.Add(this.incomeFilterCheckBox);
            this.Controls.Add(this.expenseFilterCheckBox);
            this.Controls.Add(this.itemSaveButtom);
            this.Controls.Add(this.typeToggleSwitch);
            this.Controls.Add(this.itemLastValueTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TransactionItemListForm";
            this.Text = "Pénzügyi tételek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionItemListForm_FormClosing);
            this.Load += new System.EventHandler(this.TransactionItemListForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionItemListViewModelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beolvasásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésMáskéntToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemLastValueTextBox;
        private JCS.ToggleSwitch typeToggleSwitch;
        private System.Windows.Forms.Button itemSaveButtom;
        private System.Windows.Forms.CheckBox expenseFilterCheckBox;
        private System.Windows.Forms.CheckBox incomeFilterCheckBox;
        private System.Windows.Forms.BindingSource transactionItemListViewModelBindingSource1;
        private System.Windows.Forms.BindingSource transactionItemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}