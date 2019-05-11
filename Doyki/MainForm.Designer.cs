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
            this.nameLabel = new System.Windows.Forms.Label();
            this.plusWindowButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.delRowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cattleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apparatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisOfBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lactationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucTableCattle1 = new Doyki.UCTableCattle();
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
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.plusWindowButton);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 30);
            this.panel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(30, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(910, 30);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Выберите таблицу";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NameLabel_MouseMove);
            // 
            // plusWindowButton
            // 
            this.plusWindowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.plusWindowButton.BackgroundImage = global::Doyki.Properties.Resources.plus_icon;
            this.plusWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plusWindowButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.plusWindowButton.FlatAppearance.BorderSize = 0;
            this.plusWindowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.plusWindowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.plusWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusWindowButton.ForeColor = System.Drawing.SystemColors.Control;
            this.plusWindowButton.Location = new System.Drawing.Point(0, 0);
            this.plusWindowButton.Margin = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.plusWindowButton.Name = "plusWindowButton";
            this.plusWindowButton.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.plusWindowButton.Size = new System.Drawing.Size(30, 30);
            this.plusWindowButton.TabIndex = 4;
            this.plusWindowButton.UseVisualStyleBackColor = false;
            this.plusWindowButton.Click += new System.EventHandler(this.PlusWindowButton_Click);
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
            this.minimizeButton.Location = new System.Drawing.Point(940, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
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
            this.closeButton.Location = new System.Drawing.Point(970, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowToolStripMenuItem,
            this.диаграммаToolStripMenuItem,
            this.tablesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(88, 470);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rowToolStripMenuItem
            // 
            this.rowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToolStripMenuItem1,
            this.delRowToolStripMenuItem1});
            this.rowToolStripMenuItem.Name = "rowToolStripMenuItem";
            this.rowToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
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
            // диаграммаToolStripMenuItem
            // 
            this.диаграммаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeToolStripMenuItem});
            this.диаграммаToolStripMenuItem.Name = "диаграммаToolStripMenuItem";
            this.диаграммаToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
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
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
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
            // 
            // analysisOfBloodToolStripMenuItem
            // 
            this.analysisOfBloodToolStripMenuItem.Name = "analysisOfBloodToolStripMenuItem";
            this.analysisOfBloodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.analysisOfBloodToolStripMenuItem.Text = "Анализы крови";
            // 
            // lactationToolStripMenuItem
            // 
            this.lactationToolStripMenuItem.Name = "lactationToolStripMenuItem";
            this.lactationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lactationToolStripMenuItem.Text = "Лактации";
            // 
            // reproductiveToolStripMenuItem
            // 
            this.reproductiveToolStripMenuItem.Name = "reproductiveToolStripMenuItem";
            this.reproductiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reproductiveToolStripMenuItem.Text = "Репродуктивность";
            // 
            // ucTableCattle1
            // 
            this.ucTableCattle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTableCattle1.Location = new System.Drawing.Point(88, 30);
            this.ucTableCattle1.Name = "ucTableCattle1";
            this.ucTableCattle1.Size = new System.Drawing.Size(912, 470);
            this.ucTableCattle1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.ucTableCattle1);
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
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
        protected System.Windows.Forms.Button closeButton;
        protected System.Windows.Forms.Button minimizeButton;
        protected System.Windows.Forms.Button plusWindowButton;
        private UCTableCattle ucTableCattle1;
        protected System.Windows.Forms.Label nameLabel;
    }
}

