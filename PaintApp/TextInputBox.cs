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
    public partial class TextInputBox : MaterialForm
    {
        bool isInputtingNumber = true;
        bool enableTrans = true;
        int picWidth = 64;
        int picHeight = 64;

        public TextInputBox()
        {
            InitializeComponent();
            //set up material form
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, 0, TextShade.WHITE);
            //done setting up material form

            this.ControlBox = false;
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            int width;
            int height;
            if(int.TryParse(materialSingleLineTextField1.Text, out width) && int.TryParse(materialSingleLineTextField1.Text, out height))
            {
                Form1 f1 = new Form1();
                picWidth = width;
                picHeight = height;
                isInputtingNumber = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please make sure the text fields only contain numbers!");
                return;
            }
        }

        public int getWidth()
        {
            return picWidth;
        }

        public int getHeight()
        {
            return picHeight;
        }

        public bool isInputtingNum()
        {
            return isInputtingNumber;
        }

        private void MaterialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
            {
                enableTrans = true;
            }
            else
            {
                enableTrans = false;
            }
        }

        public bool enableTransparency()
        {
            return enableTrans;
        }
    }
}
