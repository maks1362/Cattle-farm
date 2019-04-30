namespace Doyki
{
    partial class MainForm
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
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cattleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apparatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisOfBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lactationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cattleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uchot_udoevDataSet1 = new Doyki.Uchot_udoevDataSet1();
            this.cattleTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.CattleTableAdapter();
            this.apparatTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.ApparatTableAdapter();
            this.lactationTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.LactationTableAdapter();
            this.analysis_of_bloodTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.Analysis_of_bloodTableAdapter();
            this.reproductiveTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.ReproductiveTableAdapter();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.диаграммаToolStripMenuItem,
            this.tablesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rowToolStripMenuItem
            // 
            this.rowToolStripMenuItem.Name = "rowToolStripMenuItem";
            this.rowToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.rowToolStripMenuItem.Text = "Выход";
            this.rowToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Enabled = false;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reportsToolStripMenuItem.Text = "Отчёты";
            // 
            // диаграммаToolStripMenuItem
            // 
            this.диаграммаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeToolStripMenuItem});
            this.диаграммаToolStripMenuItem.Enabled = false;
            this.диаграммаToolStripMenuItem.Name = "диаграммаToolStripMenuItem";
            this.диаграммаToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.диаграммаToolStripMenuItem.Text = "Диаграмма";
            // 
            // treeToolStripMenuItem
            // 
            this.treeToolStripMenuItem.Name = "treeToolStripMenuItem";
            this.treeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.tablesToolStripMenuItem.Text = "&Таблицы";
            // 
            // cattleToolStripMenuItem
            // 
            this.cattleToolStripMenuItem.Name = "cattleToolStripMenuItem";
            this.cattleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cattleToolStripMenuItem.Text = "Скот";
            this.cattleToolStripMenuItem.Click += new System.EventHandler(this.CattleToolStripMenuItem_Click);
            // 
            // apparatToolStripMenuItem
            // 
            this.apparatToolStripMenuItem.Name = "apparatToolStripMenuItem";
            this.apparatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apparatToolStripMenuItem.Text = "Аппараты";
            this.apparatToolStripMenuItem.Click += new System.EventHandler(this.ApparatToolStripMenuItem_Click);
            // 
            // analysisOfBloodToolStripMenuItem
            // 
            this.analysisOfBloodToolStripMenuItem.Name = "analysisOfBloodToolStripMenuItem";
            this.analysisOfBloodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.analysisOfBloodToolStripMenuItem.Text = "Анализы крови";
            this.analysisOfBloodToolStripMenuItem.Click += new System.EventHandler(this.AnalysisOfBloodToolStripMenuItem_Click);
            // 
            // lactationToolStripMenuItem
            // 
            this.lactationToolStripMenuItem.Name = "lactationToolStripMenuItem";
            this.lactationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lactationToolStripMenuItem.Text = "Лактации";
            this.lactationToolStripMenuItem.Click += new System.EventHandler(this.LactationToolStripMenuItem_Click);
            // 
            // reproductiveToolStripMenuItem
            // 
            this.reproductiveToolStripMenuItem.Name = "reproductiveToolStripMenuItem";
            this.reproductiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reproductiveToolStripMenuItem.Text = "Репродуктивность";
            this.reproductiveToolStripMenuItem.Click += new System.EventHandler(this.ReproductiveToolStripMenuItem_Click);
            // 
            // cattleBindingSource1
            // 
            this.cattleBindingSource1.DataMember = "Cattle";
            this.cattleBindingSource1.DataSource = this.uchot_udoevDataSet1;
            // 
            // uchot_udoevDataSet1
            // 
            this.uchot_udoevDataSet1.DataSetName = "Uchot_udoevDataSet1";
            this.uchot_udoevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cattleTableAdapter1
            // 
            this.cattleTableAdapter1.ClearBeforeFill = true;
            // 
            // apparatTableAdapter1
            // 
            this.apparatTableAdapter1.ClearBeforeFill = true;
            // 
            // lactationTableAdapter1
            // 
            this.lactationTableAdapter1.ClearBeforeFill = true;
            // 
            // analysis_of_bloodTableAdapter1
            // 
            this.analysis_of_bloodTableAdapter1.ClearBeforeFill = true;
            // 
            // reproductiveTableAdapter1
            // 
            this.reproductiveTableAdapter1.ClearBeforeFill = true;
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.aboutToolStripMenuItem.Text = "О программе...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cattle Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диаграммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cattleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apparatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisOfBloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lactationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproductiveToolStripMenuItem;

        //private System.Windows.Forms.BindingSource cattleBindingSource;
        private Uchot_udoevDataSet1 uchot_udoevDataSet1;
        private System.Windows.Forms.BindingSource cattleBindingSource1;
        private Uchot_udoevDataSet1TableAdapters.CattleTableAdapter cattleTableAdapter1;
        private Uchot_udoevDataSet1TableAdapters.ApparatTableAdapter apparatTableAdapter1;
        private Uchot_udoevDataSet1TableAdapters.LactationTableAdapter lactationTableAdapter1;
        private Uchot_udoevDataSet1TableAdapters.Analysis_of_bloodTableAdapter analysis_of_bloodTableAdapter1;
        private Uchot_udoevDataSet1TableAdapters.ReproductiveTableAdapter reproductiveTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

