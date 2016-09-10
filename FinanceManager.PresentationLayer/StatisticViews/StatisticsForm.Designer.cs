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
            this.bottomDataGridView = new System.Windows.Forms.DataGridView();
            this.toggleSwitch = new JCS.ToggleSwitch();
            this.Dif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshButton = new System.Windows.Forms.Button();
            this.rowNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.topDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomDataGridView)).BeginInit();
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
            this.num1DataGridViewTextBoxColumn,
            this.num2DataGridViewTextBoxColumn,
            this.Dif});
            this.topDataGridView.DataSource = this.topBindingSource;
            this.topDataGridView.Location = new System.Drawing.Point(13, 37);
            this.topDataGridView.Name = "topDataGridView";
            this.topDataGridView.ReadOnly = true;
            this.topDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.topDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.topDataGridView.Size = new System.Drawing.Size(739, 287);
            this.topDataGridView.TabIndex = 0;
            this.topDataGridView.TabStop = false;
            // 
            // bottomDataGridView
            // 
            this.bottomDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bottomDataGridView.Location = new System.Drawing.Point(13, 330);
            this.bottomDataGridView.Name = "bottomDataGridView";
            this.bottomDataGridView.Size = new System.Drawing.Size(739, 223);
            this.bottomDataGridView.TabIndex = 1;
            this.bottomDataGridView.TabStop = false;
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
            // Dif
            // 
            this.Dif.DataPropertyName = "Dif";
            this.Dif.HeaderText = "Különbség";
            this.Dif.Name = "Dif";
            this.Dif.ReadOnly = true;
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
            // rowNameDataGridViewTextBoxColumn
            // 
            this.rowNameDataGridViewTextBoxColumn.DataPropertyName = "RowName";
            this.rowNameDataGridViewTextBoxColumn.HeaderText = "Időszak";
            this.rowNameDataGridViewTextBoxColumn.Name = "rowNameDataGridViewTextBoxColumn";
            this.rowNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.num2DataGridViewTextBoxColumn.HeaderText = "Kiadás";
            this.num2DataGridViewTextBoxColumn.Name = "num2DataGridViewTextBoxColumn";
            this.num2DataGridViewTextBoxColumn.ReadOnly = true;
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
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.toggleSwitch);
            this.Controls.Add(this.bottomDataGridView);
            this.Controls.Add(this.topDataGridView);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticsForm_FormClosing);
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView topDataGridView;
        private System.Windows.Forms.DataGridView bottomDataGridView;
        private JCS.ToggleSwitch toggleSwitch;
        private System.Windows.Forms.BindingSource topBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dif;
        private System.Windows.Forms.Button refreshButton;
    }
}