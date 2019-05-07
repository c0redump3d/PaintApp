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
            this.closeProjectLabel = new MaterialSkin.Controls.MaterialLabel();
            this.resetBoardLabel = new MaterialSkin.Controls.MaterialLabel();
            this.takePictureLabel = new MaterialSkin.Controls.MaterialLabel();
            this.drawBoard = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.hidetoolbarLabel = new System.Windows.Forms.Label();
            this.getColorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.removeColorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fillColorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.helpLabel = new MaterialSkin.Controls.MaterialLabel();
            this.colorBoxWhite = new System.Windows.Forms.PictureBox();
            this.colorBoxRed = new System.Windows.Forms.PictureBox();
            this.colorBoxOrange = new System.Windows.Forms.PictureBox();
            this.colorBoxYellow = new System.Windows.Forms.PictureBox();
            this.colorBoxGreen = new System.Windows.Forms.PictureBox();
            this.colorBoxAqua = new System.Windows.Forms.PictureBox();
            this.colorBoxBlue = new System.Windows.Forms.PictureBox();
            this.colorBoxBlack = new System.Windows.Forms.PictureBox();
            this.autoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.saveAsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.smallLayoutLabel = new MaterialSkin.Controls.MaterialLabel();
            this.titleUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drawBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxAqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // rectColorPicker
            // 
            this.rectColorPicker.AnyColor = true;
            this.rectColorPicker.FullOpen = true;
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
            this.colorPickerButton.Location = new System.Drawing.Point(667, 125);
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
            this.savePaintDialog.Filter = "PaintApp Files (*.pntapp)|*.pntapp";
            this.savePaintDialog.Title = "Save Drawing";
            // 
            // saveBitmapDialog
            // 
            this.saveBitmapDialog.DefaultExt = "png";
            this.saveBitmapDialog.Filter = "PNG File (*.png)|*.png";
            this.saveBitmapDialog.Title = "Save as Picture";
            // 
            // disableGridLabel
            // 
            this.disableGridLabel.AutoSize = true;
            this.disableGridLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disableGridLabel.Depth = 0;
            this.disableGridLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.disableGridLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.disableGridLabel.Location = new System.Drawing.Point(667, 155);
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
            this.setDrawEllipseLabel.Location = new System.Drawing.Point(667, 185);
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
            this.saveFileLabel.Location = new System.Drawing.Point(667, 483);
            this.saveFileLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveFileLabel.Name = "saveFileLabel";
            this.saveFileLabel.Size = new System.Drawing.Size(41, 19);
            this.saveFileLabel.TabIndex = 4;
            this.saveFileLabel.Text = "Save";
            this.saveFileLabel.Click += new System.EventHandler(this.saveFileLabel_Click);
            // 
            // closeProjectLabel
            // 
            this.closeProjectLabel.AutoSize = true;
            this.closeProjectLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeProjectLabel.Depth = 0;
            this.closeProjectLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.closeProjectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeProjectLabel.Location = new System.Drawing.Point(667, 602);
            this.closeProjectLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeProjectLabel.Name = "closeProjectLabel";
            this.closeProjectLabel.Size = new System.Drawing.Size(100, 19);
            this.closeProjectLabel.TabIndex = 5;
            this.closeProjectLabel.Text = "Close Project";
            this.closeProjectLabel.Click += new System.EventHandler(this.closeProjectLabel_Click);
            // 
            // resetBoardLabel
            // 
            this.resetBoardLabel.AutoSize = true;
            this.resetBoardLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBoardLabel.Depth = 0;
            this.resetBoardLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.resetBoardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetBoardLabel.Location = new System.Drawing.Point(667, 423);
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
            this.takePictureLabel.Location = new System.Drawing.Point(667, 453);
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
            this.drawBoard.Click += new System.EventHandler(this.DrawBoard_Click);
            this.drawBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBoard_Paint);
            this.drawBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawBoard_MouseDown);
            this.drawBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawBoard_MouseMove);
            this.drawBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawBoard_MouseUp);
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
            this.getColorLabel.Location = new System.Drawing.Point(667, 215);
            this.getColorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.getColorLabel.Name = "getColorLabel";
            this.getColorLabel.Size = new System.Drawing.Size(73, 19);
            this.getColorLabel.TabIndex = 9;
            this.getColorLabel.Text = "Get Color";
            this.getColorLabel.Click += new System.EventHandler(this.GetColorLabel_Click);
            // 
            // removeColorLabel
            // 
            this.removeColorLabel.AutoSize = true;
            this.removeColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeColorLabel.Depth = 0;
            this.removeColorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.removeColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeColorLabel.Location = new System.Drawing.Point(667, 275);
            this.removeColorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeColorLabel.Name = "removeColorLabel";
            this.removeColorLabel.Size = new System.Drawing.Size(104, 19);
            this.removeColorLabel.TabIndex = 10;
            this.removeColorLabel.Text = "Remove Color";
            this.removeColorLabel.Click += new System.EventHandler(this.RemoveColorLabel_Click);
            // 
            // fillColorLabel
            // 
            this.fillColorLabel.AutoSize = true;
            this.fillColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fillColorLabel.Depth = 0;
            this.fillColorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fillColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fillColorLabel.Location = new System.Drawing.Point(667, 245);
            this.fillColorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fillColorLabel.Name = "fillColorLabel";
            this.fillColorLabel.Size = new System.Drawing.Size(70, 19);
            this.fillColorLabel.TabIndex = 11;
            this.fillColorLabel.Text = "Fill Color";
            this.fillColorLabel.Click += new System.EventHandler(this.FillColorLabel_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpLabel.Depth = 0;
            this.helpLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.helpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.helpLabel.Location = new System.Drawing.Point(667, 694);
            this.helpLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(40, 19);
            this.helpLabel.TabIndex = 12;
            this.helpLabel.Text = "Help";
            this.helpLabel.Click += new System.EventHandler(this.HelpLabel_Click);
            // 
            // colorBoxWhite
            // 
            this.colorBoxWhite.BackColor = System.Drawing.Color.White;
            this.colorBoxWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBoxWhite.Location = new System.Drawing.Point(673, 75);
            this.colorBoxWhite.Name = "colorBoxWhite";
            this.colorBoxWhite.Size = new System.Drawing.Size(18, 18);
            this.colorBoxWhite.TabIndex = 13;
            this.colorBoxWhite.TabStop = false;
            this.colorBoxWhite.Click += new System.EventHandler(this.ColorBoxWhite_Click);
            // 
            // colorBoxRed
            // 
            this.colorBoxRed.BackColor = System.Drawing.Color.Red;
            this.colorBoxRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBoxRed.Location = new System.Drawing.Point(721, 75);
            this.colorBoxRed.Name = "colorBoxRed";
            this.colorBoxRed.Size = new System.Drawing.Size(18, 18);
            this.colorBoxRed.TabIndex = 14;
            this.colorBoxRed.TabStop = false;
            this.colorBoxRed.Click += new System.EventHandler(this.ColorBoxRed_Click);
            // 
            // colorBoxOrange
            // 
            this.colorBoxOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorBoxOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBoxOrange.Location = new System.Drawing.Point(745, 75);
            this.colorBoxOrange.Name = "colorBoxOrange";
            this.colorBoxOrange.Size = new System.Drawing.Size(18, 18);
            this.colorBoxOrange.TabIndex = 15;
            this.colorBoxOrange.TabStop = false;
            this.colorBoxOrange.Click += new System.EventHandler(this.ColorBoxOrange_Click);
            // 
            // colorBoxYellow
            // 
            this.colorBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.colorBoxYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBoxYellow.Location = new System.Drawing.Point(673, 99);
            this.colorBoxYellow.Name = "colorBoxYellow";
            this.colorBoxYellow.Size = new System.Drawing.Size(18, 18);
            this.colorBoxYellow.TabIndex = 16;
            this.colorBoxYellow.TabStop = false;
            this.colorBoxYellow.Click += new System.EventHandler(this.ColorBoxYellow_Click);
            // 
            // colorBoxGreen
            // 
            this.colorBoxGreen.BackColor = System.Drawing.Color.Green;
            this.colorBoxGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBoxGreen.Location = new System.Drawing.Point(697, 99);
            this.colorBoxGreen.Name = "colorBoxGreen";
            this.colorBoxGreen.Size = new System.Drawing.Size(18, 18);
            this.colorBoxGreen.TabIndex = 17;
            this.colorBoxGreen.TabStop = false;
            this.colorBoxGreen.Click += new System.EventHandler(this.ColorBoxGreen_Click);
            // 
            // colorBoxAqua
            // 
            this.colorBoxAqua.BackColor = System.Drawing.Color.Aqua;
            this.colorBoxAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxAqua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBoxAqua.Location = new System.Drawing.Point(721, 99);
            this.colorBoxAqua.Name = "colorBoxAqua";
            this.colorBoxAqua.Size = new System.Drawing.Size(18, 18);
            this.colorBoxAqua.TabIndex = 18;
            this.colorBoxAqua.TabStop = false;
            this.colorBoxAqua.Click += new System.EventHandler(this.ColorBoxAqua_Click);
            // 
            // colorBoxBlue
            // 
            this.colorBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.colorBoxBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBoxBlue.Location = new System.Drawing.Point(745, 99);
            this.colorBoxBlue.Name = "colorBoxBlue";
            this.colorBoxBlue.Size = new System.Drawing.Size(18, 18);
            this.colorBoxBlue.TabIndex = 19;
            this.colorBoxBlue.TabStop = false;
            this.colorBoxBlue.Click += new System.EventHandler(this.ColorBoxBlue_Click);
            // 
            // colorBoxBlack
            // 
            this.colorBoxBlack.BackColor = System.Drawing.Color.Black;
            this.colorBoxBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBoxBlack.Location = new System.Drawing.Point(697, 75);
            this.colorBoxBlack.Name = "colorBoxBlack";
            this.colorBoxBlack.Size = new System.Drawing.Size(18, 18);
            this.colorBoxBlack.TabIndex = 20;
            this.colorBoxBlack.TabStop = false;
            this.colorBoxBlack.Click += new System.EventHandler(this.ColorBoxBlack_Click);
            // 
            // autoSaveTimer
            // 
            this.autoSaveTimer.Interval = 300000;
            this.autoSaveTimer.Tick += new System.EventHandler(this.AutoSaveTimer_Tick);
            // 
            // saveAsLabel
            // 
            this.saveAsLabel.AutoSize = true;
            this.saveAsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAsLabel.Depth = 0;
            this.saveAsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.saveAsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveAsLabel.Location = new System.Drawing.Point(667, 513);
            this.saveAsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveAsLabel.Name = "saveAsLabel";
            this.saveAsLabel.Size = new System.Drawing.Size(63, 19);
            this.saveAsLabel.TabIndex = 21;
            this.saveAsLabel.Text = "Save As";
            this.saveAsLabel.Click += new System.EventHandler(this.SaveAsLabel_Click);
            // 
            // smallLayoutLabel
            // 
            this.smallLayoutLabel.AutoSize = true;
            this.smallLayoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smallLayoutLabel.Depth = 0;
            this.smallLayoutLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.smallLayoutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.smallLayoutLabel.Location = new System.Drawing.Point(667, 305);
            this.smallLayoutLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.smallLayoutLabel.Name = "smallLayoutLabel";
            this.smallLayoutLabel.Size = new System.Drawing.Size(109, 19);
            this.smallLayoutLabel.TabIndex = 22;
            this.smallLayoutLabel.Text = "Smaller Layout";
            this.smallLayoutLabel.Click += new System.EventHandler(this.SmallLayoutLabel_Click);
            // 
            // titleUpdate
            // 
            this.titleUpdate.Interval = 500;
            this.titleUpdate.Tick += new System.EventHandler(this.TitleUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 729);
            this.Controls.Add(this.smallLayoutLabel);
            this.Controls.Add(this.saveAsLabel);
            this.Controls.Add(this.colorBoxBlack);
            this.Controls.Add(this.colorBoxBlue);
            this.Controls.Add(this.colorBoxAqua);
            this.Controls.Add(this.colorBoxGreen);
            this.Controls.Add(this.colorBoxYellow);
            this.Controls.Add(this.colorBoxOrange);
            this.Controls.Add(this.colorBoxRed);
            this.Controls.Add(this.colorBoxWhite);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.fillColorLabel);
            this.Controls.Add(this.removeColorLabel);
            this.Controls.Add(this.getColorLabel);
            this.Controls.Add(this.hidetoolbarLabel);
            this.Controls.Add(this.takePictureLabel);
            this.Controls.Add(this.resetBoardLabel);
            this.Controls.Add(this.closeProjectLabel);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.drawBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxAqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxBlack)).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel closeProjectLabel;
        private MaterialSkin.Controls.MaterialLabel resetBoardLabel;
        private MaterialSkin.Controls.MaterialLabel takePictureLabel;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Label hidetoolbarLabel;
        private MaterialSkin.Controls.MaterialLabel getColorLabel;
        private MaterialSkin.Controls.MaterialLabel removeColorLabel;
        private MaterialSkin.Controls.MaterialLabel fillColorLabel;
        private MaterialSkin.Controls.MaterialLabel helpLabel;
        private System.Windows.Forms.PictureBox colorBoxWhite;
        private System.Windows.Forms.PictureBox colorBoxRed;
        private System.Windows.Forms.PictureBox colorBoxOrange;
        private System.Windows.Forms.PictureBox colorBoxYellow;
        private System.Windows.Forms.PictureBox colorBoxGreen;
        private System.Windows.Forms.PictureBox colorBoxAqua;
        private System.Windows.Forms.PictureBox colorBoxBlue;
        private System.Windows.Forms.PictureBox colorBoxBlack;
        private System.Windows.Forms.Timer autoSaveTimer;
        private MaterialSkin.Controls.MaterialLabel saveAsLabel;
        private MaterialSkin.Controls.MaterialLabel smallLayoutLabel;
        private System.Windows.Forms.Timer titleUpdate;
    }
}

