namespace PaintApp
{
    partial class FirstStartTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstStartTutorial));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolbarTutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.disableGridTutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.resetTutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveFileTutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.colorTutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureTutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.openFileTutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.squareTutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tutInfoLabel = new System.Windows.Forms.Label();
            this.controlsTutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tutPicBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.tutPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "It seems like it\'s your first time launching PaintApp.\r\nNo idea how to use the ap" +
    "plication? No worries! \r\nWe have you covered. Take a look at some of the tutoria" +
    "ls below.";
            // 
            // toolbarTutButton
            // 
            this.toolbarTutButton.AutoSize = true;
            this.toolbarTutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolbarTutButton.Depth = 0;
            this.toolbarTutButton.Icon = null;
            this.toolbarTutButton.Location = new System.Drawing.Point(23, 444);
            this.toolbarTutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.toolbarTutButton.Name = "toolbarTutButton";
            this.toolbarTutButton.Primary = true;
            this.toolbarTutButton.Size = new System.Drawing.Size(161, 36);
            this.toolbarTutButton.TabIndex = 11;
            this.toolbarTutButton.Text = "Show/Hide Toolbar";
            this.toolbarTutButton.UseVisualStyleBackColor = true;
            this.toolbarTutButton.Click += new System.EventHandler(this.toolbarTutButton_Click);
            // 
            // disableGridTutButton
            // 
            this.disableGridTutButton.AutoSize = true;
            this.disableGridTutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.disableGridTutButton.Depth = 0;
            this.disableGridTutButton.Icon = null;
            this.disableGridTutButton.Location = new System.Drawing.Point(190, 444);
            this.disableGridTutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.disableGridTutButton.Name = "disableGridTutButton";
            this.disableGridTutButton.Primary = true;
            this.disableGridTutButton.Size = new System.Drawing.Size(109, 36);
            this.disableGridTutButton.TabIndex = 12;
            this.disableGridTutButton.Text = "Disable Grid";
            this.disableGridTutButton.UseVisualStyleBackColor = true;
            this.disableGridTutButton.Click += new System.EventHandler(this.DisableGridTutButton_Click);
            // 
            // resetTutButton
            // 
            this.resetTutButton.AutoSize = true;
            this.resetTutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetTutButton.Depth = 0;
            this.resetTutButton.Icon = null;
            this.resetTutButton.Location = new System.Drawing.Point(305, 444);
            this.resetTutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetTutButton.Name = "resetTutButton";
            this.resetTutButton.Primary = true;
            this.resetTutButton.Size = new System.Drawing.Size(110, 36);
            this.resetTutButton.TabIndex = 13;
            this.resetTutButton.Text = "Reset Board";
            this.resetTutButton.UseVisualStyleBackColor = true;
            this.resetTutButton.Click += new System.EventHandler(this.ResetTutButton_Click);
            // 
            // saveFileTutButton
            // 
            this.saveFileTutButton.AutoSize = true;
            this.saveFileTutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveFileTutButton.Depth = 0;
            this.saveFileTutButton.Icon = null;
            this.saveFileTutButton.Location = new System.Drawing.Point(25, 498);
            this.saveFileTutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveFileTutButton.Name = "saveFileTutButton";
            this.saveFileTutButton.Primary = true;
            this.saveFileTutButton.Size = new System.Drawing.Size(85, 36);
            this.saveFileTutButton.TabIndex = 14;
            this.saveFileTutButton.Text = "Save File";
            this.saveFileTutButton.UseVisualStyleBackColor = true;
            this.saveFileTutButton.Click += new System.EventHandler(this.SaveFileTutButton_Click);
            // 
            // colorTutButton
            // 
            this.colorTutButton.AutoSize = true;
            this.colorTutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorTutButton.Depth = 0;
            this.colorTutButton.Icon = null;
            this.colorTutButton.Location = new System.Drawing.Point(116, 498);
            this.colorTutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorTutButton.Name = "colorTutButton";
            this.colorTutButton.Primary = true;
            this.colorTutButton.Size = new System.Drawing.Size(93, 36);
            this.colorTutButton.TabIndex = 15;
            this.colorTutButton.Text = "Set Color";
            this.colorTutButton.UseVisualStyleBackColor = true;
            this.colorTutButton.Click += new System.EventHandler(this.ColorTutButton_Click);
            // 
            // pictureTutButton
            // 
            this.pictureTutButton.AutoSize = true;
            this.pictureTutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pictureTutButton.Depth = 0;
            this.pictureTutButton.Icon = null;
            this.pictureTutButton.Location = new System.Drawing.Point(215, 498);
            this.pictureTutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pictureTutButton.Name = "pictureTutButton";
            this.pictureTutButton.Primary = true;
            this.pictureTutButton.Size = new System.Drawing.Size(135, 36);
            this.pictureTutButton.TabIndex = 16;
            this.pictureTutButton.Text = "Save as Picture";
            this.pictureTutButton.UseVisualStyleBackColor = true;
            this.pictureTutButton.Click += new System.EventHandler(this.PictureTutButton_Click);
            // 
            // openFileTutButton
            // 
            this.openFileTutButton.AutoSize = true;
            this.openFileTutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openFileTutButton.Depth = 0;
            this.openFileTutButton.Icon = null;
            this.openFileTutButton.Location = new System.Drawing.Point(25, 554);
            this.openFileTutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.openFileTutButton.Name = "openFileTutButton";
            this.openFileTutButton.Primary = true;
            this.openFileTutButton.Size = new System.Drawing.Size(87, 36);
            this.openFileTutButton.TabIndex = 17;
            this.openFileTutButton.Text = "Open File";
            this.openFileTutButton.UseVisualStyleBackColor = true;
            this.openFileTutButton.Click += new System.EventHandler(this.OpenFileTutButton_Click);
            // 
            // squareTutButton
            // 
            this.squareTutButton.AutoSize = true;
            this.squareTutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.squareTutButton.Depth = 0;
            this.squareTutButton.Icon = null;
            this.squareTutButton.Location = new System.Drawing.Point(118, 554);
            this.squareTutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.squareTutButton.Name = "squareTutButton";
            this.squareTutButton.Primary = true;
            this.squareTutButton.Size = new System.Drawing.Size(146, 36);
            this.squareTutButton.TabIndex = 18;
            this.squareTutButton.Text = "Squares/Ellipses";
            this.squareTutButton.UseVisualStyleBackColor = true;
            this.squareTutButton.Click += new System.EventHandler(this.SquareTutButton_Click);
            // 
            // tutInfoLabel
            // 
            this.tutInfoLabel.AutoSize = true;
            this.tutInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.tutInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutInfoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tutInfoLabel.Location = new System.Drawing.Point(220, 283);
            this.tutInfoLabel.Name = "tutInfoLabel";
            this.tutInfoLabel.Size = new System.Drawing.Size(252, 85);
            this.tutInfoLabel.TabIndex = 19;
            this.tutInfoLabel.Text = "PaintApp allows you to hide the toolbar.\r\nTo hide the toolbar all you have to do " +
    "is\r\nclick the \"<\" on the far right of the screen.\r\nTo show the toolbar again, si" +
    "mply press \r\nthe \">\" button.";
            // 
            // controlsTutButton
            // 
            this.controlsTutButton.AutoSize = true;
            this.controlsTutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlsTutButton.Depth = 0;
            this.controlsTutButton.Icon = null;
            this.controlsTutButton.Location = new System.Drawing.Point(270, 554);
            this.controlsTutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.controlsTutButton.Name = "controlsTutButton";
            this.controlsTutButton.Primary = true;
            this.controlsTutButton.Size = new System.Drawing.Size(91, 36);
            this.controlsTutButton.TabIndex = 20;
            this.controlsTutButton.Text = "Controls";
            this.controlsTutButton.UseVisualStyleBackColor = true;
            this.controlsTutButton.Click += new System.EventHandler(this.ControlsTutButton_Click);
            // 
            // tutPicBox
            // 
            this.tutPicBox.Image = ((System.Drawing.Image)(resources.GetObject("tutPicBox.Image")));
            this.tutPicBox.Location = new System.Drawing.Point(23, 240);
            this.tutPicBox.Name = "tutPicBox";
            this.tutPicBox.Size = new System.Drawing.Size(185, 176);
            this.tutPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tutPicBox.TabIndex = 2;
            this.tutPicBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Depth = 0;
            this.closeButton.Icon = null;
            this.closeButton.Location = new System.Drawing.Point(404, 582);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = true;
            this.closeButton.Size = new System.Drawing.Size(63, 36);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FirstStartTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 630);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.controlsTutButton);
            this.Controls.Add(this.tutInfoLabel);
            this.Controls.Add(this.squareTutButton);
            this.Controls.Add(this.openFileTutButton);
            this.Controls.Add(this.pictureTutButton);
            this.Controls.Add(this.colorTutButton);
            this.Controls.Add(this.saveFileTutButton);
            this.Controls.Add(this.resetTutButton);
            this.Controls.Add(this.disableGridTutButton);
            this.Controls.Add(this.toolbarTutButton);
            this.Controls.Add(this.tutPicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstStartTutorial";
            this.Sizable = false;
            this.Text = "Tutorial";
            ((System.ComponentModel.ISupportInitialize)(this.tutPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox tutPicBox;
        private MaterialSkin.Controls.MaterialRaisedButton toolbarTutButton;
        private MaterialSkin.Controls.MaterialRaisedButton disableGridTutButton;
        private MaterialSkin.Controls.MaterialRaisedButton resetTutButton;
        private MaterialSkin.Controls.MaterialRaisedButton saveFileTutButton;
        private MaterialSkin.Controls.MaterialRaisedButton colorTutButton;
        private MaterialSkin.Controls.MaterialRaisedButton pictureTutButton;
        private MaterialSkin.Controls.MaterialRaisedButton openFileTutButton;
        private MaterialSkin.Controls.MaterialRaisedButton squareTutButton;
        private System.Windows.Forms.Label tutInfoLabel;
        private MaterialSkin.Controls.MaterialRaisedButton controlsTutButton;
        private MaterialSkin.Controls.MaterialRaisedButton closeButton;
    }
}