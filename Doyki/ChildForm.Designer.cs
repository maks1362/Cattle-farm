namespace Doyki
{
    partial class ChildForm
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.BackgroundImage = global::Doyki.Properties.Resources.close_icon_b;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            // 
            // plusWindowButton
            // 
            this.plusWindowButton.BackColor = System.Drawing.Color.White;
            this.plusWindowButton.BackgroundImage = global::Doyki.Properties.Resources.plus_icon_b;
            this.plusWindowButton.FlatAppearance.BorderSize = 0;
            this.plusWindowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.plusWindowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            // 
            // fullScreenButton
            // 
            this.fullScreenButton.BackColor = System.Drawing.Color.White;
            this.fullScreenButton.BackgroundImage = global::Doyki.Properties.Resources.full_icon_b;
            this.fullScreenButton.FlatAppearance.BorderSize = 0;
            this.fullScreenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.fullScreenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.White;
            this.minimizeButton.BackgroundImage = global::Doyki.Properties.Resources.minim_icon_b;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Name = "ChildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
