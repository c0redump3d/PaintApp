using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PaintApp
{
    public partial class HelpForm : MaterialForm
    {
        public HelpForm()
        {
            InitializeComponent();
        
            //set up material form
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, 0, TextShade.WHITE);
            //done setting up material form
        }

        private void toolbarTutButton_Click(object sender, EventArgs e)
        {
            tutPicBox.Image = Properties.Resources.hide_toolbar;
            tutInfoLabel.Text = "PaintApp allows you to hide the toolbar.\nTo hide the toolbar all you have to " +
                "do is\nclick the \"<\" on the far right of the screen.\nTo show the toolbar again, simply press \nthe \">\" button.";
        }

        private void SaveFileTutButton_Click(object sender, EventArgs e)
        {
            tutPicBox.Image = Properties.Resources.savepntapp;
            tutInfoLabel.Text = "Want to save and or share your drawing\nwith anyone? No problem! To save your\ndrawing simply clcik the " +
                "\"Save File\" button\nand specify a location to save the file.";
        }

        private void OpenFileTutButton_Click(object sender, EventArgs e)
        {
            tutPicBox.Image = Properties.Resources.openpntapp;
            tutInfoLabel.Text = "Just downloaded or want to load a\nsaved drawing? Also not a problem.\nSimply click the \"Open File\" button and\nselect the PaintApp file you want to open.";
        }

        private void DisableGridTutButton_Click(object sender, EventArgs e)
        {
            tutPicBox.Image = Properties.Resources.disablegrid;
            tutInfoLabel.Text = "Hiding the line grid is very simple.\nSimply click the \"Disable Grid\" button.\nTo reenable the grid, click the button again.";
        }

        private void ColorTutButton_Click(object sender, EventArgs e)
        {
            tutPicBox.Image = Properties.Resources.setcolor;
            tutInfoLabel.Text = "Give your drawing some character.\nChange the color! To change the color\nsimply select the\"Choose Color\" button\nand choose the color that fits your\ndrawing the best.";
        }

        private void SquareTutButton_Click(object sender, EventArgs e)
        {
            tutPicBox.Image = Properties.Resources.ellipses;
            tutInfoLabel.Text = "PaintApp allows you to change between\ndrawing squares or ellipses. To change\nbetween the two just click \"Ellipses\" button\nor click the \"Squares\" button.";
        }

        private void ResetTutButton_Click(object sender, EventArgs e)
        {
            tutPicBox.Image = Properties.Resources.resetboard;
            tutInfoLabel.Text = "Want to restart on your drawing? To do\nthis, simply find the \"Reset\" button and\nclick it. A popup will show to confirm that\nyou want to reset the board.";
        }

        private void PictureTutButton_Click(object sender, EventArgs e)
        {
            tutPicBox.Image = Properties.Resources.savepic;
            tutInfoLabel.Text = "Assuming you've made a masterpiece,\nyou would want to save a picture of it.\nWell, you can do that! Simply press the\n\"Screenshot\" button and specify a location\nand a name to save it.";
        }

        private void ControlsTutButton_Click(object sender, EventArgs e)
        {
            tutPicBox.Image = Properties.Resources.movement;
            tutInfoLabel.Text = "Controls are simple.\nW/Up Arrow: Move player up.\nA/Left Arrow: Move player left.\nS/Down Arrow: Move player down.\nD/Right Arrow: Move player right.\nSpace: Place Square/Ellipse\nM/E: Remove placed square/ellipse.";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
