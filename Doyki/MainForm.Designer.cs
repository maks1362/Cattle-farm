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
            this.fullScreenButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.plusWindowButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.ucTableCattle1 = new Doyki.UCTableCattle(this.uchot_udoevDataSet1.Cattle, this.cattleTableAdapter1);
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.fullScreenButton);
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
            // fullScreenButton
            // 
            this.fullScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fullScreenButton.BackgroundImage = global::Doyki.Properties.Resources.minim_icon;
            this.fullScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fullScreenButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.fullScreenButton.FlatAppearance.BorderSize = 0;
            this.fullScreenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.fullScreenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fullScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreenButton.ForeColor = System.Drawing.SystemColors.Control;
            this.fullScreenButton.Location = new System.Drawing.Point(910, 0);
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
            // ucTableCattle1
            // 
            this.ucTableCattle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTableCattle1.Location = new System.Drawing.Point(0, 30);
            this.ucTableCattle1.Name = "ucTableCattle1";
            this.ucTableCattle1.Size = new System.Drawing.Size(1000, 470);
            this.ucTableCattle1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.ucTableCattle1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "l";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cattleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchot_udoevDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
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
        protected System.Windows.Forms.Button minimizeButton;
        protected System.Windows.Forms.Button plusWindowButton;
        private UCTableCattle ucTableCattle1;
        protected System.Windows.Forms.Label nameLabel;
        protected System.Windows.Forms.Button fullScreenButton;
    }
}

