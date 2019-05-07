using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialDesignColors;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PaintApp
{
    public partial class LaunchProjectForm : MaterialForm
    {

        private string openLocation;
        private string newLocation;
        private bool isOpeningExisting = false;

        public LaunchProjectForm()
        {
            Program.KeepRunning = false;

            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, 0, TextShade.WHITE);
        }

        private void OpenExistingButton_Click(object sender, EventArgs e)
        {
            if(openExistingDialog.ShowDialog() == DialogResult.OK)
            {
                openLocation = openExistingDialog.FileName;
                isOpeningExisting = true;
                this.Close();
            }
        }

        public string getOpenLocation()
        {
            return openLocation;
        }

        public bool getIsOpening()
        {
            return isOpeningExisting;
        }

        private void CreateNewProjectButton_Click(object sender, EventArgs e)
        {
            if (createNewDialog.ShowDialog() == DialogResult.OK)
            {
                newLocation = createNewDialog.FileName;

                StreamWriter sw = new StreamWriter(createNewDialog.FileName);
                sw.Close();

                isOpeningExisting = false;
                this.Close();
            }
        }

        public string getNewLocation()
        {
            return newLocation;
        }

        private void LaunchProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.KeepRunning = false;
        }
    }
}
