﻿namespace Doyki
{
    partial class UCTableApparat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTableApparat));
            this.uchot_udoevDataSet2 = new Doyki.Uchot_udoevDataSet2();
            this.apparatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apparatTableAdapter = new Doyki.Uchot_udoevDataSet2TableAdapters.ApparatTableAdapter();
            this.tableAdapterManager = new Doyki.Uchot_udoevDataSet2TableAdapters.TableAdapterManager();
            this.apparatBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.apparatBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchStripButton = new System.Windows.Forms.ToolStripButton();
            this.apparatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageyieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lactationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lactationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milkOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageMilkYieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gDailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gMonthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gYearlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gLactationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gLactationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apparatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apparatBindingNavigator)).BeginInit();
            this.apparatBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apparatDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uchot_udoevDataSet2
            // 
            this.uchot_udoevDataSet2.DataSetName = "Uchot_udoevDataSet2";
            this.uchot_udoevDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apparatBindingSource
            // 
            this.apparatBindingSource.DataMember = "Apparat";
            this.apparatBindingSource.DataSource = this.uchot_udoevDataSet2;
            // 
            // apparatTableAdapter
            // 
            this.apparatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Analysis_of_bloodTableAdapter = null;
            this.tableAdapterManager.ApparatTableAdapter = this.apparatTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CattleTableAdapter = null;
            this.tableAdapterManager.LactationTableAdapter = null;
            this.tableAdapterManager.ReproductiveTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Doyki.Uchot_udoevDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // apparatBindingNavigator
            // 
            this.apparatBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.apparatBindingNavigator.BindingSource = this.apparatBindingSource;
            this.apparatBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.apparatBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.apparatBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.apparatBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.searchStripTextBox,
            this.searchStripButton});
            this.apparatBindingNavigator.Location = new System.Drawing.Point(111, 0);
            this.apparatBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.apparatBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.apparatBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.apparatBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.apparatBindingNavigator.Name = "apparatBindingNavigator";
            this.apparatBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.apparatBindingNavigator.Size = new System.Drawing.Size(891, 25);
            this.apparatBindingNavigator.TabIndex = 0;
            this.apparatBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // apparatBindingNavigatorSaveItem
            // 
            this.apparatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.apparatBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("apparatBindingNavigatorSaveItem.Image")));
            this.apparatBindingNavigatorSaveItem.Name = "apparatBindingNavigatorSaveItem";
            this.apparatBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.apparatBindingNavigatorSaveItem.Text = "Save Data";
            this.apparatBindingNavigatorSaveItem.Click += new System.EventHandler(this.ApparatBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // searchStripTextBox
            // 
            this.searchStripTextBox.Name = "searchStripTextBox";
            this.searchStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchStripButton
            // 
            this.searchStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchStripButton.Image = global::Doyki.Properties.Resources.icons8_search_96;
            this.searchStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchStripButton.Name = "searchStripButton";
            this.searchStripButton.Size = new System.Drawing.Size(23, 22);
            this.searchStripButton.Text = "toolStripButton1";
            this.searchStripButton.Click += new System.EventHandler(this.SearchStripButton_Click);
            // 
            // apparatDataGridView
            // 
            this.apparatDataGridView.AutoGenerateColumns = false;
            this.apparatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apparatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.apparatDataGridView.DataSource = this.apparatBindingSource;
            this.apparatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apparatDataGridView.Location = new System.Drawing.Point(111, 25);
            this.apparatDataGridView.Name = "apparatDataGridView";
            this.apparatDataGridView.Size = new System.Drawing.Size(891, 549);
            this.apparatDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер записи";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_apparat";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер аппарата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_cow";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер коровы";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Number_in_day";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер в день";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Count_of_milk";
            this.dataGridViewTextBoxColumn6.HeaderText = "Количество молока";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Speed";
            this.dataGridViewTextBoxColumn7.HeaderText = "Молокоотдача";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётыToolStripMenuItem,
            this.graphicsToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(111, 574);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageyieldToolStripMenuItem,
            this.milkOutputToolStripMenuItem});
            this.отчётыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.отчётыToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(110, 69);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // averageyieldToolStripMenuItem
            // 
            this.averageyieldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyToolStripMenuItem,
            this.monthlyToolStripMenuItem,
            this.yearlyToolStripMenuItem,
            this.lactationsToolStripMenuItem,
            this.lactationToolStripMenuItem});
            this.averageyieldToolStripMenuItem.Name = "averageyieldToolStripMenuItem";
            this.averageyieldToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.averageyieldToolStripMenuItem.Text = "Средний удой";
            // 
            // dailyToolStripMenuItem
            // 
            this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
            this.dailyToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.dailyToolStripMenuItem.Text = "Суточные";
            this.dailyToolStripMenuItem.Click += new System.EventHandler(this.DailyToolStripMenuItem_Click);
            // 
            // monthlyToolStripMenuItem
            // 
            this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.monthlyToolStripMenuItem.Text = "Месячные";
            this.monthlyToolStripMenuItem.Click += new System.EventHandler(this.MonthlyToolStripMenuItem_Click);
            // 
            // yearlyToolStripMenuItem
            // 
            this.yearlyToolStripMenuItem.Name = "yearlyToolStripMenuItem";
            this.yearlyToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.yearlyToolStripMenuItem.Text = "Годовые";
            this.yearlyToolStripMenuItem.Click += new System.EventHandler(this.YearlyToolStripMenuItem_Click);
            // 
            // lactationsToolStripMenuItem
            // 
            this.lactationsToolStripMenuItem.Name = "lactationsToolStripMenuItem";
            this.lactationsToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.lactationsToolStripMenuItem.Text = "По лактациям";
            this.lactationsToolStripMenuItem.Click += new System.EventHandler(this.LactationsToolStripMenuItem_Click);
            // 
            // lactationToolStripMenuItem
            // 
            this.lactationToolStripMenuItem.Name = "lactationToolStripMenuItem";
            this.lactationToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.lactationToolStripMenuItem.Text = "По последней лактации";
            this.lactationToolStripMenuItem.Click += new System.EventHandler(this.LactationToolStripMenuItem_Click);
            // 
            // milkOutputToolStripMenuItem
            // 
            this.milkOutputToolStripMenuItem.Name = "milkOutputToolStripMenuItem";
            this.milkOutputToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.milkOutputToolStripMenuItem.Text = "Молокоотдача";
            this.milkOutputToolStripMenuItem.Click += new System.EventHandler(this.MilkOutputToolStripMenuItem_Click);
            // 
            // graphicsToolStripMenuItem
            // 
            this.graphicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageMilkYieldToolStripMenuItem});
            this.graphicsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.graphicsToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.graphicsToolStripMenuItem.Name = "graphicsToolStripMenuItem";
            this.graphicsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.graphicsToolStripMenuItem.Size = new System.Drawing.Size(110, 69);
            this.graphicsToolStripMenuItem.Text = "Графики";
            // 
            // averageMilkYieldToolStripMenuItem
            // 
            this.averageMilkYieldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gDailyToolStripMenuItem,
            this.gMonthlyToolStripMenuItem,
            this.gYearlyToolStripMenuItem,
            this.gLactationsToolStripMenuItem,
            this.gLactationToolStripMenuItem});
            this.averageMilkYieldToolStripMenuItem.Name = "averageMilkYieldToolStripMenuItem";
            this.averageMilkYieldToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.averageMilkYieldToolStripMenuItem.Text = "Средний удой";
            // 
            // gDailyToolStripMenuItem
            // 
            this.gDailyToolStripMenuItem.Name = "gDailyToolStripMenuItem";
            this.gDailyToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.gDailyToolStripMenuItem.Text = "Суточный";
            this.gDailyToolStripMenuItem.Click += new System.EventHandler(this.GDailyToolStripMenuItem_Click);
            // 
            // gMonthlyToolStripMenuItem
            // 
            this.gMonthlyToolStripMenuItem.Name = "gMonthlyToolStripMenuItem";
            this.gMonthlyToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.gMonthlyToolStripMenuItem.Text = "Месячный";
            this.gMonthlyToolStripMenuItem.Click += new System.EventHandler(this.GMonthlyToolStripMenuItem_Click);
            // 
            // gYearlyToolStripMenuItem
            // 
            this.gYearlyToolStripMenuItem.Name = "gYearlyToolStripMenuItem";
            this.gYearlyToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.gYearlyToolStripMenuItem.Text = "Годовой";
            this.gYearlyToolStripMenuItem.Click += new System.EventHandler(this.GYearlyToolStripMenuItem_Click);
            // 
            // gLactationsToolStripMenuItem
            // 
            this.gLactationsToolStripMenuItem.Name = "gLactationsToolStripMenuItem";
            this.gLactationsToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.gLactationsToolStripMenuItem.Text = "По лактациям";
            this.gLactationsToolStripMenuItem.Click += new System.EventHandler(this.GLactationsToolStripMenuItem_Click);
            // 
            // gLactationToolStripMenuItem
            // 
            this.gLactationToolStripMenuItem.Name = "gLactationToolStripMenuItem";
            this.gLactationToolStripMenuItem.Size = new System.Drawing.Size(297, 30);
            this.gLactationToolStripMenuItem.Text = "По последней лактации";
            this.gLactationToolStripMenuItem.Click += new System.EventHandler(this.GLactationToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.backToolStripMenuItem.Size = new System.Drawing.Size(110, 69);
            this.backToolStripMenuItem.Text = "Назад";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // UCTableApparat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.apparatDataGridView);
            this.Controls.Add(this.apparatBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UCTableApparat";
            this.Size = new System.Drawing.Size(1002, 574);
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apparatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apparatBindingNavigator)).EndInit();
            this.apparatBindingNavigator.ResumeLayout(false);
            this.apparatBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apparatDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Uchot_udoevDataSet2 uchot_udoevDataSet2;
        private System.Windows.Forms.BindingSource apparatBindingSource;
        private Uchot_udoevDataSet2TableAdapters.ApparatTableAdapter apparatTableAdapter;
        private Uchot_udoevDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator apparatBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton apparatBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView apparatDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox searchStripTextBox;
        private System.Windows.Forms.ToolStripButton searchStripButton;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageyieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milkOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageMilkYieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gDailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gMonthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gYearlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gLactationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gLactationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lactationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lactationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
