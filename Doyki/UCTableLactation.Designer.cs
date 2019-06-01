namespace Doyki
{
    partial class UCTableLactation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTableLactation));
            this.uchot_udoevDataSet2 = new Doyki.Uchot_udoevDataSet2();
            this.lactationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lactationTableAdapter = new Doyki.Uchot_udoevDataSet2TableAdapters.LactationTableAdapter();
            this.tableAdapterManager = new Doyki.Uchot_udoevDataSet2TableAdapters.TableAdapterManager();
            this.lactationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lactationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchStripButton = new System.Windows.Forms.ToolStripButton();
            this.lactationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisOfMilkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inThisMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lactationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lactationBindingNavigator)).BeginInit();
            this.lactationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lactationDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uchot_udoevDataSet2
            // 
            this.uchot_udoevDataSet2.DataSetName = "Uchot_udoevDataSet2";
            this.uchot_udoevDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lactationBindingSource
            // 
            this.lactationBindingSource.DataMember = "Lactation";
            this.lactationBindingSource.DataSource = this.uchot_udoevDataSet2;
            // 
            // lactationTableAdapter
            // 
            this.lactationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Analysis_of_bloodTableAdapter = null;
            this.tableAdapterManager.ApparatTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CattleTableAdapter = null;
            this.tableAdapterManager.LactationTableAdapter = this.lactationTableAdapter;
            this.tableAdapterManager.ReproductiveTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Doyki.Uchot_udoevDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lactationBindingNavigator
            // 
            this.lactationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lactationBindingNavigator.BindingSource = this.lactationBindingSource;
            this.lactationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lactationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lactationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lactationBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.searchStripTextBox,
            this.searchStripButton});
            this.lactationBindingNavigator.Location = new System.Drawing.Point(126, 0);
            this.lactationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lactationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lactationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lactationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lactationBindingNavigator.Name = "lactationBindingNavigator";
            this.lactationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lactationBindingNavigator.Size = new System.Drawing.Size(876, 25);
            this.lactationBindingNavigator.TabIndex = 0;
            this.lactationBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
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
            // lactationBindingNavigatorSaveItem
            // 
            this.lactationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lactationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lactationBindingNavigatorSaveItem.Image")));
            this.lactationBindingNavigatorSaveItem.Name = "lactationBindingNavigatorSaveItem";
            this.lactationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lactationBindingNavigatorSaveItem.Text = "Save Data";
            this.lactationBindingNavigatorSaveItem.Click += new System.EventHandler(this.LactationBindingNavigatorSaveItem_Click);
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
            // lactationDataGridView
            // 
            this.lactationDataGridView.AutoGenerateColumns = false;
            this.lactationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lactationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.lactationDataGridView.DataSource = this.lactationBindingSource;
            this.lactationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lactationDataGridView.Location = new System.Drawing.Point(126, 25);
            this.lactationDataGridView.Name = "lactationDataGridView";
            this.lactationDataGridView.Size = new System.Drawing.Size(876, 549);
            this.lactationDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_cow";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_cow";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date_start";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date_start";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date_end";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date_end";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Milking_days";
            this.dataGridViewTextBoxColumn5.HeaderText = "Milking_days";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Lactation_number";
            this.dataGridViewTextBoxColumn6.HeaderText = "Lactation_number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Live_weight";
            this.dataGridViewTextBoxColumn7.HeaderText = "Live_weight";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MDB";
            this.dataGridViewTextBoxColumn8.HeaderText = "MDB";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MDJ";
            this.dataGridViewTextBoxColumn9.HeaderText = "MDJ";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётыToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 574);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analysisOfMilkToolStripMenuItem,
            this.inThisMonthToolStripMenuItem,
            this.numberOfDaysToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // analysisOfMilkToolStripMenuItem
            // 
            this.analysisOfMilkToolStripMenuItem.Name = "analysisOfMilkToolStripMenuItem";
            this.analysisOfMilkToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.analysisOfMilkToolStripMenuItem.Text = "Анализ молока";
            this.analysisOfMilkToolStripMenuItem.Click += new System.EventHandler(this.AnalysisOfMilkToolStripMenuItem_Click);
            // 
            // inThisMonthToolStripMenuItem
            // 
            this.inThisMonthToolStripMenuItem.Name = "inThisMonthToolStripMenuItem";
            this.inThisMonthToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.inThisMonthToolStripMenuItem.Text = "Какие коровы проходят лактацию в этом месяце";
            this.inThisMonthToolStripMenuItem.Click += new System.EventHandler(this.InThisMonthToolStripMenuItem_Click);
            // 
            // numberOfDaysToolStripMenuItem
            // 
            this.numberOfDaysToolStripMenuItem.Name = "numberOfDaysToolStripMenuItem";
            this.numberOfDaysToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.numberOfDaysToolStripMenuItem.Text = "Количество дней в лактации";
            this.numberOfDaysToolStripMenuItem.Click += new System.EventHandler(this.NumberOfDaysToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.backToolStripMenuItem.Text = "Назад";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // UCTableLactation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lactationDataGridView);
            this.Controls.Add(this.lactationBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UCTableLactation";
            this.Size = new System.Drawing.Size(1002, 574);
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lactationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lactationBindingNavigator)).EndInit();
            this.lactationBindingNavigator.ResumeLayout(false);
            this.lactationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lactationDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Uchot_udoevDataSet2 uchot_udoevDataSet2;
        private System.Windows.Forms.BindingSource lactationBindingSource;
        private Uchot_udoevDataSet2TableAdapters.LactationTableAdapter lactationTableAdapter;
        private Uchot_udoevDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lactationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lactationBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox searchStripTextBox;
        private System.Windows.Forms.ToolStripButton searchStripButton;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisOfMilkToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        public System.Windows.Forms.DataGridView lactationDataGridView;
        private System.Windows.Forms.ToolStripMenuItem inThisMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfDaysToolStripMenuItem;
    }
}
