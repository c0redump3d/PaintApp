using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    class ApplicationSettings
    {
        /*
         * 
         * The purpose of this class is to create a text file telling us that
         * this application has been opened before. This is here for the tutorial
         * form. So, on first start up of this application, it will show the tutorial
         * form, otherwise it won't.
         * 
         */

        private string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // appdata location
        private bool notFirstStart = false;

        public void getFirstLaunch()// if file exists and file contains true, dont show tutorial form, else show it.
        {
            try
            {
                StreamReader readFile = new StreamReader(appData + @"\PaintApp\settings.txt");
                notFirstStart = Convert.ToBoolean(readFile.ReadLine());
                readFile.Close();
            }
            catch (FileNotFoundException) // this literally should NEVER happen, but if it does, this will be more useful.
            {
                MessageBox.Show("Error. File was not found. Please re-run this program.");
            }
            catch (Exception)
            {
                notFirstStart = false;
            }
        }

        public void createFile()// create file if neccessary, called on startup
        {
            if (File.Exists(appData + @"\PaintApp\settings.txt")) // don't want to create a file that already exists
                return;

            if (!Directory.Exists(appData + @"\PaintApp\")) //same thing, dont want to create directory that already exists
                Directory.CreateDirectory(appData + @"\PaintApp\");

            var highScoreTXT = File.Create(appData + @"\PaintApp\settings.txt");

            highScoreTXT.Close();
        }

        public void saveFile()// literally just writes true to file
        {
            try
            {
                StreamWriter writeFile = new StreamWriter(appData + @"\PaintApp\settings.txt");
                writeFile.Write("True"); // write true to file
                writeFile.Close(); // close the file
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show(fnf.Message + "\nFor some reason the file was not found, howd you do this?!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public Boolean isNotFirstLaunch()
        {
            return notFirstStart;
        }
    }
}
