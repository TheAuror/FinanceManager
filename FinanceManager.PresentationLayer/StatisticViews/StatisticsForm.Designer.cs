namespace FinanceManager.PresentationLayer.StatisticViews
{
    partial class StatisticsForm
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
            this.topDataGridView = new System.Windows.Forms.DataGridView();
            this.toggleSwitch = new JCS.ToggleSwitch();
            this.refreshButton = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bottomLeftDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bottomRightDataGridView = new System.Windows.Forms.DataGridView();
            this.rowNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bottomLeftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rowNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bottomRightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rowNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.topDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftDataGridView)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topDataGridView
            // 
            this.topDataGridView.AllowUserToAddRows = false;
            this.topDataGridView.AllowUserToDeleteRows = false;
            this.topDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topDataGridView.AutoGenerateColumns = false;
            this.topDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.topDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNameDataGridViewTextBoxColumn,
            this.Num1,
            this.Num2,
            this.Dif});
            this.topDataGridView.DataSource = this.topBindingSource;
            this.topDataGridView.Location = new System.Drawing.Point(13, 37);
            this.topDataGridView.MultiSelect = false;
            this.topDataGridView.Name = "topDataGridView";
            this.topDataGridView.ReadOnly = true;
            this.topDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.topDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.topDataGridView.Size = new System.Drawing.Size(739, 287);
            this.topDataGridView.TabIndex = 0;
            this.topDataGridView.TabStop = false;
            this.topDataGridView.SelectionChanged += new System.EventHandler(this.topDataGridView_SelectionChanged);
            // 
            // toggleSwitch
            // 
            this.toggleSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleSwitch.Location = new System.Drawing.Point(659, 12);
            this.toggleSwitch.Name = "toggleSwitch";
            this.toggleSwitch.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toggleSwitch.OffForeColor = System.Drawing.Color.White;
            this.toggleSwitch.OffText = "Havi";
            this.toggleSwitch.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toggleSwitch.OnForeColor = System.Drawing.Color.White;
            this.toggleSwitch.OnText = "Éves";
            this.toggleSwitch.Size = new System.Drawing.Size(92, 19);
            this.toggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Carbon;
            this.toggleSwitch.TabIndex = 2;
            this.toggleSwitch.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.toggleSwitch_CheckedChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(13, 8);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Frissítés";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Num1
            // 
            this.Num1.DataPropertyName = "Num1";
            this.Num1.HeaderText = "Bevétel";
            this.Num1.Name = "Num1";
            this.Num1.ReadOnly = true;
            // 
            // Num2
            // 
            this.Num2.DataPropertyName = "Num2";
            this.Num2.HeaderText = "Kiadás";
            this.Num2.Name = "Num2";
            this.Num2.ReadOnly = true;
            // 
            // Dif
            // 
            this.Dif.DataPropertyName = "Dif";
            this.Dif.HeaderText = "Különbség";
            this.Dif.Name = "Dif";
            this.Dif.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bevétel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(372, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kiadás:";
            // 
            // bottomLeftDataGridView
            // 
            this.bottomLeftDataGridView.AllowUserToAddRows = false;
            this.bottomLeftDataGridView.AllowUserToDeleteRows = false;
            this.bottomLeftDataGridView.AutoGenerateColumns = false;
            this.bottomLeftDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bottomLeftDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bottomLeftDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNameDataGridViewTextBoxColumn1,
            this.num1DataGridViewTextBoxColumn,
            this.num2DataGridViewTextBoxColumn,
            this.difDataGridViewTextBoxColumn});
            this.bottomLeftDataGridView.DataSource = this.bottomLeftBindingSource;
            this.bottomLeftDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLeftDataGridView.Location = new System.Drawing.Point(3, 23);
            this.bottomLeftDataGridView.Name = "bottomLeftDataGridView";
            this.bottomLeftDataGridView.ReadOnly = true;
            this.bottomLeftDataGridView.Size = new System.Drawing.Size(363, 197);
            this.bottomLeftDataGridView.TabIndex = 1;
            this.bottomLeftDataGridView.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.bottomLeftDataGridView, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.bottomRightDataGridView, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(13, 330);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(739, 223);
            this.tableLayoutPanel.TabIndex = 7;
            // 
            // bottomRightDataGridView
            // 
            this.bottomRightDataGridView.AllowUserToAddRows = false;
            this.bottomRightDataGridView.AllowUserToDeleteRows = false;
            this.bottomRightDataGridView.AutoGenerateColumns = false;
            this.bottomRightDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bottomRightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bottomRightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNameDataGridViewTextBoxColumn2,
            this.num1DataGridViewTextBoxColumn1,
            this.num2DataGridViewTextBoxColumn1,
            this.difDataGridViewTextBoxColumn1});
            this.bottomRightDataGridView.DataSource = this.bottomRightBindingSource;
            this.bottomRightDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRightDataGridView.Location = new System.Drawing.Point(372, 23);
            this.bottomRightDataGridView.Name = "bottomRightDataGridView";
            this.bottomRightDataGridView.ReadOnly = true;
            this.bottomRightDataGridView.Size = new System.Drawing.Size(364, 197);
            this.bottomRightDataGridView.TabIndex = 4;
            // 
            // rowNameDataGridViewTextBoxColumn1
            // 
            this.rowNameDataGridViewTextBoxColumn1.DataPropertyName = "RowName";
            this.rowNameDataGridViewTextBoxColumn1.HeaderText = "Kategória";
            this.rowNameDataGridViewTextBoxColumn1.Name = "rowNameDataGridViewTextBoxColumn1";
            this.rowNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // num1DataGridViewTextBoxColumn
            // 
            this.num1DataGridViewTextBoxColumn.DataPropertyName = "Num1";
            this.num1DataGridViewTextBoxColumn.HeaderText = "Bevétel";
            this.num1DataGridViewTextBoxColumn.Name = "num1DataGridViewTextBoxColumn";
            this.num1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // num2DataGridViewTextBoxColumn
            // 
            this.num2DataGridViewTextBoxColumn.DataPropertyName = "Num2";
            this.num2DataGridViewTextBoxColumn.HeaderText = "%";
            this.num2DataGridViewTextBoxColumn.Name = "num2DataGridViewTextBoxColumn";
            this.num2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // difDataGridViewTextBoxColumn
            // 
            this.difDataGridViewTextBoxColumn.DataPropertyName = "Dif";
            this.difDataGridViewTextBoxColumn.HeaderText = "Dif";
            this.difDataGridViewTextBoxColumn.Name = "difDataGridViewTextBoxColumn";
            this.difDataGridViewTextBoxColumn.ReadOnly = true;
            this.difDataGridViewTextBoxColumn.Visible = false;
            // 
            // bottomLeftBindingSource
            // 
            this.bottomLeftBindingSource.DataMember = "BottomLeftList";
            this.bottomLeftBindingSource.DataSource = typeof(FinanceManager.PresentationLayer.StatisticViews.StatisticsViewModel);
            // 
            // rowNameDataGridViewTextBoxColumn2
            // 
            this.rowNameDataGridViewTextBoxColumn2.DataPropertyName = "RowName";
            this.rowNameDataGridViewTextBoxColumn2.HeaderText = "Kategória";
            this.rowNameDataGridViewTextBoxColumn2.Name = "rowNameDataGridViewTextBoxColumn2";
            this.rowNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // num1DataGridViewTextBoxColumn1
            // 
            this.num1DataGridViewTextBoxColumn1.DataPropertyName = "Num1";
            this.num1DataGridViewTextBoxColumn1.HeaderText = "Bevétel";
            this.num1DataGridViewTextBoxColumn1.Name = "num1DataGridViewTextBoxColumn1";
            this.num1DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // num2DataGridViewTextBoxColumn1
            // 
            this.num2DataGridViewTextBoxColumn1.DataPropertyName = "Num2";
            this.num2DataGridViewTextBoxColumn1.HeaderText = "%";
            this.num2DataGridViewTextBoxColumn1.Name = "num2DataGridViewTextBoxColumn1";
            this.num2DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // difDataGridViewTextBoxColumn1
            // 
            this.difDataGridViewTextBoxColumn1.DataPropertyName = "Dif";
            this.difDataGridViewTextBoxColumn1.HeaderText = "Dif";
            this.difDataGridViewTextBoxColumn1.Name = "difDataGridViewTextBoxColumn1";
            this.difDataGridViewTextBoxColumn1.ReadOnly = true;
            this.difDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bottomRightBindingSource
            // 
            this.bottomRightBindingSource.DataMember = "BottomRightList";
            this.bottomRightBindingSource.DataSource = typeof(FinanceManager.PresentationLayer.StatisticViews.StatisticsViewModel);
            // 
            // rowNameDataGridViewTextBoxColumn
            // 
            this.rowNameDataGridViewTextBoxColumn.DataPropertyName = "RowName";
            this.rowNameDataGridViewTextBoxColumn.HeaderText = "Időszak";
            this.rowNameDataGridViewTextBoxColumn.Name = "rowNameDataGridViewTextBoxColumn";
            this.rowNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // topBindingSource
            // 
            this.topBindingSource.DataMember = "TopList";
            this.topBindingSource.DataSource = typeof(FinanceManager.PresentationLayer.StatisticViews.StatisticsViewModel);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 565);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.toggleSwitch);
            this.Controls.Add(this.topDataGridView);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticsForm_FormClosing);
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftDataGridView)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView topDataGridView;
        private JCS.ToggleSwitch toggleSwitch;
        private System.Windows.Forms.BindingSource topBindingSource;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView bottomLeftDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.BindingSource bottomRightBindingSource;
        private System.Windows.Forms.BindingSource bottomLeftBindingSource;
        private System.Windows.Forms.DataGridView bottomRightDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn difDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn num1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn difDataGridViewTextBoxColumn1;
    }
}