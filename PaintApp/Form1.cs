using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
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
        static Brush blockBrush = Brushes.Blue;
        Color color = ((SolidBrush)blockBrush).Color;

        int length;

        bool animation = false;

        bool transparencyEnabled = false;

        //options for app
        bool showGrid = true;
        bool drawEllipse = false;
        bool takingScreenshot = false;

        public Form1()
        {
            InitializeComponent();

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

        }

        #region Controls

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    if (player.Y != 0)
                        player.Y -= 32;
                    break;
                case Keys.Down:
                case Keys.S:
                    if (player.Y != 608)
                        player.Y += 32;
                    break;
                case Keys.Left:
                case Keys.A:
                    if (player.X != 0)
                        player.X -= 32;
                    break;
                case Keys.Right:
                case Keys.D:
                    if (player.X != 608)
                        player.X += 32;
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

                if(!takingScreenshot)
                    e.Graphics.FillRectangle(Brushes.Red, player); // player
                if (showGrid)
                {
                    for (int x = 0; x < 20; x++) //simple 20x20 grid.
                        for (int y = 0; y < 20; y++)
                            if (!transparencyEnabled)
                                e.Graphics.DrawRectangle(Pens.Black, x * 32, y * 32, 32, 32);
                            else
                                e.Graphics.DrawRectangle(new Pen(this.BackColor), x * 32, y * 32, 32, 32);
                }
            }
            else
            {
                for (int i = rect.Length - 1; i > 0; i--)
                    e.Graphics.FillEllipse(rect[i].Color, rect[i].Rect);

                if (!takingScreenshot)
                    e.Graphics.FillEllipse(Brushes.Red, player); // player
                if (showGrid)
                {
                    for (int x = 0; x < 20; x++) //simple 20x20 grid.
                        for (int y = 0; y < 20; y++)
                            if (!transparencyEnabled)
                                e.Graphics.DrawEllipse(Pens.Black, x * 32, y * 32, 32, 32);
                            else
                                e.Graphics.DrawEllipse(new Pen(this.BackColor), x * 32, y * 32, 32, 32);
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
            placeblock.Add(new ColoredRectangle(player.X, player.Y, 32, 32, new SolidBrush(rectColorPicker.Color))); // create new rectangle, set x,y to player pos and add to array index.
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
        {//reverse of what placeBlock() does.
            List<ColoredRectangle> removeblock = rect.ToList();
            for (int i = rect.Length - 1; i > 0; i--)
            {
                if (rect[i].Color.Color.ToArgb() == rectColorPicker.Color.ToArgb()) // if player x, y = another rectangles position, find that rectangle in the array index and remove it.
                {
                    removeblock.RemoveAt(i);
                    rect = removeblock.ToArray();
                }
            }
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
                for (int i = rect.Length - 1; i > 0; i--)
                {
                    //write x coordinate, newline, write y coordinate, and write color, next rectangle, etc.
                    sw.WriteLine(rect[i].Rect.X);
                    sw.WriteLine(rect[i].Rect.Y);
                    sw.WriteLine(rect[i].Color.Color.ToArgb());
                }

                sw.Close();

                MessageBox.Show("Successfully saved to: " + location);
            }catch(Exception ex)
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

                if(length > 1201) // 800 is filled board, simple check to make sure they're not trying to add more blocks then whats allowed
                {
                    MessageBox.Show("Are you sure this is a PaintApp file? Seems to be to large to be, stopping...");
                    sr1.Close();
                    return;
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

                //reset player pos so theyre not in the middle of nowhere
                player.X = 0;
                player.Y = 0;
                rectColorPicker.Color = oldColor;

                sr.Close();//close text file.
                MessageBox.Show("Successfully opened: " + location);
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
            if (savePaintDialog.ShowDialog() == DialogResult.OK)
                savePaintFile(savePaintDialog.FileName);
        }

        private void openFileLabel_Click(object sender, EventArgs e)
        {
            if (openSaveDialog.ShowDialog() == DialogResult.OK)
                loadSaveFile(openSaveDialog.FileName);
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
            for (int i = rect.Length - 1; i > 0; i--)
                if (player.Contains(rect[i].Rect))
                    rectColorPicker.Color = rect[i].Color.Color;
        }

        private void FillColorLabel_Click(object sender, EventArgs e)
        {
            int oldX;
            int oldY;

            oldX = player.X;
            oldY = player.Y;

            player.X = 0;
            player.Y = 0;
            for (int i = 0; i < 400; i++)
            {
                placeBlock();

                if (player.X < 608)
                    player.X += 32;
                else
                    player.X = 0;

                if (player.X == 0)
                    if (player.Y < 608)
                        player.Y += 32;

                if (player.X == 608 && player.Y == 608)
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
        #endregion

    }
}
