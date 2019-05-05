using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PaintApp
{
    public partial class Form1 : MaterialForm
    {

        /*
         * 
         * everything i said was a lie, until now.
         * Multi-Color support is here :D.
         * saves to files and can be loaded later and will have the correct colors :).
         *
         */

        //stuff to do with rects
        Rectangle player;
        ColoredRectangle[] rect;
        int _x = 0;
        int _y = 0;
        int maxBound = 608;
        int minBound = 0;
        int gridSize = 20;
        int layoutSize = 32;
        int unchanged;
        static Brush blockBrush = Brushes.Blue;
        Color color = ((SolidBrush)blockBrush).Color;
        SolidBrush playerCol = new SolidBrush(Color.Red);

        string autoSaveLocation;

        int length;

        bool animation = false;

        bool transparencyEnabled = false;

        bool launchProjScreen = true;

        bool leftMouseDown = false;
        bool rightMouseDown = false;

        //options for app
        bool showGrid = true;
        bool drawEllipse = false;
        bool takingScreenshot = false;
        bool smallLayout = false;
        bool usingMouseControls = false;

        public Form1(string path)
        {
            InitializeComponent();

            Program.KeepRunning = false;

            if (path != string.Empty && Path.GetExtension(path).ToLower() == ".pntapp")
            {
                launchProjScreen = false;
            }

            LaunchProjectForm launchProj = new LaunchProjectForm();

            if (launchProjScreen)
            {

                launchProj.ShowDialog();

                if (launchProj.getIsOpening())
                {

                    if (launchProj.getOpenLocation() == null)
                    {
                        this.Dispose();
                        this.Close();
                        return;
                    }

                }
                else
                {
                    if (launchProj.getNewLocation() == null)
                    {
                        this.Dispose();
                        this.Close();
                        return;
                    }
                }
            }

            ApplicationSettings appSettings = new ApplicationSettings();

            appSettings.createFile(); // creates file if necessary
            appSettings.getFirstLaunch(); // if its first launch below function will launch firststarttutorial
            appSettings.saveFile(); // save file, just writes one boolean value so isfirstlaunch will return true

            if (!appSettings.isNotFirstLaunch())
            {
                FirstStartTutorial tutorial = new FirstStartTutorial();
                tutorial.ShowDialog();
            }

            //set up material form
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, 0, TextShade.WHITE);
            //done setting up material form

            //set up rectangle array and set player pos
            rect = new ColoredRectangle[1];
            player = new Rectangle(_x, _y, 32, 32);
            //done

            //set color
            rectColorPicker.Color = Color.White;

            if (launchProjScreen)
            {
                if (launchProj.getIsOpening())
                {
                    loadSaveFile(launchProj.getOpenLocation());
                    autoSaveLocation = launchProj.getOpenLocation();
                }
                else
                {
                    loadSaveFile(launchProj.getNewLocation());
                    autoSaveLocation = launchProj.getNewLocation();
                }
            }

            if (path != string.Empty && Path.GetExtension(path).ToLower() == ".pntapp")
            {
                loadSaveFile(path);
                autoSaveLocation = path;
            }

            this.Text = "PaintApp - " + Path.GetFileNameWithoutExtension(autoSaveLocation);

            autoSaveTimer.Start();
            titleUpdate.Start();

        }

        #region Controls

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    if (player.Y != minBound)
                        player.Y -= layoutSize;
                    break;
                case Keys.Down:
                case Keys.S:
                    if (player.Y != maxBound)
                        player.Y += layoutSize;
                    break;
                case Keys.Left:
                case Keys.A:
                    if (player.X != minBound)
                        player.X -= layoutSize;
                    break;
                case Keys.Right:
                case Keys.D:
                    if (player.X != maxBound)
                        player.X += layoutSize;
                    break;
                case Keys.M:
                case Keys.E:
                    deleteBlock();
                    break;
                case Keys.Space:
                    placeBlock();
                    break;
            }
            drawBoard.Invalidate();
            usingMouseControls = false;
        }

        #endregion

        #region Mouse Controls

        /*
         * 
         * Seems to be pretty unefficent. Likes to spike CPU usage up a ton.
         * 
         */

        private void mousePlace()
        {

            var cursorPos = drawBoard.PointToClient(Cursor.Position);

            double mouseX;
            double mouseY;
            int formMouseX;
            int formMouseY;

            mouseX = cursorPos.X - layoutSize;
            mouseY = cursorPos.Y - layoutSize;

            formMouseX = (int)Math.Round(Math.Ceiling(mouseX / layoutSize) * layoutSize, MidpointRounding.ToEven);
            formMouseY = (int)Math.Round(Math.Ceiling(mouseY / layoutSize) * layoutSize, MidpointRounding.ToEven);


            if (formMouseY < minBound || formMouseY > maxBound || formMouseX < minBound || formMouseX > maxBound)
                return;

            player.X = formMouseX;
            player.Y = formMouseY;

            usingMouseControls = true;

            placeBlock();

        }

        private void mouseRemove()
        {

            var cursorPos = drawBoard.PointToClient(Cursor.Position);

            double mouseX;
            double mouseY;
            int formMouseX;
            int formMouseY;

            mouseX = cursorPos.X - layoutSize;
            mouseY = cursorPos.Y - layoutSize;

            formMouseX = (int)Math.Round(Math.Ceiling(mouseX / layoutSize) * layoutSize, MidpointRounding.ToEven);
            formMouseY = (int)Math.Round(Math.Ceiling(mouseY / layoutSize) * layoutSize, MidpointRounding.ToEven);


            if (formMouseY < minBound || formMouseY > maxBound || formMouseX < minBound || formMouseX > maxBound)
                return;

            player.X = formMouseX;
            player.Y = formMouseY;

            usingMouseControls = true;

            deleteBlock();

            drawBoard.Invalidate();
        }

        private void mouseColor()
        {
            var cursorPos = drawBoard.PointToClient(Cursor.Position);

            double mouseX;
            double mouseY;
            int formMouseX;
            int formMouseY;

            mouseX = cursorPos.X - layoutSize;
            mouseY = cursorPos.Y - layoutSize;

            formMouseX = (int)Math.Round(Math.Ceiling(mouseX / layoutSize) * layoutSize, MidpointRounding.ToEven);
            formMouseY = (int)Math.Round(Math.Ceiling(mouseY / layoutSize) * layoutSize, MidpointRounding.ToEven);


            if (formMouseY < minBound || formMouseY > maxBound || formMouseX < minBound || formMouseX > maxBound)
                return;

            player.X = formMouseX;
            player.Y = formMouseY;

            usingMouseControls = true;

            deleteBlock();

            drawBoard.Invalidate();
        }

        private void DrawBoard_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;

            if (mouse.Button == MouseButtons.Left && mouse.Button == MouseButtons.Right)
                return;

            if (mouse.Button == MouseButtons.Left)
            {
                mousePlace();
            }
            else if (mouse.Button == MouseButtons.Right)
            {
                mouseRemove();
            }
            else if (mouse.Button == MouseButtons.Middle)
            {
                getColorFromBlock();
            }
        }

        private void DrawBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Button == MouseButtons.Right)
                return;

            if (e.Button == MouseButtons.Left)
            {
                leftMouseDown = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                rightMouseDown = true;
            }
        }

        private void DrawBoard_MouseUp(object sender, MouseEventArgs e)
        {
            leftMouseDown = false;
            rightMouseDown = false;
        }

        private void DrawBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftMouseDown)
                mousePlace();
            else if (rightMouseDown)
                mouseRemove();

            if (usingMouseControls)
            {

                var cursorPos = drawBoard.PointToClient(Cursor.Position);

                double mouseX;
                double mouseY;
                int formMouseX;
                int formMouseY;

                mouseX = cursorPos.X - layoutSize;
                mouseY = cursorPos.Y - layoutSize;

                formMouseX = (int)Math.Round(Math.Ceiling(mouseX / layoutSize) * layoutSize, MidpointRounding.ToEven);
                formMouseY = (int)Math.Round(Math.Ceiling(mouseY / layoutSize) * layoutSize, MidpointRounding.ToEven);


                if (formMouseY < minBound || formMouseY > maxBound || formMouseX < minBound || formMouseX > maxBound)
                    return;

                player.X = formMouseX;
                player.Y = formMouseY;

                drawBoard.Invalidate();
            }

        }

        #endregion

        #region Draw Board Paint

        private void DrawBoard_Paint(object sender, PaintEventArgs e)
        {
            // so damn ugly, but it works /shrug

            if (!drawEllipse)
            {
                for (int i = rect.Length - 1; i > 0; i--)
                    e.Graphics.FillRectangle(rect[i].Color, rect[i].Rect);

                if (!takingScreenshot)
                    e.Graphics.FillRectangle(!usingMouseControls ? playerCol : new SolidBrush(rectColorPicker.Color), player); // player
                if (showGrid)
                {
                    for (int x = 0; x < gridSize; x++) //grid
                        for (int y = 0; y < gridSize; y++)
                            if (!transparencyEnabled)
                                e.Graphics.DrawRectangle(Pens.Black, x * layoutSize, y * layoutSize, layoutSize, layoutSize);
                            else
                                e.Graphics.DrawRectangle(new Pen(this.BackColor), x * layoutSize, y * layoutSize, layoutSize, layoutSize);
                }
            }
            else
            {
                for (int i = rect.Length - 1; i > 0; i--)
                    e.Graphics.FillEllipse(rect[i].Color, rect[i].Rect);

                if (!usingMouseControls)
                    if (!takingScreenshot)
                        e.Graphics.FillEllipse(!usingMouseControls ? playerCol : new SolidBrush(rectColorPicker.Color), player); // player
                if (showGrid)
                {
                    for (int x = 0; x < gridSize; x++) //grid.
                        for (int y = 0; y < gridSize; y++)
                            if (!transparencyEnabled)
                                e.Graphics.DrawEllipse(Pens.Black, x * layoutSize, y * layoutSize, layoutSize, layoutSize);
                            else
                                e.Graphics.DrawEllipse(new Pen(this.BackColor), x * layoutSize, y * layoutSize, layoutSize, layoutSize);
                }
            }
            
        }

        #endregion

        #region Board Functions

        private void placeBlock()
        {
            for (int i = rect.Length - 1; i > 0; i--)
                if (player.Contains(rect[i].Rect)) //make sure the player isn't placing a rectangle where one already exists.
                    return;
            List<ColoredRectangle> placeblock = rect.ToList();
            placeblock.Add(new ColoredRectangle(player.X, player.Y, layoutSize, layoutSize, new SolidBrush(rectColorPicker.Color))); // create new rectangle, set x,y to player pos and add to array index.
            rect = placeblock.ToArray();
            drawBoard.Invalidate();
        }

        private void resetBoard() // reset paint board
        {
            if (rect.Length == 1) // if just player is left, we return, no point in clearing an already cleared board
                return;
            List<ColoredRectangle> removeall = rect.ToList();
            for (int i = rect.Length - 1; i > 0; i--) // loop through array index and remove all, except index 0 which is player
            {
                removeall.Remove(rect[i]);
                rect = removeall.ToArray();
            }
            drawBoard.Invalidate();
        }

        private void deleteBlock()
        {//reverse of what placeBlock() does.
            List<ColoredRectangle> removeblock = rect.ToList();
            for (int i = rect.Length - 1; i > 0; i--)
            {
                if (player.X == rect[i].Rect.X && player.Y == rect[i].Rect.Y) // if player x, y = another rectangles position, find that rectangle in the array index and remove it.
                {
                    removeblock.RemoveAt(i);
                    rect = removeblock.ToArray();
                }
            }
        }

        private void removeColor()
        {//neat little feature that will remove all blocks with a certain color.
            List<ColoredRectangle> removeblock = rect.ToList();
            for (int i = rect.Length - 1; i > 0; i--)
            {
                if (rect[i].Color.Color.ToArgb() == rectColorPicker.Color.ToArgb()) // if selected color = any placed rectangles, remove it
                {
                    removeblock.RemoveAt(i);
                    rect = removeblock.ToArray();
                }
            }
        }

        private void getColorFromBlock()
        {
            for (int i = rect.Length - 1; i > 0; i--)
                if (player.Contains(rect[i].Rect))
                    rectColorPicker.Color = rect[i].Color.Color;
        }

        #endregion

        #region Screenshot

        private void screenshotBoard()
        {
            bool dialogClosed = false;

            //resizing feature implemented :)
            if (saveBitmapDialog.ShowDialog() == DialogResult.OK)
            {

                TextInputBox tb = new TextInputBox();
                tb.ShowDialog();

                while (tb.isInputtingNum())
                    dialogClosed = false;

                Bitmap bmp = new Bitmap(drawBoard.Width, drawBoard.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb); // create a new blank bitmap

                if (tb.enableTransparency())
                {
                    this.TransparencyKey = this.BackColor;
                    transparencyEnabled = true;
                }
                else
                {
                    transparencyEnabled = false;
                }

                drawBoard.DrawToBitmap(bmp, new Rectangle(0, 0,
                            drawBoard.Width, drawBoard.Height)); // now, draw graphics from drawBoard onto the blank bitmap

                if(transparencyEnabled)
                    bmp.MakeTransparent(this.BackColor);

                bmp.Save(@"C:\temp\temp.png", ImageFormat.Png); // save temp png. now time for resizing

                dialogClosed = true;
                if (dialogClosed)
                {
                    using (var tempimg = Image.FromFile(@"C:\temp\temp.png"))
                    using (var resizedImage = resizePic(tempimg, tb.getWidth(), tb.getHeight()))
                    {
                        bmp.Dispose();
                        bmp = null;
                        resizedImage.Save(saveBitmapDialog.FileName, ImageFormat.Png);
                    }
                    File.Delete(@"C:\temp\temp.png"); // delete the temporary file, no point in having it.
                    this.TransparencyKey = Color.Beige;
                    transparencyEnabled = false;
                }
            }
        }

        public static Image resizePic(Image tempPic, int width, int height)
        {
            double ratioX = (double)width / tempPic.Width;
            double ratioY = (double)height / tempPic.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(tempPic.Width * ratio);
            int newHeight = (int)(tempPic.Height * ratio);

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(tempPic, 0, 0, newWidth, newHeight);

            return newImage;
        }

        #endregion

        #region Tool Bar Animation

        private void hideOrShowToolBar(bool start)
        {
            if (start)
            {
                animation = true;
                animationTimer.Start();
            }
            else
            {
                animation = false;
                animationTimer.Start();
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (animation)
            {
                if (this.Width > 672)
                {
                    this.Width -= 4;
                    hidetoolbarLabel.Left -= 4;
                    hidetoolbarLabel.Text = "|";
                }
                else
                {
                    animationTimer.Stop();
                    hidetoolbarLabel.Text = ">";
                    showOrHideLabel(this, true);
                }
            }
            else
            {
                if (this.Width < 782)
                {
                    this.Width += 4;
                    hidetoolbarLabel.Left += 4;
                    hidetoolbarLabel.Text = "|";
                    showOrHideLabel(this, false);
                }
                else
                {
                    animationTimer.Stop();
                    hidetoolbarLabel.Text = "<";
                }
            }

        }

        private void showOrHideLabel(Control control, bool hide)
        {
            if (control is Label)
            {
                Label buttonLabels = (Label)control;
                if (!buttonLabels.Text.StartsWith(">"))
                {
                    if (hide)
                    {
                        buttonLabels.Hide();
                    }
                    else
                    {
                        buttonLabels.Show();
                    }
                }
            }

            foreach (Control c in control.Controls)
                showOrHideLabel(c, hide);

        }

        #endregion

        #region Files

        private void savePaintFile(string location)
        {
            try
            {
                StreamWriter sw = new StreamWriter(location);

                sw.WriteLine(smallLayout);

                for (int i = rect.Length - 1; i > 0; i--)
                {
                    //write x coordinate, newline, write y coordinate, and write color, next rectangle, etc.
                    sw.WriteLine(rect[i].Rect.X);
                    sw.WriteLine(rect[i].Rect.Y);
                    sw.WriteLine(rect[i].Color.Color.ToArgb());
                }

                sw.Close();

                unchanged = rect.Length;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError writing to file: " + location);
            }
        }

        private void loadSaveFile(string location)
        {
            //first find length of the selected file, then readline

            length = 0;
            try
            {
                StreamReader sr1 = new StreamReader(location);

                string lengthString;

                while ((lengthString = sr1.ReadLine()) != null) // for every line, add one to length.
                {
                    length++;
                }

                sr1.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nwat, somehow we were able to find the file but not get length?");
                return;
            }

            try
            {

                StreamReader sr = new StreamReader(location);

                Color oldColor = rectColorPicker.Color;

                resetBoard(); // reset board, no overlapping artwork

                smallLayout = Convert.ToBoolean(sr.ReadLine());

                if (smallLayout)
                {
                    layoutSize = 16;
                    gridSize = 40;
                    maxBound = 624;
                    smallLayoutLabel.Text = "Larger Layout";
                    player = new Rectangle(_x, _y, 16, 16);
                    drawBoard.Invalidate();
                }

                //this first step we actually place/create rectangles
                for (int i = 0; i < length / 2 - 1; i++) // we divide by two because 1 block takes two lines in file.
                {
                    // super simple, for each line in text file, we read next line, set rectx = to x in file and recty = y in file and place.
                    try
                    {
                        player.X = Convert.ToInt32(sr.ReadLine());
                        player.Y = Convert.ToInt32(sr.ReadLine());
                        rectColorPicker.Color = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
                        placeBlock();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

                //deletes that weird invisible block in top left corner.
                for (int i = rect.Length - 1; i > 0; i--)
                    if (rect[i].Color.Color.ToArgb() == 0)
                        deleteBlock();

                unchanged = rect.Length;

                //reset player pos so theyre not in the middle of nowhere
                player.X = 0;
                player.Y = 0;
                rectColorPicker.Color = oldColor;

                sr.Close();//close text file.
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nOkay seriously. How did you manage to do this? We were able to successfully find the length of the file but not able to place rects in correct pos.");
                return;
            }
        }

        #endregion

        #region Buttons
        private void DisableGridLabel_Click(object sender, EventArgs e)
        {
            if (showGrid)
            {
                showGrid = false;
                disableGridLabel.Text = "Enable Grid";
                drawBoard.Invalidate();
            }
            else
            {
                showGrid = true;
                disableGridLabel.Text = "Disable Grid";
                drawBoard.Invalidate();
            }
        }

        private void colorPickerButton_Click(object sender, EventArgs e)
        {
            if (rectColorPicker.ShowDialog() == DialogResult.OK)
            {
                color = new SolidBrush(rectColorPicker.Color).Color;

                blockBrush = new SolidBrush(color);

                if (rectColorPicker.Color == Color.Red)
                    playerCol = new SolidBrush(Color.DarkGray);
                else
                    playerCol = new SolidBrush(Color.Red);
            }
            drawBoard.Invalidate();
        }

        private void setDrawEllipseLabel_Click(object sender, EventArgs e)
        {
            if (drawEllipse)
            {
                drawEllipse = false;
                setDrawEllipseLabel.Text = "Ellipses";
                drawBoard.Invalidate();
            }
            else
            {
                drawEllipse = true;
                setDrawEllipseLabel.Text = "Squares";
                drawBoard.Invalidate();
            }
        }

        private void resetBoardLabel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This will clear the entire board!\nAre you sure you want to do this?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.Yes)
            {
                resetBoard();
            }
        }

        private void saveFileLabel_Click(object sender, EventArgs e)
        {
            savePaintFile(autoSaveLocation);
            unchanged = rect.Length;
            this.Text = "PaintApp - " + Path.GetFileNameWithoutExtension(autoSaveLocation);
        }

        private void closeProjectLabel_Click(object sender, EventArgs e)
        {
            savePaintFile(autoSaveLocation);
            Program.KeepRunning = true;
            this.Close();
        }

        private void takePictureLabel_Click(object sender, EventArgs e)
        {
            takingScreenshot = true; //setting this bool to true hides the player(red controllable block)
            drawBoard.Invalidate();
            screenshotBoard();
            takingScreenshot = false;
            drawBoard.Invalidate();
        }

        private void HidetoolbarLabel_Click(object sender, EventArgs e)
        {
            if (this.Width > 672)
            {
                hideOrShowToolBar(true);
            }
            else
            {
                hideOrShowToolBar(false);
            }
        }

        private void GetColorLabel_Click(object sender, EventArgs e)
        {
            getColorFromBlock();
        }

        private void FillColorLabel_Click(object sender, EventArgs e)
        {
            int oldX;
            int oldY;

            oldX = player.X;
            oldY = player.Y;

            player.X = 0;
            player.Y = 0;
            for (int i = 0; i < gridSize * gridSize; i++)
            {
                placeBlock();

                if (player.X < maxBound)
                    player.X += layoutSize;
                else
                    player.X = 0;

                if (player.X == 0)
                    if (player.Y < maxBound)
                        player.Y += layoutSize;

                if (player.X == maxBound && player.Y == maxBound)
                {
                    placeBlock();
                }
            }

            player.X = oldX;
            player.Y = oldY;
        }

        private void RemoveColorLabel_Click(object sender, EventArgs e)
        {
            removeColor();
            drawBoard.Invalidate();
        }
        private void HelpLabel_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();

            hf.ShowDialog();
        }

        private void ColorBoxWhite_Click(object sender, EventArgs e)
        {
            rectColorPicker.Color = Color.White;

            if (playerCol.Color == Color.DarkGray)
                playerCol = new SolidBrush(Color.Red);
        }

        private void ColorBoxRed_Click(object sender, EventArgs e)
        {
            rectColorPicker.Color = Color.Red;

            playerCol = new SolidBrush(Color.DarkGray);
        }

        private void ColorBoxOrange_Click(object sender, EventArgs e)
        {
            rectColorPicker.Color = Color.DarkOrange;

            if (playerCol.Color == Color.DarkGray)
                playerCol = new SolidBrush(Color.Red);
        }

        private void ColorBoxYellow_Click(object sender, EventArgs e)
        {
            rectColorPicker.Color = Color.Yellow;

            if (playerCol.Color == Color.DarkGray)
                playerCol = new SolidBrush(Color.Red);
        }

        private void ColorBoxGreen_Click(object sender, EventArgs e)
        {
            rectColorPicker.Color = Color.Green;

            if (playerCol.Color == Color.DarkGray)
                playerCol = new SolidBrush(Color.Red);
        }

        private void ColorBoxAqua_Click(object sender, EventArgs e)
        {
            rectColorPicker.Color = Color.Aqua;

            if (playerCol.Color == Color.DarkGray)
                playerCol = new SolidBrush(Color.Red);
        }

        private void ColorBoxBlue_Click(object sender, EventArgs e)
        {
            rectColorPicker.Color = Color.Blue;

            if (playerCol.Color == Color.DarkGray)
                playerCol = new SolidBrush(Color.Red);
        }

        private void ColorBoxBlack_Click(object sender, EventArgs e)
        {
            rectColorPicker.Color = Color.Black;

            if (playerCol.Color == Color.DarkGray)
                playerCol = new SolidBrush(Color.Red);
        }

        private void SaveAsLabel_Click(object sender, EventArgs e)
        {
            if (savePaintDialog.ShowDialog() == DialogResult.OK)
            {
                savePaintFile(savePaintDialog.FileName);
                autoSaveLocation = savePaintDialog.FileName;
                this.Text = "PaintApp - " + Path.GetFileNameWithoutExtension(autoSaveLocation);
            }
        }

        private void SmallLayoutLabel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("In order to change the layout, you must reset the board.\nAre you sure you want to do this?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                if (smallLayoutLabel.Text == "Smaller Layout" || !smallLayout)
                {
                    smallLayout = true;
                    layoutSize = 16;
                    gridSize = 40;
                    maxBound = 624;
                    smallLayoutLabel.Text = "Larger Layout";
                    player = new Rectangle(_x, _y, 16, 16);
                    drawBoard.Invalidate();
                }
                else if (smallLayoutLabel.Text == "Larger Layout" || smallLayout)
                {
                    smallLayout = false;
                    layoutSize = 32;
                    gridSize = 20;
                    maxBound = 608;
                    smallLayoutLabel.Text = "Smaller Layout";
                    player = new Rectangle(_x, _y, 32, 32);
                    drawBoard.Invalidate();
                }
            }
        }

        #endregion

        private void AutoSaveTimer_Tick(object sender, EventArgs e)
        {
            savePaintFile(autoSaveLocation);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unchanged != rect.Length)
            {
                DialogResult unsaved = MessageBox.Show("You have unsaved progress. Do you want to save before exiting?",
                            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (unsaved == DialogResult.Yes)
                    savePaintFile(autoSaveLocation);
            }

            DialogResult exit = MessageBox.Show("Are you sure you want to exit?",
                            "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.No)
                e.Cancel = true;

        }

        private void TitleUpdate_Tick(object sender, EventArgs e)
        {
            if (unchanged != rect.Length && !this.Text.Contains("*"))
            {
                this.Text += " *";
                this.Refresh();
            }
        }
    }
}
