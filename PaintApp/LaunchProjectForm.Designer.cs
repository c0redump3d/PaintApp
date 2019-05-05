namespace PaintApp
{
    partial class LaunchProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaunchProjectForm));
            this.label1 = new System.Windows.Forms.Label();
            this.openExistingButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.createNewProjectButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.createNewDialog = new System.Windows.Forms.SaveFileDialog();
            this.openExistingDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create or Open an existing project.";
            // 
            // openExistingButton
            // 
            this.openExistingButton.AutoSize = true;
            this.openExistingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openExistingButton.Depth = 0;
            this.openExistingButton.Icon = null;
            this.openExistingButton.Location = new System.Drawing.Point(148, 142);
            this.openExistingButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.openExistingButton.Name = "openExistingButton";
            this.openExistingButton.Primary = true;
            this.openExistingButton.Size = new System.Drawing.Size(120, 36);
            this.openExistingButton.TabIndex = 1;
            this.openExistingButton.Text = "Open Project";
            this.openExistingButton.UseVisualStyleBackColor = true;
            this.openExistingButton.Click += new System.EventHandler(this.OpenExistingButton_Click);
            // 
            // createNewProjectButton
            // 
            this.createNewProjectButton.AutoSize = true;
            this.createNewProjectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createNewProjectButton.Depth = 0;
            this.createNewProjectButton.Icon = null;
            this.createNewProjectButton.Location = new System.Drawing.Point(12, 142);
            this.createNewProjectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.createNewProjectButton.Name = "createNewProjectButton";
            this.createNewProjectButton.Primary = true;
            this.createNewProjectButton.Size = new System.Drawing.Size(113, 36);
            this.createNewProjectButton.TabIndex = 2;
            this.createNewProjectButton.Text = "New Project";
            this.createNewProjectButton.UseVisualStyleBackColor = true;
            this.createNewProjectButton.Click += new System.EventHandler(this.CreateNewProjectButton_Click);
            // 
            // createNewDialog
            // 
            this.createNewDialog.DefaultExt = "pntapp";
            this.createNewDialog.Filter = "PaintApp Files (*.pntapp)|*.pntapp";
            this.createNewDialog.Title = "New Project";
            // 
            // openExistingDialog
            // 
            this.openExistingDialog.Filter = "PaintApp Files (*.pntapp)|*.pntapp";
            this.openExistingDialog.Title = "Open Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(2, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome.";
            // 
            // LaunchProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 190);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createNewProjectButton);
            this.Controls.Add(this.openExistingButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LaunchProjectForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launch Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton openExistingButton;
        private MaterialSkin.Controls.MaterialRaisedButton createNewProjectButton;
        private System.Windows.Forms.SaveFileDialog createNewDialog;
        private System.Windows.Forms.OpenFileDialog openExistingDialog;
        private System.Windows.Forms.Label label2;
    }
}