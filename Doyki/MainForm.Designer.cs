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
            this.cattleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uchot_udoevDataSet1 = new Doyki.Uchot_udoevDataSet1();
            this.cattleTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.CattleTableAdapter();
            this.apparatTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.ApparatTableAdapter();
            this.lactationTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.LactationTableAdapter();
            this.analysis_of_bloodTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.Analysis_of_bloodTableAdapter();
            this.reproductiveTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.ReproductiveTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.диаграммаToolStripMenuItem,
            this.tablesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
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
            this.treeToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
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
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tablesToolStripMenuItem.Text = "&Таблицы";
            // 
            // cattleToolStripMenuItem
            // 
            this.cattleToolStripMenuItem.Name = "cattleToolStripMenuItem";
            this.cattleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cattleToolStripMenuItem.Text = "Скот";
            // 
            // apparatToolStripMenuItem
            // 
            this.apparatToolStripMenuItem.Name = "apparatToolStripMenuItem";
            this.apparatToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.apparatToolStripMenuItem.Text = "Аппараты";
            // 
            // analysisOfBloodToolStripMenuItem
            // 
            this.analysisOfBloodToolStripMenuItem.Name = "analysisOfBloodToolStripMenuItem";
            this.analysisOfBloodToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.analysisOfBloodToolStripMenuItem.Text = "Анализы крови";
            // 
            // lactationToolStripMenuItem
            // 
            this.lactationToolStripMenuItem.Name = "lactationToolStripMenuItem";
            this.lactationToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.lactationToolStripMenuItem.Text = "Лактации";
            // 
            // reproductiveToolStripMenuItem
            // 
            this.reproductiveToolStripMenuItem.Name = "reproductiveToolStripMenuItem";
            this.reproductiveToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.reproductiveToolStripMenuItem.Text = "Репродуктивность";
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.minimizeButton.BackgroundImage = global::Doyki.Properties.Resources.minim_icon;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeButton.Location = new System.Drawing.Point(740, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.closeButton.BackgroundImage = global::Doyki.Properties.Resources.close_icon;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(770, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "l";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.BindingSource cattleBindingSource;
        private Uchot_udoevDataSet1 uchot_udoevDataSet1;
        private System.Windows.Forms.BindingSource cattleBindingSource1;
        private Uchot_udoevDataSet1TableAdapters.CattleTableAdapter cattleTableAdapter1;
        private Uchot_udoevDataSet1TableAdapters.ApparatTableAdapter apparatTableAdapter1;
        private Uchot_udoevDataSet1TableAdapters.LactationTableAdapter lactationTableAdapter1;
        private Uchot_udoevDataSet1TableAdapters.Analysis_of_bloodTableAdapter analysis_of_bloodTableAdapter1;
        private Uchot_udoevDataSet1TableAdapters.ReproductiveTableAdapter reproductiveTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem delRowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диаграммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cattleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apparatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisOfBloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lactationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproductiveToolStripMenuItem;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
    }
}

