namespace PaintApp
{
    partial class MaterialMessageForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoBoxLabel = new System.Windows.Forms.Label();
            this.yesButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.noButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PaintApp.Properties.Resources.warning;
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // infoBoxLabel
            // 
            this.infoBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBoxLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infoBoxLabel.Location = new System.Drawing.Point(82, 85);
            this.infoBoxLabel.Name = "infoBoxLabel";
            this.infoBoxLabel.Size = new System.Drawing.Size(238, 64);
            this.infoBoxLabel.TabIndex = 1;
            this.infoBoxLabel.Text = "label1";
            this.infoBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yesButton.Depth = 0;
            this.yesButton.Icon = null;
            this.yesButton.Location = new System.Drawing.Point(216, 152);
            this.yesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.yesButton.Name = "yesButton";
            this.yesButton.Primary = true;
            this.yesButton.Size = new System.Drawing.Size(45, 36);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.noButton.Depth = 0;
            this.noButton.Icon = null;
            this.noButton.Location = new System.Drawing.Point(267, 152);
            this.noButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.noButton.Name = "noButton";
            this.noButton.Primary = true;
            this.noButton.Size = new System.Drawing.Size(40, 36);
            this.noButton.TabIndex = 3;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // MaterialMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 200);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.infoBoxLabel);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialMessageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaterialMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label infoBoxLabel;
        private MaterialSkin.Controls.MaterialRaisedButton yesButton;
        private MaterialSkin.Controls.MaterialRaisedButton noButton;
    }
}