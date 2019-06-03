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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cattleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uchot_udoevDataSet1 = new Doyki.Uchot_udoevDataSet1();
            this.cattleTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.CattleTableAdapter();
            this.apparatTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.ApparatTableAdapter();
            this.lactationTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.LactationTableAdapter();
            this.analysis_of_bloodTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.Analysis_of_bloodTableAdapter();
            this.reproductiveTableAdapter1 = new Doyki.Uchot_udoevDataSet1TableAdapters.ReproductiveTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.fullScreenButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.plusWindowButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CattleButton = new System.Windows.Forms.Button();
            this.AnalysOfBloodButton = new System.Windows.Forms.Button();
            this.LactationButton = new System.Windows.Forms.Button();
            this.ApparatButton = new System.Windows.Forms.Button();
            this.ReproductiveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.fullScreenButton);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.plusWindowButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 30);
            this.panel1.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.minimizeButton.BackgroundImage = global::Doyki.Properties.Resources.minim_icon;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeButton.Location = new System.Drawing.Point(910, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.TabIndex = 8;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // fullScreenButton
            // 
            this.fullScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fullScreenButton.BackgroundImage = global::Doyki.Properties.Resources.full_icon;
            this.fullScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fullScreenButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.fullScreenButton.FlatAppearance.BorderSize = 0;
            this.fullScreenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.fullScreenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fullScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreenButton.ForeColor = System.Drawing.SystemColors.Control;
            this.fullScreenButton.Location = new System.Drawing.Point(940, 0);
            this.fullScreenButton.Margin = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.fullScreenButton.Name = "fullScreenButton";
            this.fullScreenButton.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.fullScreenButton.Size = new System.Drawing.Size(30, 30);
            this.fullScreenButton.TabIndex = 7;
            this.fullScreenButton.UseVisualStyleBackColor = false;
            this.fullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(30, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(940, 30);
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
            this.plusWindowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
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
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.closeButton.BackgroundImage = global::Doyki.Properties.Resources.close_icon;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.CattleButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AnalysOfBloodButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LactationButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ApparatButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReproductiveButton, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 467);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.VisibleChanged += new System.EventHandler(this.TableLayoutPanel1_VisibleChanged);
            // 
            // CattleButton
            // 
            this.CattleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CattleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CattleButton.FlatAppearance.BorderSize = 0;
            this.CattleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.CattleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CattleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CattleButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CattleButton.ForeColor = System.Drawing.Color.White;
            this.CattleButton.Location = new System.Drawing.Point(3, 3);
            this.CattleButton.Name = "CattleButton";
            this.CattleButton.Size = new System.Drawing.Size(994, 87);
            this.CattleButton.TabIndex = 0;
            this.CattleButton.Text = "Скот";
            this.CattleButton.UseVisualStyleBackColor = false;
            this.CattleButton.Click += new System.EventHandler(this.CattleButton_Click);
            // 
            // AnalysOfBloodButton
            // 
            this.AnalysOfBloodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AnalysOfBloodButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnalysOfBloodButton.FlatAppearance.BorderSize = 0;
            this.AnalysOfBloodButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.AnalysOfBloodButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AnalysOfBloodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalysOfBloodButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalysOfBloodButton.ForeColor = System.Drawing.Color.White;
            this.AnalysOfBloodButton.Location = new System.Drawing.Point(3, 96);
            this.AnalysOfBloodButton.Name = "AnalysOfBloodButton";
            this.AnalysOfBloodButton.Size = new System.Drawing.Size(994, 87);
            this.AnalysOfBloodButton.TabIndex = 1;
            this.AnalysOfBloodButton.Text = "Анализ крови";
            this.AnalysOfBloodButton.UseVisualStyleBackColor = false;
            this.AnalysOfBloodButton.Click += new System.EventHandler(this.AnalysOfBloodButton_Click);
            // 
            // LactationButton
            // 
            this.LactationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LactationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LactationButton.FlatAppearance.BorderSize = 0;
            this.LactationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.LactationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.LactationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LactationButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LactationButton.ForeColor = System.Drawing.Color.White;
            this.LactationButton.Location = new System.Drawing.Point(3, 189);
            this.LactationButton.Name = "LactationButton";
            this.LactationButton.Size = new System.Drawing.Size(994, 87);
            this.LactationButton.TabIndex = 2;
            this.LactationButton.Text = "Лактация";
            this.LactationButton.UseVisualStyleBackColor = false;
            this.LactationButton.Click += new System.EventHandler(this.LactationButton_Click);
            // 
            // ApparatButton
            // 
            this.ApparatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ApparatButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApparatButton.FlatAppearance.BorderSize = 0;
            this.ApparatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.ApparatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ApparatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApparatButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApparatButton.ForeColor = System.Drawing.Color.White;
            this.ApparatButton.Location = new System.Drawing.Point(3, 282);
            this.ApparatButton.Name = "ApparatButton";
            this.ApparatButton.Size = new System.Drawing.Size(994, 87);
            this.ApparatButton.TabIndex = 3;
            this.ApparatButton.Text = "Доильный аппарат";
            this.ApparatButton.UseVisualStyleBackColor = false;
            this.ApparatButton.Click += new System.EventHandler(this.ApparatButton_Click);
            // 
            // ReproductiveButton
            // 
            this.ReproductiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ReproductiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReproductiveButton.FlatAppearance.BorderSize = 0;
            this.ReproductiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.ReproductiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ReproductiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReproductiveButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReproductiveButton.ForeColor = System.Drawing.Color.White;
            this.ReproductiveButton.Location = new System.Drawing.Point(3, 375);
            this.ReproductiveButton.Name = "ReproductiveButton";
            this.ReproductiveButton.Size = new System.Drawing.Size(994, 89);
            this.ReproductiveButton.TabIndex = 4;
            this.ReproductiveButton.Text = "Репродуктивность";
            this.ReproductiveButton.UseVisualStyleBackColor = false;
            this.ReproductiveButton.Click += new System.EventHandler(this.ReproductiveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите таблицу";
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        protected System.Windows.Forms.Button closeButton;
        protected System.Windows.Forms.Button plusWindowButton;
        protected System.Windows.Forms.Label nameLabel;
        protected System.Windows.Forms.Button fullScreenButton;
        protected System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button CattleButton;
        private System.Windows.Forms.Button LactationButton;
        private System.Windows.Forms.Button ApparatButton;
        private System.Windows.Forms.Button ReproductiveButton;
        private System.Windows.Forms.Button AnalysOfBloodButton;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

