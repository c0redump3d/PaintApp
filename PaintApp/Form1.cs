using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PaintApp
{
    public partial class Form1 : MaterialForm
    {

        /*
         * 
         * 
         * Having separate colors for rectangles in the array may not be possible
         * -- The issue is caused because in the paint function, we are constantly
         * looping through the array index drawing all the currently existing rectangles.
         * Without that, the rectangles obviously would not draw. So, in order to fix
         * I would need to switch to a different way of drawing the rectangles -- which
         * I have no idea how to do :/.
         * 
         *
         */

        Rectangle[] rect;
        int _x = 0;
        int _y = 0;
        int length;
        static Brush testbrush = Brushes.Blue;
        Color color = ((SolidBrush)testbrush).Color;
        bool showGrid = true;
        bool drawEllipse = false;
        bool takingScreenshot = false;

        public Form1()
        {
            InitializeComponent();

            //set up material form
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, 0, TextShade.WHITE);
            //done setting up material form

            //set up rectangle array
            rect = new Rectangle[1];
            rect[0] = new Rectangle(_x, _y, 32, 32);
            //done
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    if (rect[0].Y != 0)
                        rect[0].Y -= 32;
                    break;
                case Keys.Down:
                case Keys.S:
                    if (rect[0].Y != 608)
                        rect[0].Y += 32;
                    break;
                case Keys.Left:
                case Keys.A:
                    if (rect[0].X != 0)
                        rect[0].X -= 32;
                    break;
                case Keys.Right:
                case Keys.D:
                    if (rect[0].X != 608)
                        rect[0].X += 32;
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

        private void DrawBoard_Paint(object sender, PaintEventArgs e)
        {
            // so damn ugly, but it works /shrug

            if (!drawEllipse)
            {
                for (int i = rect.Length - 1; i > 0; i--)
                    e.Graphics.FillRectangle(testbrush, rect[i]);

                if(!takingScreenshot)
                    e.Graphics.FillRectangle(Brushes.Red, rect[0]); // player
                if (showGrid)
                {
                    for (int x = 0; x < 20; x++) //simple 20x20 grid.
                        for (int y = 0; y < 20; y++)
                            e.Graphics.DrawRectangle(Pens.Black, x * 32, y * 32, 32, 32);
                }
            }
            else
            {
                for (int i = rect.Length - 1; i > 0; i--)
                    e.Graphics.FillEllipse(testbrush, rect[i]);

                if (!takingScreenshot)
                    e.Graphics.FillEllipse(Brushes.Red, rect[0]); // player
                if (showGrid)
                {
                    for (int x = 0; x < 20; x++) //simple 20x20 grid.
                        for (int y = 0; y < 20; y++)
                            e.Graphics.DrawEllipse(Pens.Black, x * 32, y * 32, 32, 32);
                }
            }
            
        }

        private void placeBlock()
        {
            for (int i = rect.Length - 1; i > 0; i--)
                if (rect[0].Contains(rect[i])) //make sure the player isn't placing a rectangle where one already exists.
                    return;
            Rectangle testrec;
            List<Rectangle> placeblock = rect.ToList();
            placeblock.Add(testrec = new Rectangle(rect[rect.Length - 1].X, rect[rect.Length - 1].Y, 32, 32)); // create new rectangle, set x,y to player pos and add to array index.
            rect = placeblock.ToArray();
            for (int i = rect.Length - 1; i > 0; i--)
                rect[i] = rect[i - 1]; //assign correct array index for new rectangle.
            drawBoard.Invalidate();
        }

        private void resetBoard() // reset paint board
        {
            if (rect.Length == 1) // if just player is left, we return, no point in clearing an already cleared board
                return;
            List<Rectangle> removeall = rect.ToList();
            for (int i = rect.Length - 1; i > 0; i--) // loop through array index and remove all, except index 0 which is player
            {
                removeall.Remove(rect[i]);
                rect = removeall.ToArray();
            }
            drawBoard.Invalidate();
        }

        private void deleteBlock()
        {//reverse of what placeBlock() does.
            List<Rectangle> removeblock = rect.ToList();
            for (int i = rect.Length - 1; i > 0; i--)
            {
                if (rect[0].X == rect[i].X && rect[0].Y == rect[i].Y) // if player x, y = another rectangles position, find that rectangle in the array index and remove it.
                {
                    removeblock.RemoveAt(i);
                    rect = removeblock.ToArray();
                }
            }
        }

        private void screenshotBoard()
        {
            //Maybe implement a resizing feature?
            if (saveBitmapDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(drawBoard.Width, drawBoard.Height); // create a new blank bitmap

                drawBoard.DrawToBitmap(bmp, new Rectangle(0, 0,
                            drawBoard.Width, drawBoard.Height)); // now, draw graphics from drawBoard onto the blank bitmap

                bmp.Save(saveBitmapDialog.FileName, ImageFormat.Png); // save the bitmap as a png file and done :)
            }
        }

        #region Files

        private void savePaintFile(string location)
        {
            try
            {
                StreamWriter sw = new StreamWriter(location);
                for (int i = rect.Length - 1; i > 0; i--)
                {
                    //write x coordinate, newline, write y coordinate, next rectangle, etc.
                    sw.WriteLine(rect[i].X);
                    sw.WriteLine(rect[i].Y);
                }

                sw.WriteLine(drawEllipse);
                sw.WriteLine(color.ToArgb());

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

                string test;

                while ((test = sr1.ReadLine()) != null)
                {
                    length++;
                }

                if(length > 801) // 800 is filled board, simple check to make sure they're not trying to add more blocks then whats allowed
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

                resetBoard(); // reset board, no overlapping artwork

                //this first step we actually place/create rectangles
                for (int i = 0; i < length / 2 - 1; i++) // we divide by two because 1 block takes two lines in file.
                {
                    // super simple, for each line in text file, we read next line, set rectx = to x in file and recty = y in file and place.
                    try
                    {
                        rect[0].X = Convert.ToInt32(sr.ReadLine());
                        rect[0].Y = Convert.ToInt32(sr.ReadLine());
                        placeBlock();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                //second step is to find out if we should enable ellipses and find out what color to set the rectangles to.
                try
                {
                    drawEllipse = Convert.ToBoolean(sr.ReadLine());
                    color = new SolidBrush(Color.FromArgb(Convert.ToInt32(sr.ReadLine()))).Color;
                    testbrush = new SolidBrush(color);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //reset player pos so theyre not in the middle of nowhere
                rect[0].X = 0;
                rect[0].Y = 0;

                sr.Close();//close text file.
                MessageBox.Show("Successfully opened: " + location);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nOkay seriously. How did you manage to do this? We were able to successfully find the length of the file but not able to place rects in correct pos.");
            }
        }

        #endregion

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

                testbrush = new SolidBrush(color);
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
                setDrawEllipseLabel.Text = "Rectangles";
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
    }
}
