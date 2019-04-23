namespace Doyki
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.delRowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cattleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apparatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisOfBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lactationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uchot_udoevDataSet = new Doyki.Uchot_udoevDataSet();
            this.cattleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cattleTableAdapter = new Doyki.Uchot_udoevDataSetTableAdapters.CattleTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purityofbreedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmotherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDfatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofdeathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causeofdeathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belongsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generationnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uchot_udoevDataSet1 = new Doyki.Uchot_udoevDataSet1();
            this.cattleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cattleTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.CattleTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.диаграммаToolStripMenuItem,
            this.tablesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rowToolStripMenuItem
            // 
            this.rowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToolStripMenuItem1,
            this.delRowToolStripMenuItem1});
            this.rowToolStripMenuItem.Name = "rowToolStripMenuItem";
            this.rowToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.rowToolStripMenuItem.Text = "&Правка";
            // 
            // addRowToolStripMenuItem1
            // 
            this.addRowToolStripMenuItem1.Name = "addRowToolStripMenuItem1";
            this.addRowToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.addRowToolStripMenuItem1.Text = "Добавить";
            // 
            // delRowToolStripMenuItem1
            // 
            this.delRowToolStripMenuItem1.Name = "delRowToolStripMenuItem1";
            this.delRowToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.delRowToolStripMenuItem1.Text = "Удалить";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reportsToolStripMenuItem.Text = "Отчёты";
            // 
            // диаграммаToolStripMenuItem
            // 
            this.диаграммаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeToolStripMenuItem});
            this.диаграммаToolStripMenuItem.Name = "диаграммаToolStripMenuItem";
            this.диаграммаToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.диаграммаToolStripMenuItem.Text = "Диаграмма";
            // 
            // treeToolStripMenuItem
            // 
            this.treeToolStripMenuItem.Name = "treeToolStripMenuItem";
            this.treeToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.treeToolStripMenuItem.Text = "Tree";
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cattleToolStripMenuItem,
            this.apparatToolStripMenuItem,
            this.analysisOfBloodToolStripMenuItem,
            this.lactationToolStripMenuItem,
            this.reproductiveToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tablesToolStripMenuItem.Text = "Таблицы";
            // 
            // cattleToolStripMenuItem
            // 
            this.cattleToolStripMenuItem.Name = "cattleToolStripMenuItem";
            this.cattleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cattleToolStripMenuItem.Text = "Скот";
            this.cattleToolStripMenuItem.Click += new System.EventHandler(this.cattleToolStripMenuItem_Click);
            // 
            // apparatToolStripMenuItem
            // 
            this.apparatToolStripMenuItem.Name = "apparatToolStripMenuItem";
            this.apparatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apparatToolStripMenuItem.Text = "Аппарат";
            // 
            // analysisOfBloodToolStripMenuItem
            // 
            this.analysisOfBloodToolStripMenuItem.Name = "analysisOfBloodToolStripMenuItem";
            this.analysisOfBloodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.analysisOfBloodToolStripMenuItem.Text = "Анализ крови";
            // 
            // lactationToolStripMenuItem
            // 
            this.lactationToolStripMenuItem.Name = "lactationToolStripMenuItem";
            this.lactationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lactationToolStripMenuItem.Text = "Лактация";
            // 
            // reproductiveToolStripMenuItem
            // 
            this.reproductiveToolStripMenuItem.Name = "reproductiveToolStripMenuItem";
            this.reproductiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reproductiveToolStripMenuItem.Text = "Репродуктивность";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.breedDataGridViewTextBoxColumn,
            this.purityofbreedDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.iDmotherDataGridViewTextBoxColumn,
            this.iDfatherDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.dateofdeathDataGridViewTextBoxColumn,
            this.causeofdeathDataGridViewTextBoxColumn,
            this.belongsDataGridViewTextBoxColumn,
            this.placeofbirthDataGridViewTextBoxColumn,
            this.generationnumberDataGridViewTextBoxColumn,
            this.lineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cattleBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 345);
            this.dataGridView1.TabIndex = 1;
            // 
            // uchot_udoevDataSet
            // 
            this.uchot_udoevDataSet.DataSetName = "Uchot_udoevDataSet";
            this.uchot_udoevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cattleBindingSource
            // 
            this.cattleBindingSource.DataMember = "Cattle";
            this.cattleBindingSource.DataSource = this.uchot_udoevDataSet;
            // 
            // cattleTableAdapter
            // 
            this.cattleTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // breedDataGridViewTextBoxColumn
            // 
            this.breedDataGridViewTextBoxColumn.DataPropertyName = "Breed";
            this.breedDataGridViewTextBoxColumn.HeaderText = "Breed";
            this.breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            // 
            // purityofbreedDataGridViewTextBoxColumn
            // 
            this.purityofbreedDataGridViewTextBoxColumn.DataPropertyName = "Purity_of_breed";
            this.purityofbreedDataGridViewTextBoxColumn.HeaderText = "Purity_of_breed";
            this.purityofbreedDataGridViewTextBoxColumn.Name = "purityofbreedDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // iDmotherDataGridViewTextBoxColumn
            // 
            this.iDmotherDataGridViewTextBoxColumn.DataPropertyName = "ID_mother";
            this.iDmotherDataGridViewTextBoxColumn.HeaderText = "ID_mother";
            this.iDmotherDataGridViewTextBoxColumn.Name = "iDmotherDataGridViewTextBoxColumn";
            // 
            // iDfatherDataGridViewTextBoxColumn
            // 
            this.iDfatherDataGridViewTextBoxColumn.DataPropertyName = "ID_father";
            this.iDfatherDataGridViewTextBoxColumn.HeaderText = "ID_father";
            this.iDfatherDataGridViewTextBoxColumn.Name = "iDfatherDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // dateofdeathDataGridViewTextBoxColumn
            // 
            this.dateofdeathDataGridViewTextBoxColumn.DataPropertyName = "Date_of_death";
            this.dateofdeathDataGridViewTextBoxColumn.HeaderText = "Date_of_death";
            this.dateofdeathDataGridViewTextBoxColumn.Name = "dateofdeathDataGridViewTextBoxColumn";
            // 
            // causeofdeathDataGridViewTextBoxColumn
            // 
            this.causeofdeathDataGridViewTextBoxColumn.DataPropertyName = "Cause_of_death";
            this.causeofdeathDataGridViewTextBoxColumn.HeaderText = "Cause_of_death";
            this.causeofdeathDataGridViewTextBoxColumn.Name = "causeofdeathDataGridViewTextBoxColumn";
            // 
            // belongsDataGridViewTextBoxColumn
            // 
            this.belongsDataGridViewTextBoxColumn.DataPropertyName = "Belongs";
            this.belongsDataGridViewTextBoxColumn.HeaderText = "Belongs";
            this.belongsDataGridViewTextBoxColumn.Name = "belongsDataGridViewTextBoxColumn";
            // 
            // placeofbirthDataGridViewTextBoxColumn
            // 
            this.placeofbirthDataGridViewTextBoxColumn.DataPropertyName = "Place_of_birth";
            this.placeofbirthDataGridViewTextBoxColumn.HeaderText = "Place_of_birth";
            this.placeofbirthDataGridViewTextBoxColumn.Name = "placeofbirthDataGridViewTextBoxColumn";
            // 
            // generationnumberDataGridViewTextBoxColumn
            // 
            this.generationnumberDataGridViewTextBoxColumn.DataPropertyName = "Generation_number";
            this.generationnumberDataGridViewTextBoxColumn.HeaderText = "Generation_number";
            this.generationnumberDataGridViewTextBoxColumn.Name = "generationnumberDataGridViewTextBoxColumn";
            // 
            // lineDataGridViewTextBoxColumn
            // 
            this.lineDataGridViewTextBoxColumn.DataPropertyName = "Line";
            this.lineDataGridViewTextBoxColumn.HeaderText = "Line";
            this.lineDataGridViewTextBoxColumn.Name = "lineDataGridViewTextBoxColumn";
            // 
            // uchot_udoevDataSet1
            // 
            this.uchot_udoevDataSet1.DataSetName = "Uchot_udoevDataSet1";
            this.uchot_udoevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cattleBindingSource1
            // 
            this.cattleBindingSource1.DataMember = "Cattle";
            this.cattleBindingSource1.DataSource = this.uchot_udoevDataSet1;
            // 
            // cattleTableAdapter1
            // 
            this.cattleTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem delRowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem диаграммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cattleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apparatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisOfBloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lactationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproductiveToolStripMenuItem;
        private Uchot_udoevDataSet uchot_udoevDataSet;
        private System.Windows.Forms.BindingSource cattleBindingSource;
        private Uchot_udoevDataSetTableAdapters.CattleTableAdapter cattleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purityofbreedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmotherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDfatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofdeathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn causeofdeathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn belongsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generationnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineDataGridViewTextBoxColumn;
        private Uchot_udoevDataSet1 uchot_udoevDataSet1;
        private System.Windows.Forms.BindingSource cattleBindingSource1;
        private Uchot_udoevDataSet1TableAdapters.CattleTableAdapter cattleTableAdapter1;
    }
}

