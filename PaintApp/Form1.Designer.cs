namespace PaintApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rectColorPicker = new System.Windows.Forms.ColorDialog();
            this.openSaveDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorPickerButton = new MaterialSkin.Controls.MaterialLabel();
            this.savePaintDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveBitmapDialog = new System.Windows.Forms.SaveFileDialog();
            this.disableGridLabel = new MaterialSkin.Controls.MaterialLabel();
            this.setDrawEllipseLabel = new MaterialSkin.Controls.MaterialLabel();
            this.saveFileLabel = new MaterialSkin.Controls.MaterialLabel();
            this.openFileLabel = new MaterialSkin.Controls.MaterialLabel();
            this.resetBoardLabel = new MaterialSkin.Controls.MaterialLabel();
            this.takePictureLabel = new MaterialSkin.Controls.MaterialLabel();
            this.drawBoard = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.hidetoolbarLabel = new System.Windows.Forms.Label();
            this.getColorLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.drawBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // openSaveDialog
            // 
            this.openSaveDialog.Filter = "PaintApp Files (*.pntapp)|*.pntapp";
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.AutoSize = true;
            this.colorPickerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton.Depth = 0;
            this.colorPickerButton.Font = new System.Drawing.Font("Roboto", 11F);
            this.colorPickerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorPickerButton.Location = new System.Drawing.Point(667, 75);
            this.colorPickerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.Size = new System.Drawing.Size(102, 19);
            this.colorPickerButton.TabIndex = 8;
            this.colorPickerButton.Text = "Choose Color";
            this.colorPickerButton.Click += new System.EventHandler(this.colorPickerButton_Click);
            // 
            // savePaintDialog
            // 
            this.savePaintDialog.DefaultExt = "pntapp";
            this.savePaintDialog.Filter = "PaintApp File(*.pntapp)|.pntapp";
            // 
            // saveBitmapDialog
            // 
            this.saveBitmapDialog.DefaultExt = "png";
            this.saveBitmapDialog.Filter = "PNG File (*.png)|.png";
            // 
            // disableGridLabel
            // 
            this.disableGridLabel.AutoSize = true;
            this.disableGridLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disableGridLabel.Depth = 0;
            this.disableGridLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.disableGridLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.disableGridLabel.Location = new System.Drawing.Point(667, 115);
            this.disableGridLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.disableGridLabel.Name = "disableGridLabel";
            this.disableGridLabel.Size = new System.Drawing.Size(90, 19);
            this.disableGridLabel.TabIndex = 2;
            this.disableGridLabel.Text = "Disable Grid";
            this.disableGridLabel.Click += new System.EventHandler(this.DisableGridLabel_Click);
            // 
            // setDrawEllipseLabel
            // 
            this.setDrawEllipseLabel.AutoSize = true;
            this.setDrawEllipseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setDrawEllipseLabel.Depth = 0;
            this.setDrawEllipseLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.setDrawEllipseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.setDrawEllipseLabel.Location = new System.Drawing.Point(667, 155);
            this.setDrawEllipseLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.setDrawEllipseLabel.Name = "setDrawEllipseLabel";
            this.setDrawEllipseLabel.Size = new System.Drawing.Size(62, 19);
            this.setDrawEllipseLabel.TabIndex = 3;
            this.setDrawEllipseLabel.Text = "Ellipses";
            this.setDrawEllipseLabel.Click += new System.EventHandler(this.setDrawEllipseLabel_Click);
            // 
            // saveFileLabel
            // 
            this.saveFileLabel.AutoSize = true;
            this.saveFileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFileLabel.Depth = 0;
            this.saveFileLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.saveFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveFileLabel.Location = new System.Drawing.Point(667, 654);
            this.saveFileLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveFileLabel.Name = "saveFileLabel";
            this.saveFileLabel.Size = new System.Drawing.Size(69, 19);
            this.saveFileLabel.TabIndex = 4;
            this.saveFileLabel.Text = "Save File";
            this.saveFileLabel.Click += new System.EventHandler(this.saveFileLabel_Click);
            // 
            // openFileLabel
            // 
            this.openFileLabel.AutoSize = true;
            this.openFileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileLabel.Depth = 0;
            this.openFileLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.openFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.openFileLabel.Location = new System.Drawing.Point(667, 694);
            this.openFileLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.openFileLabel.Name = "openFileLabel";
            this.openFileLabel.Size = new System.Drawing.Size(71, 19);
            this.openFileLabel.TabIndex = 5;
            this.openFileLabel.Text = "Open File";
            this.openFileLabel.Click += new System.EventHandler(this.openFileLabel_Click);
            // 
            // resetBoardLabel
            // 
            this.resetBoardLabel.AutoSize = true;
            this.resetBoardLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBoardLabel.Depth = 0;
            this.resetBoardLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.resetBoardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetBoardLabel.Location = new System.Drawing.Point(667, 534);
            this.resetBoardLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetBoardLabel.Name = "resetBoardLabel";
            this.resetBoardLabel.Size = new System.Drawing.Size(47, 19);
            this.resetBoardLabel.TabIndex = 6;
            this.resetBoardLabel.Text = "Reset";
            this.resetBoardLabel.Click += new System.EventHandler(this.resetBoardLabel_Click);
            // 
            // takePictureLabel
            // 
            this.takePictureLabel.AutoSize = true;
            this.takePictureLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.takePictureLabel.Depth = 0;
            this.takePictureLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.takePictureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.takePictureLabel.Location = new System.Drawing.Point(667, 574);
            this.takePictureLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.takePictureLabel.Name = "takePictureLabel";
            this.takePictureLabel.Size = new System.Drawing.Size(85, 19);
            this.takePictureLabel.TabIndex = 7;
            this.takePictureLabel.Text = "Screenshot";
            this.takePictureLabel.Click += new System.EventHandler(this.takePictureLabel_Click);
            // 
            // drawBoard
            // 
            this.drawBoard.BackColor = System.Drawing.Color.Transparent;
            this.drawBoard.Location = new System.Drawing.Point(8, 75);
            this.drawBoard.Name = "drawBoard";
            this.drawBoard.Size = new System.Drawing.Size(641, 641);
            this.drawBoard.TabIndex = 0;
            this.drawBoard.TabStop = false;
            this.drawBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBoard_Paint);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // hidetoolbarLabel
            // 
            this.hidetoolbarLabel.AutoSize = true;
            this.hidetoolbarLabel.BackColor = System.Drawing.Color.Transparent;
            this.hidetoolbarLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidetoolbarLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidetoolbarLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hidetoolbarLabel.Location = new System.Drawing.Point(762, 364);
            this.hidetoolbarLabel.Name = "hidetoolbarLabel";
            this.hidetoolbarLabel.Size = new System.Drawing.Size(21, 22);
            this.hidetoolbarLabel.TabIndex = 1;
            this.hidetoolbarLabel.Text = "<";
            this.hidetoolbarLabel.Click += new System.EventHandler(this.HidetoolbarLabel_Click);
            // 
            // getColorLabel
            // 
            this.getColorLabel.AutoSize = true;
            this.getColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getColorLabel.Depth = 0;
            this.getColorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.getColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.getColorLabel.Location = new System.Drawing.Point(667, 195);
            this.getColorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.getColorLabel.Name = "getColorLabel";
            this.getColorLabel.Size = new System.Drawing.Size(73, 19);
            this.getColorLabel.TabIndex = 9;
            this.getColorLabel.Text = "Get Color";
            this.getColorLabel.Click += new System.EventHandler(this.GetColorLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 729);
            this.Controls.Add(this.getColorLabel);
            this.Controls.Add(this.hidetoolbarLabel);
            this.Controls.Add(this.takePictureLabel);
            this.Controls.Add(this.resetBoardLabel);
            this.Controls.Add(this.openFileLabel);
            this.Controls.Add(this.saveFileLabel);
            this.Controls.Add(this.setDrawEllipseLabel);
            this.Controls.Add(this.disableGridLabel);
            this.Controls.Add(this.colorPickerButton);
            this.Controls.Add(this.drawBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.drawBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawBoard;
        private System.Windows.Forms.ColorDialog rectColorPicker;
        private System.Windows.Forms.OpenFileDialog openSaveDialog;
        private MaterialSkin.Controls.MaterialLabel colorPickerButton;
        private System.Windows.Forms.SaveFileDialog savePaintDialog;
        private System.Windows.Forms.SaveFileDialog saveBitmapDialog;
        private MaterialSkin.Controls.MaterialLabel disableGridLabel;
        private MaterialSkin.Controls.MaterialLabel setDrawEllipseLabel;
        private MaterialSkin.Controls.MaterialLabel saveFileLabel;
        private MaterialSkin.Controls.MaterialLabel openFileLabel;
        private MaterialSkin.Controls.MaterialLabel resetBoardLabel;
        private MaterialSkin.Controls.MaterialLabel takePictureLabel;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Label hidetoolbarLabel;
        private MaterialSkin.Controls.MaterialLabel getColorLabel;
    }
}

