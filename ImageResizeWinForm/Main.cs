using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ImageResizeWinForm
{
    public class Main
    {
        public void ProcessFolder(string sourcePath, string destinationPath, int imageSize)
        {
            ImageResizer imageResizer = new ImageResizer();            
            var listOfFiles = Directory.GetFiles(sourcePath);

            foreach (var file in listOfFiles)
            {
                if (Path.GetFileName(file).EndsWith(".jpg"))
                {
                    string fileName = destinationPath + @"\" + Path.GetFileName(file);
                    imageResizer.ImageResizeAndSave(file, destinationPath, imageSize); 
                }
            }
        }        
    }
}
