using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    internal partial class MaterialMessageForm : MaterialForm
    {

        public MaterialMessageForm()
        {
            InitializeComponent();

            //set up material form
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, 0, TextShade.WHITE);
            //done setting up material form
        }

        public MaterialMessageForm(string title, string description, MessageBoxIcon icon, MessageBoxButtons buttons)
        {
            InitializeComponent();

            if (icon == MessageBoxIcon.Warning)
                pictureBox1.Image = Properties.Resources.warning;
            else if (icon == MessageBoxIcon.Information)
                pictureBox1.Image = Properties.Resources.information;

            if(buttons == MessageBoxButtons.OK)
            {
                yesButton.Hide();
                noButton.Text = "Ok";
            }

            SystemSounds.Exclamation.Play();

            this.Text = title;
            infoBoxLabel.Text = description;

            //set up material form
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, 0, TextShade.WHITE);
            //done setting up material form

            this.Refresh();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            if (noButton.Text == "No")
                this.DialogResult = DialogResult.No;
            else
                this.DialogResult = DialogResult.OK;
        }
    }

    public static class MaterialMessageBox
    {
        public static DialogResult Show(string description, string title, MessageBoxIcon icon, MessageBoxButtons buttons)
        {
            using (var f = new MaterialMessageForm(title, description, icon, buttons))
            {
                DialogResult result = f.ShowDialog();

                switch (result)
                {
                    case DialogResult.Yes:
                        return result = DialogResult.Yes;
                    case DialogResult.No:
                        return result = DialogResult.No;
                    case DialogResult.OK:
                        return result = DialogResult.OK;
                    default:
                        return result = DialogResult.No;
                }

            }
        }
    }
}
