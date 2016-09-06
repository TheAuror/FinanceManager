﻿namespace FinanceManager.PresentationLayer.MainViews
{
    partial class MainForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.statisticsOpenButton = new System.Windows.Forms.Button();
            this.itemListOpenButton = new System.Windows.Forms.Button();
            this.transactionListOpenButton = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.saveTransactionButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.regularCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toggleSwitch = new JCS.ToggleSwitch();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.menuPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuPanel.Controls.Add(this.statisticsOpenButton);
            this.menuPanel.Controls.Add(this.itemListOpenButton);
            this.menuPanel.Controls.Add(this.transactionListOpenButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1157, 79);
            this.menuPanel.TabIndex = 1;
            // 
            // statisticsOpenButton
            // 
            this.statisticsOpenButton.Location = new System.Drawing.Point(205, 3);
            this.statisticsOpenButton.Name = "statisticsOpenButton";
            this.statisticsOpenButton.Size = new System.Drawing.Size(95, 69);
            this.statisticsOpenButton.TabIndex = 2;
            this.statisticsOpenButton.Text = "Statisztikák";
            this.statisticsOpenButton.UseVisualStyleBackColor = true;
            // 
            // itemListOpenButton
            // 
            this.itemListOpenButton.Location = new System.Drawing.Point(104, 3);
            this.itemListOpenButton.Name = "itemListOpenButton";
            this.itemListOpenButton.Size = new System.Drawing.Size(95, 69);
            this.itemListOpenButton.TabIndex = 1;
            this.itemListOpenButton.Text = "Termékek Szolgáltatások";
            this.itemListOpenButton.UseVisualStyleBackColor = true;
            // 
            // transactionListOpenButton
            // 
            this.transactionListOpenButton.Location = new System.Drawing.Point(3, 3);
            this.transactionListOpenButton.Name = "transactionListOpenButton";
            this.transactionListOpenButton.Size = new System.Drawing.Size(95, 69);
            this.transactionListOpenButton.TabIndex = 0;
            this.transactionListOpenButton.Text = "Bevételek Kiadások";
            this.transactionListOpenButton.UseVisualStyleBackColor = true;
            // 
            // sidePanel
            // 
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidePanel.Controls.Add(this.itemNameTextBox);
            this.sidePanel.Controls.Add(this.saveTransactionButton);
            this.sidePanel.Controls.Add(this.dateTimePicker);
            this.sidePanel.Controls.Add(this.label5);
            this.sidePanel.Controls.Add(this.regularCheckBox);
            this.sidePanel.Controls.Add(this.textBox);
            this.sidePanel.Controls.Add(this.label3);
            this.sidePanel.Controls.Add(this.label2);
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.toggleSwitch);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel.Location = new System.Drawing.Point(957, 79);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 667);
            this.sidePanel.TabIndex = 2;
            // 
            // saveTransactionButton
            // 
            this.saveTransactionButton.Location = new System.Drawing.Point(6, 637);
            this.saveTransactionButton.Name = "saveTransactionButton";
            this.saveTransactionButton.Size = new System.Drawing.Size(187, 23);
            this.saveTransactionButton.TabIndex = 11;
            this.saveTransactionButton.Text = "Rögzítés";
            this.saveTransactionButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 184);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Keletkezés dátuma:";
            // 
            // regularCheckBox
            // 
            this.regularCheckBox.AutoSize = true;
            this.regularCheckBox.Location = new System.Drawing.Point(6, 217);
            this.regularCheckBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.regularCheckBox.Name = "regularCheckBox";
            this.regularCheckBox.Size = new System.Drawing.Size(82, 17);
            this.regularCheckBox.TabIndex = 6;
            this.regularCheckBox.Text = "Rendszeres";
            this.regularCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(6, 135);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(180, 20);
            this.textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Termék vagy szolgáltatás ára:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Termék vagy szolgáltatás neve: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tranzakció típusa:";
            // 
            // toggleSwitch
            // 
            this.toggleSwitch.Checked = true;
            this.toggleSwitch.Location = new System.Drawing.Point(6, 27);
            this.toggleSwitch.Name = "toggleSwitch";
            this.toggleSwitch.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toggleSwitch.OffForeColor = System.Drawing.Color.White;
            this.toggleSwitch.OffText = "Kiadás";
            this.toggleSwitch.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toggleSwitch.OnForeColor = System.Drawing.Color.White;
            this.toggleSwitch.OnText = "Bevétel";
            this.toggleSwitch.Size = new System.Drawing.Size(190, 29);
            this.toggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy;
            this.toggleSwitch.TabIndex = 0;
            this.toggleSwitch.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.toggleSwitch_CheckedChanged);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(FinanceManager.PresentationLayer.MainViews.MainViewModel);
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.itemNameTextBox.Location = new System.Drawing.Point(6, 85);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.itemNameTextBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1157, 746);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.menuPanel);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel sidePanel;
        private JCS.ToggleSwitch toggleSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox regularCheckBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button transactionListOpenButton;
        private System.Windows.Forms.Button saveTransactionButton;
        private System.Windows.Forms.Button statisticsOpenButton;
        private System.Windows.Forms.Button itemListOpenButton;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.TextBox itemNameTextBox;
    }
}

