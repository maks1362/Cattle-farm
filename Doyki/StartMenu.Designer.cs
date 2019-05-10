namespace Doyki
{
    partial class StartMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ErrorPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingBackgroundPanel = new System.Windows.Forms.Panel();
            this.loadingLinePanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loadingBackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.White;
            this.connectButton.FlatAppearance.BorderSize = 0;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(50, 400);
            this.connectButton.Margin = new System.Windows.Forms.Padding(0);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(300, 50);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Подключиться к БД";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connect_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(50, 210);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Племенные животные";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrorPictureBox
            // 
            this.ErrorPictureBox.Image = global::Doyki.Properties.Resources.error;
            this.ErrorPictureBox.Location = new System.Drawing.Point(175, 250);
            this.ErrorPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.ErrorPictureBox.Name = "ErrorPictureBox";
            this.ErrorPictureBox.Size = new System.Drawing.Size(50, 50);
            this.ErrorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ErrorPictureBox.TabIndex = 5;
            this.ErrorPictureBox.TabStop = false;
            this.ErrorPictureBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Doyki.Properties.Resources.cow_logo;
            this.pictureBox1.Location = new System.Drawing.Point(100, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadingBackgroundPanel
            // 
            this.loadingBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.loadingBackgroundPanel.Controls.Add(this.loadingLinePanel);
            this.loadingBackgroundPanel.Location = new System.Drawing.Point(50, 270);
            this.loadingBackgroundPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loadingBackgroundPanel.Name = "loadingBackgroundPanel";
            this.loadingBackgroundPanel.Size = new System.Drawing.Size(300, 10);
            this.loadingBackgroundPanel.TabIndex = 6;
            this.loadingBackgroundPanel.Visible = false;
            // 
            // loadingLinePanel
            // 
            this.loadingLinePanel.BackColor = System.Drawing.Color.OrangeRed;
            this.loadingLinePanel.Location = new System.Drawing.Point(220, 0);
            this.loadingLinePanel.Margin = new System.Windows.Forms.Padding(0);
            this.loadingLinePanel.Name = "loadingLinePanel";
            this.loadingLinePanel.Size = new System.Drawing.Size(80, 10);
            this.loadingLinePanel.TabIndex = 7;
            this.loadingLinePanel.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(50, 310);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(300, 90);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.close.BackgroundImage = global::Doyki.Properties.Resources.close_icon;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.SystemColors.Control;
            this.close.Location = new System.Drawing.Point(370, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.loadingBackgroundPanel);
            this.Controls.Add(this.ErrorPictureBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartMenu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loadingBackgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox ErrorPictureBox;
        private System.Windows.Forms.Panel loadingBackgroundPanel;
        private System.Windows.Forms.Panel loadingLinePanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button close;
    }
}