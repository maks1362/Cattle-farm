namespace Doyki
{
    partial class UCTableReproductive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTableReproductive));
            this.uchot_udoevDataSet2 = new Doyki.Uchot_udoevDataSet2();
            this.reproductiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reproductiveTableAdapter = new Doyki.Uchot_udoevDataSet2TableAdapters.ReproductiveTableAdapter();
            this.tableAdapterManager = new Doyki.Uchot_udoevDataSet2TableAdapters.TableAdapterManager();
            this.reproductiveBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.reproductiveBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchStripButton = new System.Windows.Forms.ToolStripButton();
            this.reproductiveDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductiveBindingNavigator)).BeginInit();
            this.reproductiveBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reproductiveDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uchot_udoevDataSet2
            // 
            this.uchot_udoevDataSet2.DataSetName = "Uchot_udoevDataSet2";
            this.uchot_udoevDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reproductiveBindingSource
            // 
            this.reproductiveBindingSource.DataMember = "Reproductive";
            this.reproductiveBindingSource.DataSource = this.uchot_udoevDataSet2;
            // 
            // reproductiveTableAdapter
            // 
            this.reproductiveTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Analysis_of_bloodTableAdapter = null;
            this.tableAdapterManager.ApparatTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CattleTableAdapter = null;
            this.tableAdapterManager.LactationTableAdapter = null;
            this.tableAdapterManager.ReproductiveTableAdapter = this.reproductiveTableAdapter;
            this.tableAdapterManager.UpdateOrder = Doyki.Uchot_udoevDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reproductiveBindingNavigator
            // 
            this.reproductiveBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reproductiveBindingNavigator.BindingSource = this.reproductiveBindingSource;
            this.reproductiveBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reproductiveBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reproductiveBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.reproductiveBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.searchStripTextBox,
            this.searchStripButton});
            this.reproductiveBindingNavigator.Location = new System.Drawing.Point(66, 0);
            this.reproductiveBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reproductiveBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reproductiveBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reproductiveBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reproductiveBindingNavigator.Name = "reproductiveBindingNavigator";
            this.reproductiveBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reproductiveBindingNavigator.Size = new System.Drawing.Size(936, 25);
            this.reproductiveBindingNavigator.TabIndex = 0;
            this.reproductiveBindingNavigator.Text = "bindingNavigator1";
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
            // reproductiveBindingNavigatorSaveItem
            // 
            this.reproductiveBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reproductiveBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reproductiveBindingNavigatorSaveItem.Image")));
            this.reproductiveBindingNavigatorSaveItem.Name = "reproductiveBindingNavigatorSaveItem";
            this.reproductiveBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reproductiveBindingNavigatorSaveItem.Text = "Save Data";
            this.reproductiveBindingNavigatorSaveItem.Click += new System.EventHandler(this.ReproductiveBindingNavigatorSaveItem_Click);
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
            // reproductiveDataGridView
            // 
            this.reproductiveDataGridView.AutoGenerateColumns = false;
            this.reproductiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reproductiveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.reproductiveDataGridView.DataSource = this.reproductiveBindingSource;
            this.reproductiveDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reproductiveDataGridView.Location = new System.Drawing.Point(66, 25);
            this.reproductiveDataGridView.Name = "reproductiveDataGridView";
            this.reproductiveDataGridView.Size = new System.Drawing.Size(936, 549);
            this.reproductiveDataGridView.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётыToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(66, 574);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reproductivityToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // reproductivityToolStripMenuItem
            // 
            this.reproductivityToolStripMenuItem.Name = "reproductivityToolStripMenuItem";
            this.reproductivityToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.reproductivityToolStripMenuItem.Text = "Отчет репродуктивности";
            this.reproductivityToolStripMenuItem.Click += new System.EventHandler(this.ReproductivityToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.backToolStripMenuItem.Text = "Назад";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер записи";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_cow";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер коровы";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOIPF";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество осеменений на одно плодотворное";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date_insemination";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата осеменения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date_otella";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата отёла";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date_past_otella";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата последнего отёла";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date_first_otella";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата первого отёла";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Service_period";
            this.dataGridViewTextBoxColumn8.HeaderText = "Сервис период";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Dry_period";
            this.dataGridViewTextBoxColumn9.HeaderText = "Сухостойный период";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ID_bull";
            this.dataGridViewTextBoxColumn10.HeaderText = "Номер быка";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // UCTableReproductive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reproductiveDataGridView);
            this.Controls.Add(this.reproductiveBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UCTableReproductive";
            this.Size = new System.Drawing.Size(1002, 574);
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductiveBindingNavigator)).EndInit();
            this.reproductiveBindingNavigator.ResumeLayout(false);
            this.reproductiveBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reproductiveDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Uchot_udoevDataSet2 uchot_udoevDataSet2;
        private System.Windows.Forms.BindingSource reproductiveBindingSource;
        private Uchot_udoevDataSet2TableAdapters.ReproductiveTableAdapter reproductiveTableAdapter;
        private Uchot_udoevDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reproductiveBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton reproductiveBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView reproductiveDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox searchStripTextBox;
        private System.Windows.Forms.ToolStripButton searchStripButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproductivityToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
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
    }
}
