namespace Doyki
{
    partial class UCTableCattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTableCattle));
            this.uchot_udoevDataSet2 = new Doyki.Uchot_udoevDataSet2();
            this.cattleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cattleTableAdapter = new Doyki.Uchot_udoevDataSet2TableAdapters.CattleTableAdapter();
            this.tableAdapterManager = new Doyki.Uchot_udoevDataSet2TableAdapters.TableAdapterManager();
            this.cattleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cattleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchStripButton = new System.Windows.Forms.ToolStripButton();
            this.cattleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генеалогическоеДеревоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingNavigator)).BeginInit();
            this.cattleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cattleDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uchot_udoevDataSet2
            // 
            this.uchot_udoevDataSet2.DataSetName = "Uchot_udoevDataSet2";
            this.uchot_udoevDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cattleBindingSource
            // 
            this.cattleBindingSource.DataMember = "Cattle";
            this.cattleBindingSource.DataSource = this.uchot_udoevDataSet2;
            // 
            // cattleTableAdapter
            // 
            this.cattleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Analysis_of_bloodTableAdapter = null;
            this.tableAdapterManager.ApparatTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CattleTableAdapter = this.cattleTableAdapter;
            this.tableAdapterManager.LactationTableAdapter = null;
            this.tableAdapterManager.ReproductiveTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Doyki.Uchot_udoevDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cattleBindingNavigator
            // 
            this.cattleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cattleBindingNavigator.AutoSize = false;
            this.cattleBindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.cattleBindingNavigator.BindingSource = this.cattleBindingSource;
            this.cattleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cattleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cattleBindingNavigator.GripMargin = new System.Windows.Forms.Padding(0);
            this.cattleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cattleBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.searchStripTextBox,
            this.searchStripButton});
            this.cattleBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.cattleBindingNavigator.Location = new System.Drawing.Point(120, 0);
            this.cattleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cattleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cattleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cattleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cattleBindingNavigator.Name = "cattleBindingNavigator";
            this.cattleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cattleBindingNavigator.Size = new System.Drawing.Size(882, 30);
            this.cattleBindingNavigator.TabIndex = 0;
            this.cattleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 27);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // cattleBindingNavigatorSaveItem
            // 
            this.cattleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cattleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cattleBindingNavigatorSaveItem.Image")));
            this.cattleBindingNavigatorSaveItem.Name = "cattleBindingNavigatorSaveItem";
            this.cattleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 27);
            this.cattleBindingNavigatorSaveItem.Text = "Save Data";
            this.cattleBindingNavigatorSaveItem.Click += new System.EventHandler(this.CattleBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // searchStripTextBox
            // 
            this.searchStripTextBox.Name = "searchStripTextBox";
            this.searchStripTextBox.Size = new System.Drawing.Size(100, 30);
            // 
            // searchStripButton
            // 
            this.searchStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchStripButton.Image = global::Doyki.Properties.Resources.icons8_search_96;
            this.searchStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchStripButton.Name = "searchStripButton";
            this.searchStripButton.Size = new System.Drawing.Size(23, 27);
            this.searchStripButton.Text = "toolStripButton1";
            this.searchStripButton.Click += new System.EventHandler(this.SearchStripButton_Click);
            // 
            // cattleDataGridView
            // 
            this.cattleDataGridView.AutoGenerateColumns = false;
            this.cattleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cattleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.cattleDataGridView.DataSource = this.cattleBindingSource;
            this.cattleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cattleDataGridView.Location = new System.Drawing.Point(120, 30);
            this.cattleDataGridView.Name = "cattleDataGridView";
            this.cattleDataGridView.Size = new System.Drawing.Size(882, 544);
            this.cattleDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер записи";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Breed";
            this.dataGridViewTextBoxColumn2.HeaderText = "Порода";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Purity_of_breed";
            this.dataGridViewTextBoxColumn3.HeaderText = "Чистокровность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_mother";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер матери";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_father";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер отца";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date_of_birth";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date_of_death";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата смерти";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cause_of_death";
            this.dataGridViewTextBoxColumn9.HeaderText = "Причина смерти";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Belongs";
            this.dataGridViewTextBoxColumn10.HeaderText = "Кому принадлежит";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Place_of_birth";
            this.dataGridViewTextBoxColumn11.HeaderText = "Место рождения";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Generation_number";
            this.dataGridViewTextBoxColumn12.HeaderText = "Номер поколения";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Line";
            this.dataGridViewTextBoxColumn13.HeaderText = "Линия";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикиToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(120, 574);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.генеалогическоеДеревоToolStripMenuItem});
            this.графикиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.графикиToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(119, 69);
            this.графикиToolStripMenuItem.Text = "Графики";
            // 
            // генеалогическоеДеревоToolStripMenuItem
            // 
            this.генеалогическоеДеревоToolStripMenuItem.Name = "генеалогическоеДеревоToolStripMenuItem";
            this.генеалогическоеДеревоToolStripMenuItem.Size = new System.Drawing.Size(303, 30);
            this.генеалогическоеДеревоToolStripMenuItem.Text = "Генеалогическое дерево";
            this.генеалогическоеДеревоToolStripMenuItem.Click += new System.EventHandler(this.ГенеалогическоеДеревоToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.backToolStripMenuItem.Size = new System.Drawing.Size(119, 69);
            this.backToolStripMenuItem.Text = "Назад";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // UCTableCattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cattleDataGridView);
            this.Controls.Add(this.cattleBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UCTableCattle";
            this.Size = new System.Drawing.Size(1002, 574);
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingNavigator)).EndInit();
            this.cattleBindingNavigator.ResumeLayout(false);
            this.cattleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cattleDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Uchot_udoevDataSet2 uchot_udoevDataSet2;
        private System.Windows.Forms.BindingSource cattleBindingSource;
        private Uchot_udoevDataSet2TableAdapters.CattleTableAdapter cattleTableAdapter;
        private Uchot_udoevDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cattleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cattleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cattleDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox searchStripTextBox;
        private System.Windows.Forms.ToolStripButton searchStripButton;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генеалогическоеДеревоToolStripMenuItem;
    }
}
